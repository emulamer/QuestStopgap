﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeatmapAssetMaker.AssetsChanger
{
    public static class AssetsConstants
    {

        public static class ClassID
        {
            public const int MonoBehaviourScriptType = 114;
            public const int AudioClipClassID = 83;
            public const int Texture2DClassID = 28;
            public const int SpriteClassID = 213;
        }

        public static class KnownObjects
        {
            public static PPtr DefaultEnvironment { get { return new PPtr(20, 1); } }
            public static PPtr BeatSaberCoverArt { get { return new PPtr(0, 19); } }

            public static PPtr OneSaberCharacteristic{ get { return new PPtr(19, 1); } }
            public static PPtr NoArrowsCharacteristic { get { return new PPtr(6, 1); } }
            public static PPtr StandardCharacteristic { get { return new PPtr(22, 1); } }
   

        }
        //public const int BeatmapDataSOTypeIndex = 0x0E;

        //public const int BeatmapLevelTypeIndex = 0x0F;

        //public const int BeatmapLevelCollectionTypeIndex = 0x10;

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
           // public static AssetsPtr BeatmapLevelDataScriptPtr { get { return new AssetsPtr(0, 39); } }
            public static PPtr MainLevelsCollectionScriptPtr { get { return new PPtr(1, 1530); } }
        }
    }
}