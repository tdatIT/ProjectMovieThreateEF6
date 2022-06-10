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
    public partial class CustomerForm : Form
    {
        public static int request ;
        private Customer customerselect;

        public CustomerForm()
        {
            InitializeComponent();
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Add_Customercs add_Customercs = new Add_Customercs();
            add_Customercs.Show();
            btn_Cancel.Enabled = true;
            btn_Save.Enabled = true;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Disable_save_cancel();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string C_phone = txt_C_phone_number.Text;
            using (MovieTheaterContext dbcontext = new MovieTheaterContext())
            {
                try
                {
                    var customer = dbcontext.Customers.Find(C_phone);
                    if (customer != null)
                    {
                        customerselect = customer;
                        ShowDataCustomer();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng !!!", "Thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Tải dữ liệu không thành công !!!", "Thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ShowDataCustomer()
        {
            txt_CPhoneNumber.Text = customerselect.C_phone_number;
            txt_Name.Text = customerselect.Name;
            txt_Day.Text = customerselect.Birthday.Value.Day.ToString();
            txt_Month.Text = customerselect.Birthday.Value.Month.ToString();
            txt_Year.Text = customerselect.Birthday.Value.Year.ToString();
            if (customerselect.Sex)
            {
                btn_Male.Checked = true;
            }
            else
            {
                btn_Female.Checked = true;
            }
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
       
        private void btn_Update_Click(object sender, EventArgs e)
        {
            request = 1;
            Enable_save_cancel();
        }

     

        private void save(object sender, EventArgs e)
        {
            switch(request)
            {
                case 1:
                    {
                       
                        if (ConfirmRequestByUser())
                        {
                            string phoneCustomer = txt_CPhoneNumber.Text;
                            string name = txt_Name.Text;
                            string Birth = txt_Year.Text + "-" + txt_Month.Text + "-" + txt_Day.Text;
                            DateTime date = DateTime.Parse(Birth);
                            bool sex = false;
                            if (btn_Male.Checked)
                                sex = true;
                            using (var context = new MovieTheaterContext())
                            {
                                try
                                {
                                    var Cus = context.Customers.Find(phoneCustomer);
                                    {
                                        Cus.C_phone_number = phoneCustomer;
                                        Cus.Name = name;
                                        Cus.Birthday = date;
                                        Cus.Sex = sex;
                                    };
                                    context.SaveChanges();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Kiểm tra lại dữ liệu !!!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                break;
                case 2:
                    {
                        lb_tb.Text = "Thông báo";
                    }
                    break;
            }
            Disable_save_cancel();
        }

        private void Cancle_click(object sender, EventArgs e)
        { 
            DialogResult question = MessageBox.Show("Bạn chắc chắn muốn hủy !!!", "Thất bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (question == DialogResult.OK)
            {
                ShowDataCustomer();
                Disable_save_cancel();
            }
        }
        private void Enable_save_cancel()
        {
            btn_Cancel.Enabled = true;
            btn_Save.Enabled = true;
            btn_Save.BackColor = Color.FromArgb(218, 180, 69);
            btn_Cancel.BackColor = Color.FromArgb(218, 180, 69);
            btn_Add.Enabled = false;
            btn_Del.Enabled = false;
            btn_Update.Enabled = false;

        }
        private void Disable_save_cancel()
        {
            btn_Cancel.Enabled = false;
            btn_Save.Enabled = false;
            btn_Save.BackColor = Color.Gray;
            btn_Cancel.BackColor = Color.Gray;
            btn_Add.Enabled = true;
            btn_Del.Enabled = true;
            btn_Update.Enabled = true;
            lb_tb.Text = "";
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            request = 2;
            Enable_save_cancel();
            lb_tb.Text = " Nhấp lưu để xác nhận xóa ";

        }
    }
}
