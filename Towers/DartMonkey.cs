using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class DartMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.DartMonkey;
    public override string TextValue => "<u>Dart</u> attack (1d, 2p, 0.95s, 32r, <i>Sharp</i>)";
}

public class DartMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.SharpShots, "+1p (3)"},
        {UpgradeType.RazorSharpShots, "+2p (5)"},
        {
            UpgradeType.SpikeOPult,
            "<u>Dart</u> replaced by <u>Spikeball</u> (1d, 1cd (2), 22p, 1.15s, <i>Shatter</i>). <u>Spikeball</u> can rebound off walls."
        },
        {
            UpgradeType.Juggernaut,
            "<u>Spikeball</u> replaced by <u>Juggernaut</u> (2d, 3cd, 50p, 36.5r, 1.0s, <i>Normal</i>). <u>Juggernaut</u> slightly knocks back bloons and can rebound off walls."
        },
        {
            UpgradeType.UltraJuggernaut,
            "<u>Juggernaut</u> replaced by <u>Ultrajugg</u> (4d, 8cd (12), 200p, 1.0s, <i>Normal</i>). <u>Ultrajugg</u> can re-hit Bloons after rebounding, " +
            "and emits 6 <u>Juggernauts</u> at 100p remaining and when it expires."
        },

        {UpgradeType.QuickShots, "85%s (0.8075)"},
        {UpgradeType.VeryQuickShots, "78.43%s (0.6333)"},
        {UpgradeType.TripleShot, "+2j (3)"},
        {
            UpgradeType.SuperMonkeyFanClub,
            "75%s (0.475), Ability (50s cooldown, 15s duration): Transforms 10 nearest Dart Monkeys (upgraded up to 242) into Superfans " +
            "that have a <u>Dart</u> attack (1d, 2p, 0.06s, 40r, <i>Sharp</i>), inheriting buffs to the transformed tower."
        },
        {
            UpgradeType.PlasmaMonkeyFanClub,
            "Ability (50s cooldown, 15s duration): Transforms 20 nearest dart monkeys (upgraded up to 252) into Plasmafans " +
            "that have a <u>Plasma</u> attack (2d, 5p, 0.03s, 40r, <i>Plasma</i>), inheriting buffs to the transformed tower."
        },

        {UpgradeType.LongRangeDarts, "+8r (40)"},
        {
            UpgradeType.EnhancedEyesight, "+8r (48)\nGains Camo detection"
        },
        {UpgradeType.Crossbow, "<u>Dart</u> replaced by <u>Bolt</u> (3d, 3p, 0.95s, 56r, <i>Sharp</i>)"},
        {
            UpgradeType.SharpShooter, "+3d (6), 0.75s\n" +
                                      "50d Crit every 8-12 shots"
        },
        {
            UpgradeType.CrossbowMaster, "+7p (10) (16p w/ 105, 23p w/ 205), +20r (76), 0.16s, <i>Normal</i>\n" +
                                        "Crit now occurs every 4-8 shots"
        },
    };
}