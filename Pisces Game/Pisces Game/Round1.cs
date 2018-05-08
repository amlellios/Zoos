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
    public partial class Round1 : Form
    {
                
        public static int MoneySpent;
        public static int CatMoney;
        public static int CowMoney;
        public static int SalamanderMoney;
        public static int KestrelMoney;

        public static int DeerMoney;
        public static int GiftMoney;
        
        public static int EmployeeMoney;
        

        public Round1()
        {
            InitializeComponent();

        
        }


        private void round1EndBtn_Click(object sender, EventArgs e)
        {

            Round1Summary roundS1 = new Round1Summary();
            roundS1.Visible = true;
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatMoney = Convert.ToInt32(CatBox.Value);
        }

        private void CowButton_Click(object sender, EventArgs e)
        {
      
            CowMoney = Convert.ToInt32(CowBox.Value);
        }

        private void DeerButton_Click(object sender, EventArgs e)
        {
            DeerMoney = Convert.ToInt32(DeerBox.Value);
        }

        private void KestrelButton_Click(object sender, EventArgs e)
        {
            KestrelMoney = Convert.ToInt32(KestrelBox.Value);
        }

        private void SalamanderButton_Click(object sender, EventArgs e)
        {
            SalamanderMoney = Convert.ToInt32(SalamanderBox.Value);
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            EmployeeMoney = Convert.ToInt32(EmployeeBox.Value);
        }

        private void GiftShopButton_Click(object sender, EventArgs e)
        {
            GiftMoney = Convert.ToInt32(GiftShopBox.Value);
        }

        private void Round1_Load(object sender, EventArgs e)
        {

        }

        private void KestrelBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
