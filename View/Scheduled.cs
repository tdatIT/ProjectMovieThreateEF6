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
			
			dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
			dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
			dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 30, 30);
			dataGridView1.BackgroundColor = Color.White;
			//style rows
			dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridView1.EnableHeadersVisualStyles = false;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			//style header
			dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Be VietNam Pro", 10);
			dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 33, 59);
			dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
		}
	}
}
