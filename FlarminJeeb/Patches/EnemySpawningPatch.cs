using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlarminJeeb.Patches
{
    class EnemySpawningPatch
    {
        internal static bool isShipLanded = false;
        [HarmonyPatch(typeof(RoundManager), nameof(RoundManager.BeginEnemySpawning))]
        [HarmonyPostfix]
        static void BeginEnemySpawningPatch_Postfix()
        {
            EnemySpawningPatch.isShipLanded = true;
        }
    }
}
