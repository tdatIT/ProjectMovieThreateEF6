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
    public partial class Add_Customercs : Form
    {
        public Add_Customercs()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string phone_cus = txt_C_phone_number.Text;
            string name = txt_Name.Text;
            string Birth = year.Text + "-" + month.Text + "-" + day.Text;
            DateTime date = DateTime.Parse(Birth);


            bool sex = false;
            if (btn_Male.Checked)
                sex = true;
            using (var context = new MovieTheaterContext())
            {
                try
                {
                    var Cus = new Customer
                    {
                        C_phone_number = phone_cus,
                        Name = name,
                        Birthday = date,
                        Sex = sex
                    };
                    context.Customers.Add(Cus);
                    context.SaveChanges();
                    MessageBox.Show("Thêm vào thành công !!!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Kiểm tra lại dữ liệu !!!", "Thất bại", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
        }

        private void Add_Customercs_Load(object sender, EventArgs e)
        {

        }
    }
}
