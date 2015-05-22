using Adventure_Capitalist_Calculator.ItemComposite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Adventure_Capitalist_Calculator
{
    public partial class main : Form
    {
        FormState state = new FormState();

        public main()
        {
            InitializeComponent();
        }

        private void loadConfig()
        {
            XmlSerializer ser = new XmlSerializer(typeof(FormState));
            using (FileStream fs = File.OpenRead(FormState.stateFilePath))
            {
                state = (FormState)ser.Deserialize(fs);
            }
        }

        private void writeConfig()
        {
            using (StreamWriter sw = new StreamWriter(FormState.stateFilePath))
            {
                state.lemonStandState = LemonStandInput.Text;
                state.newspaperState = NewspaperInput.Text;
                state.carwashState = CarwashInput.Text;
                state.pizzaDeliveryState = PizzaDeliveryInput.Text;
                state.donutShopState = DonutShopInput.Text;
                state.shrimpBoatState = ShrimpBoatInput.Text;
                state.hockeyTeamState = HockeyTeamInput.Text;
                state.movieStudioState = MovieStudioInput.Text;
                state.bankState = BankInput.Text;
                state.oilRigState = OilRigInput.Text;
                XmlSerializer ser = new XmlSerializer(typeof(FormState));
                ser.Serialize(sw, state);
            }
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            writeConfig();
        }

        ItemContainer itemContainer = new ItemContainer();

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

            if (File.Exists(FormState.stateFilePath)) loadConfig();

            LemonStandInput.Text = state.lemonStandState ?? "1";
            NewspaperInput.Text = state.newspaperState ?? "1";
            CarwashInput.Text = state.carwashState ?? "1";
            PizzaDeliveryInput.Text = state.pizzaDeliveryState ?? "1";
            DonutShopInput.Text = state.donutShopState ?? "1";
            ShrimpBoatInput.Text = state.shrimpBoatState ?? "1";
            HockeyTeamInput.Text = state.hockeyTeamState ?? "1";
            MovieStudioInput.Text = state.movieStudioState ?? "1";
            BankInput.Text = state.bankState ?? "1";
            OilRigInput.Text = state.oilRigState ?? "1";

            angelCountText.Text = "2893000";

            cashUpgradeCombo.DataSource = new BindingSource(dataHolder.getCashUpgradeComboSource(), null);
            cashUpgradeCombo.DisplayMember = "Value";
            cashUpgradeCombo.ValueMember = "Key";


            angelUpgradesCombo.DataSource = new BindingSource(dataHolder.getAngelUpgradeComboSource(), null);
            angelUpgradesCombo.DisplayMember = "Value";
            angelUpgradesCombo.ValueMember = "Key";

            managerAngelUpgradeCombo.DataSource = new BindingSource(dataHolder.getManagerAngelUpgradeComboSource(), null);
            managerAngelUpgradeCombo.DisplayMember = "Value";
            managerAngelUpgradeCombo.ValueMember = "Key";

            suggestButton_Click(null, null);
           
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemContainer.cashUpgradesLevel = ((KeyValuePair<double, string>)cashUpgradeCombo.SelectedItem).Key;
            suggestButton_Click(null, null);
        }

        private void angelUpgradesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void managerAngelUpgradeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void write(string inLine) { listBox1.Items.Add(inLine); }




        private void suggestButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            itemContainer.setLemonStandLevel(Convert.ToDouble(LemonStandInput.Text));
            itemContainer.setNewspaperLevel(Convert.ToDouble(NewspaperInput.Text));
            itemContainer.setCarWashLevel(Convert.ToDouble(CarwashInput.Text));
            itemContainer.setPizzaDeliveryLevel(Convert.ToDouble(PizzaDeliveryInput.Text));
            itemContainer.setDonutShopLevel(Convert.ToDouble(DonutShopInput.Text));
            itemContainer.setShrimpBoatLevel(Convert.ToDouble(ShrimpBoatInput.Text));
            itemContainer.setHockeyTeamLevel(Convert.ToDouble(HockeyTeamInput.Text));
            itemContainer.setMovieStudioLevel(Convert.ToDouble(MovieStudioInput.Text));
            itemContainer.setBankLevel(Convert.ToDouble(BankInput.Text));
            itemContainer.setOilCompanyLevel(Convert.ToDouble(OilRigInput.Text));

            write(itemContainer.getItemWithLowestEfficency().GetType().Name);
            write("");
            write("");
            write("");
            itemContainer.allitems.OrderBy(i => i.getBuyEfficiency()).ToList().ForEach(i => write(i.GetType().Name.PadLeft(20) + " " + i.getBuyEfficiency().ToString("F2").PadLeft(20)));

            //Reports report = new Reports();
            //report.writeEfficiencyOverLevel(itemContainer);
            //report.writeAlwaysChooseTheEffItem(itemContainer);
            //report.writeAlwaysChooseTheCheapestItem(itemContainer);
            //report.writeReport();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            itemContainer.setLemonStandLevel(Convert.ToDouble(LemonStandInput.Text));
            itemContainer.setNewspaperLevel(Convert.ToDouble(NewspaperInput.Text));
            itemContainer.setCarWashLevel(Convert.ToDouble(CarwashInput.Text));
            itemContainer.setPizzaDeliveryLevel(Convert.ToDouble(PizzaDeliveryInput.Text));
            itemContainer.setDonutShopLevel(Convert.ToDouble(DonutShopInput.Text));
            itemContainer.setShrimpBoatLevel(Convert.ToDouble(ShrimpBoatInput.Text));
            itemContainer.setHockeyTeamLevel(Convert.ToDouble(HockeyTeamInput.Text));
            itemContainer.setMovieStudioLevel(Convert.ToDouble(MovieStudioInput.Text));
            itemContainer.setBankLevel(Convert.ToDouble(BankInput.Text));
            itemContainer.setOilCompanyLevel(Convert.ToDouble(OilRigInput.Text));

            write(itemContainer.getItemWithLowestEfficency().GetType().Name);
            write("");
            write("");
            write("");
            itemContainer.allitems.OrderBy(i => i.getBuyEfficiency()).ToList().ForEach(i => write(i.GetType().Name.PadLeft(20) + " " + i.getBuyEfficiency().ToString("F2").PadLeft(20)));



            itemContainer.setItemLevel(itemContainer.getItemWithLowestEfficency(), itemContainer.getItemWithLowestEfficency().level + 10);

            LemonStandInput.Text = itemContainer.lemonStand.level.ToString();
            NewspaperInput.Text = itemContainer.newspaper.level.ToString();
            CarwashInput.Text = itemContainer.carWash.level.ToString();
            PizzaDeliveryInput.Text = itemContainer.pizzaDelivery.level.ToString();
            DonutShopInput.Text = itemContainer.donutShop.level.ToString();
            ShrimpBoatInput.Text = itemContainer.shrimpBoat.level.ToString();
            HockeyTeamInput.Text = itemContainer.hockeyTeam.level.ToString();
            MovieStudioInput.Text = itemContainer.movieStudio.level.ToString();
            BankInput.Text = itemContainer.bank.level.ToString();
            OilRigInput.Text = itemContainer.oilCompany.level.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            itemContainer.setLemonStandLevel(Convert.ToDouble(LemonStandInput.Text));
            itemContainer.setNewspaperLevel(Convert.ToDouble(NewspaperInput.Text));
            itemContainer.setCarWashLevel(Convert.ToDouble(CarwashInput.Text));
            itemContainer.setPizzaDeliveryLevel(Convert.ToDouble(PizzaDeliveryInput.Text));
            itemContainer.setDonutShopLevel(Convert.ToDouble(DonutShopInput.Text));
            itemContainer.setShrimpBoatLevel(Convert.ToDouble(ShrimpBoatInput.Text));
            itemContainer.setHockeyTeamLevel(Convert.ToDouble(HockeyTeamInput.Text));
            itemContainer.setMovieStudioLevel(Convert.ToDouble(MovieStudioInput.Text));
            itemContainer.setBankLevel(Convert.ToDouble(BankInput.Text));
            itemContainer.setOilCompanyLevel(Convert.ToDouble(OilRigInput.Text));

            write(itemContainer.getItemWithLowestEfficency().GetType().Name);
            write("");
            write("");
            write("");
            itemContainer.allitems.OrderBy(i => i.getBuyEfficiency()).ToList().ForEach(i => write(i.GetType().Name.PadLeft(20) + " " + i.getBuyEfficiency().ToString("F2").PadLeft(20)));



            itemContainer.setItemLevel(itemContainer.getItemWithLowestEfficency(), itemContainer.getItemWithLowestEfficency().level + 1);

            LemonStandInput.Text = itemContainer.lemonStand.level.ToString();
            NewspaperInput.Text = itemContainer.newspaper.level.ToString();
            CarwashInput.Text = itemContainer.carWash.level.ToString();
            PizzaDeliveryInput.Text = itemContainer.pizzaDelivery.level.ToString();
            DonutShopInput.Text = itemContainer.donutShop.level.ToString();
            ShrimpBoatInput.Text = itemContainer.shrimpBoat.level.ToString();
            HockeyTeamInput.Text = itemContainer.hockeyTeam.level.ToString();
            MovieStudioInput.Text = itemContainer.movieStudio.level.ToString();
            BankInput.Text = itemContainer.bank.level.ToString();
            OilRigInput.Text = itemContainer.oilCompany.level.ToString();
        }


    }
}
