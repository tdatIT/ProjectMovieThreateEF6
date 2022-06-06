using LTWin_Last.View;
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
    public partial class Phim : Form
    {
        public Phim()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ChiTietPhim frm_ChiTietPhim = new frm_ChiTietPhim();
            frm_ChiTietPhim.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		
		}

		private void txt_search_MouseClick(object sender, MouseEventArgs e)
		{
		
		}

		private void comboBox1_Click(object sender, EventArgs e)
		{
			if(cbx_search.Text.Equals("Tên phim"))
			{
				cbx_search.Text = "";
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_TextChanged(object sender, EventArgs e)
		{

			cbx_search.Font = new Font("Be VietNam Pro", cbx_search.Font.Size, FontStyle.Regular);
			cbx_search.ForeColor = Color.Black;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			frm_ChiTietPhim frm_ChiTietPhim = new frm_ChiTietPhim();
			frm_ChiTietPhim.Show();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			AddFilm addFilm = new AddFilm();
			addFilm.Show();
		}
	}
}
