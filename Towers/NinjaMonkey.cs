using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class NinjaMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.NinjaMonkey;

    public override string TextValue => "<u>Shuriken</u> attack (1d, 2p, 40r, 0.7s, <i>Sharp</i>, Camo).";
}

public class NinjaMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.NinjaDiscipline, "+7r (47), 62%s (0.433)"},
        {UpgradeType.SharpShurikens, "<u>Shuriken</u> buffed: +2p (4)."},
        {UpgradeType.DoubleShot, "<u>Shuriken</u> buffed: +1j (2)."},
        {UpgradeType.Bloonjitsu, "<u>Shuriken</u> buffed: +3j (5)."},
        {UpgradeType.GrandmasterNinja, "+10r (57). <u>Shuriken</u> buffed: +1d (2), 0.217s, +3j (8)."},

        {
            UpgradeType.Distraction,
            "<u>Shuriken</u> gains on-damage effect: Bloons have a 15% chance to be sent back 10-300 units."
        },
        {UpgradeType.CounterEspionage, "All attacks gain De-camo on-damage effect."},
        {
            UpgradeType.ShinobiTactics,
            "92%s and +8%p (multiplicative) to all Ninjas in range, stacking up to 20 times. "
        },
        {
            UpgradeType.BloonSabotage,
            "Ability (60s cooldown, 15s duration): All Bloons and Blimps move at half speed, including new spawns, but not children of Blimps."
        },
        {
            UpgradeType.GrandSaboteur,
            "Ability (60s cooldown, 30s duration): All Bloons and blimps move at half speed, including new spawns, but not children of blimps; deals 25%d to new Blimps entering the map. Shinobis have +1md, +5r."
        },

        {UpgradeType.SeekingShuriken, "<u>Shurikens</u> can seek targets."},
        {UpgradeType.Caltrops, "Every 4.4s, place a <u>Caltrop</u>: 1d, 6p, <i>Sharp</i>."},
        {
            UpgradeType.FlashBomb,
            "Every 4th Shuriken is replaced by <u>Flash-Bomb</u> attack (1d, 60p, <i>Normal</i>, 1s stun to Bloons)."
        },
        {
            UpgradeType.StickyBomb,
            "Gains <u>Sticky Bomb</u> attack (5.0s, 60r) which applies <u>Bombed</u> to strongest Blimp, dealing 500d and (100d, 10p, 40r) AOE on expiration."
        },
        {
            UpgradeType.MasterBomber,
            "<u>Flash Bomb</u> buffed: +9d (10), stun can now affect Moabs for 0.25s. <u>Sticky Bomb</u> buffed: ∞r, 40%s (2.0), also stuns for 1s. " +
            "<u>Bombed</u> status buffed: 1000d, 300d AOE"
        },
    };
}