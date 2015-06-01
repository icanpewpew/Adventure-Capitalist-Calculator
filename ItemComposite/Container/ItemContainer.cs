using Adventure_Capitalist_Calculator.ItemComposite.ItemHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Capitalist_Calculator.ItemComposite.Container
{

    interface GlobalStats
    {
        double angelsCount { get; set; }
        double advertismentBonus { get; set; }
        double angelsPercent { get; set; }
        double GlobalAchievmentRevenueModifier { get; set; }
        double GlobalAchievmentSpeedModifier { get; set; }
    }

    abstract class ItemContainer : GlobalStats
    {

        public double angelsCount { get; set; }
        public double advertismentBonus { get; set; }
        public double angelsPercent { get; set; }
        public double GlobalAchievmentRevenueModifier { get; set; }
        public double GlobalAchievmentSpeedModifier { get; set; }

        protected abstract void setGlobalAchievmentModifier();
        protected abstract void setCashUpgradeLevel(double inCashUpgradeLevel);

        public StringBuilder levelUpPath = new StringBuilder();

        public double totalMoneySpend { get; set; }

        private double _cashUpgradesLevel;
        public double cashUpgradesLevel
        {
            get { return _cashUpgradesLevel; }
            set
            {
                setCashUpgradeLevel(value);
                _cashUpgradesLevel = value;
            }
        }

        public ItemContainer()
        {
            angelsCount = 0;
            advertismentBonus = 2;
            cashUpgradesLevel = 1;
            totalMoneySpend = 0;
            GlobalAchievmentRevenueModifier = 1;
            GlobalAchievmentSpeedModifier = 1;
        }

        public void setItemLevel(ItemBase inItem, double inLevel)
        {
            totalBuyEfficiencyHistory.Add(getTotalBuyEfficiency());
            inItem.level = inLevel;
            setGlobalAchievmentModifier();

            if (this is EarthItemContainer)
            {
                double newsPaperAdditionalRevenuePerSecond = allitems.Sum(i => i.getRevenueDeltaInRevenueBetweenNewspaperAndWithout());
                ((EarthItemContainer)(this)).newspaper.newspaperAdditionalRevenuePerSecond = newsPaperAdditionalRevenuePerSecond;
            }

            totalMoneySpend += inItem.getBuyCost();
            levelUpPath.Append(inLevel + "\t" + inItem.GetType().Name + "\t" + getTotalRevenuePerSecond() + "\t" + totalMoneySpend + "\t" + getTotalBuyEfficiency() + "\r\n");
        }

        public List<ItemBase> allitems = new List<ItemBase>();
        public List<double> totalBuyEfficiencyHistory = new List<double>();

        public ItemBase getItemWithLowestEfficency()
        {
            return allitems.First(i => i.getBuyEfficiency().Equals(allitems.Min(o => o.getBuyEfficiency())));
        }

        public ItemBase getItemWithCheapestBuyCost()
        {
            return allitems.First(i => i.getBuyCost().Equals(allitems.Min(o => o.getBuyCost())));
        }

        public ItemBase getItemWithLowestLevel()
        {
            return allitems.Where(i => i.level.Equals(allitems.Min(o => o.level))).OrderBy(i => i.getBuyCost()).First();
        }

        public double getTotalRevenuePerSecond()
        {
            return allitems.Sum(o => o.getRevenuePerSecond());
        }

        public double getTotalBuyEfficiency()
        {
            return allitems.Sum(o => o.getBuyEfficiency());
        }
    }
}
