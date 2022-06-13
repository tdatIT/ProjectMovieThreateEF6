using LTWin_Last.Controller;
using LTWin_Last.View;
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
	public delegate void DFuncDate();
    public partial class Analystic : Form
    {
		//delegate - static variable for pass value to btw diff form
		public static DFuncDate funcDate;
		public static DateTime dateRequest;
		//
		private WriteFileExcel writefile;
		private QueryData queryData;
		
        public Analystic()
        {
            InitializeComponent();
			writefile = new WriteFileExcel();
			queryData = new QueryData();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
			
        }

		private void btn_Output_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "Excel File(*.xlsx)|*.xlsx|All files (*.*)|*.*";
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				writefile.WriteToExcel(dgv_Result, saveFileDialog1.FileName);
			}
			
		}

		private void Analystic_Load(object sender, EventArgs e)
		{
			cbx_Func.SelectedIndex = 0;
		}

        private void btn_Search_Click(object sender, EventArgs e)
        {
			string choice = cbx_Func.Text;
			switch(choice)
            {
				case "Quản lý nhân viên":
                    {
						EmployeeMangerment employeee = new EmployeeMangerment();
						employeee.Show();
                    }
					break;
				case "Xem số lượng vé bán trong ngày":
					{
						funcDate = new DFuncDate(LoadThongTinVeBanTrongNgay);
						DateInput form = new DateInput();
						form.Show();
					}
					break;
				case "Xem doanh thu của rạp trong trong tháng":
					{
						funcDate = new DFuncDate(LoadDoanhThuTrongThang);
						DateInput form = new DateInput();
						form.Show();
					}
					break;
				case "Tiền lương phải trả cho nhân viên trong tháng":
					{
						funcDate = new DFuncDate(LoadLuongNhanVien);
						DateInput form = new DateInput();
						form.Show();
					}
					break;
				case "Top những phim được xem nhiều trong năm":
					{
						funcDate = new DFuncDate(LoadPhimTrongNam);
						DateInput form = new DateInput();
						form.Show();
					}
					break;

			}
        }
		private void LoadThongTinVeBanTrongNgay()
		{
			dgv_Result.DataSource = queryData.ThongTinVeBanTrongNgay(dateRequest);
		}
		private void LoadDoanhThuTrongThang()
		{
			dgv_Result.DataSource = queryData.ThongDoanhThuRapTrongThang(dateRequest);
		}
		private void LoadLuongNhanVien()
		{
			dgv_Result.DataSource = queryData.ThongTinLuongNhanVien(dateRequest);
		}
		private void LoadPhimTrongNam()
		{
			dgv_Result.DataSource = queryData.PhimXemNhieuTrongNam(dateRequest);
		}
	}
}
