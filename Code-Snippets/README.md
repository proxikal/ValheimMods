# Code Snippets
> A bunch of code that I've been working on.  
> All of the code in this Section comes from my **Echo Bot Mod**  
> Which wil be available soon on Github. 

# WearNTear Patch Fix.
> Remove all decay effects on buildable objects.  
> Keep everything looking brand new and full health!
```cs
[HarmonyPatch(typeof(WearNTear), nameof(WearNTear.UpdateWear))]
class WearNTearPatch : BaseUnityPlugin
{
  static void Postfix(ref bool ___m_noRoofWear, ref float ___m_health, ref float ___m_rainTimer, WearNTear __instance)
  {
	  ___m_noRoofWear = false;
		___m_rainTimer = 0f;
		___m_health = 100f;
		__instance.UpdateVisual(false);
	}
}
```

# CraftingStations Patch Fix
> All crafting stations can be used indoor or outdoor at anytime.  
> Also, we'll expand the use radius so we don't have tons of ugly workbenches  
```cs
[HarmonyPatch(typeof(CraftingStation), "CheckUsable")]
class PatchStation
{
  static bool Prefix(bool __result, CraftingStation __instance)
  {
    __instance.m_craftRequireRoof = false;
    __result = true;
    return __result;
  }
}

[HarmonyPatch(typeof(CraftingStation), "Start")]
class StationDistance_Patch
{
  static void Prefix(CraftingStation __instance)
  {
    __instance.m_useDistance = 5f;
  }
}
```

# 
