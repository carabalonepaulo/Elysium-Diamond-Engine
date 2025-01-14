﻿using MySql.Data.MySqlClient;
using WorldServer.GameGuild;

namespace WorldServer.MySQL {
    public static class Guild_DB {       
        /// <summary>
        /// Verifica se o nome de guild está no banco de dados.
        /// </summary>
        /// <param name="gName"></param>
        /// <returns></returns>
        public static bool ExistGuild(string gName) {
            var query = $"SELECT id FROM guilds WHERE guild_name=?gName";
            var cmd = new MySqlCommand(query, Common_DB.Connection);
            cmd.Parameters.AddWithValue("?gName", gName);
            var reader = cmd.ExecuteReader();
            var value = reader.Read();

            reader.Close();
            return value;
        }

        /// <summary>
        /// Obtém o ID de guild.
        /// </summary>
        /// <param name="gName"></param>
        /// <returns></returns>
        public static int GetGuildID(string gName) {
            var query = $"SELECT id FROM guilds WHERE guild_name=?gName";
            var cmd = new MySqlCommand(query, Common_DB.Connection);
            cmd.Parameters.AddWithValue("?gName", gName);
            var reader = cmd.ExecuteReader();

            if (!reader.Read()) {
                reader.Close();
                return 0;
            }

            var id = (int)reader["id"];

            reader.Close();

            return id;
        }

        /// <summary>
        /// Carrega parcialmente os dados de guild.
        /// </summary>
        public static void LoadGuild() {           
            var query = "SELECT id, owner_id, owner_name, guild_name, announcement FROM guilds";
            var cmd = new MySqlCommand(query, Common_DB.Connection);
            var reader = cmd.ExecuteReader();
            var gData = new Guild();

            while (reader.Read()) {
                gData.ID = (int)reader["id"];
                gData.OwnerID = (int)reader["owner_id"];
                gData.OwnerName = (string)reader["owner_name"];
                gData.Name = (string)reader["guild_name"];
                gData.Announcement = (string)reader["announcement"];

                Guild.Guilds.Add(gData);
            }

            reader.Close(); 
        }

        /// <summary>
        /// Carrega parcialmente os membros da guild.
        /// </summary>
        public static void LoadGuildMember() {
            var mData = new GuildMember();
            var query = $"SELECT player_id, player_name, selfintro, FROM guilds_member WHERE guild_id=?guildID";
            var cmd = new MySqlCommand(query, Common_DB.Connection);

            foreach (var gData in Guild.Guilds) {
                cmd.Parameters.AddWithValue("?guildID", gData.ID);
                var reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    mData.ID = (int)reader["player_id"];
                    mData.Name = (string)reader["player_name"];
                    mData.SelfIntro = (string)reader["selfintro"];

                    gData.Member.Add(mData);
                }

                cmd.Parameters.Clear();
                reader.Close();
              }
        }
    }
}

