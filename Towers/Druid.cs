using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class DruidTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.Druid;

    public override string TextValue => "<u>Thorn</u> attack (1d, 1p, 1.1s, 35r, 5j, <i>Sharp</i>).";
}

public class DruidUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.HardThorns, "<u>Thorn</u> buffed: +1p (2), <i>Normal</i>"},
        {UpgradeType.HeartOfThunder, "Gains <u>Lightning</u> attack (2d, 31p, 2.3s, <i>Plasma</i>)."},
        {
            UpgradeType.DruidOfTheStorm,
            "Gains <u>Tornado</u> attack (0d, 30p, 2.5s) that pushes back Bloons 100-200 units."
        },
        {
            UpgradeType.BallLightning,
            "<u>Lightning</u> buffed: +1d (3). Gains Ball Lightning attack (3d, 30p, 6.0s creation, 0.35s damaging, <i>Plasma</i>). <u>Tornado</u> +30p (60), blows back 150-250 units."
        },
        {
            UpgradeType.Superstorm, "Camo. <u>Lightning</u> buffed: +7d (10). <u>Ball Lightning</u> buffed: +7d (10). " +
                                    "Gains <u>Superstorm</u> attack (12d, 200p (MOABs use 5p, DDTs 10p, BFBs 20, ZOMGs 50p), 4.0s) that pushes back ~30-300 units and spawns <u>Ball Lightnings</u>."
        },

        {UpgradeType.ThornSwarm, "<u>Thorns</u> buffed: +3j (8)."},
        {UpgradeType.HeartOfOak, "All attacks gain on-hit effect: De-regrow."},
        {
            UpgradeType.DruidOfTheJungle,
            "Gains <u>Vine</u> attack (1.4s) that targets strongest Bloon and destroys it. Drops <u>Brambles</u>: 1d, 20p, .3s, <i>Sharp</i> (<i>Normal</i> w/ 130)"
        },
        {
            UpgradeType.JunglesBounty,
            "+10r (45).<u>Brambles</u> buffed: +20p (40). <u>Vine</u> can target 2 Bloons at once <u>Ability</u> (60s cooldown): Gains $240, plus $120 for every Banana Farm in range."
        },
        {
            UpgradeType.SpiritOfTheForest, "+$1000 end of round income. <u>Thorns</u> buffed: 20d. <u>Vine</u> buffed: 0.3s. " +
                                           "Gains <u>Brambles</u> attack (2-4d, 8-16cd (10-20), 8-16md (10-20), ∞p, 0.5s, ∞r, <i>Sharp</i>, Camo, cannot be buffed). " +
                                           "Ability buffed: +25 lives. <u>Brambles</u> buffed: +4d (5)."
        },

        {UpgradeType.DruidicReach, "+10r (45)."},
        {
            UpgradeType.HeartOfVengeance,
            "+x% speed, up to +100%, where x is 10 + lives below amount when upgrade was purchased, ignoring lives above the starting amount."
        },
        {
            UpgradeType.DruidOfWrath,
            "+y% speed (multiplicative), up to +100%, where y is half the damage dealt by this druid since it was last idle for more than 2s."
        },
        {
            UpgradeType.Poplust,
            "Gains a buff: +15% speed and pierce to other Druids in range; can stack (additively) up to 5 times."
        },
        {
            UpgradeType.AvatarOfWrath,
            "+3d (4), 50%s (0.55), +5r (50), +1d for every 3000 RBE on screen, up to +30. (205 gets <u>Lightning</u> +1d per 6000 RBE)"
        },
    };
}