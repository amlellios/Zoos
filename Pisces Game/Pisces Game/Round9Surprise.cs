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
    public partial class Round9Surprise : Form
    {
        public Round9Surprise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Round10 round3 = new Round10();
            round3.Visible = true;
            this.Hide();
        }
    }
}
