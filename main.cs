using Adventure_Capitalist_Calculator.ItemComposite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            LemonStandInput.Text = "570";
            NewspaperInput.Text = "260";
            CarwashInput.Text = "260";
            PizzaDeliveryInput.Text = "260";
            DonutShopInput.Text = "250";
            ShrimpBoatInput.Text = "250";
            HockeyTeamInput.Text = "250";
            MovieStudioInput.Text = "251";
            BankInput.Text = "296";
            OilRigInput.Text = "300";

            suggestButton_Click(null, null);
           
        }

        private void write(string inLine) { listBox1.Items.Add(inLine); }

        private void suggestButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            ItemContainer itemContainer = new ItemContainer();
            itemContainer.angelsCount = 87568;
            itemContainer.advertismentBonus = 2;
            itemContainer.cashUpgradesLevel = 33;


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

            string current_dir = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "Report_" + DateTime.Now.ToString("yyyyMMdd_HHmmss_fff");

            StreamWriter fileContent = new System.IO.StreamWriter(current_dir + fileName + ".txt", false, Encoding.UTF8);

            for (int i = 1; i < 1000; i++)
            {
                itemContainer.setNewspaperLevel(i);
                //write(allItems.lemonStand.level.ToString().PadRight(5)  + "   getRevenueIncreaseWithNextLevel: " + allItems.lemonStand.getRevenueIncreaseWithNextLevel().ToString("F2").PadLeft(30));
                write(itemContainer.newspaper.level.ToString().PadRight(5) + "   efficiency: " + itemContainer.newspaper.getBuyEfficiency().ToString().PadLeft(30));

                fileContent.WriteLine(itemContainer.newspaper.level.ToString() + "\t" + itemContainer.newspaper.getBuyEfficiency().ToString("F9").PadLeft(30));
            }

            fileContent.Close();

            /*itemContainer.allitems.ForEach(i => write(i.GetType().Name.PadLeft(14) + " " + i.level.ToString().PadRight(5)
                                           + "   getCurrentRevenue: " + i.getCurrentRevenue().ToString("F2").PadLeft(30)
                                           + "   getRevenueIncreaseWithNextLevel: " + i.getRevenueIncreaseWithNextLevel().ToString("F2").PadLeft(30)
                                           + "   getBuyCost: " + i.getBuyCost().ToString("F2").PadLeft(30)
                                           + "   revenuePerSecond: " + i.getRevenuePerSecond().ToString("F2").PadLeft(30)
                                           + "   efficiency: " + i.getBuyEfficiency().ToString("F2").PadLeft(30)
                                           ));*/



            /*
            allItems.allitems.ForEach(i => write(i.GetType().Name.PadLeft(14) + " " + i.level.ToString().PadRight(5) 
                                                 + "   getCurrentRevenue: " + i.getCurrentRevenue().ToString("F2").PadLeft(30)
                                                 + "   getRevenueIncreaseWithNextLevel: " + i.getRevenueIncreaseWithNextLevel().ToString("F2").PadLeft(30)
                                                 + "   get1TimesBuyCost: " + i.get1TimesBuyCost().ToString("F2").PadLeft(30))
                                                 );
             */
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
