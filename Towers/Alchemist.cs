using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class AlchemistTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.Alchemist;

    public override string TextValue =>
        "<u>Potion</u> attack (1d, 15p, 2.0s, 45r, <i>Acid</i>) that applies <u>Acid</u> status (1d/2.0s, 4s duration, <i>Acid</i>).";
}

public class AlchemistUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.LargerPotions, "<u>Potion</u> buffed: +5p (20), larger blast radius."},
        {
            UpgradeType.AcidicMixtureDip,
            "Every 10s, applies <u>Acidified</u> (+1cd, +1md, lead, lasts 10 (13 w/ 220) shots) to random non-Alchemists in range, prioritizing those not already buffed."
        },
        {
            UpgradeType.BerserkerBrew,
            "Every 8s applies <u>Berserk</u> (+1d, +2p, 90%s, +10%r, lasts 5.0s (6.0s w/ 320) or 25 (40 w/ 320) shots, cannot be reapplied for 5.0s (4.0s w/ 320)) " +
            "to closest non-Alchemist tower in range that's buffable."
        },
        {
            UpgradeType.StrongerStimulant,
            "<u>Berserk</u> buffed: +1p (+3p), now 85%s, +5%r (+15%r), lasts +6.0s (12.0s) or +15 (40) shots."
        },
        {
            UpgradeType.PermanentBrew,
            "<u>Acidified</u> and <u>Berserk</u> buffs are permanent (unless this Alchemist is sold)."
        },

        {UpgradeType.StrongerAcid, "<u>Acid</u> status buffed: 1d/1.5s, 4.5s duration."},
        {
            UpgradeType.PerishingPotions,
            "<u>Potion</u> buffed: +4md (5), removes fortified from Bloons, or does an extra 15d to fortified Blimps (20 total)."
        },
        {
            UpgradeType.UnstableConcoction,
            "Gains <u>Unstable Potion</u> attack (3p, 6.0s, 67.5r, Blimps only) that applies <u>Unstable</u> (on pop, 1%d, 10%md, 50p (Blimps use 2p), <i>Explosion</i>)."
        },
        {
            UpgradeType.TransformingTonic,
            "Ability (60s cooldown, 20s duration): Transforms into a <u>Monster</u> with <u>Beam</u> attack (2d, 6p, 72r, 0.03s, <i>Plasma</i>)."
        },
        {
            UpgradeType.TotalTransformation,
            "Ability (40s cooldown, 20s duration): Transforms self and 5 nearby towers (tier 3 or lower) into <u>Monsters</u>. Other <u>Monsters</u> have +4p (10)."
        },

        {UpgradeType.AlchemistFasterThrowing, "80%s (1.6)"},
        {
            UpgradeType.AcidPool,
            "If no target for <u>Potion</u>, instead creates <u>Acid Pool</u> (7s lifetime, 1d, 5p) that applies <u>Acid</u> status."
        },
        {
            UpgradeType.LeadToGold,
            "<u>Potion</u> buffed: +9ld, applies Golden Lead status (gives $50 when the Lead layer is popped)."
        },
        {
            UpgradeType.RubberToGold,
            "Gains <u>Gold Potion</u> attack (15p, 5.0s) that applies <u>Golden</u> status (+2 cash modifier), which soaks through Bloons but not Blimps, and doesn't affect BADs."
        },
        {
            UpgradeType.BloonMasterAlchemist,
            "Gains <u>Red Potion</u> attack (200p (MOABs use 20p, BFBs/DDTs 50p, ZOMGs 100p), 10.0s, ∞r) that transforms target into a Red Bloon."
        },
    };
}