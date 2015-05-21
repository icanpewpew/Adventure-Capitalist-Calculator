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
            LemonStandInput.Text = "500";
            NewspaperInput.Text = "220";
            CarwashInput.Text = "230";
            PizzaDeliveryInput.Text = "220";
            DonutShopInput.Text = "220";
            ShrimpBoatInput.Text = "230";
            HockeyTeamInput.Text = "220";
            MovieStudioInput.Text = "240";
            BankInput.Text = "250";
            OilRigInput.Text = "250";

            suggestButton_Click(null, null);
           
        }

        private void write(string inLine) { listBox1.Items.Add(inLine); }




        private void suggestButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            ItemContainer itemContainer = new ItemContainer();
            itemContainer.angelsCount = 812658;
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

            write(itemContainer.getItemWithLowestEfficency().GetType().Name);
            itemContainer.allitems.ForEach(i => write(i.GetType().Name.PadLeft(20) + " " + i.getBuyEfficiency().ToString("F2")));


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
            ItemContainer itemContainer = new ItemContainer();
            itemContainer.angelsCount = 812658;
            itemContainer.cashUpgradesLevel = 32;

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
            itemContainer.allitems.ForEach(i => write(i.GetType().Name.PadLeft(20) + " " + i.getBuyEfficiency().ToString("F2")));



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
    }
}
