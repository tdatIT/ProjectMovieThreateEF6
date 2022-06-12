using LTWin_Last.Controller;
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

namespace LTWin_Last.View
{

    public partial class EmployeeMangerment : Form
    {
        private QueryData queryData;
		private WriteFileExcel fileExcel;
        public static int request;
        public EmployeeMangerment()
        {
            InitializeComponent();
            queryData = new QueryData();
			fileExcel = new WriteFileExcel();
        }

        private void EmployeeMangerment_Load(object sender, EventArgs e)
        {
            dgv.DataSource = queryData.GetAllEmployee();
            Disable_save_cancel();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            txt_id.Text = "Auto";
            txt_Name.Text = "";
            txt_Birthday.Text = "";
            txt_Username.Text = "";
            txt_Pass.Text = "";
            txt_Job.Text = "";
            txt_Salary.Text = "";
            rbtn_Nam.Checked = false;
            rbtn_Nu.Checked = false;
            Enable_save_cancel();
            request = 2;
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
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void Cell_click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                txt_id.Text = row.Cells[0].Value.ToString();
                txt_Name.Text = row.Cells[1].Value.ToString();
                txt_Birthday.Text = row.Cells[2].Value.ToString();
                txt_Username.Text = row.Cells[4].Value.ToString();
                txt_Pass.Text = row.Cells[5].Value.ToString();
                txt_Job.Text = row.Cells[6].Value.ToString();
                txt_Salary.Text = row.Cells[7].Value.ToString();
                string sex = row.Cells[3].Value.ToString();
                if(sex == "False")
                {
                    rbtn_Nam.Checked = true;
                }
                else
                {
                    rbtn_Nu.Checked= true;
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            request = 1;
            Enable_save_cancel();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
           
                switch (request)
                {
                    case 1 : 
                        {

                        if (ConfirmRequestByUser())
                        {
                            var contextDelete = new MovieTheaterContext();
                            var employ = contextDelete.Employees.Find(int.Parse(txt_id.Text));
                            contextDelete.Employees.Remove(employ);
                            contextDelete.SaveChanges();
                            string Name = txt_Name.Text;
                            DateTime birth = DateTime.Parse(txt_Birthday.Text);
                            string job = txt_Job.Text;
                            string username = txt_Username.Text;
                            string password = txt_Pass.Text;
                            double salary = double.Parse(txt_Salary.Text);
                            bool sex = true;
                            if (rbtn_Nam.Checked)
                            {
                                sex = false;
                            }
                            using (var context = new MovieTheaterContext())
                            {
                                try
                                {
                                    var Employee = new Employee
                                    {
                                        Name = Name,
                                        Birthday = birth,
                                        Job = job,
                                        Username = username,
                                        Password = password,
                                        Salary = salary,
                                        sex = sex
                                    };
                                    context.Employees.Add(Employee);
                                    context.SaveChanges();
                                    MessageBox.Show("Đã lưu !!!", "Thông báo",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        
                        string Name = txt_Name.Text;
                        DateTime birth = DateTime.Parse(txt_Birthday.Text);
                        string job = txt_Job.Text;
                        string username = txt_Username.Text;
                        string password = txt_Pass.Text;
                        double salary = double.Parse(txt_Salary.Text);
                        bool sex = false;
                        if (rbtn_Nu.Checked)
                        {
                            sex = true;
                        }
                        using (var context = new MovieTheaterContext())
                        {
                            try
                            {
                                var Employee = new Employee
                                {
                                    Name = Name,
                                    Birthday = birth,
                                    Job = job,
                                    Username = username,
                                    Password = password,
                                    Salary = salary,
                                    sex = sex
                                };
                                context.Employees.Add(Employee);
                                context.SaveChanges();
                                MessageBox.Show("Đã lưu !!!", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Kiểm tra lại dữ liệu !!!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    break;
                case 3:
                    {
                        DateTime birth = DateTime.Parse(txt_Birthday.Text);
                        using (var context = new MovieTheaterContext())
                        {
                            try
                            {
                                var employ = context.Employees.Find(int.Parse(txt_id.Text));
                                context.Employees.Remove(employ);
                                context.SaveChanges();
                                MessageBox.Show("Xóa thành công !!!", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Kiểm tra lại dữ liệu !!!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    break;

                }
            Disable_save_cancel();
            dgv.DataSource = queryData.GetAllEmployee();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Bạn chắc chắn muốn hủy !!!", "Thất bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (question == DialogResult.OK)
            {
                txt_id.Text ="";
                txt_Name.Text = "";
                txt_Birthday.Text = "";
                txt_Username.Text = "";
                txt_Pass.Text = "";
                txt_Job.Text = "";
                txt_Salary.Text = "";
                rbtn_Nam.Checked = false;
                rbtn_Nu.Checked = false;
                Disable_save_cancel();
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            request =  3;
            Enable_save_cancel();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "Excel File(*.xlsx)|*.xlsx|All files (*.*)|*.*";
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				fileExcel.WriteToExcel(dgv, saveFileDialog1.FileName);
			}
		}

		private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
