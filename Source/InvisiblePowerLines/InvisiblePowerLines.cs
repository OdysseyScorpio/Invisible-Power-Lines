using HarmonyLib;
using System.Reflection;
using Verse;

[StaticConstructorOnStartup]
internal class SmallWireGoAway
{
    static SmallWireGoAway()
    {
        var harmony = new Harmony("OdysseyScorpio.InvisibleConduit.202003");
        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }
}
