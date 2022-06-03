using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWin_Last
{
    public partial class Suat : Form
    {
        public Suat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSuat addSuat = new AddSuat();
            addSuat.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
