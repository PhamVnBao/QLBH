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

namespace GUI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = tbUsername.Text;
            string passWord = tbPassWord.Text;
            LoginBUS lg = new LoginBUS();
            bool result = lg.loginValid(userName, passWord);
            if (result == true)
            {
                fMain f = new fMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Username or password invalid", "Thong bao", MessageBoxButtons.OK);
        }
    }
}
