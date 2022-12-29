using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class MonkeyAceTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.MonkeyAce;

    public override string TextValue =>
        "<u>Radial Darts</u> attack (1d, 5p, 8j, 1.68s, <i>Sharp</i>, passive). Flies on a circular path with radius 80, or a figure 8 or figure infinite with radii 40.";
}

public class MonkeyAceUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.RapidFire, "75%s (1.26)"},
        {UpgradeType.LotsMoreDarts, "<u>Radial Darts</u> buffed: +4j (12)"},
        {
            UpgradeType.FighterPlane,
            "Flies 20% faster, gains <u>Moab Missile</u> attack (18md, 4p (6p w/ 310), 4.0s, 2j, <i>Explosion</i>, homing, Blimps only)"
        },
        {
            "Operation: Dart Storm",
            "<u>Radial Darts</u> buffed: 50%s (0.63), +4j (16). <u>Moab Missile</u> buffed: 50%s (2.0), +1p (4) (6 w/ 410), +6md (24). All crosspath attacks twice as fast."
        },
        {
            UpgradeType.SkyShredder,
            "<u>Radial Dart</u> buffed: +2d (3), +2cd (5), +3p (8), 50%s (0.315), +16j (32), <i>Normal</i>. <u>Moab Missile</u> buffed: 150md, +1p (5) (7 w/ 510), <i>Normal</i>."
        },

        {UpgradeType.ExplodingPineapple, "Gains <u>Pineapple</u> attack (1d, 20p (32p w/ 011), 2s, <i>Explosion</i>)"},
        {UpgradeType.SpyPlane, "Camo detection, +1d to Camos"},
        {
            UpgradeType.BomberAce,
            "<u>Pineapple</u> replaced by <u>Bombing Run</u> (3d, 20p (32p w/ 031), 1.7s, 4j, <i>Explosion</i>) that's dropped on path"
        },
        {
            UpgradeType.GroundZero,
            "<u>Bombing Run</u> buffed: +7d (10), +20p (40). Ability (45s cooldown): 700d bomb with 1000p."
        },
        {
            UpgradeType.TsarBomba,
            "<u>Bombing Run</u> buffed: normal type. Ability (35s cooldown): 3000d bomb with 5000p, with an 8.2s stun to anything that survives."
        },

        {UpgradeType.SharperDarts, "<u>Radial Darts</u> buffed: +3p (8)"},
        {
            UpgradeType.CenteredPath,
            "Gains 'Centred Path' targeting (fly on a circular path in the center of the screen with radius 90)."
        },
        {UpgradeType.NevaMissTargeting, "<u>Radial Darts</u> buffed: faster projectile speed and homing."},
        {
            UpgradeType.Spectre,
            "<u>Radial Darts</u> replaced by <u>Barrage</u> (0.06s, ∞r) which alternately fires <u>Darts</u> (3d, +2cd (4), 15p, <i>Sharp</i>) and <u>Bombs</u> (2d, +4cd (6), 30p (45p w/ 014), <i>Explosion</i>). "
        },
        {
            UpgradeType.FlyingFortress,
            "<u>Barrage</u> buffed: +2d, +2j, +10md, 66.66%s (0.04), <i>Normal</i>. The 3 projectiles have separate targeting (first, last, and close)."
        },
    };
}