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
    public partial class Round10Summary : Form
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



        public Round10Summary()
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



        private void Round10Summary_Load(object sender, EventArgs e)
        {

        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            Round10Surprise round3 = new Round10Surprise();
            round3.Visible = true;
            this.Hide();
        }
    }
}
