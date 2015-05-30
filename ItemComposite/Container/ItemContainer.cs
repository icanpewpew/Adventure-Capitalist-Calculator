using Adventure_Capitalist_Calculator.ItemComposite.ItemHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Capitalist_Calculator.ItemComposite.Container
{

    interface GlobalStats
    {
        double angelsCount { get; set; }
        double advertismentBonus { get; set; }
        double angelsPercent { get; set; }
    }

    abstract class ItemContainer : GlobalStats
    {

        public double angelsCount { get; set; }
        public double advertismentBonus { get; set; }
        public double angelsPercent { get; set; }

        public List<ItemBase> allitems = new List<ItemBase>();

        protected abstract void setGlobalAchievmentModifier();

        /*
        MoonShoe
        GravityBooth
        PaydayClone
        MoonExpress
        OxygenBar
        Helium3Farm
        CheesMine
        AmusmentPark
        WerwolfColony
        GigantLaser
        */
        
    }
}
