using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlarminJeeb.Patches
{
    internal class RoundManagerPatch
    {
        internal static bool isShipLanded = false;
        [HarmonyPatch(typeof(RoundManager), nameof(RoundManager.FinishGeneratingNewLevelClientRpc))]
        [HarmonyPostfix]
        static void RoundManagerPostfixPatch()
        {
            RoundManagerPatch.isShipLanded = true;

            /**if (RoundManager.Instance.currentLevel.name.Contains("Gordion"))
            {
                RoundManagerPatch.isShipLanded = false;
            }*/
        }

        [HarmonyPatch(typeof(RoundManager), nameof(RoundManager.DespawnPropsAtEndOfRound))]
        [HarmonyPostfix]
        static void despawnPropsPatch()
        {
            RoundManagerPatch.isShipLanded = false;
        }
    }
}
