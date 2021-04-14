using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;
using UnityEngine;
using BepInEx.Configuration;

namespace Echo
{
	[HarmonyPatch(typeof(WearNTear), nameof(WearNTear.UpdateWear))]
	class WearNTearPatch : BaseUnityPlugin
    {
		static void Postfix(ref bool ___m_noRoofWear, ref float ___m_health, ref float ___m_rainTimer, WearNTear __instance)
		{
    // 
			if(GoTools.noBuildDamage.Value) // BepInEx Config variable. Replace with a True or False value or remove if statement to keep enabled.
      {
				___m_noRoofWear = false;
				___m_rainTimer = 0f;
				___m_health = 100f;
				__instance.UpdateVisual(false);
			}
		}
	}
}
