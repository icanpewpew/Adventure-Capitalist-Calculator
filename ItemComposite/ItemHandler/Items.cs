using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Capitalist_Calculator.ItemComposite.ItemHandler
{

    class LemonStand : ItemBase
    {
        public LemonStand()
        {
            level = 1;
            
            InitialCost = 3.738;
            CalcCoefficient = 1.07;
            InitialTime = 0.6;
            InitialRevenue = 1;
            InitialProductivity = 1.67;
        }

        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getSpeed && level >= 25) result *= 2;
            if (getSpeed && level >= 50) result *= 2;
            if (getSpeed && level >= 100) result *= 2;
            if (getSpeed && level >= 200) result *= 2;
            if (getSpeed && level >= 300) result *= 2;
            if (getSpeed && level >= 400) result *= 2;

            if (getRevenue && level >= 500) result *= 4;
            if (getRevenue && level >= 600) result *= 4;
            if (getRevenue && level >= 700) result *= 4;
            if (getRevenue && level >= 800) result *= 4;
            if (getRevenue && level >= 900) result *= 4;

            if (getRevenue && level >= 1000) result *= 5;
            if (getRevenue && level >= 1100) result *= 4;
            if (getRevenue && level >= 1200) result *= 4;
            if (getRevenue && level >= 1300) result *= 4;
            if (getRevenue && level >= 1400) result *= 4;
            if (getRevenue && level >= 1500) result *= 4;
            if (getRevenue && level >= 1600) result *= 4;
            if (getRevenue && level >= 1700) result *= 4;
            if (getRevenue && level >= 1800) result *= 4;
            if (getRevenue && level >= 1900) result *= 4;

            if (getRevenue && level >= 2000) result *= 5;

            return result;
        }
    }

    class Newspaper : ItemBase
    {
        public static double newsPaperLevel { get; set; }

        public Newspaper()
        {
            level = 1;

            InitialCost = 60;
            CalcCoefficient = 1.15;
            InitialTime = 3;
            InitialRevenue = 60;
            InitialProductivity = 20;
        }

        protected override double getAchievementModifier(bool getRevenue)
        {
            return getNewspaperModifier(getRevenue);
        }
    }

    class CarWash : ItemBase
    {
        public CarWash()
        {
            level = 1;

            InitialCost = 720;
            CalcCoefficient = 1.14;
            InitialTime = 6;
            InitialRevenue = 540;
            InitialProductivity = 90;
        }

        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getSpeed && level >= 25) result *= 2;
            if (getSpeed && level >= 50) result *= 2;
            if (getSpeed && level >= 100) result *= 2;
            if (getSpeed && level >= 200) result *= 2;
            if (getSpeed && level >= 300) result *= 2;
            if (getSpeed && level >= 400) result *= 2;

            if (getRevenue && level >= 500) result *= 2;
            if (getRevenue && level >= 600) result *= 2;
            if (getRevenue && level >= 700) result *= 2;
            if (getRevenue && level >= 800) result *= 2;
            if (getRevenue && level >= 900) result *= 2;

            if (getRevenue && level >= 1000) result *= 3;
            if (getRevenue && level >= 1100) result *= 2;
            if (getRevenue && level >= 1200) result *= 2;
            if (getRevenue && level >= 1300) result *= 2;
            if (getRevenue && level >= 1400) result *= 2;
            if (getRevenue && level >= 1500) result *= 2;
            if (getRevenue && level >= 1600) result *= 2;
            if (getRevenue && level >= 1700) result *= 2;
            if (getRevenue && level >= 1800) result *= 2;
            if (getRevenue && level >= 1900) result *= 2;

            if (getRevenue && level >= 2000) result *= 5;

            return result;
        }
    }

    class PizzaDelivery : ItemBase
    {
        public PizzaDelivery()
        {
            level = 1;

            InitialCost = 8640;
            CalcCoefficient = 1.13;
            InitialTime = 12;
            InitialRevenue = 4320;
            InitialProductivity = 360;
        }

        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getSpeed && level >= 25) result *= 2;
            if (getSpeed && level >= 50) result *= 2;
            if (getSpeed && level >= 100) result *= 2;
            if (getSpeed && level >= 200) result *= 2;
            if (getSpeed && level >= 300) result *= 2;
            if (getSpeed && level >= 400) result *= 2;

            if (getRevenue && level >= 500) result *= 2;
            if (getRevenue && level >= 600) result *= 2;
            if (getRevenue && level >= 700) result *= 2;
            if (getRevenue && level >= 800) result *= 2;
            if (getRevenue && level >= 900) result *= 2;

            if (getRevenue && level >= 1000) result *= 3;
            if (getRevenue && level >= 1100) result *= 2;
            if (getRevenue && level >= 1200) result *= 2;
            if (getRevenue && level >= 1300) result *= 2;
            if (getRevenue && level >= 1400) result *= 2;
            if (getRevenue && level >= 1500) result *= 2;
            if (getRevenue && level >= 1600) result *= 2;
            if (getRevenue && level >= 1700) result *= 2;
            if (getRevenue && level >= 1800) result *= 2;
            if (getRevenue && level >= 1900) result *= 2;

            if (getRevenue && level >= 2000) result *= 5;

            return result;
        }
    }

    class DonutShop : ItemBase
    {
        public DonutShop()
        {
            level = 1;

            InitialCost = 103680;
            CalcCoefficient = 1.12;
            InitialTime = 24;
            InitialRevenue = 51840;
            InitialProductivity = 2160;
        }

        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getSpeed && level >= 25) result *= 2;
            if (getSpeed && level >= 50) result *= 2;
            if (getSpeed && level >= 100) result *= 2;
            if (getSpeed && level >= 200) result *= 2;
            if (getSpeed && level >= 300) result *= 2;
            if (getSpeed && level >= 400) result *= 2;

            if (getRevenue && level >= 500) result *= 2;
            if (getRevenue && level >= 600) result *= 2;
            if (getRevenue && level >= 700) result *= 2;
            if (getRevenue && level >= 800) result *= 2;
            if (getRevenue && level >= 900) result *= 2;

            if (getRevenue && level >= 1000) result *= 3;
            if (getRevenue && level >= 1100) result *= 2;
            if (getRevenue && level >= 1200) result *= 2;
            if (getRevenue && level >= 1300) result *= 2;
            if (getRevenue && level >= 1400) result *= 2;
            if (getRevenue && level >= 1500) result *= 2;
            if (getRevenue && level >= 1600) result *= 2;
            if (getRevenue && level >= 1700) result *= 2;
            if (getRevenue && level >= 1800) result *= 2;
            if (getRevenue && level >= 1900) result *= 2;

            if (getRevenue && level >= 2000) result *= 5;

            return result;
        }
    }

    class ShrimpBoat : ItemBase
    {
        public ShrimpBoat()
        {
            level = 1;

            InitialCost = 1244160;
            CalcCoefficient = 1.11;
            InitialTime = 96;
            InitialRevenue = 622080;
            InitialProductivity = 6480;
        }

        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getSpeed && level >= 25) result *= 2;
            if (getSpeed && level >= 50) result *= 2;
            if (getSpeed && level >= 100) result *= 2;
            if (getSpeed && level >= 200) result *= 2;
            if (getSpeed && level >= 300) result *= 2;
            if (getSpeed && level >= 400) result *= 2;

            if (getRevenue && level >= 500) result *= 2;
            if (getRevenue && level >= 600) result *= 2;
            if (getRevenue && level >= 700) result *= 2;
            if (getRevenue && level >= 800) result *= 2;
            if (getRevenue && level >= 900) result *= 2;

            if (getRevenue && level >= 1000) result *= 3;
            if (getRevenue && level >= 1100) result *= 2;
            if (getRevenue && level >= 1200) result *= 2;
            if (getRevenue && level >= 1300) result *= 2;
            if (getRevenue && level >= 1400) result *= 2;
            if (getRevenue && level >= 1500) result *= 2;
            if (getRevenue && level >= 1600) result *= 2;
            if (getRevenue && level >= 1700) result *= 2;
            if (getRevenue && level >= 1800) result *= 2;
            if (getRevenue && level >= 1900) result *= 2;

            if (getRevenue && level >= 2000) result *= 5;

            return result;
        }
    }

    class HockeyTeam : ItemBase
    {
        public HockeyTeam()
        {
            level = 1;

            InitialCost = 14929920;
            CalcCoefficient = 1.10;
            InitialTime = 384;
            InitialRevenue = 7464960;
            InitialProductivity = 19440;
        }

        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getSpeed && level >= 25) result *= 2;
            if (getSpeed && level >= 50) result *= 2;
            if (getSpeed && level >= 100) result *= 2;
            if (getSpeed && level >= 200) result *= 2;
            if (getSpeed && level >= 300) result *= 2;
            if (getSpeed && level >= 400) result *= 2;

            if (getRevenue && level >= 500) result *= 2;
            if (getRevenue && level >= 600) result *= 2;
            if (getRevenue && level >= 700) result *= 2;
            if (getRevenue && level >= 800) result *= 2;
            if (getRevenue && level >= 900) result *= 2;

            if (getRevenue && level >= 1000) result *= 3;
            if (getRevenue && level >= 1100) result *= 2;
            if (getRevenue && level >= 1200) result *= 2;
            if (getRevenue && level >= 1300) result *= 2;
            if (getRevenue && level >= 1400) result *= 2;
            if (getRevenue && level >= 1500) result *= 2;
            if (getRevenue && level >= 1600) result *= 2;
            if (getRevenue && level >= 1700) result *= 2;
            if (getRevenue && level >= 1800) result *= 2;
            if (getRevenue && level >= 1900) result *= 2;

            if (getRevenue && level >= 2000) result *= 5;

            return result;
        }
    }

    class MovieStudio : ItemBase
    {
        public MovieStudio()
        {
            level = 1;

            InitialCost = 179159040;
            CalcCoefficient = 1.09;
            InitialTime = 1536;
            InitialRevenue = 89579520;
            InitialProductivity = 58320;
        }

        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getSpeed && level >= 25) result *= 2;
            if (getSpeed && level >= 50) result *= 2;
            if (getSpeed && level >= 100) result *= 2;
            if (getSpeed && level >= 200) result *= 2;
            if (getSpeed && level >= 300) result *= 2;
            if (getSpeed && level >= 400) result *= 2;

            if (getRevenue && level >= 500) result *= 2;
            if (getRevenue && level >= 600) result *= 2;
            if (getRevenue && level >= 700) result *= 2;
            if (getRevenue && level >= 800) result *= 2;
            if (getRevenue && level >= 900) result *= 2;

            if (getRevenue && level >= 1000) result *= 3;
            if (getRevenue && level >= 1100) result *= 2;
            if (getRevenue && level >= 1200) result *= 2;
            if (getRevenue && level >= 1300) result *= 2;
            if (getRevenue && level >= 1400) result *= 2;
            if (getRevenue && level >= 1500) result *= 2;
            if (getRevenue && level >= 1600) result *= 2;
            if (getRevenue && level >= 1700) result *= 2;
            if (getRevenue && level >= 1800) result *= 2;
            if (getRevenue && level >= 1900) result *= 2;

            if (getRevenue && level >= 2000) result *= 5;

            return result;
        }
    }

    class Bank : ItemBase
    {
        public Bank()
        {
            level = 1;

            InitialCost = 2149908480;
            CalcCoefficient = 1.08;
            InitialTime = 6144;
            InitialRevenue = 1074954240;
            InitialProductivity = 174960;
        }

        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getSpeed && level >= 25) result *= 2;
            if (getSpeed && level >= 50) result *= 2;
            if (getSpeed && level >= 100) result *= 2;
            if (getSpeed && level >= 200) result *= 2;
            if (getSpeed && level >= 300) result *= 2;
            if (getSpeed && level >= 400) result *= 2;

            if (getRevenue && level >= 500) result *= 2;
            if (getRevenue && level >= 600) result *= 2;
            if (getRevenue && level >= 700) result *= 2;
            if (getRevenue && level >= 800) result *= 2;
            if (getRevenue && level >= 900) result *= 2;

            if (getRevenue && level >= 1000) result *= 3;
            if (getRevenue && level >= 1100) result *= 2;
            if (getRevenue && level >= 1200) result *= 2;
            if (getRevenue && level >= 1300) result *= 2;
            if (getRevenue && level >= 1400) result *= 2;
            if (getRevenue && level >= 1500) result *= 2;
            if (getRevenue && level >= 1600) result *= 2;
            if (getRevenue && level >= 1700) result *= 2;
            if (getRevenue && level >= 1800) result *= 2;
            if (getRevenue && level >= 1900) result *= 2;

            if (getRevenue && level >= 2000) result *= 5;

            return result;
        }
    }

    class OilCompany : ItemBase
    {
        public OilCompany()
        {
            level = 1;

            InitialCost = 25798901760;
            CalcCoefficient = 1.07;
            InitialTime = 36864;
            InitialRevenue = 29668737024;
            InitialProductivity = 804816;
        }

        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getSpeed && level >= 25) result *= 2;
            if (getSpeed && level >= 50) result *= 2;
            if (getSpeed && level >= 100) result *= 2;
            if (getSpeed && level >= 200) result *= 2;
            if (getSpeed && level >= 300) result *= 2;
            if (getSpeed && level >= 400) result *= 2;

            if (getRevenue && level >= 500) result *= 2;
            if (getRevenue && level >= 600) result *= 2;
            if (getRevenue && level >= 700) result *= 2;
            if (getRevenue && level >= 800) result *= 2;
            if (getRevenue && level >= 900) result *= 2;

            if (getRevenue && level >= 1000) result *= 3;
            if (getRevenue && level >= 1100) result *= 2;
            if (getRevenue && level >= 1200) result *= 2;
            if (getRevenue && level >= 1300) result *= 2;
            if (getRevenue && level >= 1400) result *= 2;
            if (getRevenue && level >= 1500) result *= 2;
            if (getRevenue && level >= 1600) result *= 2;
            if (getRevenue && level >= 1700) result *= 2;
            if (getRevenue && level >= 1800) result *= 2;
            if (getRevenue && level >= 1900) result *= 2;

            if (getRevenue && level >= 2000) result *= 5;

            return result;
        }
    }


}
