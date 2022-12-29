using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class IceMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.IceMonkey;

    public override string TextValue =>
        "<u>Freeze</u> attack (1d, 30p, 2.4s, 20r, <i>Cold</i>) that applies <u>Frozen</u> status for 1.5s";
}

public class IceMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.Permafrost, "Applies <u>Permafrost</u> status (50% slow; 25% for Blimps, if targetable)."},
        {UpgradeType.ColdSnap, "Can pop Camo and Lead (but not necessarily Frozen)."},
        {UpgradeType.IceShards, "+5r (25), Frozen Bloons emit <u>Shards</u> (2d, 3p, 3j, <i>Shatter</i>) when hit."},
        {
            UpgradeType.Embrittlement,
            "+1d (2), Camo, On-hit effects: De-camo, De-regrow. Applies <u>Brittle</u> status (take +1d, 2s duration) also affecting MOABs."
        },
        {
            UpgradeType.SuperBrittle,
            "+3d (5), 90%s (2.16), <i>Normal</i>. <u>Brittle</u> status buffed: take +4d, 3s duration. Blimps can receive <u>Permafrost</u> and <u>Brittle</u>."
        },

        {UpgradeType.EnhancedFreeze, "75%s (1.8s), <u>Frozen</u> status now lasts 1.75s."},
        {UpgradeType.DeepFreeze, "+10p, <u>Frozen</u> status is passed down 1 layer and lasts 2.2s."},
        {
            UpgradeType.ArcticWind,
            "+60p (100), gains <u>Slow</u> aura (<i>Cold</i>, 60% slow). Land towers are placeable on any water in range."
        },
        {
            UpgradeType.Snowstorm, "+10r (30), Ability (30s cooldown): 1 damage to everything (non-white) on screen; " +
                                   "applies <u>Frozen</u> status to remaining Bloons (including white) for 6s and to Blimps for 2s."
        },
        {
            UpgradeType.AbsoluteZero,
            "+200p (300), +10r (40), <u>Slow</u> effect is now 60%, <u>Frozen</u> status is passed down 3 layers. " +
            "Ability (20s cooldown): 1 damage and 10s <u>Frozen</u> status to everything; all Ice Monkeys gain 66.66%s buff for 10s."
        },

        {UpgradeType.LargerRadius, "+7r (27)"},
        {UpgradeType.ReFreeze, "<u>Freeze</u>: <i>Glacier</i>"},
        {
            UpgradeType.CryoCannon,
            "Replaces <u>Freeze</u> attack with <u>Ice-Bomb</u> (1.2s, 46r, <i>Color</i>) that applies <u>Freeze</u> (2d, 20p, 20r, <i>Glacier</i>, <u>Frozen</u> for 1.5s)"
        },
        {UpgradeType.Icicles, "<u>Frozen</u> Bloons have <u>Icicles</u> (2d, 3p, <i>Sharp</i>)."},
        {
            UpgradeType.IcicleImpale,
            "75%s (0.75), +49md (50), <i>Shatter</i>. Blimps can be targeted: ZOMGSs are 50% slower, other Blimps move at ZOMGs' original speed."
        },
    };
}