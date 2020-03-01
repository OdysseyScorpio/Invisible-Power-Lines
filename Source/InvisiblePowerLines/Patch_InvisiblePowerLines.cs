using HarmonyLib;
using RimWorld;

namespace GoAwaySmallWire
{
    [HarmonyPatch(typeof(PowerNetGraphics))]
    [HarmonyPatch("PrintWirePieceConnecting")]
    internal class Patch_ThatSmallWire
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}
