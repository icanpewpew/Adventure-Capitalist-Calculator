using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Capitalist_Calculator.counter
{
    abstract class counter
    {

        public double level { get; set; }

        public static double angelsCount { get; set; }
        public static double angelsPercent { get; set; }
        public double upgradeMultiplier { get; set; }
        public bool globalAchievmentIncrease { get; set; }

        protected double CalcCoefficient { get; set; }
        protected double InitialRevenue { get; set; }
        protected double InitialTime { get; set; }
        protected double InitialCost { get; set; }
        protected double InitialProductivity { get; set; }

        public double getUnitCost()
        {
            return InitialCost * Math.Pow(CalcCoefficient, level);
        }

        public double getProductionSpeed()
        {
            return InitialTime / (Math.Pow(2, getSpeedUpgrades())) / getGlobalAchievmentIncrease();
        }

        public double getMoneyGeneratedByUnis()
        {
            return level * upgradeMultiplier * 0;
        }

        public double getSpeedUpgrades()
        {
            if (level < 25) return 0;
            if (level < 50) return 1;
            if (level < 100) return 2;
            if (level < 200) return 3;
            if (level < 300) return 4;
            if (level < 400) return 5;
            return 6;
        }

        public double getCurrentRevenue()
        {
            double revenueWithoutAngels = level * InitialRevenue * 54;  // * 3 * 3 * 3 * 2;     $upgradeLocal * $upgradeLocal * $upgradeGlobal * addbonus
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

        public double getProductionSpeed()
        {

            return 1;
        }


        /* calc effiency
         * (effiency)                    = (cost per unit) / ($ increase pro minute) 
         * ($ increase pro minute)       = 60 / ((production speed) * (delta $ increase with level))
         * (production speed)            = 
         * (delta $ increase with level) = (next level Revenue) - (current level Revenue)
         * (current level Revenue)       = level * InitialRevenue * $upgradeLocal * $upgradeGlobal * addbonus * (angels * (angel% / 100))
         *                                   210   60                     6                6            1           9218      2
         *                 
         * newspaper
         * * level 1 = 11.121,60    = InitialRevenue + (InitialRevenue * 0,01 * angel% * angels) = 
         * * level 2 = 22.243.20    = level * InitialRevenue +  (level * InitialRevenue * 0.01 * angel% * angels) = (level * InitialRevenue) 
         * * level 3 = 33.364,80      cost: 91,25
         * * level 4 = 44.486,40      cost:104,94
         * * level 5 = 55.608,00      cost:120,68
         * * level 25 = 834.120,00    cost:40.102,63 upgrade x3 = level * InitialRevenue + (InitialRevenue * 0,01 * angel% * angels)
         * * level 114 = 3.758m       cost:79.406m   upgrade x3
         * 100%  = 453.600
         * 3%    = 13.608
         * 9075% = 39.204.000
         * soll = 93.640.xxx
         * 
         * */
        public double getGlobalAchievmentIncrease()
        {
            //wenn alle 
            return 1;
        }

    }
}
