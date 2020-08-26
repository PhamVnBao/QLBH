using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        private int maSanPham;
        private string tenSanPham;
        private float gia;
        private int soLuongToiDa;
        private int soLuongToiThieu;
        private int soLuongHienTai;
        private int maChungLoai;

        public int MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }

        public string TenSanPham
        {
            get { return tenSanPham; }
            set { tenSanPham = value; }
        }

        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        public int SoLuongToiDa
        {
            get { return soLuongToiDa; }
            set { soLuongToiDa = value; }
        }

        public int SoLuongToiThieu
        {
            get { return soLuongToiThieu; }
            set { soLuongToiThieu = value; }
        }

        public int SoLuongHienTai
        {
            get { return soLuongHienTai; }
            set { soLuongHienTai = value; }
        }

        public int MaChungLoai
        {
            get { return maChungLoai; }
            set { maChungLoai = value; }
        }

        public SanPham(int maSanPham, string tenSanPham, float gia, int soLuongToiDa, int soLuongToiThieu, int soLuongHienTai, int maChungLoai)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.gia = gia;
            this.soLuongToiDa = soLuongToiDa;
            this.soLuongToiThieu = soLuongToiThieu;
            this.soLuongHienTai = soLuongHienTai;
            this.maChungLoai = maChungLoai;
        }
    }
}
