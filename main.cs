using Adventure_Capitalist_Calculator.ItemComposite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Capitalist_Calculator
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LemonStandInput.Text = "2";
            NewspaperInput.Text = "106";
            CarwashInput.Text = "100";
            PizzaDeliveryInput.Text = "82";
            DonutShopInput.Text = "80";
            ShrimpBoatInput.Text = "70";
            HockeyTeamInput.Text = "57";
            MovieStudioInput.Text = "39";
            BankInput.Text = "9";
            OilRigInput.Text = "0";

           
        }

        private void write(string inLine) { listBox1.Items.Add(inLine); }

        private void suggestButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            ItemContainer allItems = new ItemContainer();
            allItems.angelsCount = 24416;
            allItems.advertismentBonus = 2;
            allItems.cashUpgradesLevel = 28;


            allItems.setLemonStandLevel(Convert.ToDouble(LemonStandInput.Text));
            allItems.setNewspaperLevel(Convert.ToDouble(NewspaperInput.Text));
            allItems.setCarWashLevel(Convert.ToDouble(CarwashInput.Text));
            allItems.setPizzaDeliveryLevel(Convert.ToDouble(PizzaDeliveryInput.Text));
            allItems.setDonutShopLevel(Convert.ToDouble(DonutShopInput.Text));
            allItems.setShrimpBoatLevel(Convert.ToDouble(ShrimpBoatInput.Text));
            allItems.setHockeyTeamLevel(Convert.ToDouble(HockeyTeamInput.Text));
            allItems.setMovieStudioLevel(Convert.ToDouble(MovieStudioInput.Text));
            allItems.setBankLevel(Convert.ToDouble(BankInput.Text));
            allItems.setOilCompanyLevel(Convert.ToDouble(OilRigInput.Text));

            allItems.allitems.ForEach(i => write(i.GetType().Name.PadLeft(14) + " " + i.level.ToString().PadRight(5) + "   getCurrentRevenue: " + i.getCurrentRevenue().ToString("F2").PadLeft(30)));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
