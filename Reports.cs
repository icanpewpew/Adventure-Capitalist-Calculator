using Adventure_Capitalist_Calculator.ItemComposite;
using Adventure_Capitalist_Calculator.ItemComposite.ItemHandler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Capitalist_Calculator
{


    class Reports
    {

        StreamWriter reportContent;
        string current_dir = AppDomain.CurrentDomain.BaseDirectory;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public string GetCurrentMethod()
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);

            return sf.GetMethod().Name;
        }

        public Reports()
        {
            
             
        }

        private string getFilePath(string inReportName)
        {
            string fileName = "{0}.txt";
            return current_dir + String.Format(fileName, inReportName);
        }

        public void writeEfficiencyOverLevel(ItemContainer inItemContainer)
        {

            reportContent = new System.IO.StreamWriter(getFilePath(GetCurrentMethod()), false, Encoding.UTF8);
            reportContent.WriteLine("newspaperlevel\tefficiency");

            for (int i = 1; i < 1000; i++)
            {
                inItemContainer.setNewspaperLevel(i);
                reportContent.WriteLine(inItemContainer.newspaper.level.ToString() + "\t" + inItemContainer.newspaper.getBuyEfficiency().ToString("F9"));
            }
            reportContent.Close();
        }

        public void writeAlwaysChooseTheEffItem(ItemContainer inItemContainer)
        {
            reportContent = new System.IO.StreamWriter(getFilePath(GetCurrentMethod()), false, Encoding.UTF8);
            reportContent.WriteLine("\ttotal level\ttotal revenue per second\ttotal money spend\titem choosed\titem level\titem revenue per second\titem efficiency\titem buy cost");

            double errorCorrection = 2133292;
            double totalMoneySpend = 0;
            for (int i = 1; i < 10000; i++)
            {
                ItemBase lowest = inItemContainer.getItemWithLowestEfficency();

                StringBuilder line = new StringBuilder();
                line.Append("\t" + inItemContainer.allitems.Sum(o => o.level).ToString());
                line.Append("\t" + (inItemContainer.allitems.Sum(o => o.getRevenuePerSecond()) - errorCorrection).ToString("F2"));
                line.Append("\t" + totalMoneySpend.ToString("F10").PadRight(20));
                line.Append("\t" + lowest.GetType().Name.PadRight(20));
                line.Append("\t" + lowest.level.ToString().PadRight(5));
                line.Append("\t" + lowest.getRevenuePerSecond().ToString("F2").PadRight(20));
                line.Append("\t" + lowest.getBuyEfficiency().ToString("F10").PadRight(20));
                line.Append("\t" + lowest.getBuyCost().ToString("F10").PadRight(20));

                reportContent.WriteLine(line.ToString());

                totalMoneySpend += lowest.getBuyCost();
                inItemContainer.setItemLevel(lowest, lowest.level+1);
            }
            reportContent.Close();
        }

        public void writeAlwaysChooseTheCheapestItem(ItemContainer inItemContainer)
        {
            reportContent = new System.IO.StreamWriter(getFilePath(GetCurrentMethod()), false, Encoding.UTF8);
            reportContent.WriteLine("\ttotal level\ttotal revenue per second\ttotal money spend\titem choosed\titem level\titem revenue per second\titem efficiency\titem buy cost");

            double errorCorrection = 2133292;
            double totalMoneySpend = 0;
            for (int i = 1; i < 10000; i++)
            {
                ItemBase lowest = inItemContainer.getItemWithCheapestBuyCost();

                StringBuilder line = new StringBuilder();
                line.Append("\t" + inItemContainer.allitems.Sum(o => o.level).ToString());
                line.Append("\t" + (inItemContainer.allitems.Sum(o => o.getRevenuePerSecond()) - errorCorrection).ToString("F2"));
                line.Append("\t" + totalMoneySpend.ToString("F10").PadRight(20));
                line.Append("\t" + lowest.GetType().Name.PadRight(20));
                line.Append("\t" + lowest.level.ToString().PadRight(5));
                line.Append("\t" + lowest.getRevenuePerSecond().ToString("F2").PadRight(20));
                line.Append("\t" + lowest.getBuyEfficiency().ToString("F10").PadRight(20));
                line.Append("\t" + lowest.getBuyCost().ToString("F10").PadRight(20));

                reportContent.WriteLine(line.ToString());


                totalMoneySpend += lowest.getBuyCost();
                inItemContainer.setItemLevel(lowest, lowest.level + 1);
            }

            reportContent.Close();
        }

        public void writeChooseRandom()
        {
            List<ItemContainer> allRandoms = new List<ItemContainer>();
            int totalContainerCount = 1000;


            for (int i = 0; i < totalContainerCount; i++)
                allRandoms.Add(new ItemContainer());

            reportContent = new System.IO.StreamWriter(getFilePath(GetCurrentMethod()), false, Encoding.UTF8);


            StringBuilder headerLine = new StringBuilder();
            headerLine.Append("\tlevel spend");
            reportContent.WriteLine(headerLine.ToString());

            Random random = new Random();

            //double errorCorrection = 1066647.67;
            for (int i = 1; i < 10000; i++)
            {
                foreach (ItemContainer curRandom in allRandoms)
                {
                    ItemBase curItem = curRandom.allitems[random.Next(0, curRandom.allitems.Count())];
                    curRandom.setItemLevel(curItem, curItem.level + 1);
                }
            }

            ItemContainer bestContainer = allRandoms.First(i => i.getTotalBuyEfficiency().Equals(allRandoms.Min(o => o.getTotalBuyEfficiency())));

            reportContent.WriteLine(bestContainer.levelUpPath.ToString());


            reportContent.Close();

        }

        public void writeTestStrategies()
        {
            ItemContainer effContainer = new ItemContainer();
            ItemContainer ceapBuyCostContainer = new ItemContainer();
            ItemContainer lowestLevelContainer = new ItemContainer();

            reportContent = new System.IO.StreamWriter(getFilePath(GetCurrentMethod()), false, Encoding.UTF8);


            StringBuilder headerLine = new StringBuilder();
            headerLine.Append("\tlevel spend");
            headerLine.Append("\teff revenue per second");
            headerLine.Append("\tceap revenue per second");
            headerLine.Append("\tlowest level revenue per second");
            headerLine.Append("\teff total money spend");
            headerLine.Append("\tceap total money spend");
            headerLine.Append("\tlowest level money spend");
            headerLine.Append("\teff choosen");
            headerLine.Append("\tcheap choosen");
            headerLine.Append("\tlowest level choosen");
            reportContent.WriteLine(headerLine.ToString());

            double errorCorrection = 1066647.67;
            for (int i = 1; i < 10000; i++)
            {

                StringBuilder line = new StringBuilder();
                line.Append("\t" + i);
                line.Append("\t" + (effContainer.getTotalRevenuePerSecond() - errorCorrection).ToString("F2"));
                line.Append("\t" + (ceapBuyCostContainer.getTotalRevenuePerSecond() - errorCorrection).ToString("F2"));
                line.Append("\t" + (lowestLevelContainer.getTotalRevenuePerSecond() - errorCorrection).ToString("F2"));
                line.Append("\t" + effContainer.totalMoneySpend.ToString("F10").PadRight(20));
                line.Append("\t" + ceapBuyCostContainer.totalMoneySpend.ToString("F10").PadRight(20));
                line.Append("\t" + lowestLevelContainer.totalMoneySpend.ToString("F10").PadRight(20));
                line.Append("\t" + effContainer.getItemWithLowestEfficency().GetType().Name);
                line.Append("\t" + ceapBuyCostContainer.getItemWithCheapestBuyCost().GetType().Name);
                line.Append("\t" + lowestLevelContainer.getItemWithLowestLevel().GetType().Name);

                reportContent.WriteLine(line.ToString());

                effContainer.setItemLevel(effContainer.getItemWithLowestEfficency(), effContainer.getItemWithLowestEfficency().level + 1);
                ceapBuyCostContainer.setItemLevel(ceapBuyCostContainer.getItemWithCheapestBuyCost(), ceapBuyCostContainer.getItemWithCheapestBuyCost().level + 1);
                lowestLevelContainer.setItemLevel(lowestLevelContainer.getItemWithLowestLevel(), lowestLevelContainer.getItemWithLowestLevel().level + 1);

            }

            reportContent.Close();


        }

    }
}
