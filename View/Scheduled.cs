using Project_LT_Windows_EF6.Model;
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


		private void Suat_Load(object sender, EventArgs e)
		{
			initStyleDataGridView();
			txt_search.Text = DateTime.Now.ToString("dd-MM-yyyy").ToString();
			XuatThongTin();
		}
		public void XuatThongTin()
		{
			using (MovieTheaterContext dbcontext = new MovieTheaterContext())
			{
				dgv_Schedule.DataSource = dbcontext.ScheduledMovies.ToList();
				dgv_Schedule.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";
				dgv_Schedule.Columns[2].DefaultCellStyle.Format = "HH:mm:ss";
			}
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
			XuatThongTin();
			MessageBox.Show("Cập nhật thành công !!!", "Thông báo",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

        private void txt_search_Click(object sender, EventArgs e)
        {
			txt_search.Text = "";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
			using (MovieTheaterContext dbcontext = new MovieTheaterContext())
			{
				dgv_Schedule.DataSource = dbcontext.ScheduledMovies.Where(x => x.Begindate.ToString().Contains(txt_search.Text)).ToList();
			}	
		}

        private void btn_Search_Click(object sender, EventArgs e)
        {
			using (MovieTheaterContext dbcontext = new MovieTheaterContext())
			{
				DateTime dateTimeNow = DateTime.ParseExact(txt_search.Text,"dd-MM-yyyy",null);
				DateTime dateTomorrow = dateTimeNow.AddDays(1);
				dgv_Schedule.DataSource = dbcontext.ScheduledMovies.Where(x => x.Begindate <= dateTomorrow && x.Begindate >= dateTimeNow ).ToList();
							

			}
		}

        private void dgv_Schedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
			using (MovieTheaterContext dbcontext = new MovieTheaterContext())
			{
				dgv_Schedule.DataSource = dbcontext.ScheduledMovies.ToList();
				if (MessageBox.Show("Co muon xoa", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					dgv_Schedule.Rows.RemoveAt(dgv_Schedule.SelectedRows[0].Index);
				}
			}
			
        }
    }
}
