using LTWin_Last.View;
using Project_LT_Windows_EF6.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWin_Last
{
	public delegate void UpdateMoivesData();
    public partial class Phim : Form
    {
		public static UpdateMoivesData DelegateUpdate;	
		private List<Movie> movies;
		private Movie movieSelected;
		private int index = 0;

        public Phim()
        {
            InitializeComponent();
			GetDataMovies();
			ShowMovieInPanel();
			DelegateUpdate = new UpdateMoivesData(GetDataMovies);
			AddSourceIntoCbxSearch();
		}
	
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
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
			frm_ChiTietPhim frm_ChiTietPhim = new frm_ChiTietPhim(movieSelected);
			frm_ChiTietPhim.Show();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			AddFilm addFilm = new AddFilm();
			addFilm.Show();
		}
		private void ShowMovieInPanel()
		{
			movieSelected = movies.ElementAt(index);
			pbx_Poster.Image = ByteArrayToImage(movieSelected.Poster);
		}
		private void GetDataMovies()
		{
			using (MovieTheaterContext dbcontext = new MovieTheaterContext())
			{
				try
				{
					movies = dbcontext.Movies.ToList();
					movieSelected = movies.ElementAt(index);
					return;
				}
				catch (Exception)
				{
					MessageBox.Show("Tải dữ liệu !!!", "Thất bại", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				movies = null;
			}

		}
		private Image ByteArrayToImage(byte[] byteArr)
		{
			MemoryStream ms = new MemoryStream(byteArr);
			Image image = Image.FromStream(ms);
			return image;
		}

		private void btn_Previous_Click(object sender, EventArgs e)
		{
			if (index > 0)
				index--;
			ShowMovieInPanel();
		}

		private void btn_Foward_Click(object sender, EventArgs e)
		{
			if (index < movies.Count-1)
				index++;
			ShowMovieInPanel();
		}
		private void AddSourceIntoCbxSearch()
		{
			foreach(var i in movies)
			{
				cbx_search.Items.Add(i.Name);
			}
		}

		private void btn_Search_Click(object sender, EventArgs e)
		{
			using (MovieTheaterContext dbcontext = new MovieTheaterContext())
			{
				try
				{
					movies = (from i in dbcontext.Movies
							   where i.Name.Contains(cbx_search.Text)
							   select i).ToList();

					index = 0;
					ShowMovieInPanel();
				}
				catch (Exception)
				{
					MessageBox.Show("Tải dữ liệu không thành công !!!", "Thất bại",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
