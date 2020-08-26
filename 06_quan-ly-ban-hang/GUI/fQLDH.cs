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
    public partial class fQLDH : Form
    {
        public fQLDH()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            fSanPham f = new fSanPham();
            f.chonSP = new fSanPham.chonSanPham(loadSP);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        void loadSP(int maSanPham, float gia)
        {
            tbMaSanPham.Text = "";
            tbMaSanPham.Text = maSanPham.ToString();
            tbDonGia.Text = "";
            tbDonGia.Text = gia.ToString();
        }
    }
}
