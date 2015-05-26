using Adventure_Capitalist_Calculator.ItemComposite.ItemHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Capitalist_Calculator.ItemComposite
{
    class ItemContainer
    {

        private double _angelsCount;
        public double angelsCount
        {
            get { return _angelsCount; }
            set
            {
                allitems.ForEach(i => i.angelsCount = value);
                _angelsCount = value;
            }
        }

        private double _advertismentBonus { get; set; }
        public double advertismentBonus
        {
            get { return _advertismentBonus; }
            set
            {
                allitems.ForEach(i => i.advertismentBonus = value);
                _advertismentBonus = value;
            }
        }



        private double _cashUpgradesLevel;
        

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

        public void setLemonStandLevel(double inLevel) { lemonStand.level = inLevel; setGlobalAchievmentModifier(); }
        public void setNewspaperLevel(double inLevel) { newspaper.level = inLevel; setGlobalAchievmentModifier(); }
        public void setCarWashLevel(double inLevel) { carWash.level = inLevel; setGlobalAchievmentModifier(); }
        public void setPizzaDeliveryLevel(double inLevel) { pizzaDelivery.level = inLevel; setGlobalAchievmentModifier(); }
        public void setDonutShopLevel(double inLevel) { donutShop.level = inLevel; setGlobalAchievmentModifier(); }
        public void setShrimpBoatLevel(double inLevel) { shrimpBoat.level = inLevel; setGlobalAchievmentModifier(); }
        public void setHockeyTeamLevel(double inLevel) { hockeyTeam.level = inLevel; setGlobalAchievmentModifier(); }
        public void setMovieStudioLevel(double inLevel) { movieStudio.level = inLevel; setGlobalAchievmentModifier(); }
        public void setBankLevel(double inLevel) { bank.level = inLevel; setGlobalAchievmentModifier(); }
        public void setOilCompanyLevel(double inLevel) { oilCompany.level = inLevel; setGlobalAchievmentModifier(); }
        public void setItemLevel(ItemBase inItem, double inLevel)
        {
            inItem.level = inLevel;
            setGlobalAchievmentModifier(); 
            totalMoneySpend += inItem.getBuyCost();
            levelUpPath.Append(inLevel + "\t" + inItem.GetType().Name + "\t" + getTotalRevenuePerSecond() + "\t" + totalMoneySpend + "\t" + getTotalBuyEfficiency() + "\r\n");
        }

        public StringBuilder levelUpPath = new StringBuilder();

        public double totalMoneySpend { get; set; }

        private void setGlobalAchievmentModifier()
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

            allitems.ForEach(i => i.GlobalAchievmentRevenueModifier = resultRevenue);
            allitems.ForEach(i => i.GlobalAchievmentSpeedModifier = resultSpeed);
        }

        public List<ItemBase> allitems = new List<ItemBase>();

        public ItemBase getItemWithLowestEfficency()
        {
            return allitems.First(i => i.getBuyEfficiency().Equals(allitems.Min(o => o.getBuyEfficiency())));
        }

        public ItemBase getItemWithCheapestBuyCost()
        {
            return allitems.First(i => i.getBuyCost().Equals(allitems.Min(o => o.getBuyCost())));
        }

        public ItemBase getItemWithLowestLevel()
        {
            return allitems.Where(i => i.level.Equals(allitems.Min(o => o.level))).OrderBy(i => i.getBuyCost()).First();
        }

        public double getTotalRevenuePerSecond()
        {
            return allitems.Sum(o => o.getRevenuePerSecond());
        }

        public double getTotalBuyEfficiency()
        {
            return allitems.Sum(o => o.getBuyEfficiency());
        }

        public ItemContainer()
        {
            angelsCount = 0;
            advertismentBonus = 2;
            cashUpgradesLevel = 1;
            totalMoneySpend = 0;
            lemonStand = new LemonStand();
            newspaper = new Newspaper();
            carWash = new CarWash();
            pizzaDelivery = new PizzaDelivery();
            donutShop = new DonutShop();
            shrimpBoat = new ShrimpBoat();
            hockeyTeam = new HockeyTeam();
            movieStudio = new MovieStudio();
            bank = new Bank();
            oilCompany = new OilCompany();

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

        public double cashUpgradesLevel
        {
            get { return _cashUpgradesLevel; }
            set
            {
                allitems.ForEach(i => i.cashUpgradeModifier = 1);
                allitems.ForEach(i => i.angelsPercent = 2);

                if (value >= 2) lemonStand.cashUpgradeModifier *= 3;
                if (value >= 3) newspaper.cashUpgradeModifier *= 3;
                if (value >= 4) carWash.cashUpgradeModifier *= 3;
                if (value >= 5) pizzaDelivery.cashUpgradeModifier *= 3;
                if (value >= 6) donutShop.cashUpgradeModifier *= 3;
                if (value >= 7) shrimpBoat.cashUpgradeModifier *= 3;
                if (value >= 8) hockeyTeam.cashUpgradeModifier *= 3;
                if (value >= 9) movieStudio.cashUpgradeModifier *= 3;
                if (value >= 10) bank.cashUpgradeModifier *= 3;
                if (value >= 11) oilCompany.cashUpgradeModifier *= 3;
                if (value >= 12) allitems.ForEach(i => i.cashUpgradeModifier *= 3);

                if (value >= 13) lemonStand.cashUpgradeModifier *= 3;
                if (value >= 14) newspaper.cashUpgradeModifier *= 3;
                if (value >= 15) carWash.cashUpgradeModifier *= 3;
                if (value >= 16) pizzaDelivery.cashUpgradeModifier *= 3;
                if (value >= 17) donutShop.cashUpgradeModifier *= 3;
                if (value >= 18) shrimpBoat.cashUpgradeModifier *= 3;
                if (value >= 19) hockeyTeam.cashUpgradeModifier *= 3;
                if (value >= 20) movieStudio.cashUpgradeModifier *= 3;
                if (value >= 21) bank.cashUpgradeModifier *= 3;
                if (value >= 22) oilCompany.cashUpgradeModifier *= 3;
                if (value >= 23) allitems.ForEach(i => i.cashUpgradeModifier *= 3);

                if (value >= 24) allitems.ForEach(i => i.angelsPercent += 1); //$100 Quadrillion

                if (value >= 25) lemonStand.cashUpgradeModifier *= 3;
                if (value >= 26) newspaper.cashUpgradeModifier *= 3;
                if (value >= 27) carWash.cashUpgradeModifier *= 3;
                if (value >= 28) pizzaDelivery.cashUpgradeModifier *= 3;
                if (value >= 29) donutShop.cashUpgradeModifier *= 3;
                if (value >= 30) shrimpBoat.cashUpgradeModifier *= 3;
                if (value >= 31) hockeyTeam.cashUpgradeModifier *= 3;
                if (value >= 32) movieStudio.cashUpgradeModifier *= 3;
                if (value >= 33) bank.cashUpgradeModifier *= 3;
                if (value >= 34) oilCompany.cashUpgradeModifier *= 3;
                if (value >= 35) allitems.ForEach(i => i.cashUpgradeModifier *= 3);

                if (value >= 36) allitems.ForEach(i => i.angelsPercent += 1); //$1 Sextillion

                if (value >= 37) lemonStand.cashUpgradeModifier *= 3;
                if (value >= 38) newspaper.cashUpgradeModifier *= 3;
                if (value >= 39) carWash.cashUpgradeModifier *= 3;
                if (value >= 40) pizzaDelivery.cashUpgradeModifier *= 3;
                if (value >= 41) donutShop.cashUpgradeModifier *= 3;
                if (value >= 42) shrimpBoat.cashUpgradeModifier *= 3;
                if (value >= 43) hockeyTeam.cashUpgradeModifier *= 3;
                if (value >= 44) movieStudio.cashUpgradeModifier *= 3;
                if (value >= 45) bank.cashUpgradeModifier *= 3;
                if (value >= 46) oilCompany.cashUpgradeModifier *= 3;
                if (value >= 47) allitems.ForEach(i => i.cashUpgradeModifier *= 3);

                if (value >= 48) allitems.ForEach(i => i.angelsPercent += 2); //$10 Septillion

                if (value >= 49) lemonStand.cashUpgradeModifier *= 7;
                if (value >= 50) newspaper.cashUpgradeModifier *= 7;
                if (value >= 51) carWash.cashUpgradeModifier *= 7;
                if (value >= 52) pizzaDelivery.cashUpgradeModifier *= 7;
                if (value >= 53) donutShop.cashUpgradeModifier *= 7;
                if (value >= 54) shrimpBoat.cashUpgradeModifier *= 7;
                if (value >= 55) hockeyTeam.cashUpgradeModifier *= 7;
                if (value >= 56) movieStudio.cashUpgradeModifier *= 7;
                if (value >= 57) bank.cashUpgradeModifier *= 7;
                if (value >= 58) oilCompany.cashUpgradeModifier *= 7;
                if (value >= 59) allitems.ForEach(i => i.cashUpgradeModifier *= 7);

                _cashUpgradesLevel = value;

            }
        }






    }
}
