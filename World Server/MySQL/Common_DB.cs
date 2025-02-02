﻿using MySql.Data.MySqlClient;

namespace WorldServer.MySQL {
    public static class Common_DB {
        public static MySqlConnection Connection { get; set; }
        public static string Server { get; set; }
        public static int Port { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Database { get; set; }

        /// <summary>
        /// Realiza a conexão com o banco de dados.
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool Open(out string message) {
            var query = $"Server={Server};Port={Port};Database={Database};User ID={Username};Password={Password};";

            try {
                Connection = new MySqlConnection();
                Connection.ConnectionString = query;
                Connection.Open();
            }
            catch (MySqlException ex) {
                message = ex.Message;
                return false;
            }

            message = string.Empty;
            return true;
        }

        /// <summary>
        /// Fecha a conexão com o banco de dados.
        /// </summary>
        /// <returns></returns>
        public static void Close() {
            if (Connection == null)  return; 
            Connection.Close();
            Connection.Dispose();
        }
    }
}
