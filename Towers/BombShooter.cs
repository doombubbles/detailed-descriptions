using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class BombShooterTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.BombShooter;

    public override string TextValue =>
        "<u>Bomb</u> attack (1.5s, 40r), creates on-hit <u>Explosion</u> (1d, 14p, <i>Explosion</i>)";
}

public class BombShooterUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.BiggerBombs, "+6p (20)"},
        {UpgradeType.HeavyBombs, "+1d (2), +10p (30)"},
        {UpgradeType.ReallyBigBombs, "+1d (3), +20p (48)"},
        {UpgradeType.BloonImpact, "+3r (43). Applies stun status for 1s (cannot affect Blimps)."},
        {UpgradeType.BloonCrush, "+9d (12), <i>Normal</i>\nStun buffed: 2s duration, can affect Blimps"},

        {UpgradeType.FasterReload, "75%s (1.125)"},
        {UpgradeType.MissileLauncher, "80%s (0.9), +4r (44), faster projectile speed"},
        {UpgradeType.MOABMauler, "+1cd (2), +18md (19), +5r (49)"},
        {
            UpgradeType.MOABAssassin,
            "+12md (31), +3cd (5), +5r (54). Ability (30s cooldown): Targets the strongest blimp: removes its top layer (up to 750d), and creates a (3d, 100p) <i>Explosion</i>."
        },
        {
            UpgradeType.MOABEliminator,
            "99md (100), <i>Normal</i>. Ability (10s cooldown): Targets the strongest blimp: removes its top layer (up to 4500d), and creates a (3d, 100p) <i>Explosion</i>."
        },

        {UpgradeType.ExtraRange, "+7r (47)"},
        {
            UpgradeType.FragBombs,
            "+2r (49), <i>Normal</i>, On-hit: <u>Frags</u> (1d (2d w/ 302, 12 w/ 502), 1p (2p w/ 202, 3p w/ 502), 8j, <i>Sharp</i>)"
        },
        {UpgradeType.ClusterBombs, "<u>Frags</u> replaced by <u>Clusters</u> (1d, 10p, 8j, <i>Explosion</i>)"},
        {
            UpgradeType.RecursiveCluster,
            "Every other shot does a <u>Supercluster</u>, which also makes a <u>Subcluster</u> (1d, 60p (120p w/ 104), <i>Explosion</i>)."
        },
        {
            UpgradeType.BombBlitz,
            "+4d (5). Every shot does a <u>Super Cluster</u>. Passive (40s cooldown): When something leaks, destroys all Bloons (including camo) and MOABs, and deals 2000 damage to all other Blimps."
        },
    };
}