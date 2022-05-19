using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyPhongMach
{
    public partial class TraCuuDonThuoc : Form
    {
        public TraCuuDonThuoc()
        {
            InitializeComponent();
        }

        private void TraCuuDonThuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongMachDataSet.DonThuoc' table. You can move, or remove it, as needed.
            this.donThuocTableAdapter.Fill(this.quanLyPhongMachDataSet.DonThuoc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();

            // Thêm file temp xls
            COMExcel.Workbook exBook = exApp.Workbooks.Add(
                      COMExcel.XlWBATemplate.xlWBATWorksheet);

            // Lấy sheet 1.
            COMExcel.Worksheet exSheet = (COMExcel.Worksheet)exBook.Worksheets[1];

            exSheet.Activate();
            exSheet.Name = "Đơn thuốc";

            int rows = dataGridView1.Rows.Count;
            int columns = dataGridView1.Columns.Count;
            //Ghi dữ liệu
            for (int i = 1; i <= rows; i++) // duyệt các dòng trong datagrid
            {
                for (int j = 0; j <= columns - 1; j++) // duyệt các cột của mỗi dòng
                {
                    COMExcel.Range r = (COMExcel.Range)exSheet.Cells[i + 1, j + 1];

                    r.Value2 = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    //MessageBox.Show(dataGridView1.Rows[i].Cells[j].Value.ToString());

                    r.Columns.AutoFit(); // tự động giãn cột
                }
            }

            // Hiển thị chương trình excel
            exApp.Visible = true;

            System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
        }
    }
}
