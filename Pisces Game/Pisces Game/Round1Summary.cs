using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pisces_Game
{
    public partial class Round1Summary : Form
    {
        public static int MoneyHas = 5000;    //How many fish are in communal lake

        //Create values for each sign
       

        public int MoneySpent;

        public Round1Summary()
        {
            InitializeComponent();
            DisplayFish();
        }

        //Insert random somewhere in here


        //public void DeterminePlayerSign()
        //{
        //    //Figures out which sign the player is
        //    if (Instructions.playerZodiacSign == "Aries")
        //    {
        //        AriesFish = Round1.playerFishTaken;
        //    }
        //    if (Instructions.playerZodiacSign == "Taurus")
        //    {
        //        TaurusFish = Round1.playerFishTaken;
        //    }
        //    if (Instructions.playerZodiacSign == "Gemini")
        //    {
        //        GeminiFish = Round1.playerFishTaken;
        //    }
        //    if (Instructions.playerZodiacSign == "Cancer")
        //    {
        //        CancerFish = Round1.playerFishTaken;
        //    }
        //    if (Instructions.playerZodiacSign == "Leo")
        //    {
        //        LeoFish = Round1.playerFishTaken;
        //    }
        //    if (Instructions.playerZodiacSign == "Virgo")
        //    {
        //        VirgoFish = Round1.playerFishTaken;
        //    }
        //    if (Instructions.playerZodiacSign == "Libra")
        //    {
        //        LibraFish = Round1.playerFishTaken;
        //    }
        //    if (Instructions.playerZodiacSign == "Scorpio")
        //    {
        //        ScorpioFish = Round1.playerFishTaken;
        //    }
        //    if (Instructions.playerZodiacSign == "Sagittarius")
        //    {

        //        SagittariusFish = Round1.playerFishTaken;
        //    }
        //    if (Instructions.playerZodiacSign == "Capricorn")
        //    {
        //        CapricornFish = Round1.playerFishTaken;
        //    }
        //    if (Instructions.playerZodiacSign == "Aquarius")
        //    {
        //        AquariusFish = Round1.playerFishTaken;
        //    }
        //    if (Instructions.playerZodiacSign == "Pisces")
        //    {
        //        PiscesFish = Round1.playerFishTaken;
        //    }
        //}

        public void DisplayFish()
        {
            

            //Display everyones fish
            CatMoneyLbl.Text = Convert.ToString(CatMoney);
            SalamanderMoneyLbl.Text = Convert.ToString(SalamanderMoney);
            DeerMoneyLbl.Text = Convert.ToString(DeerMoney);
            CowMoneyLbl.Text = Convert.ToString(CancerFish);
            KestrelMoneyLbl.Text = Convert.ToString(LeoFish);
            VirFishLbl.Text = Convert.ToString(VirgoFish);
            GiftMoneyLbl.Text = Convert.ToString(LibraFish);
            EmployeeMoneyLbl.Text = Convert.ToString(ScorpioFish);
            SagFishLbl.Text = Convert.ToString(SagittariusFish);
            CapFishLbl.Text = Convert.ToString(CapricornFish);
            AquaFishLbl.Text = Convert.ToString(AquariusFish);
            PiscFishLbl.Text = Convert.ToString(PiscesFish);

            TotalFishInPond();
        }

        public void FinalMoneys()
        {
            //Add all the comp fish
            MoneySpent = CatMoney + TaurusFish + GeminiFish + CancerFish + LeoFish + VirgoFish + LibraFish + ScorpioFish + SagittariusFish + CapricornFish + AquariusFish + PiscesFish;

            //Subtracts fish from total
            MoneyHas -= MoneySpent;

            //Gets the total
            MoneyHas += (Convert.ToInt32(0.3) * MoneyHas);
            TotalMoneysLbl.Text = Convert.ToString(MoneyHas);
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            Round2 round2 = new Round2();
            round2.Visible = true;
            this.Hide();
        }

        private void AriesLbl_Click(object sender, EventArgs e)
        {

        }

        private void Round1Summary_Load(object sender, EventArgs e)
        {

        }

        private void AriesFishLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
