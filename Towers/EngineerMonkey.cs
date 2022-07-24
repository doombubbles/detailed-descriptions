using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class EngineerMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.EngineerMonkey;

    public override string TextValue => "<u>Nail</u> attack (1d, 3p, 0.7s, 40r, <i>Sharp</i>).";
}

public class EngineerMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {
            UpgradeType.SentryGun,
            "Every 10s, place a <u>Sentry</u> that lasts 25s and has <u>Sentry Nail</u> attack (1d, 2p (3p w/ 101), 0.95s, 45r (49r w/ 110), <i>Sharp</i> (<i>Shatter</i> w/ 101))."
        },
        {UpgradeType.FasterEngineering, "Sentries built every 6s."},
        {UpgradeType.Sprockets, "<u>Nail</u> and <u>Sentry Nail</u> buffed: 60%s (0.42 and 0.57)."},
        {
            UpgradeType.SentryExpert,
            "<u>Crushing Sentry</u> has <u>Spiked-ball</u> attack (2d, 4cd, 22p, 50r, 1.1s, <i>Shatter</i>). " +
            "<u>Boom Sentry</u> has a <u>Bomb</u> attack (4d, 30p, 50r, 0.9s, 18 blast radius, <i>Explosion</i>). " +
            "<u>Cold Sentry</u> has a <u>Ice-ball</u> attack (1d, 25p, 50r, 1.5s, <i>Cold</i>) that applies Frozen/Permafrost status for 1.5s. " +
            "<u>Energy Sentry</u> has a <u>Laser</u> attack (2d, 2md, 8p, 50r, 0.57s, <i>Energy</i>)."
        },
        {
            UpgradeType.SentryParagon,
            "Places <u>Paragon Sentries</u> with <u>Plasma</u> attack (2d, 5p, 50r, 0.06s, <i>Plasma</i>) that self-destruct for (100d, 50p, <i>Plasma</i>)."
        },

        {UpgradeType.LargerServiceArea, "+20r (60)"},
        {UpgradeType.Deconstruction, "All attacks buffed: +1md, +1fd."},
        {
            UpgradeType.CleansingFoam,
            "Every 2s (1.2s w/ 230), places <u>Foam</u> (0d, 1 ld, 10p (15p w/ 230), <i>Normal</i>, 8.5s lifetime, De-camo, De-grow)."
        },
        {
            UpgradeType.Overclock,
            "<u>Nail</u> buffed: +12p (15). Ability (45s cooldown): Chosen tower attacks 1.667× faster for the next (105 - 15 tier)s. " +
            "Heroes have 'tier' (level - 1)/4. Overclocked farms give more income; Villages have +25%r."
        },
        {
            UpgradeType.Ultraboost,
            "<u>Nail</u> buffed: +15p (30). Ability (35s cooldown): When Overclock is applied, the tower gains an additional permanent 4% reload (2.5%r for Villages) buff, which stacks additively up to 10 times."
        },

        {UpgradeType.OversizeNails, "<u>Nail</u> buffed: +5p (8), <i>Shatter</i>. Sentry pierce +25%."},
        {
            UpgradeType.Pin,
            "<u>Nail</u> buffed: Applies <u>Pinned</u> status (0.95s duration, 100% slow, Ceramic and higher are immune). 302 Sentries can Pin."
        },
        {UpgradeType.DoubleGun, "50%s (0.35)."},
        {
            UpgradeType.BloonTrap,
            "Places <u>Traps</u> (500p, +1 cash modifier, 100r collection for extra money). Places new <u>Traps</u> 2.9s after collection of previous, 12s (9s with 204) cooldown."
        },
        {UpgradeType.XXXLTrap, "<u>Trap</u> buffed: 10000p, can trap blimps below BAD, and cools-down at 1/6th rate."},
    };
}