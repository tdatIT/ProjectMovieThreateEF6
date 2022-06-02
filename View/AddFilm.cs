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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            { Filter = "Image file(*.png)|*png", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ptbAnh.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
    }
}
