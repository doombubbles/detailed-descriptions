using BTD_Mod_Helper.Api.Data;
using UnityEngine;

namespace DetailedDescriptions;

public abstract class UpgradeDetailedDescriptions : ModMultiTextOverride
{
    public override string KeySuffix => " Description";

    public override bool Active => Input.GetKey(KeyCode.LeftShift);
}