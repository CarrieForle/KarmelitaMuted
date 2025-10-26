using BepInEx;
using HarmonyLib;
using System;
using UnityEngine;

namespace KarmelitaMuted;

[BepInAutoPlugin(id: "io.github.karmelitamuted")]
public partial class KarmelitaMutedPlugin : BaseUnityPlugin
{
    private void Awake()
    {
        var harmony = new Harmony("io.github.karmelitamuted");
        harmony.PatchAll();
        Logger.LogInfo($"Plugin {Name} ({Id}) has loaded!");
    }
}

[HarmonyPatch(typeof(AudioSource))]
[HarmonyPatch("Play", typeof(ulong))]
class PatchPlay
{
    static bool Prefix(ref AudioSource __instance, ulong delay = 0)
    {
        if (__instance.clip.GetName() == "H87 Flower Live Vox-117 Game VOX STEM w intro vox")
        {
            return false;
        }

        return true;
    }
}

[HarmonyPatch(typeof(AudioSource))]
[HarmonyPatch("PlayScheduled")]
class PatchPlayScheduled
{
    static bool Prefix(ref AudioSource __instance, double time)
    {
        if (__instance.clip.GetName() == "H87 Flower Live Vox-117 Game VOX STEM w intro vox")
        {
            return false;
        }

        return true;
    }
}