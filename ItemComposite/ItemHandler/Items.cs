using Adventure_Capitalist_Calculator.ItemComposite.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Capitalist_Calculator.ItemComposite.ItemHandler
{

    class MoonShoe : ItemBase
    {
        public MoonShoe(GlobalStats inGlobalStats) 
            : base(inGlobalStats) 
        {
            level = 1;
            InitialCost = 4.762;
            CalcCoefficient = 1.05;
            InitialTime = 2;
            InitialRevenue = 1;
        }
        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getRevenue && level >= 10) result *= 3.5;
            if (getRevenue && level >= 20) result *= 3.5;
            if (getRevenue && level >= 40) result *= 3.5;
            if (getRevenue && level >= 80) result *= 3.5;
            if (getRevenue && level >= 160) result *= 3.5;
            if (getRevenue && level >= 320) result *= 3.5;
            if (getRevenue && level >= 640) result *= 3.5;
            if (getRevenue && level >= 1280) result *= 3.5;
            if (getRevenue && level >= 2560) result *= 3.5;
            if (getRevenue && level >= 5120) result *= 3.5;
            if (getRevenue && level >= 10240) result *= 3.5;

            return result;
        }
    }
    class GravityBooth : ItemBase
    {
        public GravityBooth(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
        {
            level = 1;
            InitialCost = 105;
            CalcCoefficient = 1.21;
            InitialTime = 7;
            InitialRevenue = 21;
        }
        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getRevenue && level >= 30) result *= 1.5;
            if (getRevenue && level >= 60) result *= 1.75;
            if (getRevenue && level >= 100) result *= 2;
            if (getRevenue && level >= 150) result *= 2.25;
            if (getRevenue && level >= 210) result *= 2.5;
            if (getRevenue && level >= 280) result *= 2.75;
            if (getRevenue && level >= 360) result *= 3;
            if (getRevenue && level >= 450) result *= 3.25;
            if (getRevenue && level >= 550) result *= 3.5;
            if (getRevenue && level >= 660) result *= 3.75;
            if (getRevenue && level >= 780) result *= 4;
            if (getRevenue && level >= 910) result *= 4.25;
            if (getRevenue && level >= 1050) result *= 4.5;
            if (getRevenue && level >= 1200) result *= 4.75;
            if (getRevenue && level >= 1360) result *= 5;
            if (getRevenue && level >= 1520) result *= 5.5;
            if (getRevenue && level >= 1700) result *= 5.75;
            if (getRevenue && level >= 1890) result *= 6;
            if (getRevenue && level >= 2000) result *= 6.25;
            if (getRevenue && level >= 2050) result *= 6.5;
            if (getRevenue && level >= 2100) result *= 6.75;
            if (getRevenue && level >= 2150) result *= 7;
            if (getRevenue && level >= 2200) result *= 7.25;
            if (getRevenue && level >= 2250) result *= 7.5;
            if (getRevenue && level >= 2300) result *= 7.75;
            if (getRevenue && level >= 2350) result *= 8;
            if (getRevenue && level >= 2400) result *= 8.5;

            return result;

        }
    }
    class PaydayClone : ItemBase
    {
        public PaydayClone(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
        {
            level = 1;
            InitialCost = 2929;
            CalcCoefficient = 1.07;
            InitialTime = 28;
            InitialRevenue = 2000;
        }
        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getRevenue && level >= 10) result *= 3;
            if (getRevenue && level >= 20) result *= 3;
            if (getRevenue && level >= 40) result *= 3;
            if (getRevenue && level >= 60) result *= 3;
            if (getRevenue && level >= 80) result *= 3;
            if (getRevenue && level >= 100) result *= 3;
            if (getRevenue && level >= 120) result *= 3;
            if (getRevenue && level >= 240) result *= 3;
            if (getRevenue && level >= 360) result *= 3;
            if (getRevenue && level >= 480) result *= 3;
            if (getRevenue && level >= 600) result *= 3;
            if (getRevenue && level >= 840) result *= 3;
            if (getRevenue && level >= 1080) result *= 3;
            if (getRevenue && level >= 1320) result *= 3;
            if (getRevenue && level >= 1560) result *= 3;
            if (getRevenue && level >= 1800) result *= 3;
            if (getRevenue && level >= 2160) result *= 3;
            if (getRevenue && level >= 2520) result *= 3;
            if (getRevenue && level >= 2880) result *= 3;
            if (getRevenue && level >= 3240) result *= 3;
            if (getRevenue && level >= 3600) result *= 3;
            if (getRevenue && level >= 4000) result *= 3;
            if (getRevenue && level >= 4400) result *= 3;
            if (getRevenue && level >= 4800) result *= 3;
            if (getRevenue && level >= 5200) result *= 3;
            if (getRevenue && level >= 5600) result *= 3;
            if (getRevenue && level >= 6000) result *= 3;
            if (getRevenue && level >= 6666) result *= 3;

            return result;
        }
    }
    class MoonExpress : ItemBase
    {
        public MoonExpress(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
        {
            level = 1;
            InitialCost = 42525;
            CalcCoefficient = 1.19;
            InitialTime = 2;
            InitialRevenue = 376;
        }
        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getRevenue && level >= 25) result *= 3;
            if (getRevenue && level >= 50) result *= 3;
            if (getRevenue && level >= 75) result *= 3;
            if (getRevenue && level >= 100) result *= 3;
            if (getRevenue && level >= 150) result *= 6;
            if (getRevenue && level >= 200) result *= 6;
            if (getRevenue && level >= 250) result *= 6;
            if (getRevenue && level >= 300) result *= 6;
            if (getRevenue && level >= 350) result *= 6;
            if (getRevenue && level >= 400) result *= 6;
            if (getRevenue && level >= 450) result *= 6;
            if (getRevenue && level >= 500) result *= 6;
            if (getRevenue && level >= 700) result *= 12;
            if (getRevenue && level >= 900) result *= 12;
            if (getRevenue && level >= 1100) result *= 12;
            if (getRevenue && level >= 1300) result *= 12;
            if (getRevenue && level >= 1500) result *= 12;
            if (getRevenue && level >= 1700) result *= 12;
            if (getRevenue && level >= 1900) result *= 12;
            if (getRevenue && level >= 2100) result *= 12;
            if (getRevenue && level >= 2300) result *= 12;
            if (getRevenue && level >= 2500) result *= 12;

            return result;
        }
    }
    class OxygenBar : ItemBase
    {
        public OxygenBar(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
        {
            level = 1;
            InitialCost = 493025;
            CalcCoefficient = 1.09;
            InitialTime = 45;
            InitialRevenue = 99000;
        }
        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getRevenue && level >= 20) result *= 12;
            if (getRevenue && level >= 50) result *= 12;
            if (getRevenue && level >= 90) result *= 12;
            if (getRevenue && level >= 180) result *= 12;
            if (getRevenue && level >= 360) result *= 12;
            if (getRevenue && level >= 720) result *= 12;
            if (getRevenue && level >= 1440) result *= 12;
            if (getRevenue && level >= 2880) result *= 12;
            if (getRevenue && level >= 5720) result *= 12;

            return result;
        }
    }
    class Helium3Farm : ItemBase
    {
        public Helium3Farm(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
        {
            level = 1;
            InitialCost = 18753525;
            CalcCoefficient = 1.15;
            InitialTime = 180;
            InitialRevenue = 1980000;
        }
        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getRevenue && level >= 50) result *= 7;
            if (getRevenue && level >= 100) result *= 7;
            if (getRevenue && level >= 200) result *= 7;
            if (getRevenue && level >= 300) result *= 7;
            if (getRevenue && level >= 400) result *= 7;
            if (getRevenue && level >= 500) result *= 7;
            if (getRevenue && level >= 600) result *= 7;
            if (getRevenue && level >= 700) result *= 7;
            if (getRevenue && level >= 800) result *= 7;
            if (getRevenue && level >= 900) result *= 7;
            if (getRevenue && level >= 1000) result *= 7;
            if (getRevenue && level >= 1200) result *= 7;
            if (getRevenue && level >= 1400) result *= 7;
            if (getRevenue && level >= 1600) result *= 7;
            if (getRevenue && level >= 1800) result *= 7;
            if (getRevenue && level >= 2000) result *= 7;
            if (getRevenue && level >= 2200) result *= 7;
            if (getRevenue && level >= 2400) result *= 7;
            if (getRevenue && level >= 2600) result *= 7;
            if (getRevenue && level >= 2800) result *= 7;
            if (getRevenue && level >= 3000) result *= 7;

            return result;
        }
    }
    class CheesMine : ItemBase
    {
        public CheesMine(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
        {
            level = 1;
            InitialCost = 393824025;
            CalcCoefficient = 1.13;
            InitialTime = 600;
            InitialRevenue = 33000000;
        }
        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getRevenue && level >= 8) result *= 5;
            if (getRevenue && level >= 16) result *= 5;
            if (getRevenue && level >= 32) result *= 5;
            if (getRevenue && level >= 64) result *= 5;
            if (getRevenue && level >= 128) result *= 5;
            if (getRevenue && level >= 256) result *= 5;
            if (getRevenue && level >= 512) result *= 5;
            if (getRevenue && level >= 1024) result *= 5;
            if (getRevenue && level >= 2048) result *= 5;
            if (getRevenue && level >= 4096) result *= 5;

            return result;
        }
    }
    class AmusmentPark : ItemBase
    {
        public AmusmentPark(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
        {
            level = 1;
            InitialCost = 8270000000;
            CalcCoefficient = 1.17;
            InitialTime = 3000;
            InitialRevenue = 1152000000;
        }
        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getRevenue && level >= 80) result *= 8;
            if (getRevenue && level >= 160) result *= 8;
            if (getRevenue && level >= 240) result *= 8;
            if (getRevenue && level >= 320) result *= 8;
            if (getRevenue && level >= 480) result *= 8;
            if (getRevenue && level >= 640) result *= 8;
            if (getRevenue && level >= 800) result *= 8;
            if (getRevenue && level >= 960) result *= 8;
            if (getRevenue && level >= 1200) result *= 8;
            if (getRevenue && level >= 1440) result *= 8;
            if (getRevenue && level >= 1680) result *= 8;
            if (getRevenue && level >= 1920) result *= 8;
            if (getRevenue && level >= 2160) result *= 8;
            if (getRevenue && level >= 2300) result *= 8;
            if (getRevenue && level >= 2540) result *= 8;
            if (getRevenue && level >= 2780) result *= 8;
            if (getRevenue && level >= 3000) result *= 8;

            return result;
        }
    }
    class WerwolfColony : ItemBase
    {
        public WerwolfColony(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
        {
            level = 1;
            InitialCost = 173676000000;
            CalcCoefficient = 1.11;
            InitialTime = 14400;
            InitialRevenue = 11067000000;
        }
        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getRevenue && level >= 25) result *= 2;
            if (getRevenue && level >= 50) result *= 2;
            if (getRevenue && level >= 75) result *= 2;
            if (getRevenue && level >= 100) result *= 2;
            if (getRevenue && level >= 150) result *= 2;
            if (getRevenue && level >= 200) result *= 2;
            if (getRevenue && level >= 250) result *= 2;
            if (getRevenue && level >= 300) result *= 2;
            if (getRevenue && level >= 350) result *= 2;
            if (getRevenue && level >= 400) result *= 2;
            if (getRevenue && level >= 450) result *= 2;
            if (getRevenue && level >= 500) result *= 2;
            if (getRevenue && level >= 600) result *= 2;
            if (getRevenue && level >= 700) result *= 2;
            if (getRevenue && level >= 800) result *= 2;
            if (getRevenue && level >= 900) result *= 2;
            if (getRevenue && level >= 1000) result *= 2;
            if (getRevenue && level >= 1200) result *= 2;
            if (getRevenue && level >= 1400) result *= 2;
            if (getRevenue && level >= 1600) result *= 2;
            if (getRevenue && level >= 1800) result *= 2;
            if (getRevenue && level >= 2000) result *= 2;
            if (getRevenue && level >= 2300) result *= 2;
            if (getRevenue && level >= 2600) result *= 2;
            if (getRevenue && level >= 2900) result *= 2;
            if (getRevenue && level >= 3200) result *= 2;
            if (getRevenue && level >= 3500) result *= 2;
            if (getRevenue && level >= 3800) result *= 2;
            if (getRevenue && level >= 4100) result *= 2;

            return result;
        }
    }
    class GigantLaser : ItemBase
    {
        public GigantLaser(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
        {
            level = 1;
            InitialCost = 1000000000000;
            CalcCoefficient = 1.50;
            InitialTime = 86400;
            InitialRevenue = 332640000000;
        }
        protected override double getAchievementModifier(bool getRevenue)
        {
            double result = 1;
            bool getSpeed = !getRevenue;

            if (getRevenue && level >= 50) result *= 75;
            if (getRevenue && level >= 100) result *= 75;
            if (getRevenue && level >= 200) result *= 75;
            if (getRevenue && level >= 300) result *= 75;
            if (getRevenue && level >= 400) result *= 75;
            if (getRevenue && level >= 500) result *= 75;
            if (getRevenue && level >= 600) result *= 75;
            if (getRevenue && level >= 700) result *= 75;
            if (getRevenue && level >= 800) result *= 75;
            if (getRevenue && level >= 900) result *= 75;
            if (getRevenue && level >= 1000) result *= 75;
            if (getRevenue && level >= 1111) result *= 75;

            return result;
        }
    }

    class LemonStand : ItemBase
    {
        public LemonStand(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
        {
            level = 1;

            InitialCost = 3.738;
            CalcCoefficient = 1.07;
            InitialTime = 0.6;
            InitialRevenue = 1;
            InitialProductivity = 1.67;
        }

        new public double getBuyCost()
        {
            return InitialCost * Math.Pow(CalcCoefficient, level - 1);
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
        public double newspaperAdditionalRevenuePerSecond { get; set; }

        public Newspaper(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
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

        public override double getBuyEfficiency()
        {
            return getBuyCost() / (getRevenuePerSecond() + newspaperAdditionalRevenuePerSecond);
        }
    }

    class CarWash : ItemBase
    {
        public CarWash(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
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
        public PizzaDelivery(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
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
        public DonutShop(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
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
        public ShrimpBoat(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
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
        public HockeyTeam(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
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
        public MovieStudio(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
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
        public Bank(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
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
        public OilCompany(GlobalStats inGlobalStats)
            : base(inGlobalStats) 
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
