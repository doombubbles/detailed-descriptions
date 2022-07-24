using System.Collections.Generic;
using Assets.Scripts.Unity.Menu;
using Assets.Scripts.Unity.UI_New.Upgrade;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using DetailedDescriptions;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

[assembly:
    MelonInfo(typeof(DetailedDescriptionsMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace DetailedDescriptions
{
    public class DetailedDescriptionsMod : BloonsTD6Mod
    {
        private static UpgradeDetails? hoveredDetails;

        public const KeyCode Modifier = KeyCode.LeftShift;

        public override void OnUpdate()
        {
            if ((Input.GetKeyDown(Modifier) || Input.GetKeyUp(Modifier)) &&
                MenuManager.instance.Exists().GetCurrentMenu().Is(out UpgradeScreen upgradeScreen))
            {
                upgradeScreen.UpdateUi(upgradeScreen.currTowerId);

                if (upgradeScreen.upgradePopup != null && hoveredDetails != null)
                {
                    hoveredDetails.beginShowPopup = true;
                    hoveredDetails.popupTimer = .5f;
                }
            }
        }

        [HarmonyPatch(typeof(UpgradeDetails), nameof(UpgradeDetails.OnPointerEnter))]
        internal class UpgradeDetails_OnPointerEnter
        {
            [HarmonyPostfix]
            public static void PostFix(UpgradeDetails __instance)
            {
                hoveredDetails = __instance;
            }
        }

        [HarmonyPatch(typeof(UpgradeDetails), nameof(UpgradeDetails.OnPointerExit))]
        internal class UpgradeDetails_OnPointerExit
        {
            [HarmonyPostfix]
            public static void PostFix()
            {
                hoveredDetails = null;
            }
        }
    }
}