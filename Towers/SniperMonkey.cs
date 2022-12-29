using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class SniperMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.SniperMonkey;

    public override string TextValue => "<u>Bullet</u> attack (2d, 1p, 1.59s, ∞r, <i>Sharp</i>, impact)";
}

public class SniperMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.FullMetalJacket, "+2d (4), <i>Normal</i>"},
        {UpgradeType.LargeCalibre, "+3d (7)"},
        {UpgradeType.DeadlyPrecision, "+13d (20), +15cd (35)"},
        {UpgradeType.MaimMOAB, "+10d (30, 45cd), Stuns blimps (MOABs 1s, BFBs 1s, ZOMGs and DDTs 0.5s)."},
        {
            UpgradeType.CrippleMOAB,
            "+50d (80, 75cd), Stun duration buffed: MOAB 4.5s, BFB 4s, ZOMG 2s, DDT 2.5s and applies <u>Crippled</u> status (take +5d) (0.5s for BADs)."
        },

        {UpgradeType.NightVisionGoggles, "Gains Camo detection\n<u>Bullet</u> buffed: +2 Camo damage"},
        {
            UpgradeType.ShrapnelShot,
            "On-hit effect: emits <u>Shrapnel</u> (1d (2d, 4d, 6d, 12d w/ 220 through 520), 3p (4p w/ 023), 5j, <u>Sharp</u>, 45° spread centred on the direction fired)"
        },
        {UpgradeType.BouncingBullet, "4p (no longer impact), jumps to targets within 40r (50r w/ 230) until pierce runs out."},
        {
            UpgradeType.SupplyDrop,
            "<u>Shrapnel</u> buffed: +3p (5). <u>Bullet</u> buffed: <i>Normal</i>. Ability (90s cooldown): Drops a crate worth $1200."
        },
        {
            UpgradeType.EliteSniper,
            "40%s (0.636s), buffs all other Snipers 75%s and provides Elite targeting (Near exit > Ceramics > Strong). Ability (60s cooldown): Drops a crate worth $3000."
        },

        {UpgradeType.FastFiring, "70%s (1.113s)"},
        {UpgradeType.EvenFasterFiring, "70%s (0.78s)"},
        {UpgradeType.SemiAutomatic, "33.33%s (0.26s)"},
        {UpgradeType.FullAutoRifle, "1 md, 50%s (0.13s)"},
        {
            UpgradeType.EliteDefender,
            "2md (3md w/ 105, 4md w/ 205), 50%s (0.064925s), 1% faster per percent along track target is. Passive (10s cooldown): Shoots 4× faster for 7s after leaking."
        },
    };
}