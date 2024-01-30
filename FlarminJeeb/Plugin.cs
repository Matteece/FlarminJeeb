using BepInEx;
using FlarminJeeb.Patches;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlarminJeeb
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class flarminJeeb : BaseUnityPlugin
    {
        private const string modGUID = "FlarminJeeb";
        private const string modName = "Flarmin Jeeb";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static flarminJeeb Instance;

        internal BepInEx.Logging.ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("The Flarmin Jeeb has awakened...");

            harmony.PatchAll(typeof(flarminJeeb));
            harmony.PatchAll(typeof(HUDManagerJeebPatch));
            harmony.PatchAll(typeof(RoundManagerPatch));
        }
    }
}
