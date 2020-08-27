using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class SanPhamBUS
    {
        private static SanPhamBUS instance;

        public static SanPhamBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamBUS();
                return instance;
            }
        }

        private SanPhamBUS() { }

        public void hienThiSanPham(DataGridView data)
        {
            data.DataSource = SanPhamDAO.Instance.hienThiSanPham();
        }
        public void hienthisanpham2(DataGridView data)
        {
            data.DataSource = SanPhamDAO.Instance.Sanphamcannhap();
        }

        public void nhapsanpham(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6, TextBox t7)
        {
            try
            {
                SanPham sp = new SanPham(
                    Int32.Parse(t1.Text),
                    t2.Text,
                    float.Parse(t3.Text),
                    Int32.Parse(t4.Text),
                    Int32.Parse(t5.Text),
                    Int32.Parse(t6.Text),
                    Int32.Parse(t7.Text)
                    );
                SanPhamDAO.Instance.Nhapsanpham(sp);
            }
            catch
            {
                MessageBox.Show("error");
            }            
        }
        public void Xoasanpham(DataGridView data)
        {
            for (int i = 0; i < data.Rows.Count ; i++)
            {
                try
                {
                    if (data.Rows[i].Cells[1].Value != null)
                    {                       
                        SanPhamDAO.Instance.Xoasanpham(Int32.Parse((data.Rows[i].Cells[2].Value.ToString())));
                    }
                }
                catch
                {
                    MessageBox.Show("error");
                }
            }
        }

        public void Xuatfile(DataGridView dataGridView1)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (j != 1)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
            }
        }
    }
}
