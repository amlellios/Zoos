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
        public static int MoneyHas = 5000;
        public static int MoneySpent;
        public static int CatMoney;
        public static int CowMoney;
        public static int SalamanderMoney;
        public static int KestrelMoney;

        public static int DeerMoney;
        public static int GiftMoney;
        public static int DonationMoney=100;
        public static int GovernmentMoney=2000;
        public static int TicketSales=200;

        public static int EmployeeMoney;



        

        public Round1Summary()
        {
            InitializeComponent();
            DisplayMoney();
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
            
            MoneySpent = (CatMoney + SalamanderMoney + DeerMoney + CowMoney + KestrelMoney + (GiftMoney) + EmployeeMoney)*100 ;

            //Subtract the moneys
            MoneyHas -= MoneySpent;

            //Add the moneys

            MoneyHas += (DonationMoney + TicketSales + ((GiftMoney * 2) * 100));

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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
