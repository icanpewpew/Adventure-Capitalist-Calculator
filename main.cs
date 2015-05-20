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
            LemonStandInput.Text = "589";
            NewspaperInput.Text = "268";
            CarwashInput.Text = "248";
            PizzaDeliveryInput.Text = "231";
            DonutShopInput.Text = "248";
            ShrimpBoatInput.Text = "259";
            HockeyTeamInput.Text = "241";
            MovieStudioInput.Text = "256";
            BankInput.Text = "259";
            OilRigInput.Text = "268";

            suggestButton_Click(null, null);
           
        }

        private void write(string inLine) { listBox1.Items.Add(inLine); }

        private void suggestButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            ItemContainer allItems = new ItemContainer();
            allItems.angelsCount = 24416;
            allItems.advertismentBonus = 2;
            allItems.cashUpgradesLevel = 29;


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

           /* for (int i = 1; i < 1000; i++)
            {
                allItems.setNewspaperLevel(i);
                //write(allItems.lemonStand.level.ToString().PadRight(5)  + "   getRevenueIncreaseWithNextLevel: " + allItems.lemonStand.getRevenueIncreaseWithNextLevel().ToString("F2").PadLeft(30));
                write(allItems.newspaper.level.ToString().PadRight(5) + "   get1TimesBuyCost: " + allItems.newspaper.get1TimesBuyCost().ToString("F2").PadLeft(30));
            }*/


            allItems.allitems.ForEach(i => write(i.GetType().Name.PadLeft(14) + " " + i.level.ToString().PadRight(5) 
                                                 + "   getCurrentRevenue: " + i.getCurrentRevenue().ToString("F2").PadLeft(30)
                                                 + "   getRevenueIncreaseWithNextLevel: " + i.getRevenueIncreaseWithNextLevel().ToString("F2").PadLeft(30)
                                                 + "   get1TimesBuyCost: " + i.get1TimesBuyCost().ToString("F2").PadLeft(30))
                                                 );
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
