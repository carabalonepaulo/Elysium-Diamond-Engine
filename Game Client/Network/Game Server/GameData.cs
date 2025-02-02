﻿using System;
using Elysium_Diamond.DirectX;
using Elysium_Diamond.Common;
using Elysium_Diamond.GameClient;
using Elysium_Diamond.Maps;
using Elysium_Diamond.Npcs;
using Elysium_Diamond.EngineWindow;
using Elysium_Diamond.Resource;
using Lidgren.Network;

namespace Elysium_Diamond.Network {
    public class GameData {

        public static void Ping() {
            Configuration.PingEnd = Environment.TickCount;
            Configuration.Latency = Configuration.PingEnd - Configuration.PingStart;
            Configuration.PingSend = true;
        }

        /// <summary>
        /// Recebe o jogador do mapa atual e adiciona na lista.
        /// </summary>
        /// <param name="msg"></param>
        public static void GetPlayerMap(NetIncomingMessage msg) {
            var pData = new EngineCharacter();
            pData.ID = msg.ReadInt32();
            pData.Name = msg.ReadString();
            pData.Sprite = msg.ReadInt16();
            pData.Dir = EngineCharacter.GetDir(msg.ReadByte());
            pData.X = msg.ReadInt16();
            pData.Y = msg.ReadInt16();
            pData.Coordinate = new SharpDX.Point(pData.X, pData.Y);
            pData.X *= 16;
            pData.Y *= 16;
            pData.Enabled = true;
            pData.CanPlayerControl = false;

            MapManager.Player.Add(pData);
        }

        /// <summary>
        /// Adiciona o movimento de outros jogadores.
        /// </summary>
        /// <param name="msg"></param>
        public static void PlayerMapMove(NetIncomingMessage msg) {
            var pData = MapManager.FindPlayerByID(msg.ReadInt32());
            pData.DirectionQueue.Enqueue((byte)EngineCharacter.GetDir(msg.ReadByte()));
        }

        /// <summary>
        /// Recebe a experiência do jogador.
        /// </summary>
        /// <param name="data"></param>
        public static void PlayerExp(NetIncomingMessage msg) {
            Client.PlayerLocal.Exp = msg.ReadInt64();
        }

        public static void PlayerName(NetIncomingMessage msg) {
            Client.PlayerLocal.Name = msg.ReadString();
            Client.PlayerLocal.Character.Name = Client.PlayerLocal.Name;
        }

        public static void PlayerStatPoints(NetIncomingMessage msg) {
            Client.PlayerLocal.Points = msg.ReadInt32();
        }

        public static void PlayerLevel(NetIncomingMessage msg) {
            Client.PlayerLocal.Level = msg.ReadInt32();
        }

        public static void PlayerSprite(NetIncomingMessage msg) {
            Client.PlayerLocal.Sprite = msg.ReadInt16();
            Client.PlayerLocal.Character.Sprite = Client.PlayerLocal.Sprite;
        }

        public static void Location(NetIncomingMessage msg) {
            Client.PlayerLocal.X = msg.ReadInt16();
            Client.PlayerLocal.Y = msg.ReadInt16();

            Client.PlayerLocal.Character.X = Client.PlayerLocal.X * 16;
            Client.PlayerLocal.Character.Y = Client.PlayerLocal.Y * 16;
            Client.PlayerLocal.Character.Coordinate = new SharpDX.Point(Client.PlayerLocal.X, Client.PlayerLocal.Y);
        }
       
        /// <summary>
        /// Recebe a posição do jogador no mapa.
        /// </summary>
        /// <param name="msg"></param>
        public static void PlayerLocation(NetIncomingMessage msg) {
            Client.PlayerLocal.WorldID = msg.ReadInt16();
            Client.PlayerLocal.RegionID = msg.ReadInt16();
            Client.PlayerLocal.Direction = msg.ReadByte();
            Client.PlayerLocal.X = msg.ReadInt16();
            Client.PlayerLocal.Y = msg.ReadInt16();

            Client.PlayerLocal.Character.X = Client.PlayerLocal.X * 16;
            Client.PlayerLocal.Character.Y = Client.PlayerLocal.Y * 16;
            Client.PlayerLocal.Character.Dir = (EngineCharacter.Direction)Client.PlayerLocal.Direction;
            Client.PlayerLocal.Character.Coordinate = new SharpDX.Point(Client.PlayerLocal.X, Client.PlayerLocal.Y);
        }

        public static void PlayerStats(NetIncomingMessage msg) {
            Client.PlayerLocal.Strenght = msg.ReadInt32();
            Client.PlayerLocal.Dexterity = msg.ReadInt32();
            Client.PlayerLocal.Agility = msg.ReadInt32();
            Client.PlayerLocal.Constitution = msg.ReadInt32();
            Client.PlayerLocal.Intelligence = msg.ReadInt32();
            Client.PlayerLocal.Wisdom = msg.ReadInt32();
            Client.PlayerLocal.Will = msg.ReadInt32();
            Client.PlayerLocal.Mind = msg.ReadInt32();
        }

        public static void PlayerVital(NetIncomingMessage msg) {
            Client.PlayerLocal.MaxHP = msg.ReadInt32();
            Client.PlayerLocal.HP = msg.ReadInt32();
            Client.PlayerLocal.MaxMP = msg.ReadInt32();
            Client.PlayerLocal.MP = msg.ReadInt32();
            Client.PlayerLocal.MaxSP = msg.ReadInt32();
            Client.PlayerLocal.SP = msg.ReadInt32();
        }

        public static void PlayerVitalRegen(NetIncomingMessage msg) {
            Client.PlayerLocal.RegenHP = msg.ReadInt32();
            Client.PlayerLocal.RegenMP = msg.ReadInt32();
            Client.PlayerLocal.RegenSP = msg.ReadInt32();
        }

        public static void PlayerPhysicalStats(NetIncomingMessage msg) {
            Client.PlayerLocal.Attack = msg.ReadInt32();
            Client.PlayerLocal.Accuracy = msg.ReadInt32();
            Client.PlayerLocal.Defense = msg.ReadInt32();
            Client.PlayerLocal.Evasion = msg.ReadInt32();
            Client.PlayerLocal.Block = msg.ReadInt32();
            Client.PlayerLocal.Parry = msg.ReadInt32();
            Client.PlayerLocal.CriticalRate = msg.ReadInt32();
            Client.PlayerLocal.CriticalDamage = msg.ReadInt32();
            Client.PlayerLocal.AttackSpeed = msg.ReadInt32();
        }

        public static void PlayerMagicalStats(NetIncomingMessage msg) {
            Client.PlayerLocal.MagicAttack = msg.ReadInt32();
            Client.PlayerLocal.MagicAccuracy = msg.ReadInt32();
            Client.PlayerLocal.MagicDefense = msg.ReadInt32();
            Client.PlayerLocal.MagicResist = msg.ReadInt32();
            Client.PlayerLocal.MagicCriticalRate = msg.ReadInt32();
            Client.PlayerLocal.MagicCriticalDamage = msg.ReadInt32();
            Client.PlayerLocal.CastSpeed = msg.ReadInt32();
        }

        public static void PlayerUniqueStats(NetIncomingMessage msg) {
            Client.PlayerLocal.Concentration = msg.ReadInt32();
            Client.PlayerLocal.HealingPower = msg.ReadInt32();
            Client.PlayerLocal.Enmity = msg.ReadInt32();
            Client.PlayerLocal.DamageSuppression = msg.ReadInt32();
        }

        public static void PlayerElementalStats(NetIncomingMessage msg) {
            Client.PlayerLocal.AttributeEarth = msg.ReadInt32();
            Client.PlayerLocal.AttributeFire = msg.ReadInt32();
            Client.PlayerLocal.AttributeWater = msg.ReadInt32();
            Client.PlayerLocal.AttributeWind = msg.ReadInt32();
            Client.PlayerLocal.AttributeLight = msg.ReadInt32();
            Client.PlayerLocal.AttributeDark = msg.ReadInt32();
        }

        public static void PlayerResistStats(NetIncomingMessage msg) {
            Client.PlayerLocal.ResistStun = msg.ReadInt32();
            Client.PlayerLocal.ResistParalysis = msg.ReadInt32();
            Client.PlayerLocal.ResistBlind = msg.ReadInt32();
            Client.PlayerLocal.ResistSilence = msg.ReadInt32();
            Client.PlayerLocal.ResistCriticalRate = msg.ReadInt32();
            Client.PlayerLocal.ResistCriticalDamage = msg.ReadInt32();
            Client.PlayerLocal.ResistMagicCriticalRate = msg.ReadInt32();
            Client.PlayerLocal.ResistMagicCriticalDamage = msg.ReadInt32();
        }

        public static void PlayerCurrency(long currency) {
            Client.PlayerLocal.Currency = currency;
        }


        /// <summary>
        /// Recebe os dados do jogador.
        /// </summary>
        /// <param name="msg"></param>
        public static void PlayerData(NetIncomingMessage msg) {
            Client.PlayerLocal.Name = msg.ReadString();
            Client.PlayerLocal.ClasseID = msg.ReadInt16();
            Client.PlayerLocal.Sprite = msg.ReadInt16();
            Client.PlayerLocal.Level = msg.ReadInt32();
            Client.PlayerLocal.Exp = msg.ReadInt64();
            Client.PlayerLocal.Points = msg.ReadInt32();

            Client.PlayerLocal.Character.Name = Client.PlayerLocal.Name;
            Client.PlayerLocal.Character.Sprite = Client.PlayerLocal.Sprite;
            Client.PlayerLocal.Character.Guild = Client.PlayerLocal.Guild;
        }

        /// <summary>
        /// Remove um jogador do mapa
        /// </summary>
        /// <param name="playerID"></param>
        public static void RemovePlayerMap(int playerID) {
            MapManager.Player.Remove(MapManager.FindPlayerByID(playerID));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public static void ReceiveNpc(NetIncomingMessage msg) {
            var lenght = msg.ReadInt32();

            for (var n = 0; n < lenght; n++) {
                var npc = new EngineNpc();
     
                npc.ID = msg.ReadInt32();
                npc.UniqueID = msg.ReadInt32();
                npc.HP = msg.ReadInt32();
                npc.MaxHP = msg.ReadInt32();
                npc.PositionX = msg.ReadInt16() * 16;
                npc.PositionY = msg.ReadInt16() * 16;

                npc.Dir = (EngineNpc.Direction)EngineCharacter.GetDir(msg.ReadByte());

                var _npc = NpcManager.FindNpcByID(npc.ID);

                npc.Name = _npc.Name;
                npc.Sprite = _npc.Sprite;

                MapManager.Npc.Add(npc);
            }
        }

        public static void NpcMove(NetIncomingMessage msg) {
            var uniqueid = msg.ReadInt32();
            var dir = msg.ReadByte();

            var npc = MapManager.FindPlayerByUniqueID(uniqueid);

            if (npc == null) return;

            npc.DirectionQueue.Enqueue((byte)EngineCharacter.GetDir(dir));
        }

      
    }
}
