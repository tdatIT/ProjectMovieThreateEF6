using Project_LT_Windows_EF6.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWin_Last.View
{
    public partial class AddFilm : Form
    {
        public AddFilm()
        {
            InitializeComponent();
        }
        private byte[] ImageToByteArray(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
        private Image ByteArrayToImage(byte[] byteArr)
        {
            MemoryStream ms = new MemoryStream(byteArr);
            Image image = Image.FromStream(ms);
            return image;
        }
        private void AddFilm_Load(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString();
        }

		private void ptb_Anh_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog()
			{ Filter = "Image file(*.jpg)|*jpg", Multiselect = false })
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					pbx_Poster.Image = Image.FromFile(ofd.FileName);
				}
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			string tenphim = txt_Name.Text;
			string maphim = txt_ID.Text;
			string theloai = txt_Category.Text;
			double danhgia = double.Parse(txt_Rating.Text);
			string mota = rtxt_Description.Text;
			int thoiluong = Int16.Parse(txt_Minutes.Text);
			byte[] img = ImageToByteArray(pbx_Poster.Image);
			bool status = false;
			if (rbtn_Yes.Checked)
				status = true;
			//get values from controls
			using (var context = new MovieTheaterContext())
			{
				try
				{
					var film = new Movie
					{
						Id = maphim,
						Name = tenphim,
						Catagory = theloai,
						Rating = danhgia,
						Description = mota,
						Status = status,
						Poster = img,
						Minutes = thoiluong
					};
					context.Movies.Add(film);
					context.SaveChanges();
					MessageBox.Show("Thêm vào thành công !!!", "Thông báo",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					FilmForm.DelegateUpdate();
				}
				catch (Exception)
				{
					MessageBox.Show("Kiểm tra lại dữ liệu !!!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
