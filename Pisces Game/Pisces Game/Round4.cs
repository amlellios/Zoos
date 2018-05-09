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
    public partial class Round4 : Form
    {



        public static int MoneySpent;
        public static int CatMoney;
        public static int CowMoney;
        public static int SalamanderMoney;
        public static int KestrelMoney;

        public static int DeerMoney;
        public static int GiftMoney;

        public static int EmployeeMoney;


        public Round4()
        {
            InitializeComponent();
        }




        private void SalamanderButton2_Click(object sender, EventArgs e)
        {
            SalamanderMoney = Convert.ToInt32(Salamanderbox.Value);
        }

        private void CatButton2_Click(object sender, EventArgs e)
        {
            CatMoney = Convert.ToInt32(Catbox.Value);
        }

        private void DeerButton2_Click(object sender, EventArgs e)
        {
            DeerMoney = Convert.ToInt32(Deerbox.Value);
        }

        private void KestrelButton2_Click(object sender, EventArgs e)
        {
            KestrelMoney = Convert.ToInt32(Kestrelbox.Value);
        }

        private void GiftButton2_Click(object sender, EventArgs e)
        {
            GiftMoney = Convert.ToInt32(Giftbox.Value);
        }

        private void EmployeeButton2_Click(object sender, EventArgs e)
        {
            EmployeeMoney = Convert.ToInt32(Employeebox.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Round4Summary roundS6 = new Round4Summary();
            roundS6.Visible = true;
            this.Hide();
        }

        private void CowButton2_Click(object sender, EventArgs e)
        {
            CowMoney = Convert.ToInt32(Cowbox2.Value);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void KestrelButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
