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

namespace LTWin_Last.View
{
	public partial class Login : Form
	{

		public Login()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			string username = txt_username.Text;
			string pass = txt_password.Text;
			using (MovieTheaterContext context = new MovieTheaterContext())
			{
				var account = context.Employees
					.Where(t => t.Username.Equals(username))
					.FirstOrDefault();
				if (account!=null && account.Password.Trim() == pass)
				{
					MainForm mainForm = new MainForm(account);
					mainForm.Show();
					this.Hide();
				}
				else
					MessageBox.Show("Sai tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
