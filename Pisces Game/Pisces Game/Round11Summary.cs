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
    public partial class Round11Summary : Form
    {

        public static int MoneyHas;
        public static int MoneySpent;
        public static int CatMoney;
        public static int CowMoney;
        public static int SalamanderMoney;
        public static int KestrelMoney;

        public static int DeerMoney;
        public static int GiftMoney;
        public static int DonationMoney = 100;
        public static int GovernmentMoney = 2000;
        public static int TicketSales = 200;

        public static int EmployeeMoney;



        public Round11Summary()
        {
            InitializeComponent();
        }

        public void DisplayMoney()
        {



            CatMoneyLbl.Text = Convert.ToString(CatMoney);
            SalamanderMoneyLbl.Text = Convert.ToString(SalamanderMoney);
            DeerMoneyLbl.Text = Convert.ToString(DeerMoney);
            CowMoneyLbl.Text = Convert.ToString(CowMoney);
            KestrelMoneyLbl.Text = Convert.ToString(KestrelMoney);

            GiftMoneyLbl.Text = Convert.ToString(GiftMoney);
            EmployeeMoneyLbl.Text = Convert.ToString(EmployeeMoney);
            DonationMoneyLbl.Text = Convert.ToString(DonationMoney);
            GovernmentMoneyLbl.Text = Convert.ToString(GovernmentMoney);
            TicketSalesLbl.Text = Convert.ToString(TicketSales);


        }

        public void FinalMoneys()
        {

            MoneySpent = (CatMoney + SalamanderMoney + DeerMoney + CowMoney + KestrelMoney + (GiftMoney) + EmployeeMoney) * 100;

            //Subtract the moneys
            MoneyHas -= MoneySpent;

            //Add the moneys

            MoneyHas += (GovernmentMoney + DonationMoney + TicketSales + ((GiftMoney * 2) * 100));

            //Gets the total
            MoneyHas += (Convert.ToInt32(0.3) * MoneyHas);
            TotalMoneysLbl.Text = Convert.ToString(MoneyHas);






        }



        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            Round11Surprise round3 = new Round11Surprise();
            round3.Visible = true;
            this.Hide();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GovernmentMoneyLbl_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TicketSalesLbl_Click(object sender, EventArgs e)
        {

        }

        private void TicketLbl_Click(object sender, EventArgs e)
        {

        }

        private void DonationMoneyLbl_Click(object sender, EventArgs e)
        {

        }

        private void DonationsLbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MoneyLbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TotalMoneysLbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FishTakenLbl_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeMoneyLbl_Click(object sender, EventArgs e)
        {

        }

        private void GiftMoneyLbl_Click(object sender, EventArgs e)
        {

        }

        private void KestrelMoneyLbl_Click(object sender, EventArgs e)
        {

        }

        private void CowMoneyLbl_Click(object sender, EventArgs e)
        {

        }

        private void DeerMoneyLbl_Click(object sender, EventArgs e)
        {

        }

        private void SalamanderMoneyLbl_Click(object sender, EventArgs e)
        {

        }

        private void CatMoneyLbl_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeLbl_Click(object sender, EventArgs e)
        {

        }

        private void GiftLbl_Click(object sender, EventArgs e)
        {

        }

        private void KestrelLbl_Click(object sender, EventArgs e)
        {

        }

        private void CowLbl_Click(object sender, EventArgs e)
        {

        }

        private void DeerLbl_Click(object sender, EventArgs e)
        {

        }

        private void SalamanderLbl_Click(object sender, EventArgs e)
        {

        }

        private void CatLbl_Click(object sender, EventArgs e)
        {

        }

        private void HeaderLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
