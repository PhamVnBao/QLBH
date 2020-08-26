using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fSanPham : Form
    {
        public delegate void chonSanPham(int maSanPham, float gia);
        public chonSanPham chonSP;
        public fSanPham()
        {
            InitializeComponent();
            SanPhamBUS.Instance.hienThiSanPham(dtgvSanPham);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvSanPham.SelectedCells[0].OwningRow;
            string maSanPham = row.Cells["MaSanPham"].Value.ToString();
            string gia = row.Cells["Gia"].Value.ToString();
            chonSP(Int32.Parse(maSanPham), float.Parse(gia));
            this.Hide();
        }
    }
}
