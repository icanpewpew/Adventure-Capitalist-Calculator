using Adventure_Capitalist_Calculator.ItemComposite.Container;
using Adventure_Capitalist_Calculator.ItemComposite.ItemHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Capitalist_Calculator.ItemComposite
{
    class EarthItemContainer : ItemContainer
    {
        public LemonStand lemonStand { get; set; }
        public Newspaper newspaper { get; set; }
        public CarWash carWash { get; set; }
        public PizzaDelivery pizzaDelivery { get; set; }
        public DonutShop donutShop { get; set; }
        public ShrimpBoat shrimpBoat { get; set; }
        public HockeyTeam hockeyTeam { get; set; }
        public MovieStudio movieStudio { get; set; }
        public Bank bank { get; set; }
        public OilCompany oilCompany { get; set; }

        public void setLemonStandLevel(double inLevel) { setItemLevel(lemonStand, inLevel); }
        public void setNewspaperLevel(double inLevel) { setItemLevel(newspaper, inLevel); }
        public void setCarWashLevel(double inLevel) { setItemLevel(carWash, inLevel); }
        public void setPizzaDeliveryLevel(double inLevel) { setItemLevel(pizzaDelivery, inLevel); }
        public void setDonutShopLevel(double inLevel) { setItemLevel(donutShop, inLevel); }
        public void setShrimpBoatLevel(double inLevel) { setItemLevel(shrimpBoat, inLevel); }
        public void setHockeyTeamLevel(double inLevel) { setItemLevel(hockeyTeam, inLevel); }
        public void setMovieStudioLevel(double inLevel) { setItemLevel(movieStudio, inLevel); }
        public void setBankLevel(double inLevel) { setItemLevel(bank, inLevel); }
        public void setOilCompanyLevel(double inLevel) { setItemLevel(oilCompany, inLevel); }

        public EarthItemContainer()
        {
            lemonStand = new LemonStand(this);
            newspaper = new Newspaper(this);
            carWash = new CarWash(this);
            pizzaDelivery = new PizzaDelivery(this);
            donutShop = new DonutShop(this);
            shrimpBoat = new ShrimpBoat(this);
            hockeyTeam = new HockeyTeam(this);
            movieStudio = new MovieStudio(this);
            bank = new Bank(this);
            oilCompany = new OilCompany(this);

            allitems.Add(lemonStand);
            allitems.Add(newspaper);
            allitems.Add(carWash);
            allitems.Add(pizzaDelivery);
            allitems.Add(donutShop);
            allitems.Add(shrimpBoat);
            allitems.Add(hockeyTeam);
            allitems.Add(movieStudio);
            allitems.Add(bank);
            allitems.Add(oilCompany);
        }

        protected override void setGlobalAchievmentModifier()
        {
            double resultRevenue = 1;
            double resultSpeed = 1;

            double lowestLevel = allitems.Min(i => i.level);

            if (lowestLevel >= 25) resultSpeed *= 2;
            if (lowestLevel >= 50) resultSpeed *= 2;
            if (lowestLevel >= 100) resultSpeed *= 2;
            if (lowestLevel >= 200) resultSpeed *= 2;
            if (lowestLevel >= 300) resultSpeed *= 2;
            if (lowestLevel >= 400) resultSpeed *= 2;

            if (lowestLevel >= 500) resultRevenue *= 2;
            if (lowestLevel >= 600) resultRevenue *= 2;
            if (lowestLevel >= 666) resultRevenue *= 2;
            if (lowestLevel >= 700) resultRevenue *= 2;
            if (lowestLevel >= 777) resultRevenue *= 2;
            if (lowestLevel >= 800) resultRevenue *= 2;
            if (lowestLevel >= 900) resultRevenue *= 2;

            if (lowestLevel >= 1000) resultRevenue *= 2;
            if (lowestLevel >= 1100) resultRevenue *= 2;
            if (lowestLevel >= 1111) resultRevenue *= 2;
            if (lowestLevel >= 1200) resultRevenue *= 2;
            if (lowestLevel >= 1300) resultRevenue *= 2;
            if (lowestLevel >= 1400) resultRevenue *= 2;
            if (lowestLevel >= 1500) resultRevenue *= 2;
            if (lowestLevel >= 1600) resultRevenue *= 2;
            if (lowestLevel >= 1700) resultRevenue *= 2;
            if (lowestLevel >= 1800) resultRevenue *= 2;
            if (lowestLevel >= 1900) resultRevenue *= 2;

            if (lowestLevel >= 2000) resultRevenue *= 2;

            GlobalAchievmentRevenueModifier = resultRevenue;
            GlobalAchievmentSpeedModifier = resultSpeed;
        }
        
        protected override void setCashUpgradeLevel(double inCashUpgradeLevel)
        {
            allitems.ForEach(i => i.cashUpgradeModifier = 1);
            angelsPercent = 2;

            if (inCashUpgradeLevel >= 2) lemonStand.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 3) newspaper.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 4) carWash.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 5) pizzaDelivery.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 6) donutShop.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 7) shrimpBoat.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 8) hockeyTeam.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 9) movieStudio.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 10) bank.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 11) oilCompany.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 12) allitems.ForEach(i => i.cashUpgradeModifier *= 3);

            if (inCashUpgradeLevel >= 13) lemonStand.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 14) newspaper.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 15) carWash.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 16) pizzaDelivery.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 17) donutShop.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 18) shrimpBoat.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 19) hockeyTeam.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 20) movieStudio.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 21) bank.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 22) oilCompany.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 23) allitems.ForEach(i => i.cashUpgradeModifier *= 3);

            if (inCashUpgradeLevel >= 24) angelsPercent += 1; //$100 Quadrillion

            if (inCashUpgradeLevel >= 25) lemonStand.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 26) newspaper.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 27) carWash.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 28) pizzaDelivery.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 29) donutShop.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 30) shrimpBoat.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 31) hockeyTeam.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 32) movieStudio.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 33) bank.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 34) oilCompany.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 35) allitems.ForEach(i => i.cashUpgradeModifier *= 3);

            if (inCashUpgradeLevel >= 36) angelsPercent += 1; //$1 Sextillion

            if (inCashUpgradeLevel >= 37) lemonStand.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 38) newspaper.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 39) carWash.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 40) pizzaDelivery.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 41) donutShop.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 42) shrimpBoat.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 43) hockeyTeam.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 44) movieStudio.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 45) bank.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 46) oilCompany.cashUpgradeModifier *= 3;
            if (inCashUpgradeLevel >= 47) allitems.ForEach(i => i.cashUpgradeModifier *= 3);

            if (inCashUpgradeLevel >= 48) angelsPercent += 2; //$10 Septillion

            if (inCashUpgradeLevel >= 49) lemonStand.cashUpgradeModifier *= 7;
            if (inCashUpgradeLevel >= 50) newspaper.cashUpgradeModifier *= 7;
            if (inCashUpgradeLevel >= 51) carWash.cashUpgradeModifier *= 7;
            if (inCashUpgradeLevel >= 52) pizzaDelivery.cashUpgradeModifier *= 7;
            if (inCashUpgradeLevel >= 53) donutShop.cashUpgradeModifier *= 7;
            if (inCashUpgradeLevel >= 54) shrimpBoat.cashUpgradeModifier *= 7;
            if (inCashUpgradeLevel >= 55) hockeyTeam.cashUpgradeModifier *= 7;
            if (inCashUpgradeLevel >= 56) movieStudio.cashUpgradeModifier *= 7;
            if (inCashUpgradeLevel >= 57) bank.cashUpgradeModifier *= 7;
            if (inCashUpgradeLevel >= 58) oilCompany.cashUpgradeModifier *= 7;
            if (inCashUpgradeLevel >= 59) allitems.ForEach(i => i.cashUpgradeModifier *= 7);
        }
    }
}
