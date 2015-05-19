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

        public double getGlobalAchievmentIncrease()
        {
            //wenn alle 
            return 1;
        }

    }
}
