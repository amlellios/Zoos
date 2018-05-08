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

        public Round1()
        {
            InitializeComponent();

        
        }

        //private void eatFishBtn_Click(object sender, EventArgs e)
        //{
        //    if (eatFishBox.Value < 6)
        //    {
        //        eatFishLbl.Visible = true;
        //        eatFishLbl.Text = "";
        //    }
        //    else if (eatFishBox.Value > 6)
        //    {
        //        eatFishLbl.Visible = true;
        //        eatFishLbl.Text = "You ate more than enough to survive";
        //        eatFishBtn.Visible = false;
                
        //    }
        //    else if (eatFishBox.Value > 12)
        //    {
        //        eatFishLbl.Visible = true;
        //        eatFishLbl.Text = "That's way too many fish...";
        //    }
        //    else
        //    {
        //        eatFishLbl.Visible = true;
        //        eatFishLbl.Text = "You ate enough to survive.";
        //        eatFishBtn.Visible = false;
                
        //    }
        //    playerFishTaken = Convert.ToInt32(eatFishBox.Value);
        //}

        private void round1EndBtn_Click(object sender, EventArgs e)
        {
            
            Round2 round2 = new Round2();
            round2.Visible = true;
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
            MoneySpent = Convert.ToInt32(CatBox.Value);
        }

        private void CowButton_Click(object sender, EventArgs e)
        {
      
            MoneySpent = Convert.ToInt32(CatBox.Value);
        }

        private void DeerButton_Click(object sender, EventArgs e)
        {
            MoneySpent = Convert.ToInt32(CatBox.Value);
        }

        private void KestrelButton_Click(object sender, EventArgs e)
        {
            MoneySpent = Convert.ToInt32(CatBox.Value);
        }

        private void SalamanderButton_Click(object sender, EventArgs e)
        {
            MoneySpent = Convert.ToInt32(CatBox.Value);
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            MoneySpent = Convert.ToInt32(CatBox.Value);
        }

        private void GiftShopButton_Click(object sender, EventArgs e)
        {
            MoneySpent = Convert.ToInt32(CatBox.Value);
        }

        private void Round1_Load(object sender, EventArgs e)
        {

        }
    }
}
