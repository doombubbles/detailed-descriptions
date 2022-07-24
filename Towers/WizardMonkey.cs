using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class WizardMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.WizardMonkey;

    public override string TextValue => "<u>Bolt</u> attack (1d, 3p, 40r, 1.1s, <i>Energy</i>)";
}

public class WizardMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {
            UpgradeType.GuidedMagic,
            "<u>Bolt</u> buffed: homing, ignores walls. Wall of Fire placed according to target priority."
        },
        {UpgradeType.ArcaneBlast, "<u>Bolt</u> buffed: +1d (2)."},
        {UpgradeType.ArcaneMastery, "+20r (60), <u>Bolt</u> buffed: +1d (3), +4p (6), 50%s (0.55)."},
        {UpgradeType.ArcaneSpike, "+2d (5), +11md (16), 50%s (0.275), <u>Plasma</u>"},
        {
            UpgradeType.Archmage,
            "<u>Bolt</u> buffed: +2d (7), +6md (24), +4p (10), 50%s (0.1375). Gains Dragon's Breath and Shimmer attacks."
        },

        {
            UpgradeType.Fireball,
            "Gains <u>Fireball</u> attack (1d, 3.0s, <i>Fire</i>) that creates an explosion (1d, 15p, <i>Explosion</i>) on damage."
        },
        {
            UpgradeType.WallOfFire,
            "Ever 5.5s creates <u>Wall of Fire</u> effect (1d, 15p (20p w/ 021), 20r, 0.1s, <i>Fire</i>, 4.5s lifetime)."
        },
        {
            "Dragon's Breath",
            "Gains <u>Flame</u> attack (1d, 1cd (2), 4p (6p w/ 031), 0.1s, 50r, <i>Fire</i>) that applies <u>Burn</u> status (1d/1.5s, <i>Fire</i>, 3s duration). " +
            "Wall of Fire now happens every 4.5s. <u>Fireball</u> buffed: +2d (3)"
        },
        {
            UpgradeType.SummonPhoenix,
            "Ability (45s cooldown, 20s duration): Summons a <u>Phoenix</u> with <u>Flame</u> attack (5d, 10p, ∞r, 0.1s, <i>Fire</i>, Camo)."
        },
        {
            UpgradeType.WizardLordPhoenix,
            "<u>Flame</u> buffed: +5d (6), +46p (50). <u>Fireball</u> buffed: +24d (27). <u>Phoenix</u> is permanent. Ability (45s cooldown, 20s duration): Transforms into <u>Phoenix Lord</u> " +
            "with <u>Flame</u> attack (20d, 50p, ∞r, 0.1s, <i>Normal</i>, Camo) and <u>Meteor</u> attack (50d, 500p, ∞r, 1.0s, 8j, Normal, Camo)."
        },

        {UpgradeType.IntenseMagic, "<u>Bolt</u> buffed: +5p (7), faster projectile speed."},
        {UpgradeType.MonkeySense, "Camo."},
        {UpgradeType.Shimmer, "Gains Shimmer attack (0d, 200p, 2.5s, 70r, De-camo)."},
        {
            "Necromancer: Unpopped Army",
            "Stores up to 500 pops within 70r in <u>Graveyard</u> for 2 rounds (pops worth 7-13 after round 80). " +
            "Gains <u>Reanimate</u> attack (1.5s (-10% per 100 current <u>Graveyard</u>), spawns 1-4 <u>Zombloons</u>, costs 1-10 <u>Graveyard</u> pops.). " +
            "<u>Zombloon</u>: 2d (+1 per 200 current <u>Graveyard</u>), 1p (+1 per pop used), <i>Normal</i>, 10s."
        },
        {
            UpgradeType.Soulbind,
            "+40r (80). <u>Bolt</u> buffed: 25%s (0.275). <u>Shimmer</u> buffed: 50%s (1.25). <u>Graveyard</u> 3000 (3 rounds). " +
            "Gains <u>Reanimate Blimp</u> attack (3s; 20 pops for <u>ZMoab</u> (40d (+1 per 300 current <u>Graveyard</u>), 20p, <i>Normal</i>, 20s), " +
            "or 50 pops for <u>ZBfb</u> (100d, 50p, <i>Normal</i>, 13.3s.) if Graveyard > 2000). ALL zombies have +1d and +50% lifetime."
        },
    };
}