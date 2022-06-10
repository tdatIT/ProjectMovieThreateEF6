using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWin_Last.View
{
    public partial class EmployeeMangerment : Form
    {
        public EmployeeMangerment()
        {
            InitializeComponent();
        }

        private void EmployeeMangerment_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string Name = txt_Name.Text;
            DateTime birth = DateTime.Parse(txt_Birthday.Text);
            
        }
    }
}
