using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlarminJeeb.Patches
{
    [HarmonyPatch(typeof(NoisemakerProp))]
    internal class HUDManagerJeebPatch
    {
        /**
        internal static bool level = false;
        [HarmonyPatch(typeof(StartOfRound), nameof(StartOfRound.ArriveAtLevel))]
        [HarmonyPostfix]
        static void helperPatch()
        {
            if (StartOfRound.Instance.levels.Length >= 4 && StartOfRound.Instance.levels[3] != null)
            {
                if (!StartOfRound.Instance.levels[3].PlanetName.Contains("Gordion"))
                {
                    level = true;
                }
            }
        }  */      

        [HarmonyPatch(nameof(NoisemakerProp.ItemActivate))]
        [HarmonyPostfix]
        static void flarminJeebPatch()
        {
            // use 0.002f
            if ((UnityEngine.Random.value < 0.99f) && RoundManagerPatch.isShipLanded);
            {
                HUDManager.Instance.DisplayTip(" ", "The Flarmin' Jeeb is hunting you...", true, false, "LC_Tip1");
            }
        }
    }
}
