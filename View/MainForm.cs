using LTWin_Last.View;
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
    public partial class MainForm : Form
    {
		private Employee employee;
        private Button currentBtn;
        private Form activeForm = new Form();
        public MainForm(Employee employee)
        {
			this.employee = employee;
			InitializeComponent();
            bnt_Back.Visible = false;
        }

        private void disableButton()
        {
            foreach (Control prevBtn in pn_menu.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.MediumAquamarine;
                    prevBtn.ForeColor = Color.Black;
                }
            }
        }
        private void activeButton(Object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    disableButton();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = Color.FromArgb(16, 65, 39);
                    currentBtn.ForeColor = Color.White;
                    bnt_Back.Visible = true;
                }
            }
        }
        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_child.Controls.Add(childForm);
            pn_child.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           
        }

        private void btn_Suat_Click(object sender, EventArgs e)
        {
            openChildForm(new Suat(), sender);
			lbl_Title.Text = "LỊCH CHIẾU";
		}

        private void btn_KH_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm(), sender);
			lbl_Title.Text = "KHÁCH HÀNG";
		}

        private void btn_Phim_Click(object sender, EventArgs e)
        {
            openChildForm(new Phim(), sender);
			lbl_Title.Text = "PHIM";

		}

        private void btn_Ptich_Click(object sender, EventArgs e)
        {
            openChildForm(new Analystic(), sender);
			lbl_Title.Text = "PHÂN TÍCH DỮ LIỆU";
		}

        private void bnt_Back_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            disableButton();
            lbl_Title.Text = "TRANG CHỦ";
            currentBtn = null;
            bnt_Back.Visible = false;
        }

		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lb_Time.Text = DateTime.Now.ToString();
		}

		private void lb_Time_Click(object sender, EventArgs e)
		{

		}

		private void pn_title_Paint(object sender, PaintEventArgs e)
		{

		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			lb_Time.Text = DateTime.Now.ToString();
			lb_name.Text = this.employee.Name;
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			AddFilm addFilm = new AddFilm();
			addFilm.Visible = true;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AddSuat addSuat = new AddSuat();
			addSuat.Visible = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Add_Customercs add_Customercs = new Add_Customercs();
			add_Customercs.Visible = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			openChildForm(new Book(), sender);
			lbl_Title.Text = "Đặt vé";
		}

		private void lbl_Title_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}
