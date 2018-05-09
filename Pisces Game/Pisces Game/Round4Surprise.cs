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
    public partial class Round4Surprise : Form
    {
        public Round4Surprise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Round5 round3 = new Round5();
            round3.Visible = true;
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
