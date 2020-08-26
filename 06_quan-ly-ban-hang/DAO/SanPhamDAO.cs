using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
