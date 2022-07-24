﻿using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class SpikeFactoryTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.SpikeFactory;

    public override string TextValue =>
        "<u>Spikes</u> attack (1d, 5p, 1.75s, 34r, targets track, 50s or end of round lifespan).";
}

public class SpikeFactoryUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.BiggerStacks, "+5p (10)"},
        {UpgradeType.WhiteHotSpikes, "Spikes become <i>Normal</i>."},
        {UpgradeType.SpikedBalls, "+1d (2), +3cd (5), +1fd, +4p (14)."},
        {
            UpgradeType.SpikedMines,
            "+3cd (8). Creates an <u>Explosion</u> (10d, 2cd (12), 1fd, 40p, <i>Explosion</i>) that applies <u>Burn</u> status (1d/2s, <i>Fire</i>, 6s duration) when spikes expire."
        },
        {
            UpgradeType.SuperMines,
            "Speed becomes 4.4s. <u>Explosion</u> buffed: +990d (1000), +20p (60), <i>Normal</i>. " +
            "Each Spike of each mine makes a smaller <u>Explosion</u> (10d, 30p, 20r, <i>Explosion</i>)."
        },

        {UpgradeType.FasterProduction, "80%s (1.4)"},
        {UpgradeType.EvenFasterProduction, "70%s (0.98)"},
        {UpgradeType.MOABSHREDR, "+4md (5)"},
        {
            UpgradeType.SpikeStorm,
            "Ability (40s cooldown): For 1s, places <u>Spikes</u> (1d, 4md (5), 5p, 10s (15s w/ 041) lifetime) every .005s randomly on track."
        },
        {
            UpgradeType.CarpetOfSpikes,
            "Default and Ability spikes gain +2d (3, 7md). Passive (15s cooldown): Same as activated ability."
        },

        {UpgradeType.LongReach, "+8r (42), 100s lifespan."},
        {
            UpgradeType.DirectedSpikes,
            "Gains extra targeting options: close, far, and smart (earliest point Bloons haven't reached yet). Passive (1 round cooldown): 4× faster (0.55s) for 2.5s."
        },
        {UpgradeType.LongLifeSpikes, "140s or end of 2 rounds lifespan."},
        {UpgradeType.DeadlySpikes, "+1d (2), 3 round lifespan."},
        {UpgradeType.PermaSpike, "+8d (10), +45p (50) (90p w/ 105), 6.0s, 300s lifespan."},
    };
}