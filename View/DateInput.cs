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
	public partial class DateInput : Form
	{
		public static int request=0;
		

		public DateInput()
		{
			InitializeComponent();
		}

		private void DateInput_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Analystic.dateRequest = dateTimePicker1.Value;
			Analystic.funcDate();
			Dispose();
		}
	}
}
