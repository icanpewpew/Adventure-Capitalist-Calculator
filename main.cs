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
        EarthItemContainer earthItemContainer = new EarthItemContainer();
        MoonItemContainer moonItemContainer = new MoonItemContainer();

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

                state.angelCount = angelCountText.Text;

                state.selectedCashUpgradeCombo = cashUpgradeCombo.SelectedIndex;
                state.selectedAngelUpgradesCombo = angelUpgradesCombo.SelectedIndex;
                state.selectedManagerAngelUpgradeCombo = managerAngelUpgradeCombo.SelectedIndex;

                state.moonShoeState = shoe.Text;
                state.gravityBoothState = booth.Text;
                state.paydayCloneState = clone.Text;
                state.moonExpressState = express.Text;
                state.oxygenBarState = oxygen.Text;
                state.helium3FarmState = helium3.Text;
                state.cheesMineState = cheese.Text;
                state.amusmentParkState = park.Text;
                state.werwolfColonyState = werewolf.Text;
                state.gigantLaserState = laser.Text;
                state.moonAngelCount = moonAngelCount.Text;

                state.selectedTab = tabControl1.SelectedIndex;

                XmlSerializer ser = new XmlSerializer(typeof(FormState));
                ser.Serialize(sw, state);
            }
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            writeConfig();
        }
               

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
            initCombos();

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

            angelCountText.Text = state.angelCount ?? "1";

            cashUpgradeCombo.SelectedIndex = state.selectedCashUpgradeCombo;
            angelUpgradesCombo.SelectedIndex = state.selectedAngelUpgradesCombo;
            managerAngelUpgradeCombo.SelectedIndex = state.selectedManagerAngelUpgradeCombo;


            shoe.Text = state.moonShoeState ?? "1";
            booth.Text = state.gravityBoothState ?? "1";
            clone.Text = state.paydayCloneState ?? "1";
            express.Text = state.moonExpressState ?? "1";
            oxygen.Text = state.oxygenBarState ?? "1";
            helium3.Text = state.helium3FarmState ?? "1";
            cheese.Text = state.cheesMineState ?? "1";
            park.Text = state.amusmentParkState ?? "1";
            werewolf.Text = state.werwolfColonyState ?? "1";
            laser.Text = state.gigantLaserState ?? "1";

            moonAngelCount.Text = state.moonAngelCount ?? "1";

            tabControl1.SelectedIndex = state.selectedTab;

            suggestButton_Click(null, null);

            //Reports report = new Reports();
            //report.writeTestStrategies();
            //report.writeChooseRandom();

        }

        private void initCombos()
        {
            cashUpgradeCombo.DataSource = new BindingSource(dataHolder.getCashUpgradeComboSource(), null);
            cashUpgradeCombo.DisplayMember = "Value";
            cashUpgradeCombo.ValueMember = "Key";
            angelUpgradesCombo.DataSource = new BindingSource(dataHolder.getAngelUpgradeComboSource(), null);
            angelUpgradesCombo.DisplayMember = "Value";
            angelUpgradesCombo.ValueMember = "Key";
            managerAngelUpgradeCombo.DataSource = new BindingSource(dataHolder.getManagerAngelUpgradeComboSource(), null);
            managerAngelUpgradeCombo.DisplayMember = "Value";
            managerAngelUpgradeCombo.ValueMember = "Key";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            earthItemContainer.cashUpgradesLevel = ((KeyValuePair<double, string>)cashUpgradeCombo.SelectedItem).Key;
            //suggestButton_Click(null, null);
        }

        private void angelUpgradesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void managerAngelUpgradeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void write(string inLine) { listBox1.Items.Add(inLine); }
        private void writeMoon(string inLine) { moonListBox.Items.Add(inLine); }



        private void suggestButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            earthItemContainer.setLemonStandLevel(Convert.ToDouble(LemonStandInput.Text));
            earthItemContainer.setNewspaperLevel(Convert.ToDouble(NewspaperInput.Text));
            earthItemContainer.setCarWashLevel(Convert.ToDouble(CarwashInput.Text));
            earthItemContainer.setPizzaDeliveryLevel(Convert.ToDouble(PizzaDeliveryInput.Text));
            earthItemContainer.setDonutShopLevel(Convert.ToDouble(DonutShopInput.Text));
            earthItemContainer.setShrimpBoatLevel(Convert.ToDouble(ShrimpBoatInput.Text));
            earthItemContainer.setHockeyTeamLevel(Convert.ToDouble(HockeyTeamInput.Text));
            earthItemContainer.setMovieStudioLevel(Convert.ToDouble(MovieStudioInput.Text));
            earthItemContainer.setBankLevel(Convert.ToDouble(BankInput.Text));
            earthItemContainer.setOilCompanyLevel(Convert.ToDouble(OilRigInput.Text));

            write(earthItemContainer.getItemWithLowestEfficency().GetType().Name);
            write("");
            write("");
            write("");
            earthItemContainer.allitems.OrderBy(i => i.getBuyEfficiency()).ToList().ForEach(i => write(i.GetType().Name.PadLeft(20) + " " + i.getBuyEfficiency().ToString("G3").PadLeft(10)));



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            earthItemContainer.setItemLevel(earthItemContainer.getItemWithLowestEfficency(), earthItemContainer.getItemWithLowestEfficency().level + 1);

            setInputBoxesWithContainer();

            suggestButton_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            earthItemContainer.setItemLevel(earthItemContainer.getItemWithLowestEfficency(), earthItemContainer.getItemWithLowestEfficency().level + 10);
            
            setInputBoxesWithContainer();
            
            suggestButton_Click(null, null);
            
        }

        private void setInputBoxesWithContainer()
        {
            LemonStandInput.Text = earthItemContainer.lemonStand.level.ToString();
            NewspaperInput.Text = earthItemContainer.newspaper.level.ToString();
            CarwashInput.Text = earthItemContainer.carWash.level.ToString();
            PizzaDeliveryInput.Text = earthItemContainer.pizzaDelivery.level.ToString();
            DonutShopInput.Text = earthItemContainer.donutShop.level.ToString();
            ShrimpBoatInput.Text = earthItemContainer.shrimpBoat.level.ToString();
            HockeyTeamInput.Text = earthItemContainer.hockeyTeam.level.ToString();
            MovieStudioInput.Text = earthItemContainer.movieStudio.level.ToString();
            BankInput.Text = earthItemContainer.bank.level.ToString();
            OilRigInput.Text = earthItemContainer.oilCompany.level.ToString();
        }

        private void moonSuggest_Click(object sender, EventArgs e)
        {
            moonListBox.Items.Clear();

            moonItemContainer.setMoonShoeLevel(Convert.ToDouble(shoe.Text));
            moonItemContainer.setGravityBoothLevel(Convert.ToDouble(booth.Text));
            moonItemContainer.setPaydayCloneLevel(Convert.ToDouble(clone.Text));
            moonItemContainer.setMoonExpressLevel(Convert.ToDouble(express.Text));
            moonItemContainer.setOxygenBarLevel(Convert.ToDouble(oxygen.Text));
            moonItemContainer.setHelium3FarmLevel(Convert.ToDouble(helium3.Text));
            moonItemContainer.setCheesMineLevel(Convert.ToDouble(cheese.Text));
            moonItemContainer.setAmusmentParkLevel(Convert.ToDouble(park.Text));
            moonItemContainer.setWerwolfColonyLevel(Convert.ToDouble(werewolf.Text));
            moonItemContainer.setGigantLaserLevel(Convert.ToDouble(laser.Text));

            writeMoon(moonItemContainer.getItemWithLowestEfficency().GetType().Name);
            writeMoon("");
            writeMoon("");
            writeMoon("");
            moonItemContainer.allitems.OrderBy(i => i.getBuyEfficiency()).ToList().ForEach(i => writeMoon(i.GetType().Name.PadLeft(20) + " " + i.getBuyEfficiency().ToString("G3").PadLeft(10)));

        }

        private void moonFollowed1_Click(object sender, EventArgs e)
        {
            moonItemContainer.setItemLevel(moonItemContainer.getItemWithLowestEfficency(), moonItemContainer.getItemWithLowestEfficency().level + 1);

            setInputBoxesWithContainerMoon();

            moonSuggest_Click(null, null);
        }

        private void moonFollowed10_Click(object sender, EventArgs e)
        {
            moonItemContainer.setItemLevel(moonItemContainer.getItemWithLowestEfficency(), moonItemContainer.getItemWithLowestEfficency().level + 1);

            setInputBoxesWithContainerMoon();

            moonSuggest_Click(null, null);
        }

        private void setInputBoxesWithContainerMoon()
        {
            shoe.Text = moonItemContainer.moonShoe.level.ToString();
            booth.Text = moonItemContainer.gravityBooth.level.ToString();
            clone.Text = moonItemContainer.paydayClone.level.ToString();
            express.Text = moonItemContainer.moonExpress.level.ToString();
            oxygen.Text = moonItemContainer.oxygenBar.level.ToString();
            helium3.Text = moonItemContainer.helium3Farm.level.ToString();
            cheese.Text = moonItemContainer.cheesMine.level.ToString();
            park.Text = moonItemContainer.amusmentPark.level.ToString();
            werewolf.Text = moonItemContainer.werwolfColony.level.ToString();
            laser.Text = moonItemContainer.gigantLaser.level.ToString();
        }

    }
}
