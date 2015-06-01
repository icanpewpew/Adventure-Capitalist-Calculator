using Adventure_Capitalist_Calculator.ItemComposite.Container;
using Adventure_Capitalist_Calculator.ItemComposite.ItemHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Capitalist_Calculator.ItemComposite
{
    class MoonItemContainer : ItemContainer
    {
        public MoonShoe moonShoe { get; set; }
        public GravityBooth gravityBooth { get; set; }
        public PaydayClone paydayClone { get; set; }
        public MoonExpress moonExpress { get; set; }
        public OxygenBar oxygenBar { get; set; }
        public Helium3Farm helium3Farm { get; set; }
        public CheesMine cheesMine { get; set; }
        public AmusmentPark amusmentPark { get; set; }
        public WerwolfColony werwolfColony { get; set; }
        public GigantLaser gigantLaser { get; set; }

        public void setMoonShoeLevel(double inLevel) { setItemLevel(moonShoe, inLevel); }
        public void setGravityBoothLevel(double inLevel) { setItemLevel(gravityBooth, inLevel); }
        public void setPaydayCloneLevel(double inLevel) { setItemLevel(paydayClone, inLevel); }
        public void setMoonExpressLevel(double inLevel) { setItemLevel(moonExpress, inLevel); }
        public void setOxygenBarLevel(double inLevel) { setItemLevel(oxygenBar, inLevel); }
        public void setHelium3FarmLevel(double inLevel) { setItemLevel(helium3Farm, inLevel); }
        public void setCheesMineLevel(double inLevel) { setItemLevel(cheesMine, inLevel); }
        public void setAmusmentParkLevel(double inLevel) { setItemLevel(amusmentPark, inLevel); }
        public void setWerwolfColonyLevel(double inLevel) { setItemLevel(werwolfColony, inLevel); }
        public void setGigantLaserLevel(double inLevel) { setItemLevel(gigantLaser, inLevel); }

        public MoonItemContainer()
        {
            moonShoe = new MoonShoe(this);
            gravityBooth = new GravityBooth(this);
            paydayClone = new PaydayClone(this);
            moonExpress = new MoonExpress(this);
            oxygenBar = new OxygenBar(this);
            helium3Farm = new Helium3Farm(this);
            cheesMine = new CheesMine(this);
            amusmentPark = new AmusmentPark(this);
            werwolfColony = new WerwolfColony(this);
            gigantLaser = new GigantLaser(this);

            allitems.Add(moonShoe);
            allitems.Add(gravityBooth);
            allitems.Add(paydayClone);
            allitems.Add(moonExpress);
            allitems.Add(oxygenBar);
            allitems.Add(helium3Farm);
            allitems.Add(cheesMine);
            allitems.Add(amusmentPark);
            allitems.Add(werwolfColony);
            allitems.Add(gigantLaser);
        }

        protected override void setGlobalAchievmentModifier()
        {
            double resultRevenue = 1;
            double resultSpeed = 1;

            double lowestLevel = allitems.Min(i => i.level);

            if (lowestLevel >= 5) resultSpeed *= 2;
            if (lowestLevel >= 25) resultSpeed *= 2;

            if (lowestLevel >= 100) resultSpeed *= 2;
            if (lowestLevel >= 200) resultSpeed *= 2;
            if (lowestLevel >= 300) resultSpeed *= 2;
            if (lowestLevel >= 400) resultSpeed *= 2;
            if (lowestLevel >= 500) resultSpeed *= 2;
            if (lowestLevel >= 600) resultSpeed *= 2;
            if (lowestLevel >= 700) resultSpeed *= 2;
            if (lowestLevel >= 800) resultSpeed *= 2;
            if (lowestLevel >= 900) resultSpeed *= 2;

            if (lowestLevel >= 1000) resultSpeed *= 2;
            if (lowestLevel >= 1111) resultSpeed *= 2;


            GlobalAchievmentRevenueModifier = resultRevenue;
            GlobalAchievmentSpeedModifier = resultSpeed;
        }

        protected override void setCashUpgradeLevel(double inCashUpgradeLevel)
        {
            allitems.ForEach(i => i.cashUpgradeModifier = 1);
            angelsPercent = 2;

            //if (inCashUpgradeLevel >= 2) lemonStand.cashUpgradeModifier *= 3;

        }

    }
}
