using BTD_Mod_Helper.Api.Data;
using UnityEngine;

namespace DetailedDescriptions;

public abstract class TowerDetailedDescription : ModTextOverride
{
    protected abstract string TowerId { get; }

    public  sealed override string LocalizationKey => TowerId + " Description";

    public override bool Active => Input.GetKey(KeyCode.LeftShift);
}

