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
    public partial class Round2 : Form
    {


        public static int MoneySpent;
        public static int CatMoney;
        public static int CowMoney;
        public static int SalamanderMoney;
        public static int KestrelMoney;

        public static int DeerMoney;
        public static int GiftMoney;

        public static int EmployeeMoney;


        public Round2()
        {
            InitializeComponent();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

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
            Round2Summary roundS2 = new Round2Summary();
            roundS2.Visible = true;
            this.Hide();
        }

        private void CowButton2_Click(object sender, EventArgs e)
        {
            CowMoney = Convert.ToInt32(Cowbox2.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Catbox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Deerbox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Kestrelbox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Salamanderbox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Employeebox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Giftbox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
