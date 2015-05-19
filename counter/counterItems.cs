using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Capitalist_Calculator.counter
{

    class LemonStand : counter
    {

        public LemonStand()
        {
            upgradeMultiplier = 1;
            currentLevel = 1;

            CONST_Profit = 1;
            CONST_Speed = 0.5;
            CONST_BaseCost = 4;
            CONST_UnitCost = 1.07;
        }

        new public double getUnitCost()
        {
            return CONST_BaseCost * Math.Pow(CONST_UnitCost, (currentLevel - 1));
        }

        new public double getProductionSpeed()
        {
            return (Math.Pow(CONST_Speed, getSpeedUpgrades() + 1)) / getGlobalAchievmentIncrease();
        }

    }

    class Newspaper : counter
    {
        public Newspaper()
        {
            upgradeMultiplier = 1;
            currentLevel = 1;

            CONST_Profit = 60;
            CONST_Speed = 3;
            CONST_BaseCost = 60;
            CONST_UnitCost = 1.15;
        }
    }


}
