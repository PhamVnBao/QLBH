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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnQLDH_Click(object sender, EventArgs e)
        {
            fQLDH f = new fQLDH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            fQLSP f = new fQLSP();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
