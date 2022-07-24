using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class MortarMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.MortarMonkey;

    public override string TextValue =>
        "<u>Shell</u> attack (2.0s, ∞r) creates <u>Explosion</u> effect (1d, 40p, <i>Explosion</i> type, ~34 blast radius).";
}

public class MortarMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.BiggerBlast, "+5p (45)"},
        {UpgradeType.BloonBuster, "+1d (2)"},
        {
            UpgradeType.Shockwave,
            "<u>Shell</u> also creates: <u>Shockwave</u> (45p, <i>Explosion</i>) that stuns in small radius for 0.5s, then deals 1d to anything in a larger radius that was not stunned."
        },
        {UpgradeType.TheBigOne, "+40p (85), <i>Normal</i>. <u>Explosion</u> buffed: +4d (7)."},
        {
            UpgradeType.TheBiggestOne,
            "+115p (200). <u>Explosion</u> buffed: +20d (25), +20cd (40), +20md (40), ~80 blast radius. <u>Shockwave</u> buffed: +20cd (11) outside stun, ~120 blast radius."
        },

        {UpgradeType.MortarFasterReload, "75%s (1.5)"},
        {UpgradeType.MortarRapidReload, "72%s (1.08)"},
        {UpgradeType.HeavyShells, "+3cd (4), +1md (2), +1fd, +1 lead damage, +2 stunned damage, <i>Normal</i>."},
        {
            UpgradeType.ArtilleryBattery,
            "25%s (0.27). Ability (60s cooldown): 4x attack rate and +15% blast radius for 8s."
        },
        {
            UpgradeType.PopAndAwe,
            "+8 stunned damage (+10), +9cd (12), +3ld (4), +3fd (4), +3md (4). Ability (60s cooldown): Every second for the next 8 seconds, hits everything on screen for 20d and a 1s stun."
        },

        {UpgradeType.IncreasedAccuracy, "Less variance in shell target."},
        {
            UpgradeType.BurnyStuff,
            "On-damage effect: apply <u>Burn</u> status (1d/1.25s (2d, 5d, 25d for 302,402,502), <i>Fire</i>, 3.75s duration)."
        },
        {UpgradeType.SignalFlare, "Camo. Creates AoE De-camo (50r, 80p)"},
        {UpgradeType.ShatteringShells, "On-hit effect: De-regrow, De-fortify, De-camo, but still not DDTs. "},
        {
            UpgradeType.Blooncineration,
            "<i>Normal</i>, <u>Burn</u> status buffed: 5d/.75s, 100md/1s. De-camo and De-fortify now affect DDTs. " +
            "<u>Shell</u> gains a <u>Firewall</u> effect (1d, 20p, 0.1s, <i>Normal</i>, Camo)."
        },
    };
}