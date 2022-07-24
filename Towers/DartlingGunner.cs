using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class DartlingGunnerTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.DartlingGunner;

    public override string TextValue => "<u>Dart</u> attack (1d, 1p, .2s, ∞r, <i>Sharp</i>, 23° spread)";
}

public class DartlingGunnerUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.FocusedFiring, "<u>Dart</u> buffed: -14° spread (9°)"},
        {
            UpgradeType.LaserShock,
            "On-hit effect: <u>Laser Shock</u> (1d/1s, takes +1d from other Laser Shock Dartling Guns)."
        },
        {
            UpgradeType.LaserCannon,
            "<u>Dart</u> attack replaced with <u>Laser</u> (2d, 6p (9p w/ 302), .2s, ∞r, <i>Energy</i>). <u>Laser Shock</u> now lasts 2s."
        },
        {
            UpgradeType.PlasmaAccelerator,
            "<u>Laser</u> replaced with <u>Beam</u> (1d, 50p (75 w/ 402), .2s, ∞r, <i>Plasma</i>) " +
            "that at the tip does (2d +10md, 50p, .25s, 4r). <u>Laser Shock</u> now lasts 5s."
        },
        {
            UpgradeType.RayOfDoom,
            "No tip effect, but <u>Beam</u> buffed: 25d (+55d to first hit), +950p (1000). <u>Laser Shock</u> buffed: 15d/.1s, 5s duration"
        },

        {UpgradeType.AdvancedTargeting, "Camo."},
        {UpgradeType.FasterBarrelSpin, "0.66%s (.132)"},
        {
            UpgradeType.HydraRocketPods,
            "<u>Dart</u> attack replaced with <u>Rocket</u> (0d, 6p (2 used up per Bloon), .132s, ∞r) that create <u>Blasts</u> on each hit (1d, 6p, 8r, <i>Normal</i>)."
        },
        {
            UpgradeType.RocketStorm,
            "<u>Rockets</u> and <u>Blasts</u> buffed: +2p. Ability (40s): Produces 15 waves of 10 <u>Missiles</u> (5d, 8p, ∞r, <i>Normal</i>, 120°) that briefly stun Bloons."
        },
        {
            UpgradeType.MAD,
            "<u>Rockets</u> now have (3d, 550md, 12p, .4s). Ability <u>Missiles</u> are larger and have +8p (16)."
        },

        {UpgradeType.FasterSwivel, "2x faster turn speed."},
        {UpgradeType.PowerfulDarts, "<u>Dart</u> attack buffed: +2p (3), <i>Shatter</i>, and increased projectile speed. All projectiles are slightly larger."},
        {
            UpgradeType.Buckshot,
            "<u>Dart</u> attack replaced with <u>Buckshot</u> (4d, 4p, 1.5s (1s w/ 023), 6j, 130r) that knocks back non-MOAB Bloons a small amount."
        },
        {
            UpgradeType.BloonAreaDenialSystem,
            "<u>Buckshot</u> attack buffed: 25%s (0.45s) (0.3s w/ 024). Gains 'Independent Targeting' option for barrels to shoot First, Last, Close Strong."
        },
        {
            UpgradeType.BloonExclusionZone,
            "<u>Buckshot</u> attack buffed: 66%s (0.3s) (0.2s w/ 025), +6j (12), +4d (8). Top two barrels completely ignore Line of Sight."
        },
    };
}