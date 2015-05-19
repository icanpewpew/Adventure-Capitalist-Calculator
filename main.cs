using Adventure_Capitalist_Calculator.counter;
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

            //LemonStand ls = new LemonStand(Convert.ToDouble(LemonStandInput.Text),1 );
            //Newspaper news = new Newspaper(Convert.ToDouble(NewspaperInput.Text));


            LemonStand ls = new LemonStand();
            for (int i = 177; i <= 300; i++)
            {
                ls.currentLevel = i;
                listBox1.Items.Add(i + "  cost next unit: " + ls.getUnitCost().ToString("F2"));
                listBox1.Items.Add(i + "  production Speed: " + ls.getProductionSpeed().ToString("F6"));
                listBox1.Items.Add("==================");
            }





            //double costNews = news.costNextUnit();
            
        }

        private void suggestButton_Click(object sender, EventArgs e)
        {

        }
    }
}
