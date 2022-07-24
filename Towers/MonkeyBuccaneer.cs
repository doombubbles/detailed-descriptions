using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class MonkeyBuccaneerTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.MonkeyBuccaneer;

    public override string TextValue =>
        "<u>Dart</u> attack (1d, 4p, 1.0s, 60r, <i>Sharp</i>) (Also shoots behind Boat if there are targets there).";
}

public class MonkeyBuccaneerUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.FasterShootingBuccaneer, "75%s (0.75)"},
        {UpgradeType.DoubleShotBuccaneer, "<u>Dart</u> buffed: +1j (2)"},
        {UpgradeType.Destroyer, "20%s (0.15)"},
        {
            UpgradeType.AircraftCarrier,
            "Spawns three <u>Planes</u>: <u>Forward Darts</u> (1d, 9p, 0.15s, 2j, <i>Sharp</i>), " +
            "<u>Radial-Darts</u> (1d, 9p, 1.0s, 8j, <i>Sharp</i>), <u>Moab-Missile</u> (15md, 3p, 3.0s, <i>Explosion</i>)"
        },
        {
            UpgradeType.CarrierFlagship,
            "<u>Dart</u> buffed: <i>Normal</i>. <u>Plane Darts</u> buffed: +1d (2), +3cd (5), +5p (14), <i>Normal</i>. " +
            "<u>Moab Missile</u> buffed: +15md (30), +1p (4), 50%s (1.5), <i>Normal</i>. Buffs all water towers and Aces 85%s."
        },

        {UpgradeType.GrapeShot, "Gains <u>Grapes</u> attack (1d, 1p, 1.3s, 5j (10j w/ 210), <i>Sharp</i>)"},
        {
            UpgradeType.HotShot,
            "<u>Grapes</u> buffed: <i>Fire</i>, applies a burn status (1d/1.5s, <i>Fire</i>, 3s duration)"
        },
        {
            UpgradeType.CannonShip,
            "Gains <u>Cannonball</u> attack (1d, 1.2s, impact) that creates an explosion on hit (1d, 28p, <i>Explosion</i>) and <u>Frags</u> (1d, 8j, <i>Sharp</i>, impact)"
        },
        {
            UpgradeType.MonkeyPirates,
            "<u>Cannonball</u> buffed: +1d (2), +2j (3). <u>Grapes</u> buffed: +1cd. Ability (50s cooldown): Immediately removes the strongest non-ZOMG/BAD Blimp, gaining full cash."
        },
        {
            UpgradeType.PirateLord,
            "50%s. <u>Grapes</u> buffed: +4d (5), +5cd (10). Ability (30s cooldown): now has three hooks and gains double cash; can use two hooks at once to take down a ZOMG."
        },

        {UpgradeType.LongRange, "+11r (71). +1p to most projectiles, projectile speeds increased."},
        {UpgradeType.CrowsNest, "Camo"},
        {UpgradeType.Merchantman, "$200 end of round income."},
        {
            UpgradeType.FavoredTrades,
            "50%s (0.5), +$300 end of round income ($500). Gains a buff: +10% sell price to anything in range; stackable up to 95% cap."
        },
        {
            UpgradeType.TradeEmpire,
            "+1d (2), +1cd (3), +1md (3), +$300 end of round income ($800). Gains a buff: +1d, +1cd, +1md, +$20n income to up to 20 xx3 or xx4 Buccaneers."
        },
    };
}