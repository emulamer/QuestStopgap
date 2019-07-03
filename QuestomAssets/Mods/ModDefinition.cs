﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using QuestomAssets.AssetOps;
using QuestomAssets.AssetsChanger;
using QuestomAssets.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace QuestomAssets.Mods
{
    public class ModDefinition
    {
        /// <summary>
        /// The list of individual components of this mod
        /// </summary>
        public List<ModComponent> Components { get; set; } = new List<ModComponent>();

        public bool ShouldSerializeComponents()
        {
            return false;
        }

        public List<AssetOp> GetInstallOps(ModContext context)
        {
            List<AssetOp> ops = new List<AssetOp>();
            using (new LogTiming($"Installing mod ID {ID}"))
            {
                if (Components == null || Components.Count < 1)
                {
                    Log.LogErr($"The mod with ID {ID} has no components to install.");
                    throw new Exception($"The mod with ID {ID} has no components to install.");
                }
                try
                {
                    foreach (var comp in Components)
                    {
                        ops.AddRange(comp.GetInstallOps(context));
                    }
                }
                catch (Exception ex)
                {
                    Log.LogErr($"Mod ID {ID} threw an exception while installing.", ex);
                    throw new Exception($"Mod ID {ID} failed to install.", ex);
                }
            }
            ops.Add(new ModStatusOp(this, ModStatusType.Installed));
            return ops;
        }

        public List<AssetOp> GetUninstallOps(ModContext context)
        {
            List<AssetOp> ops = new List<AssetOp>();
            using (new LogTiming($"Uninstalling mod ID {ID}"))
            {
                if (Components == null || Components.Count < 1)
                {
                    Log.LogErr($"The mod with ID {ID} has no components to uninstall.");
                    throw new Exception($"The mod with ID {ID} has no components to uninstall.");
                }
                try
                {
                    foreach (var comp in Components)
                    {
                        ops.AddRange(comp.GetUninstallOps(context));
                    }
                }
                catch (Exception ex)
                {
                    Log.LogErr($"Mod ID {ID} threw an exception while uninstalling.", ex);
                    throw new Exception($"Mod ID {ID} failed to uninstall.", ex);
                }
            }
            ops.Add(new ModStatusOp(this, ModStatusType.NotInstalled));
            return ops;
        }

        public ModDefinition ToBase()
        {
            return JsonConvert.DeserializeObject<ModDefinition>(JsonConvert.SerializeObject(this));
        }

        private ModStatusType _status;
        /// <summary>
        /// Gets or sets the installation status of the mod
        /// </summary>
        public ModStatusType Status
        {
            get
            {
                return _status;
            }
            set
            {
                bool change = (_status == value);
                _status = value;
                if (change)
                    PropChanged(nameof(Status));
            }
        }

        /// <summary>
        /// Unique identifier of this mod
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// The (display) name of the mod
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The author of the mod
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// A link to more information about the mod
        /// </summary>
        public string InfoUrl { get; set; }

        /// <summary>
        /// The description of the mod
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The category this mod falls into for display and organizational purposes
        /// </summary>
        public ModCategory Category { get; set; }

        /// <summary>
        /// The version of Beat Saber that this mod was designed for
        /// </summary>
        public string TargetBeatSaberVersion { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void PropChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ModStatusType
    {
        NotInstalled,
        Installed
    }
}