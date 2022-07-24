using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class MonkeyVillageTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.MonkeyVillage;

    public override string TextValue => "<u>Buff</u> effect (40r; grants: +10%r).";
}

public class MonkeyVillageUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.BiggerRadius, "+8r (48)"},
        {UpgradeType.JungleDrums, "<u>Buff</u> improved: now also gives 85%s."},
        {
            UpgradeType.PrimaryTraining,
            "Gains <u>Primary Buff</u> (targets: primary towers; grants: +1p, +10%r, increased projectile speed)."
        },
        {
            UpgradeType.PrimaryMentoring,
            "<u>Primary Buff</u> improved: free tier 1 upgrades, +5r, 90% ability cooldowns."
        },
        {
            UpgradeType.PrimaryExpertise,
            "+7r (55). <u>Primary Buff</u> improved: +2p (so +3 overall), free tier 2 upgrades. 80% ability cooldowns. " +
            "Gains <u>Catapult</u> attack (10d, 190cd (200), 190md (200), 100p but Blimps use 10p, ∞r, 2.5s, <i>Normal</i>, Camo)."
        },

        {UpgradeType.GrowBlocker, "Applies Anti-regrow status to Bloons in range."},
        {UpgradeType.RadarScanner, "Buff improved: Grants Camo."},
        {UpgradeType.MonkeyIntelligenceBureau, "Buff improved: grants <i>Normal</i> damage."},
        {UpgradeType.CallToArms, "Ability (45s cooldown): Provides another buff for 15s (+50%p, 66.67%s)."},
        {
            UpgradeType.HomelandDefense,
            "Ability (60s cooldown): Applies over an infinite range for 20s, and improved to (+100%p, 50%s)."
        },

        {UpgradeType.MonkeyBusiness, "<u>Buff</u> improved: +10% discount to base towers and upgrades up to tier 3."},
        {
            UpgradeType.MonkeyCommerce,
            "<i>Buff</i> improved: +5% discount to base towers and upgrades up to tier 3, stackable (additively) up to 3 times total."
        },
        {UpgradeType.MonkeyTown, "<u>Buff</u> improved: +50% cash modifier (additive with other cash modifiers)."},
        {
            UpgradeType.MonkeyCity,
            "+10r (50). Provides a free Dart Monkey each round. Gains <u>Support Buff</u> (targets: income towers; grants: +15% income)."
        },
        {
            UpgradeType.Monkeyopolis,
            "Actual cost is $5000 * number of non-tier-5 Farms in range. Sacrifices those Farms to gain income of $300 * floor(sacrifice $ / 2000)."
        },
    };
}