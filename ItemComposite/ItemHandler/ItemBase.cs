using Adventure_Capitalist_Calculator.ItemComposite.Container;
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



        public double cashUpgradeModifier { get; set; }
        
        
        
        

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

        private GlobalStats globalStats;
        private double advertismentBonus { get { return globalStats.advertismentBonus; } }
        private double angelsCount { get { return globalStats.angelsCount; } }
        private double angelsPercent { get { return globalStats.angelsPercent; } }
        private double GlobalAchievmentRevenueModifier { get { return globalStats.GlobalAchievmentRevenueModifier; } }
        private double GlobalAchievmentSpeedModifier { get { return globalStats.GlobalAchievmentSpeedModifier; } }

        public ItemBase(GlobalStats inGlobalStats) 
        {
            globalStats = inGlobalStats;
            cashUpgradeModifier = 1;
        }

        public double getCurrentRevenue() 
        {
            double revenueWithoutAngels = level * 
                                          InitialRevenue * 
                                          cashUpgradeModifier * 
                                          advertismentBonus * 
                                          AchievementRevenueModifier * 
                                          GlobalAchievmentRevenueModifier *
                                          ((calculateWithNewspaper) ? newspaperRevenueModifier : 1);
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

        private bool calculateWithNewspaper = true;

        public double getRevenuePerSecondWithoutNewspaper()
        {
            double result;

            if (this is Newspaper)
                result = getCurrentRevenue() / getProductionSpeed();
            else
            {
                calculateWithNewspaper = false;
                result = getCurrentRevenue() / getProductionSpeed();
                calculateWithNewspaper = true;
            }
            return result;
        }

        public double getRevenueDeltaInRevenueBetweenNewspaperAndWithout()
        {
            return getRevenuePerSecond() - getRevenuePerSecondWithoutNewspaper();
        }

        private double getProductionSpeed() {
            return InitialTime / (AchievementSpeedModifier * 
                                  GlobalAchievmentSpeedModifier * 
                                  ((calculateWithNewspaper) ? newspaperSpeedModifier : 1));
        }

        public double getBuyCost()
        {
            return InitialCost * Math.Pow(CalcCoefficient, level) ;
        }

        public virtual double getBuyEfficiency()
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

            if (getRevenue && this is MovieStudio && Newspaper.newsPaperLevel >= 700) result *= 11;
            if (getRevenue && this is PizzaDelivery && Newspaper.newsPaperLevel >= 725) result *= 6;
            if (getRevenue && this is DonutShop && Newspaper.newsPaperLevel >= 750) result *= 6;
            if (getRevenue && this is LemonStand && Newspaper.newsPaperLevel >= 775) result *= 3;

            if (getRevenue && this is Bank && Newspaper.newsPaperLevel >= 800) result *= 11;
            if (getRevenue && this is CarWash && Newspaper.newsPaperLevel >= 825) result *= 7;
            if (getRevenue && this is PizzaDelivery && Newspaper.newsPaperLevel >= 850) result *= 7;
            if (getRevenue && this is DonutShop && Newspaper.newsPaperLevel >= 875) result *= 7;

            if (getRevenue && this is OilCompany && Newspaper.newsPaperLevel >= 900) result *= 11;
            if (getRevenue && this is ShrimpBoat && Newspaper.newsPaperLevel >= 925) result *= 7;
            if (getRevenue && this is HockeyTeam && Newspaper.newsPaperLevel >= 950) result *= 7;
            if (getRevenue && this is MovieStudio && Newspaper.newsPaperLevel >= 975) result *= 7;

            if (getRevenue && this is Newspaper && Newspaper.newsPaperLevel >= 1000) result *= 7777777;
            if (getRevenue && this is Bank && Newspaper.newsPaperLevel >= 1025) result *= 7;
            if (getRevenue && this is OilCompany && Newspaper.newsPaperLevel >= 1050) result *= 7;
            if (getRevenue && this is CarWash && Newspaper.newsPaperLevel >= 1075) result *= 8;

            if (getRevenue && this is PizzaDelivery && Newspaper.newsPaperLevel >= 1100) result *= 8;
            if (getRevenue && this is DonutShop && Newspaper.newsPaperLevel >= 1125) result *= 8;
            if (getRevenue && this is ShrimpBoat && Newspaper.newsPaperLevel >= 1150) result *= 8;
            if (getRevenue && this is HockeyTeam && Newspaper.newsPaperLevel >= 1175) result *= 8;

            if (getRevenue && this is MovieStudio && Newspaper.newsPaperLevel >= 1200) result *= 8;
            if (getRevenue && this is Bank && Newspaper.newsPaperLevel >= 1225) result *= 8;
            if (getRevenue && this is OilCompany && Newspaper.newsPaperLevel >= 1250) result *= 8;

            if (getRevenue && this is Newspaper && Newspaper.newsPaperLevel >= 1300) result *= 7777;
            if (getRevenue && this is LemonStand && Newspaper.newsPaperLevel >= 1350) result *= 9;

            if (getRevenue && this is CarWash && Newspaper.newsPaperLevel >= 1400) result *= 9;
            if (getRevenue && this is PizzaDelivery && Newspaper.newsPaperLevel >= 1450) result *= 9;

            if (getRevenue && this is DonutShop && Newspaper.newsPaperLevel >= 1500) result *= 9;
            if (getRevenue && this is ShrimpBoat && Newspaper.newsPaperLevel >= 1550) result *= 9;

            if (getRevenue && this is HockeyTeam && Newspaper.newsPaperLevel >= 1600) result *= 9;
            if (getRevenue && this is MovieStudio && Newspaper.newsPaperLevel >= 1650) result *= 9;


            return result;
        }



    }
}
