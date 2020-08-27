using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamDAO();
                return instance;
            }
        }

        private SanPhamDAO() { }

        public List<SanPham> hienThiSanPham()
        {
            List<SanPham> sp = new List<SanPham>();

            string query = "select * from SanPham";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                string maSanPham = item["MaSanPham"].ToString();
                string tenSanPham = item["TenSanPham"].ToString();
                string gia = item["Gia"].ToString();
                string soLuongToiDa = item["SoLuongToiDa"].ToString();
                string soLuongToiThieu = item["SoLuongToiThieu"].ToString();
                string soLuongHienTai = item["SoLuongHienTai"].ToString();
                string maChungLoai = item["MaChungLoai"].ToString();

                SanPham newSp = new SanPham(
                    Int32.Parse(maSanPham),
                    tenSanPham,
                    float.Parse(gia),
                    Int32.Parse(soLuongToiDa),
                    Int32.Parse(soLuongToiThieu),
                    Int32.Parse(soLuongHienTai),
                    Int32.Parse(maChungLoai)
                    );

                sp.Add(newSp);
            }

            return sp; 
        }
        public List<SanPham> Sanphamcannhap()
        {
            List<SanPham> sp = new List<SanPham>();

            string query = "select * from SanPham where SoLuongHienTai < SoLuongToiThieu";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maSanPham = item["MaSanPham"].ToString();
                string tenSanPham = item["TenSanPham"].ToString();
                string gia = item["Gia"].ToString();
                string soLuongToiDa = item["SoLuongToiDa"].ToString();
                string soLuongToiThieu = item["SoLuongToiThieu"].ToString();
                string soLuongHienTai = item["SoLuongHienTai"].ToString();
                string maChungLoai = item["MaChungLoai"].ToString();

                SanPham newSp = new SanPham(
                    Int32.Parse(maSanPham),
                    tenSanPham,
                    float.Parse(gia),
                    Int32.Parse(soLuongToiDa),
                    Int32.Parse(soLuongToiThieu),
                    Int32.Parse(soLuongHienTai),
                    Int32.Parse(maChungLoai)
                    );

                sp.Add(newSp);
            }

            return sp;
        }

        public int Nhapsanpham(SanPham sp)
        {
            int maSanPham = sp.MaSanPham;
            string tenSanPham = sp.TenSanPham;
            float gia = sp.Gia;
            int soLuongToiDa = sp.SoLuongToiDa;
            int soLuongToiThieu = sp.SoLuongToiThieu;
            int soLuongHienTai = sp.SoLuongHienTai;
            int maChungLoai = sp.MaChungLoai;
            
            string query = "INSERT INTO SanPham VALUES ("+maSanPham+","+"'"+tenSanPham+"'" + "," + gia + "," + soLuongToiDa + "," + soLuongToiThieu + "," + soLuongHienTai + "," + maChungLoai +  "); ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            return 0;
        }
        public int Xoasanpham(int masp)
        {
            string query = "DELETE FROM SanPham WHERE MaSanPham =" +masp + ";";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return 0;
        }
    }
}
