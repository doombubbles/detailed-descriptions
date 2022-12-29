using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class TackShooterTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.TackShooter;

    public override string TextValue => "<u>Tacks</u> attack (1d, 1p, 1.4s, 23r, 8j, <i>Sharp</i>)";
}

public class TaskShooterUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.FasterShooting, "75%s (1.05)"},
        {UpgradeType.EvenFasterShooting, "60%s (0.63)"},
        {UpgradeType.HotShots, "+1d (2), <i>Normal</i>"},
        {
            UpgradeType.RingOfFire,
            "<u>Tacks</u> replaced by <u>Firezone</u> (5d (6d w/ 401, 7d w/ 402), 40p (50p w/ 410, 60p w/ 420), 0.315s, 23r zone, <i>Fire</i>)."
        },
        {
            UpgradeType.InfernoRing,
            "+3d (8), +4md (12), 0.1s, +11.5r (34.5). Gains <u>Meteor</u> attack (700d (100d w/ 502), 1p (2p w/520), 4.0s, ∞r, <i>Fire</i>, Camo, Strong targeting) " +
            "that creates <u>Explosion</u> (50d, 10p, 18 blast radius) and applies <u>Burn</u> status (50d/1.0s, 4s duration, <i>Fire</i>)."
        },

        {UpgradeType.LongRangeTacks, "+4r (27)"},
        {UpgradeType.SuperRangeTacks, "+4r (31), +1p (2)"},
        {UpgradeType.BladeShooter, "<u>Tacks</u> replaced by <u>Blades</u> (1d, 6p, 1.19s, 31r, <i>Sharp</i>)"},
        {
            UpgradeType.BladeMaelstrom,
            "Ability (20s cooldown): Emits blades (1d, 200p, 0.0333s, 2j, <i>Sharp</i>) for 3s."
        },
        {
            UpgradeType.SuperMaelstrom,
            "+1d (2), <i>Normal</i>. Ability (20s cooldown): Emits blades (2d, 500p, 0.0333s, 4j, <i>Normal</i>) for 9s"
        },

        {UpgradeType.MoreTacks, "+2j (10)"},
        {UpgradeType.EvenMoreTacks, "+2j (12)"},
        {UpgradeType.TackSprayer, "75%s (1.05), +4j (16)"},
        {UpgradeType.Overdrive, "+1p (2), 33.33%s (0.35)"},
        {UpgradeType.TheTackZone, "+1md (2), +2p (4) (10 w/ 025), 75%s (0.2625), +7r (30) (50 w/ 025), +16j (32)"},
    };
}