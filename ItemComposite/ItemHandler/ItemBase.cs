using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Capitalist_Calculator.ItemComposite.ItemHandler
{
    abstract class ItemBase
    {

        private double _level;
        public double level
        {
            get { return _level; }
            set
            {
                _level = value;
                if (this is Newspaper) Newspaper.newsPaperLevel = value;
            }
        }

        public double newspaperRevenueModifier { get { return getNewspaperRevenueModifier(); } }
        public double newspaperSpeedModifier { get { return getNewspaperSpeedModifier(); } }

        public double GlobalAchievmentRevenueModifier { get; set; }
        public double GlobalAchievmentSpeedModifier { get; set; }

        public double cashUpgradeModifier { get; set; }
        public double angelsCount { get; set; }
        public double angelsPercent { get; set; }
        public double advertismentBonus { get; set; }

        protected double CalcCoefficient { get; set; }
        protected double InitialRevenue { get; set; }
        protected double InitialTime { get; set; }
        protected double InitialCost { get; set; }
        protected double InitialProductivity { get; set; }

        protected double AchievementRevenueModifier { get { return getAchievementRevenueModifier(); } }
        protected double AchievementSpeedModifier { get { return getAchievementSpeedModifier(); } }

        protected double getAchievementRevenueModifier() { return getAchievementModifier(true); }
        protected double getAchievementSpeedModifier() { return getAchievementModifier(false); }

        protected abstract double getAchievementModifier(bool getRevenue);

        public ItemBase()
        {
            GlobalAchievmentRevenueModifier = 1;
            GlobalAchievmentSpeedModifier = 1;
            advertismentBonus = 1;
            cashUpgradeModifier = 1;
        }

        public double getCurrentRevenue() 
        {
            double revenueWithoutAngels = level * InitialRevenue * cashUpgradeModifier * advertismentBonus * newspaperRevenueModifier * AchievementRevenueModifier * GlobalAchievmentRevenueModifier;
            double revenueAngel = revenueWithoutAngels * angelsCount * (angelsPercent / 100);
            return revenueWithoutAngels + revenueAngel;
        }

        public double getRevenueIncreaseWithNextLevel()
        {
            double currentRevenue = getCurrentRevenue();
            level++;
            double nextRevenue = getCurrentRevenue();
            level--;

            return nextRevenue - currentRevenue;
        }

        public double getRevenuePerSecond()
        {
            return getCurrentRevenue() / getProductionSpeed();
        }

        private double getProductionSpeed() {
            return InitialTime / (newspaperSpeedModifier * AchievementSpeedModifier * GlobalAchievmentSpeedModifier);
        }

        public double getBuyCost()
        {
            return InitialCost * Math.Pow(CalcCoefficient, level) ;
        }

        public double getBuyEfficiency()
        {
            return getBuyCost() / getRevenuePerSecond();
        }

        private double getNewspaperRevenueModifier() { return getNewspaperModifier(true); }

        private double getNewspaperSpeedModifier() { return getNewspaperModifier(false); }

        protected double getNewspaperModifier(bool getRevenue)
        {

            double result = 1;
            bool getSpeed = !getRevenue;

            //Newspaper Delivery Profit Speed Doubled gibt es nur für newspaper
            if (getSpeed && this is Newspaper && Newspaper.newsPaperLevel >= 25) result *= 2;
            if (getSpeed && this is Newspaper && Newspaper.newsPaperLevel >= 50) result *= 2;
            if (getSpeed && this is Newspaper && Newspaper.newsPaperLevel >= 100) result *= 2;
            if (getSpeed && this is Newspaper && Newspaper.newsPaperLevel >= 200) result *= 2;
            if (getSpeed && this is Newspaper && Newspaper.newsPaperLevel >= 300) result *= 2;
            if (getSpeed && this is Newspaper && Newspaper.newsPaperLevel >= 400) result *= 2;

            if (getRevenue && this is LemonStand && Newspaper.newsPaperLevel >= 125) result *= 2;
            if (getRevenue && this is CarWash && Newspaper.newsPaperLevel >= 150) result *= 2;
            if (getRevenue && this is PizzaDelivery && Newspaper.newsPaperLevel >= 175) result *= 2;

            if (getRevenue && this is DonutShop && Newspaper.newsPaperLevel >= 225) result *= 2;
            if (getRevenue && this is LemonStand && Newspaper.newsPaperLevel >= 250) result *= 3;
            if (getRevenue && this is CarWash && Newspaper.newsPaperLevel >= 275) result *= 3;

            if (getRevenue && this is PizzaDelivery && Newspaper.newsPaperLevel >= 325) result *= 3;
            if (getRevenue && this is DonutShop && Newspaper.newsPaperLevel >= 350) result *= 3;
            if (getRevenue && this is LemonStand && Newspaper.newsPaperLevel >= 375) result *= 4;

            if (getRevenue && this is CarWash && Newspaper.newsPaperLevel >= 425) result *= 4;
            if (getRevenue && this is PizzaDelivery && Newspaper.newsPaperLevel >= 450) result *= 4;
            if (getRevenue && this is DonutShop && Newspaper.newsPaperLevel >= 475) result *= 4;

            if (getRevenue && this is ShrimpBoat && Newspaper.newsPaperLevel >= 500) result *= 11;
            if (getRevenue && this is LemonStand && Newspaper.newsPaperLevel >= 525) result *= 5;
            if (getRevenue && this is CarWash && Newspaper.newsPaperLevel >= 550) result *= 5;
            if (getRevenue && this is PizzaDelivery && Newspaper.newsPaperLevel >= 575) result *= 5;

            if (getRevenue && this is HockeyTeam && Newspaper.newsPaperLevel >= 600) result *= 11;
            if (getRevenue && this is DonutShop && Newspaper.newsPaperLevel >= 625) result *= 5;
            if (getRevenue && this is LemonStand && Newspaper.newsPaperLevel >= 650) result *= 6;
            if (getRevenue && this is CarWash && Newspaper.newsPaperLevel >= 675) result *= 6;

            return result;
        }



    }
}
