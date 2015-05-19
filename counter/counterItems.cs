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
            level = 1;
            
            InitialCost = 4;
            CalcCoefficient = 1.07;
            InitialTime = 0.5;
            InitialRevenue = 1;
            InitialProductivity = 1.67;
        }

        new public double getUnitCost()
        {
            return InitialCost * Math.Pow(CalcCoefficient, (level - 1));
        }

        new public double getProductionSpeed()
        {
            return (Math.Pow(InitialTime, getSpeedUpgrades() + 1)) / getGlobalAchievmentIncrease();
        }

    }

    class Newspaper : counter
    {
        public Newspaper()
        {
            upgradeMultiplier = 1;
            level = 1;

            InitialCost = 60;
            CalcCoefficient = 1.15;
            InitialTime = 3;
            InitialRevenue = 60;
            InitialProductivity = 20;
        }
    }


}
