using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Capitalist_Calculator
{
    class dataHolder
    {

        public static Dictionary<double, string> getAngelUpgradeComboSource()
        {
            Dictionary<double, string> comboSource = new Dictionary<double, string>();
            comboSource.Add(1, "All x3");
            comboSource.Add(2, "Angel eff +2");
            comboSource.Add(3, "Angel eff +2");
            comboSource.Add(4, "All x5");
            comboSource.Add(5, "All x9");
            comboSource.Add(6, "+10 news");
            comboSource.Add(7, "+10 car");
            comboSource.Add(8, "+10 pizza");
            comboSource.Add(9, "+10 donut");
            comboSource.Add(10, "+50 news ");
            comboSource.Add(11, "+50 news");
            return comboSource;
        }

        public static Dictionary<double, string> getManagerAngelUpgradeComboSource()
        {
            Dictionary<double, string> comboSource = new Dictionary<double, string>();
            comboSource.Add(1, "oil 10% cheaper");
            comboSource.Add(2, "bank 10% cheaper");
            comboSource.Add(3, "movie 10% cheaper");
            comboSource.Add(4, "hockey 10% cheaper");
            comboSource.Add(5, "shrimp 10% cheaper");
            comboSource.Add(6, "donut 10% cheaper");
            comboSource.Add(7, "pizza 10% cheaper");
            comboSource.Add(8, "car 10% cheaper");
            comboSource.Add(9, "news 10% cheaper");
            comboSource.Add(10, "lemon 10% cheaper");
            //11 tut nix
            comboSource.Add(12, "news 99.999% cheaper");
            return comboSource;
        }

        public static Dictionary<double, string> getCashUpgradeComboSource()
        {
            Dictionary<double, string> comboSource = new Dictionary<double, string>();
            comboSource.Add(1, "1 - LemonStand");
            comboSource.Add(2, "1 - Newspaper");
            comboSource.Add(3, "1 - Carwash");
            comboSource.Add(4, "1 - PizzaDelivery");
            comboSource.Add(5, "1 - DonutShop");
            comboSource.Add(6, "1 - ShrimpBoat");
            comboSource.Add(7, "1 - HockeyTeam");
            comboSource.Add(8, "1 - MovieStudio");
            comboSource.Add(9, "1 - Bank");
            comboSource.Add(10, "1 - OilRig");
            comboSource.Add(11, "1 - All");
            comboSource.Add(12, "2 - LemonStand");
            comboSource.Add(13, "2 - Newspaper");
            comboSource.Add(14, "2 - Carwash");
            comboSource.Add(15, "2 - PizzaDelivery");
            comboSource.Add(16, "2 - DonutShop");
            comboSource.Add(17, "2 - ShrimpBoat");
            comboSource.Add(18, "2 - HockeyTeam");
            comboSource.Add(19, "2 - MovieStudio");
            comboSource.Add(20, "2 - Bank");
            comboSource.Add(21, "2 - OilRig");
            comboSource.Add(22, "2 - All");
            comboSource.Add(23, "2 - ANGEL - $100 Quadrillion");
            comboSource.Add(24, "3 - LemonStand");
            comboSource.Add(25, "3 - Newspaper");
            comboSource.Add(26, "3 - Carwash");
            comboSource.Add(27, "3 - PizzaDelivery");
            comboSource.Add(28, "3 - DonutShop");
            comboSource.Add(29, "3 - ShrimpBoat");
            comboSource.Add(30, "3 - HockeyTeam");
            comboSource.Add(31, "3 - MovieStudio");
            comboSource.Add(32, "3 - Bank");
            comboSource.Add(33, "3 - OilRig");
            comboSource.Add(34, "3 - All");
            comboSource.Add(35, "3 - ANGEL - $1 Sextillion");
            comboSource.Add(36, "4 - LemonStand");
            comboSource.Add(37, "4 - Newspaper");
            comboSource.Add(38, "4 - Carwash");
            comboSource.Add(39, "4 - PizzaDelivery");
            comboSource.Add(40, "4 - DonutShop");
            comboSource.Add(41, "4 - ShrimpBoat");
            comboSource.Add(42, "4 - HockeyTeam");
            comboSource.Add(43, "4 - MovieStudio");
            comboSource.Add(44, "4 - Bank");
            comboSource.Add(45, "4 - OilRig");
            comboSource.Add(46, "4 - All");
            comboSource.Add(47, "4 - ANGEL - $10 Septillion");
            comboSource.Add(48, "5 - LemonStand");
            comboSource.Add(49, "5 - Newspaper");
            comboSource.Add(50, "5 - Carwash");
            comboSource.Add(51, "5 - PizzaDelivery");
            comboSource.Add(52, "5 - DonutShop");
            comboSource.Add(53, "5 - ShrimpBoat");
            comboSource.Add(54, "5 - HockeyTeam");
            comboSource.Add(55, "5 - MovieStudio");
            comboSource.Add(56, "5 - Bank");
            comboSource.Add(57, "5 - OilRig");
            comboSource.Add(58, "5 - All");

            return comboSource;
        }
    }
}
