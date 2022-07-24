using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class BoomerangMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.BoomerangMonkey;

    public override string TextValue => "<u>Boomerang</u> attack (1d, 4p, 43r, 1.2s, <i>Sharp</i>)";
}

public class BoomerangMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.ImprovedRangs, "+4p (8)"},
        {UpgradeType.Glaives, "+5p (13)"},
        {UpgradeType.GlaiveRicochet, "<u>Boomerang</u> replaced by <u>Glaive</u> (1d, 50p, 1.2s, 43r, <i>Sharp</i>)"},
        {UpgradeType.MOARGlaives, "+50p (100), 50%s (0.6)"},
        {
            UpgradeType.GlaiveLord,
            "Gains <u>Orbital Glaive</u> attack (2d, 5cd (7), 5md (7), 2fd (4), ∞p, 0.1s, 40r zone, camo). <u>Glaive</u> buffed: 8d, first hit applies shred effect (100d/1.0s, 15s duration)."
        },

        {UpgradeType.FasterThrowing, "75%s (.9)"},
        {UpgradeType.FasterRangs, "75%s (0.675), faster projectile speed"},
        {UpgradeType.BioncBoomerang, "+2md (3), 0.238s"},
        {UpgradeType.TurboCharge, "Ability (45s cooldown): +1d and 7× faster (0.04s) for 10s."},
        {
            UpgradeType.PermaCharge,
            "+3d (4, 6md) (8, 10md w/ 052), 0.04s\nAbility (40s cooldown): +8d (+10d w/052) for 15s."
        },

        {UpgradeType.LongRangeRangs, "+6.5r (49.5)"},
        {UpgradeType.RedHotRangs, "+1d, <i>Normal</i>"},
        {
            UpgradeType.KylieBoomerang,
            "<u>Boomerang</u> replaced by <u>Kylie</u> (2d, 18p, 1.2s, 49.5r, <i>Normal</i>) that travels in a straight line and can re-hit Bloons every .3s"
        },
        {
            UpgradeType.MOABPress,
            "Gains <u>Heavy Kylie</u> attack (1d, 4md (5), 200p (300p w/ 104, 320p w/ 204), 10.0s, <i>Normal</i>) that targets and knocks back Blimps below BAD and can re-hit every 0.1s."
        },
        {
            UpgradeType.MOABDomination, "<u>Kylie</u> buffed: +10d (12), 50%s (0.71). " +
                                        "<u>Heavy Kylie</u> buffed: +20md (25), 50%s (5.0s), 100r, 0.25s stun, can target BADs, creates explosion effect instead of returning: " +
                                        "100d, 40p, <i>Normal</i>, 50 blast radius, applies burn status (50d/1s, 4s duration)"
        },
    };
}