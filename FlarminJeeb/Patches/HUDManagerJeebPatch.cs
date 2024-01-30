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
        [HarmonyPatch(nameof(NoisemakerProp.ItemActivate))]
        [HarmonyPostfix]
        static void flarminJeebPatch()
        {
            // use 0.002f
            if ((UnityEngine.Random.value < 0.002f) && RoundManagerPatch.isShipLanded /**&& StartOfRound.Instance.shipHasLanded*/)
            {
                HUDManager.Instance.DisplayTip(" ", "The Flarmin' Jeeb is hunting you...", true, false, "LC_Tip1");
            }
        }
    }
}
