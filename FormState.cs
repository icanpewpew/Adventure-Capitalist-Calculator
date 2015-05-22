using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Capitalist_Calculator
{
    public class FormState
    {

        public static string stateFilePath = AppDomain.CurrentDomain.BaseDirectory + "stateFile.xml";

        public string lemonStandState { get; set; }

        public FormState() { }

        public string newspaperState { get; set; }

        public string carwashState { get; set; }

        public string pizzaDeliveryState { get; set; }

        public string donutShopState { get; set; }

        public string shrimpBoatState { get; set; }

        public string hockeyTeamState { get; set; }

        public string movieStudioState { get; set; }

        public string bankState { get; set; }

        public string oilRigState { get; set; }

        public string angelCount { get; set; }

        public int selectedCashUpgradeCombo { get; set; }

        public int selectedAngelUpgradesCombo { get; set; }

        public int selectedManagerAngelUpgradeCombo { get; set; }
    }
}
