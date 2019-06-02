﻿using QuestomAssets.AssetsChanger;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestomAssets.BeatSaber
{
    public static class BeatSaberConstants
    {

        public static class KnownFiles
        {
            public const string File19 = "sharedassets19.assets";
            public const string File17 = "sharedassets17.assets";
            public const string File11 = "sharedassets11.assets";
            public const string File14 = "sharedassets14.assets";

            public const string FullFile19Path = AssetsRootPath + File19;
            public const string FullFile17Path = AssetsRootPath + File17;
            public const string FullFile11Path = AssetsRootPath + File11;
            public const string FullFile14Path = AssetsRootPath + File14;

            public const string AssetsRootPath = "assets/bin/Data/";
            public const string SaberAssetsFilename = File11;
            public const string SongsAssetsFilename = File17;
            public const string MainCollectionAssetsFilename = File19;

            public const string FullSaberAssetsPath = AssetsRootPath + SaberAssetsFilename;
            public const string FullSongsAssetsPath = AssetsRootPath + SongsAssetsFilename;
            public const string FullMainCollectionAssetsPath = AssetsRootPath + MainCollectionAssetsFilename;
        }

        public static class ScriptHash
        {
            public static Guid BeatmapLevelPackScriptHash { get { return new Guid("252e448f-a4c9-c8aa-dabe-c88917b0dc7d"); } }
            public static Guid BeatmapLevelCollectionScriptHash { get { return new Guid("59dd0c93-dbc2-fac4-6745-01914a570ac2"); } }
            public static Guid MainLevelsCollectionHash { get { return new Guid("8398a1c6-7d3b-cc41-e8d7-83cd6a11bfd4"); } }
            public static Guid BeatmapLevelDataHash { get { return new Guid("4690eca3-1201-f506-cd10-9314850602e3"); } }
            public static Guid BeatmapDataHash { get { return new Guid("8d3caf95-6f40-5cf3-9da1-51e0ee1e0013"); } }
        }

        public static class ScriptPtr
        {
            public static PPtr BeatmapLevelDataScriptPtr { get { return new PPtr(1, 644); } }
            public static PPtr BeatmapDataScriptPtr { get { return new PPtr(1, 1552); } }
            public static PPtr BeatmapLevelCollectionScriptPtr { get { return new PPtr(1, 762); } }
            public static PPtr BeatmapLevelPackScriptPtr { get { return new PPtr(1, 1480); } }
            public static PPtr MainLevelsCollectionScriptPtr { get { return new PPtr(1, 1530); } }
        }

        public static Dictionary<Guid, Type> GetAssetTypeMap()
        {
            Dictionary<Guid, Type> scriptHashToTypes = new Dictionary<Guid, Type>();
            scriptHashToTypes.Add(ScriptHash.BeatmapLevelPackScriptHash, typeof(BeatmapLevelPackObject));
            scriptHashToTypes.Add(ScriptHash.BeatmapLevelCollectionScriptHash, typeof(BeatmapLevelCollectionObject));
            scriptHashToTypes.Add(ScriptHash.MainLevelsCollectionHash, typeof(MainLevelPackCollectionObject));
            scriptHashToTypes.Add(ScriptHash.BeatmapDataHash, typeof(BeatmapDataObject));
            scriptHashToTypes.Add(ScriptHash.BeatmapLevelDataHash, typeof(BeatmapLevelDataObject));
            return scriptHashToTypes;
        }

        public static List<string> KnownLevelPackNames { get; } = new List<string>() {
            "OstVol1LevelPack",
            "OstVol2LevelPack",
            "ExtrasLevelPack",
            "MonstercatPreviewBeatmapLevelPack"
        };
    }
}