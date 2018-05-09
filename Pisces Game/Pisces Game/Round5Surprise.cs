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
    public partial class Round5Surprise : Form
    {
        public Round5Surprise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Round6 round3 = new Round6();
            round3.Visible = true;
            this.Hide();
        }
    }
}
