using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Capitalist_Calculator.counter
{
    abstract class counter
    {

        public double currentLevel { get; set; }

        public double upgradeMultiplier { get; set; }

        public bool globalAchievmentIncrease { get; set; }

        protected double CONST_UnitCost { get; set; }

        protected double CONST_Profit { get; set; }

        protected double CONST_Speed { get; set; }

        protected double CONST_BaseCost { get; set; }

        public double getUnitCost()
        {
            return CONST_BaseCost * Math.Pow(CONST_UnitCost, (currentLevel));
        }

        public double getProductionSpeed()
        {
            return CONST_Speed / (Math.Pow(2, getSpeedUpgrades())) / getGlobalAchievmentIncrease();
        }

        public double getMoneyGeneratedByUnis()
        {
            return currentLevel * upgradeMultiplier * 0;
        }

        public double getSpeedUpgrades()
        {
            if (currentLevel < 25) return 0;
            if (currentLevel < 50) return 1;
            if (currentLevel < 100) return 2;
            if (currentLevel < 200) return 3;
            if (currentLevel < 300) return 4;
            if (currentLevel < 399) return 5;
            return 6;
        }

        public double getGlobalAchievmentIncrease()
        {
            //wenn alle 
            return 1;
        }

    }
}
