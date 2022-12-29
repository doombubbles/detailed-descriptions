using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class HeliPilotTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.HeliPilot;

    public override string TextValue => "<u>Darts</u> attack (1d, 3p, 40r, 0.56s, 2j, <i>Sharp</i>).";
}

public class HeliPilotUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.QuadDarts, "+2j (4)"},
        {
            UpgradeType.Pursuit,
            "Gains 'Pursuit' targeting (always flies towards a point slightly ahead of the first Bloon)."
        },
        {UpgradeType.RazorRotors, "Gains <u>Rotor</u> attack (2d, 10p, 35r zone, 0.75s, <i>Normal</i>)."},
        {
            UpgradeType.ApacheDartship,
            "<u>Rotor</u> buffed: +2d (4), +10p (20). Gains <u>Machine Gun</u> attack (1d, 7p, 0.05s, <i>Sharp</i>) and <u>Rocket</u> attack (2d, 40p, 1.0s, ∞r, 4j, <i>Explosion</i>)."
        },
        {
            UpgradeType.ApachePrime,
            "<u>Dart</u> buffed: +5d (6), +20p (23), <i>Normal</i>. <u>Rotor</u> buffed: +4d (8), +20p (40). <u>Machine Gun</u> buffed: +4d (5), +4p (11), <i>Plasma</i>. <u>Rocket</u> buffed: +15md (17)."
        },

        {UpgradeType.BiggerJets, "Flies faster."},
        {UpgradeType.IFR, "Camo."},
        {
            UpgradeType.Downdraft,
            "Gains <u>Downdraft</u> attack (0d, 0.15s (.12s w/ 032)1p, ) that sends Bloon 32-150 units back."
        },
        {
            UpgradeType.SupportChinook,
            "<u>Downdraft</u> buffed: 32-300 units. Ability (60s cooldown): Move a tower, except for: Aces, Helis, Farms, Villages, Aircraft Carriers, and Temples.) Ability (90s cooldown): Drops $1650 and 10 lives."
        },
        {
            UpgradeType.SpecialPoperations,
            "Ability (60s cooldown): Drops $4500 and 25 lives. Ability (25s cooldown): deploy a Marine (30s lifetime) with a <u>Bullet</u> attack (6d, 20p, 0.05s, 50r, <i>Normal</i>)."
        },

        {UpgradeType.FasterDarts, "Darts travel 30% faster and farther."},
        {UpgradeType.FasterFiring, "<u>Darts</u> buffed: 80%s."},
        {
            UpgradeType.MOABShove,
            "Gains <u>Shove</u> attack (0d, 1p) that pushes back MOABs and BFBs, or slows DDTs and ZOMGs. <u>Mini Missile</u> attack: (1d, 10p)."
        },
        {
            UpgradeType.ComancheDefense,
            "<u>Passive</u>: Summons 1, 2, 3 Mini-Comanches for 15s when a Bloon crosses 25%, 50%, 75% of the track" +
            "with <u>Darts</u> attack (2d, 4p, 0.3s, 40r, 3j, <i>Sharp</i>) and <u>Rocket</u> attack (1d, 2cd (3), 2md (3), 100p, 3.0s, <i>Explosion</i>). " +
            "<u>Mini Missile</u> buffed: 3d, 30p, 1s. <u>Darts</u> buffed: 2d"
        },
        {UpgradeType.ComancheCommander, "+1d (including mini comanche attacks). Comanches are permanent."},
    };
}