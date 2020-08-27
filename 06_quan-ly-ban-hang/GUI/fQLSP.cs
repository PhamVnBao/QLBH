using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class fQLSP : Form
    {
        public fQLSP()
        {
            InitializeComponent();
            SanPhamBUS.Instance.hienthisanpham2(dataGridView1);
            SanPhamBUS.Instance.hienThiSanPham(dataGridView2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanPhamBUS.Instance.nhapsanpham(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7);
            SanPhamBUS.Instance.hienthisanpham2(dataGridView1);
            SanPhamBUS.Instance.hienThiSanPham(dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SanPhamBUS.Instance.Xuatfile(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SanPhamBUS.Instance.Xoasanpham(dataGridView1);
            SanPhamBUS.Instance.hienthisanpham2(dataGridView1);
            SanPhamBUS.Instance.hienThiSanPham(dataGridView2);
        }
    }
}
