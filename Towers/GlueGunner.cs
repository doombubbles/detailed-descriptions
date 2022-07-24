using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class GlueGunnerTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.GlueGunner;

    public override string TextValue =>
        "<u>Glue</u> attack (0d, 1p, 1.0s, 46r, <i>Acid</i>) that applies <u>Glued</u> (11s duration, 50% slow, 3 layers)";
}

public class GlueGunnerUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.GlueSoak, "<u>Glued</u> status soaks through all non-Blimp layers."},
        {
            UpgradeType.CorrosiveGlue,
            "<u>Glued</u> status buffed: 1d/2s and can overwrites weaker effects. <u>Glue</u> can affect Blimps, but lasts half as long and doesn't slow."
        },
        {UpgradeType.BloonDissolver, "<u>Glued</u> status buffed: 1d/.575s, +1cd (2)"},
        {UpgradeType.BloonLiquefier, "+1p (2). <u>Glued</u> status buffed: 1d/.1s"},
        {UpgradeType.TheBloonSolver, "2j, 4p, 25%s (0.25), impact. <u>Glued</u> status buffed: +4cd/0.1s and +5md/0.1s."},

        {UpgradeType.BiggerGlobs, "+1p (2)"},
        {UpgradeType.GlueSplatter, "+4p (6), impact"},
        {UpgradeType.GlueHose, "33.33%s (0.333)"},
        {
            UpgradeType.GlueStrike,
            "Ability (30s cooldown): Applies weakening-glue (take +2d, allows <i>Sharp</i>to pop Lead) to all Bloons, (+Blimps w/ 240). Soaks 6 layers. Will refresh duration of stronger glue instead of replacing."
        },
        {
            UpgradeType.GlueStorm,
            "Ability (30s cooldown): Every 2s for the next 15s, applies weakening-glue to all valid targets with twice the duration and slowing power of standard attack. Soaks 9 layers."
        },

        {UpgradeType.StickierGlue, "<u>Glued</u> status buffed: +13s duration (24s)."},
        {UpgradeType.StrongerGlue, "<u>Glued</u> status buffed: 75% slow."},
        {UpgradeType.MOABGlue, "Can now target Blimps, but slowed for less (37.5%) and for half the duration (12s)."},
        {
            UpgradeType.RelentlessGlue,
            "<u>Glued</u> Bloons drop the glue when popped, to be picked up by the next target, lasts 5s."
        },
        {
            UpgradeType.SuperGlue,
            "+50md (50), +5p (6), <u>Glued</u> status buffed: 1d/2.3s (2.0s with 205); Bloons are slowed 100%; MOABs and DDTs are slowed 100% for the first 5s; BFBs are slowed 95% for the first 2.5s; ZOMGs are slowed 90% for the first 0.75s."
        },
    };
}