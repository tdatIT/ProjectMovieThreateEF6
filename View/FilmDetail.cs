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

namespace LTWin_Last
{
	public partial class frm_ChiTietPhim : Form
	{
		private Movie mvEdit;
		public frm_ChiTietPhim(Movie movieSelected)
		{
			InitializeComponent();
			mvEdit = movieSelected;

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void frm_ChiTietPhim_Load(object sender, EventArgs e)
		{
			txt_Name.Text = mvEdit.Name;
			txt_ID.Text = mvEdit.Id;
			txt_Category.Text = mvEdit.Catagory;
			txt_Rating.Text = mvEdit.Rating + "";
			txt_Minutes.Text = mvEdit.Minutes + "";
			rtxt_Description.Text = mvEdit.Description;
			pbx_Poster.Image = ByteArrayToImage(mvEdit.Poster);
			if (mvEdit.Status)
				rbtn_Yes.Checked = true;
			else
				rbtn_No.Checked = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (ConfirmRequestByUser())
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
						var film = context.Movies.Find(maphim);

						film.Name = tenphim;
						film.Catagory = theloai;
						film.Rating = danhgia;
						film.Description = mota;
						film.Status = status;
						film.Poster = img;
						film.Minutes = thoiluong;
						context.SaveChanges();
						MessageBox.Show("Cập nhật thành công !!!", "Thông báo",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						Phim.DelegateUpdate();
					}
					catch (Exception)
					{
						MessageBox.Show("Kiểm tra lại dữ liệu !!!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}
		private bool ConfirmRequestByUser()
		{
			DialogResult cnfrm = MessageBox.Show("Bạn có chắc thay đổi dữ liệu", "Xác nhận",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (cnfrm == DialogResult.OK)
			{
				return true;
			}
			return false;
		}
		private Image ByteArrayToImage(byte[] byteArr)
		{
			MemoryStream ms = new MemoryStream(byteArr);
			Image image = Image.FromStream(ms);
			return image;
		}
		private byte[] ImageToByteArray(Image image)
		{
			MemoryStream ms = new MemoryStream();
			image.Save(ms, ImageFormat.Png);
			return ms.ToArray();
		}

		private void pbx_Poster_Click(object sender, EventArgs e)
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
	}
}
