--Sửa Nhà Xuất Bản
CREATE PROC SuaNXB
@MaNXB NVARCHAR(10),
@TenNXB NVARCHAR(50)
AS
BEGIN
    UPDATE dbo.NXB SET TenNXB=@TenNXB
	WHERE MaNXB=@MaNXB
END
GO

--Sửa Đầu Sách
CREATE PROC SuaDausach
@MaSach NVARCHAR(10),
@TuaSach NVARCHAR(100),
@MaNXB NVarchar(10),
@NgonNgu nvarchar(20),
@TheLoai nvarchar(20),
@ThoiGianMuonToiDa int
AS
BEGIN
    UPDATE dbo.DauSach SET TuaSach=@TuaSach , MaNXB=@MaNXB, NgonNgu=@NgonNgu, TheLoai=@TheLoai, ThoiGianMuonToiDa=@ThoiGianMuonToiDa
	WHERE MaSach=@MaSach  
END
GO

--Sửa Cuốn Sách
CREATE PROC SuaCuonSach
@MaSach nvarchar(10), 
@MaCuon nvarchar(10),
@TinhTrangSach nvarchar(15),
@DoMoiCuaSach nvarchar(5),
@GiaMua money,
@GiaThue money,
@KeSach int,
@Tang int
As
BEGIN
	UPDATE dbo.CuonSach SET MaSach=@MaSach , TinhTrangSach=@TinhTrangSach , DoMoiCuaSach=@DoMoiCuaSach , GiaMua=@GiaMua, GiaThue=@GiaThue , KeSach=@KeSach, Tang=@Tang
	WHERE MaCuon=@MaCuon
END
GO

--Sửa Nhân Viên
CREATE PROC SuaNhanVien
@MaNhanVien nvarchar(10),
@TenNhanVien nvarchar(30),
@NgaySinh datetime,
@CMND nvarchar(12),
@GioiTinh nvarchar(6),
@EmailNhanVien nvarchar(30),
@DiaChi nvarchar(60),
@SDT nvarchar(10),
@ChucVu nvarchar(10)
As
BEGIN
	UPDATE dbo.NhanVien SET MaNhanVien=@MaNhanVien, TenNhanVien=@TenNhanVien, NgaySinh=@NgaySinh, CMND=@CMND, GioiTinh=@GioiTinh, EmailNhanVien=@EmailNhanVien, DiaChi=@DiaChi, SDT=@SDT, ChucVu=@ChucVu                          
	WHERE MaNhanVien=@MaNhanVien             
END
GO

--Sửa Khách Hàng
CREATE PROC SuaKhachHang
@MaKhach nvarchar(10),
@TenKhach nvarchar(30),
@Email nvarchar(30),
@DiaChiKhach nvarchar(60),
@DienThoaiKhach nvarchar(10)
As
BEGIN
	UPDATE dbo.KhachHang SET TenKhach=@TenKhach, Email=@Email, DiaChiKhach=@DiaChiKhach, DienThoaiKhach=@DienThoaiKhach 
	WHERE MaKhach=@MaKhach             
END
GO

--Sửa Đơn Mượn
CREATE PROC SuaDonMuon
@MaDonMuon nvarchar(10),
@MaNhanVien nvarchar(10),
@MaKhach nvarchar(10),
@NgayMuon datetime
AS
BEGIN
	UPDATE dbo.DonMuon SET MaNhanVien=@MaNhanVien, MaKhach=@MaKhach, NgayMuon=@NgayMuon
	Where MaDonMuon=@MaDonMuon
END
GO

--Sửa đơn trả
CREATE PROC SuaDonTra
@MaDonTra nvarchar(10),
@MaDonMuon nvarchar(10)
AS
Begin
	UPDATE dbo.DonTra SET MaDonMuon=@MaDonMuon
	Where MaDonTra=@MaDonTra
END
GO

--Sửa tác giả
CREATE PROC SuaTacGia
@MaSach nvarchar(10),
@TenTacGia nvarchar(30)
AS 
BEGIN
    UPDATE dbo.TacGia SET MaSach=@MaSach
	WHERE TenTacGia=@TenTacGia
END
GO 

--Sửa chi tiết đơn mượn
CREATE PROC SuaChiTietDonMuon
@MaDonMuon nvarchar(10),
@MaCuon nvarchar(10)
AS 
BEGIN
    UPDATE dbo.ChiTietDonMuon SET MaCuon=@MaCuon
	WHERE MaDonMuon=@MaDonMuon
END
GO 

--Sửa chi tiết đơn trả
CREATE PROC SuaChiTietDonTra
@MaDonTra nvarchar(10),
@MaCuon nvarchar(10),
@NgayTra DATETIME,
@TienPhat MONEY
AS 
BEGIN
    UPDATE dbo.ChiTietDonTra SET MaCuon=@MaCuon, NgayTra=@NgayTra, TienPhat=@TienPhat
	WHERE MaDonTra=@MaDonTra
END
GO 
