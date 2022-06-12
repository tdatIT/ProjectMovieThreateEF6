using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWin_Last.Controller
{
	public class WriteFileExcel
	{
		public void WriteToExcel(DataGridView dgv, string filename)
		{
			Microsoft.Office.Interop.Excel.Application excel;
			Microsoft.Office.Interop.Excel.Workbook workbook;
			Microsoft.Office.Interop.Excel.Worksheet worksheet;
			try
			{
				//Tạo đối tượng COM.
				excel = new Microsoft.Office.Interop.Excel.Application();
				excel.Visible = false;
				excel.DisplayAlerts = false;
				//tạo mới một Workbooks bằng phương thức add()
				workbook = excel.Workbooks.Add(Type.Missing);
				worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];	
				//đặt tên cho sheet
				worksheet.Name = "Sheet1";

				// export header trong DataGridView
				for (int i = 0; i < dgv.ColumnCount; i++)
				{
					worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
				}
				// export nội dung trong DataGridView
				for (int i = 0; i < dgv.RowCount; i++)
				{
					for (int j = 0; j < dgv.ColumnCount; j++)
					{
						worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
					}
				}
				// sử dụng phương thức SaveAs() để lưu workbook với filename
				workbook.SaveAs(filename);
				//đóng workbook
				workbook.Close();
				excel.Quit();
				MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				workbook = null;
				worksheet = null;
			}
		}

	}

}

