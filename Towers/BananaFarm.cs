using System.Collections.Generic;
using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class BananaFarmTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.BananaFarm;

    public override string TextValue =>
        "<u>Banana</u> effect (40r, $80 income, split over 4 projectiles throughout the round, 15s lifetime).";
}

public class BananaFarmUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.IncreasedProduction, "<u>Bananas</u> buffed: +2j (6), +$40 income ($120)."},
        {UpgradeType.GreaterProduction, "<u>Bananas</u> buffed: +2j (8), +$40 income ($160)."},
        {UpgradeType.BananaPlantation, "<u>Bananas</u> buffed: +8j (16), +$160 income ($320)."},
        {UpgradeType.BananaResearchFacility, "<u>Bananas</u> become <u>Banana Crates</u>: 5j, $1500 income."},
        {
            UpgradeType.BananaCentral,
            "+$4500 income ($6000). Gains a buff: +25% income to all 4xx farms (stacks multiplicatively with x2x)."
        },

        {UpgradeType.LongLifeBananas, "<u>Bananas</u> buffed: +15s lifetime (30)."},
        {UpgradeType.ValuableBananas, "+25% income."},
        {
            UpgradeType.MonkeyBank,
            "+$150 income ($230), held in the bank instead bananas. Balance increases by 15% at end of round, up to a capacity of $7000. 031 shows glowing $ sign, 032 autocollects."
        },
        {
            UpgradeType.IMFLoan,
            "+$3000 capacity ($10000). Ability (90s cooldown): Loan $10k, to be repaid by taking 50% from any future income."
        },
        {UpgradeType.MonkeyNomics, "Ability (60s cooldown): Gain $10k."},

        {
            UpgradeType.EZCollect,
            "<u>Bananas</u> can be collected from further away (about 50% more), and salvage for 50% value."
        },
        {
            UpgradeType.BananaSalvage,
            "Expired <u>Bananas</u> give 85% their usual amount. +10% sellback rate for this farm (80%)."
        },
        {
            UpgradeType.Marketplace,
            "+12j (16), +$240 income ($320). <u>Bananas</u> are automatically collected immediately."
        },
        {
            UpgradeType.CentralMarket,
            "+$800 income ($1120). Gains a buff: +10% end of round income to all xx3+ Buccaneers, stacks additively up to 10 times (+100%), but not with Trade Empire."
        },
        {UpgradeType.MonkeyWallStreet, "$4000 and 10 lives produced each round."},
    };
}