﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Elysium_Diamond.Common;
using SharpDX.XAudio2;

namespace Elysium_Diamond.DirectX {
    public static class EngineMultimedia {
        public static EngineSoundManager SoundManager { get; set; }
        private static List<EngineMusic> Player { get; set; }
        private static List<SoundEngine> Sound { get; set; }

        /// <summary>
        /// Instancia e inicializa os arquivos de audio.
        /// </summary>
        public static void Initialize() {
            SoundManager = new EngineSoundManager();
            Sound = new List<SoundEngine>();

            Player = new List<EngineMusic>();
            Player.Add(new EngineMusic("Lineage 2 Ertheia - The Epic Tales of Aden.mp3", "Ertheia"));
            Player.Add(new EngineMusic("scene_1.wav", "Scene"));

            //Carrega os arquivos.
            Sound.Add(new SoundEngine(Configuration.GamePath + @"\Data\Sound\0.wav"));
            Sound.Add(new SoundEngine(Configuration.GamePath + @"\Data\Sound\1.wav"));        
        }

        /// <summary>
        /// Realiza a execução do audio.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="loop"></param>
        public static void PlayMusic(int index, bool loop) {
            Player[index].Open();
            Player[index].Play(loop);
        }

        /// <summary>
        /// Fecha o arquivo de audio.
        /// </summary>
        /// <param name="index"></param>
        public static void StopMusic(int index) {
            Player[index].Close();
        }

        /// <summary>
        /// Fecha todas as músicas.
        /// </summary>
        private static void StopMusic() {
            var count = Player.Count;

            for(var n = 0; n > count; n++) { Player[n].Close(); }
        }

        /// <summary>
        /// Toca um som com base no índice.
        /// </summary>
        /// <param name="index"></param>
        public static void Play(EngineSoundEnum index) {
            SoundManager.Play(Sound[(int)index]);          
        }

        /// <summary>
        /// Para a 'engine' evitando problemas.
        /// </summary>
        public static void StopMultimedia() {
            SoundManager.Dispose();
            SoundManager = null;

            //fecha todas as musicas
            StopMusic();

            Player.Clear();
            Sound.Clear();
        }   
    }
}
