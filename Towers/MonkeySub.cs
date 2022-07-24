using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class MonkeySubTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.MonkeySub;

    public override string TextValue => "<u>Dart</u> attack (1d, 2p, 0.75s, 42r, <i>Sharp</i>)";
}

public class MonkeySubUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.LongerRange, "+10r (52)"},
        {
            UpgradeType.AdvancedIntel,
            "Can target anything in the primary attack range of any tower, including Camo detection."
        },
        {
            UpgradeType.SubmergeAndSupport,
            "Gains Submerge targeting option, replacing <u>Dart</u> with <u>Sonar</u> (0d, ∞p, 1.75s (1.275s w/ 301, 0.956s w/ 302), de-camo)."
        },
        {
            UpgradeType.BloontoniumReactor,
            "<u>Sonar</u> buffed: 0.3s. While submerged, gains <u>Radioactive</u> attack (1d (2ld w/ 420), 50p (70p w/ 410, 100p w/ 420), 0.3s (0.255s w/ 410, 0.191s w/ 420), <i>Normal</i>). " +
            "Water towers in range have 85% ability cooldowns."
        },
        {
            UpgradeType.Energizer,
            "<u>Radioactive</u> buffed: 3d, 1000p/ Water towers in range have 50% ability cooldowns, all others 80%. Heroes in range get +50% XP."
        },

        {UpgradeType.BarbedDarts, "+3p (5)"},
        {UpgradeType.HeatTippedDarts, "<u>Dart</u>: <i>Normal</i>"},
        {
            UpgradeType.BallisticMissile,
            "+8r (50), gains <u>Missile</u> attack (1d, 5cd (6), 5md (6), 100p, 1.105s (.967s w/ 031, 0.87s w/ 032), <i>Explosion</i>). Infinite range with 230 crosspath."
        },
        {
            UpgradeType.FirstStrikeCapability,
            "Ability (60s cooldown): 10000 <i>Normal</i> damage to strongest Bloon, which can pierce blimp layers; additionally creates a (350d, 80p, 75r, <i>Normal</i>) explosion."
        },
        {
            UpgradeType.PreEmptiveStrike,
            "<u>Missile</u> buffed: +6cd (11), +6md (11), 33.33%s (0.5s). Ability cooldown is now 45s. Passive: Sends an assassin (up to 750d) at any Blimp that enters the map."
        },

        {UpgradeType.TwinGuns, "50%s (0.375)"},
        {
            UpgradeType.AirburstDarts,
            "<u>Dart</u> is now an impact projectile, emits <u>Airbursts</u> on hit (1d, 2p, 3j, <i>Sharp</i>)"
        },
        {UpgradeType.TripleGuns, "66.66%s (0.25)"},
        {
            UpgradeType.ArmorPiercingDarts,
            "<u>Dart</u> buffed: +1d (2), +2md (4).\n<u>Airbursts</u> buffed: +1md (2), +3p (5)."
        },
        {
            UpgradeType.SubCommander,
            "50%s (0.125), <u>Command</u> buff for all subs in range including self: <u>Dart</u> +1d, <u>Dart</u> +4p, all other attacks double damage."
        },
    };
}