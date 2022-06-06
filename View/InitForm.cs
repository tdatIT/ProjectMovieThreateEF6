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
	public partial class InitForm : Form
	{
		public InitForm()
		{
			InitializeComponent();
		}

		private void InitForm_Load(object sender, EventArgs e)
		{
			
		}
		private void InitForm_Shown(object sender, EventArgs e)
		{
			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			
		}

		private void timer1_Tick_1(object sender, EventArgs e)
		{
			timer1.Stop();
			timer1.Enabled = false;
			using (MovieTheaterContext context = new MovieTheaterContext())
			{
				context.Database.CreateIfNotExists();
				var dbExists = context.Database.Exists();
				if (dbExists == true)
				{
					this.Visible = false;
					Login login = new Login();
					login.Show();
				}
				else
				{
					MessageBox.Show("Lỗi kết nối / khởi tạo CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
