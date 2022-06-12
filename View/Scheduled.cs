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

		private void txt_search_TextChanged(object sender, EventArgs e)
		{

		}

		private void Suat_Load(object sender, EventArgs e)
		{
			initStyleDataGridView();	
		}
		void initStyleDataGridView()
		{
			
			dgv_Schedule.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
			dgv_Schedule.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
			dgv_Schedule.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 30, 30);
			dgv_Schedule.BackgroundColor = Color.White;
			//style rows
			dgv_Schedule.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dgv_Schedule.EnableHeadersVisualStyles = false;
			dgv_Schedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			//style header
			dgv_Schedule.ColumnHeadersDefaultCellStyle.Font = new Font("Be VietNam Pro", 10);
			dgv_Schedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 33, 59);
			dgv_Schedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
		}

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }
    }
}
