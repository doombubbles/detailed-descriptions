using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class SuperMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.SuperMonkey;

    public override string TextValue => "<u>Dart</u> attack (1d, 1p, 0.06s, 50r, <i>Sharp</i>).";
}

public class SuperMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.LaserBlasts, "+1p (2), <i>Energy</i>."},
        {UpgradeType.PlasmaBlasts, "50%s, <i>Plasma</i>."},
        {UpgradeType.SunAvatar, "+3p (6), +2j (3)."},
        {
            UpgradeType.SunTemple,
            "<u>Sun Beams</u> replaced by <u>Sunblast</u> (5d, 20p, 0.06s, 65r, <i>Normal</i>) (Look online for Sacrifice stuff lol)."
        },
        {UpgradeType.TrueSunGod, "+10d (15) (Look online for Sacrifice stuff lol)."},

        {UpgradeType.SuperRange, "+1p (2), +10r (60)"},
        {UpgradeType.EpicRange, "+2p (4), +12r (72), faster projectile speed."},
        {UpgradeType.RoboMonkey, "+3p (6), gains independent second attack. 10d Crits every 15 - 20 shots."},
        {
            UpgradeType.TechTerror,
            "Attack replaced by <u>Plasma</u> (1d, 8p, 0.048s, 72r, <i>Plasma</i>). Ability (45s cooldown): 2500d, 2000p, 70r."
        },
        {
            UpgradeType.TheAntiBloon,
            "+4d (5), +5p (13), +10r (82), <i>Normal</i>. 50d Crits every 13-17 shots. Ability (45s cooldown): 5000d, 10000p, 120r."
        },

        {
            UpgradeType.Knockback,
            "Applies <u>Knockback</u> status (~0.5s duration, 125% slow for regular Bloons, 60% for Leads/Ceramics, and 30% for Blimps)."
        },
        {UpgradeType.Ultravision, "+3r (53), Camo."},
        {
            UpgradeType.DarkKnight,
            "<u>Dart</u> replaced by <u>Monkeyrang</u> (1d, 2md (3), 4p, 0.06s, 53r, <i>Sharp</i>). <u>Knockback</u> buffed: 90% slow to Leads/Ceramics. " +
            "Ability (20s cooldown): Teleport to a chosen point within range."
        },
        {
            UpgradeType.DarkChampion,
            "+1d (2), +1md (5), +2cd, +4p (8), 50%s (0.03), <i>Normal</i>. <u>Knockback</u> buffed: 100% slow to Leads/Ceramics. Ability buffed: Can teleport anywhere."
        },
        {
            UpgradeType.LegendOfTheNight,
            "+8d, +5md, +2cd (10, 18md, 14cd), +15p (22), +4r (57). Passive (120s cooldown): Before something leaks, delete it, and anything else that would leak in the next 8s."
        },
    };
}