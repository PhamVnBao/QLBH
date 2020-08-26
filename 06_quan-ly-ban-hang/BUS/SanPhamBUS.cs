using DAO;
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
    }
}
