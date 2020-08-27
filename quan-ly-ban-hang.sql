-- create databases Quan ly ban hang
DROP DATABASE QLBH
GO
CREATE DATABASE QLBH
GO

-- use databases Quan ly ban hang
USE QLBH
GO

-- create table NhanVien
DROP TABLE NhanVien
GO
CREATE TABLE NhanVien
(
	MaNV INT,
	TenNV NVARCHAR(50),
	DiaChi NVARCHAR(100),
	Sdt NCHAR(10),
	ChucVu NVARCHAR(50),
	NVPassword NVARCHAR(10)
	PRIMARY KEY (MaNV)
)
GO

-- create table ChungLoai
DROP TABLE ChungLoai
GO
CREATE TABLE ChungLoai
(
	MaChungLoai INT,
	TenChungLoai NVARCHAR(50),
	MoTa NVARCHAR(100)
	PRIMARY KEY (MaChungLoai)
)
GO

-- create table SanPham
DROP TABLE SanPham
GO
CREATE TABLE SanPham
(
	MaSanPham INT,
	TenSanPham NVARCHAR(50),
	Gia FLOAT,
	SoLuongToiDa INT,
	SoluongToiThieu INT,
	SoLuongHienTai INT,
	MaChungLoai INT
	PRIMARY KEY (MaSanPham)
)
GO

-- create table KhachHang
DROP TABLE KhachHang
GO
CREATE TABLE KhachHang
(
	MaKhachHang INT, 
	TenKhachHang NVARCHAR(50),
	Sdt VARCHAR(10),
	DiaChi NVARCHAR(100),
	Email NVARCHAR(50),
	PRIMARY KEY (MaKhachHang)
) 
GO

-- create table ThanhToanHoaDon
DROP TABLE ThanhToanHoaDon
GO
CREATE TABLE ThanhToanHoaDon
(
	MaKhachHang INT,
	MaHoaDon INT,
	SoTien FLOAT,
	ThuQuy INT,
	ThoiGian DATE,
	HinhThucThanhToan INT,
	PRIMARY KEY (MaKhachHang, MaHoaDon)
)

-- create table HoaDon
DROP TABLE HoaDon
GO
CREATE TABLE HoaDon
(
	MaHoaDon INT,
	MaKhachHang INT,
	TongSoTien FLOAT,
	Ngay DATE, 
	NhanVienBanHang INT,
	NhanVienGiaoHang INT,
	ThongTinThanhToan VARCHAR(50)
	PRIMARY KEY (MaHoaDon)
)

-- createe table CT_HoaDon
DROP TABLE CT_HoaDon
GO
CREATE TABLE CT_HoaDon
(
	MaHoaDon INT,
	MaSanPham INT,
	SoLuong INT,
	ThanhTien FLOAT,
	TinhTrang NCHAR(50)
	PRIMARY KEY (MaHoaDon, MaSanPham)
)
GO
create table phieunhap(
	mapn int,
	manv int,
	ngay date,
	primary key(matk)
)
GO
create table ctphieunhap(
	mapn int,
	masp int,
	soluong int,
	giatien float,
	primary key(mapn,masp)
GO

-- foreign key
ALTER TABLE dbo.SanPham DROP CONSTRAINT FK_SANPHAM_CHUNGLOAI;
ALTER TABLE dbo.SanPham ADD CONSTRAINT FK_SANPHAM_CHUNGLOAI FOREIGN KEY (MaChungLoai) REFERENCES dbo.ChungLoai(MaChungLoai);

ALTER TABLE dbo.ThanhToanHoaDon DROP CONSTRAINT FK_THANHTOANHOADON_KHACHHANG;
ALTER TABLE dbo.ThanhToanHoaDon ADD CONSTRAINT FK_THANHTOANHOADON_KHACHHANG FOREIGN KEY(MaKhachHang) REFERENCES dbo.KhachHang(MaKhachHang);
ALTER TABLE dbo.ThanhToanHoaDon DROP CONSTRAINT FK_THANHTOANHOADON_HOADON;
ALTER TABLE dbo.ThanhToanHoaDon ADD CONSTRAINT FK_THANHTOANHOADON_HOADON FOREIGN KEY(MaHoaDon) REFERENCES dbo.HoaDon(MaHoaDon);

ALTER TABLE dbo.HoaDon DROP CONSTRAINT FK_HOADON_NHANVIEN;
ALTER TABLE dbo.HoaDon ADD CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY(NhanVienBanHang) REFERENCES dbo.NhanVien(MaNV);
ALTER TABLE dbo.HoaDon DROP CONSTRAINT FK_HOADON_NHANVIEN1;
ALTER TABLE dbo.HoaDon ADD CONSTRAINT FK_HOADON_NHANVIEN1 FOREIGN KEY(NhanVienGiaoHang) REFERENCES dbo.NhanVien(MaNV);
ALTER TABLE dbo.HoaDon DROP CONSTRAINT FK_HOADON_KHACHHANG;
ALTER TABLE dbo.HoaDon ADD CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY(MaKhachHang) REFERENCES dbo.KhachHang(MaKhachHang)

ALTER TABLE dbo.CT_HoaDon DROP CONSTRAINT FK_CTHOADON_HOADON;
ALTER TABLE dbo.CT_HoaDon ADD CONSTRAINT FK_CTHOADON_HOADON FOREIGN KEY(MaHoaDon) REFERENCES dbo.HoaDon(MaHoaDon);
ALTER TABLE dbo.CT_HoaDon DROP CONSTRAINT FK_CTHOADON_SANPHAM;
ALTER TABLE dbo.CT_HoaDon ADD CONSTRAINT FK_CTHOADON_SANPHAM FOREIGN KEY(MaSanPham) REFERENCES dbo.SanPham(MaSanPham);

-- insert data into table ChungLoai
INSERT INTO dbo.ChungLoai VALUES (001, N'Apple', N'Dien thoai apple');
INSERT INTO dbo.ChungLoai VALUES (002, N'Caffee', N'Caffee');
INSERT INTO dbo.ChungLoai VALUES (003, N'Drink', N'ddoof uoongs');
INSERT INTO dbo.ChungLoai VALUES (004, N'Food', N'ddoof awn');
INSERT INTO dbo.ChungLoai VALUES (005, N'Personal Care', N'ddoof dungf cas nhaan');
GO

-- insert data into table SanPham
INSERT INTO dbo.SanPham VALUES (001, N'Iphone 13', 1500, 50, 10, 11, 001);
INSERT INTO dbo.SanPham VALUES (002, N'Iphone 14', 1600, 50, 10, 12, 001);
INSERT INTO dbo.SanPham VALUES (003, N'Iphone 15', 1700, 50, 10, 13, 001);
INSERT INTO dbo.SanPham VALUES (004, N'Iphone 16', 1800, 50, 10, 14, 001);
INSERT INTO dbo.SanPham VALUES (005, N'Iphone 17', 1900, 50, 10, 15, 001);

INSERT INTO dbo.SanPham VALUES (006, N'Caffee 13', 15100, 50, 10, 0, 002);
INSERT INTO dbo.SanPham VALUES (007, N'Caffee 14', 16200, 50, 10, 2, 002);
INSERT INTO dbo.SanPham VALUES (008, N'Caffee 15', 1700, 50, 10, 3, 002);
INSERT INTO dbo.SanPham VALUES (009, N'Caffee 16', 18300, 50, 10, 14, 002);
INSERT INTO dbo.SanPham VALUES (010, N'Caffee 17', 19400, 50, 10, 15, 002);

INSERT INTO dbo.SanPham VALUES (011, N'Drink 13', 15020, 50, 10, 11, 003);
INSERT INTO dbo.SanPham VALUES (012, N'Drink 14', 16020, 50, 10, 12, 003);
INSERT INTO dbo.SanPham VALUES (013, N'Drink 15', 17030, 50, 10, 5, 003);
INSERT INTO dbo.SanPham VALUES (014, N'Drink 16', 18020, 50, 10, 14, 003);
INSERT INTO dbo.SanPham VALUES (015, N'Drink 17', 19020, 50, 10, 5, 003);

INSERT INTO dbo.SanPham VALUES (016, N'Food 13', 15002, 50, 10, 11, 004);
INSERT INTO dbo.SanPham VALUES (017, N'Food 14', 16002, 50, 10, 2, 004);
INSERT INTO dbo.SanPham VALUES (018, N'Food 15', 17020, 50, 10, 13, 004);
INSERT INTO dbo.SanPham VALUES (019, N'Food 16', 18020, 50, 10, 4, 004);
INSERT INTO dbo.SanPham VALUES (020, N'Food 17', 19020, 50, 10, 15, 004);

INSERT INTO dbo.SanPham VALUES (021, N'Personal Care 13', 1500, 50, 10, 21, 005);
INSERT INTO dbo.SanPham VALUES (022, N'Personal Care 14', 1600, 50, 10, 2, 005);
INSERT INTO dbo.SanPham VALUES (023, N'Personal Care 15', 1700, 50, 10, 23, 005);
INSERT INTO dbo.SanPham VALUES (024, N'Personal Care 16', 1800, 50, 10, 14, 005);
INSERT INTO dbo.SanPham VALUES (025, N'Personal Care 17', 1900, 50, 10, 5, 005);
GO


-- insert data into table KhachHang
INSERT INTO dbo.KhachHang VALUES(001, N'Nguyen Thi A', '0123456987', N'Ha Noi', N'nta@gamil.com')
GO

-- insert data into table NhanVien
INSERT INTO dbo.NhanVien VALUES (001, N'Nguyen Van A', N'Ho Chi Minh', '0123456789', 'Nhan vien ban hang', N'123456');
INSERT INTO dbo.NhanVien VALUES (002, N'Nguyen Van B', N'Dong Nai', '0123498765', 'Nhan vien giao hang',  null);
GO

-- stored procudure

--DROP PROC sp_KiemTraNVTonTai
--GO
--CREATE PROC sp_KiemTraNVTonTai @MaNV INT, @PassWord NVARCHAR(10)
--AS
--	BEGIN
--		SELECT * FROM dbo.NhanVien WHERE MaNV = @MaNV AND NVPassword = @PassWord
--	END
--GO
--EXEC dbo.sp_KiemTraNVTonTai @MaNV = 001, @PassWord = N'123456'
------> success

-- query
SELECT * FROM dbo.ChungLoai;
SELECT * FROM dbo.SanPham;
SELECT * FROM dbo.KhachHang;
SELECT * FROM dbo.NhanVien;
SELECT * FROM dbo.HoaDon;
SELECT * FROM dbo.CT_HoaDon;
SELECT * FROM dbo.ThanhToanHoaDon;

-- end
