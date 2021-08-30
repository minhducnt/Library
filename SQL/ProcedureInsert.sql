--Nhập đầu sách
CREATE PROC NhapDauSach
@MaSach NVARCHAR(10),
@TuaSach NVARCHAR(100),
@MaNXB NVARCHAR(10),
@NgonNgu NVARCHAR(20),
@TheLoai NVARCHAR(20),
@ThoiGianMuonToiDa INT
AS
BEGIN
    INSERT INTO dbo.DauSach VALUES( @MaSach ,@TuaSach ,@MaNXB ,@NgonNgu ,@TheLoai ,@ThoiGianMuonToiDa)
END
GO 

--Nhập khách hàng
CREATE PROC NhapKhachHang 
@MaKhach NVARCHAR(10),
@TenKhach NVARCHAR(30),
@Email NVARCHAR(30),
@DiaChiKhach NVARCHAR(60),
@DienThoaiKhach NVARCHAR(10)
AS 
BEGIN
     INSERT INTO dbo.KhachHang VALUES(@MaKhach, @TenKhach, @Email, @DiaChiKhach, @DienThoaiKhach)
END
GO

--Nhập tác giả
CREATE PROC NhapTacGia
 @MaSach NVARCHAR(10),
 @TenTacGia NVARCHAR(30)
 AS
 BEGIN
     INSERT INTO TacGia VALUES(@MaSach,@TenTacGia)
 END
GO 

--Nhập cuốn sách
CREATE PROC NhapCuonSach
@MaSach NVARCHAR(10),
@MaCuon NVARCHAR(10),
@TinhTrangSach NVARCHAR(15),
@DoMoiCuaSach NVARCHAR(5),
@GiaMua MONEY,
@GiaThue MONEY,
@KeSach INT,
@Tang INT
AS
BEGIN
    INSERT INTO dbo.CuonSach VALUES (@MaSach,@MaCuon,@TinhTrangSach,@DoMoiCuaSach,@GiaMua,@GiaThue,@KeSach,@Tang)            
END
GO 

--Nhập chi tiết đơn mượn
CREATE PROC NhapChiTietDonMuon
@MaDonMuon NVARCHAR(10),
@MaCuon NVARCHAR(10)
AS
BEGIN
    INSERT INTO dbo.ChiTietDonMuon VALUES (@MaDonMuon,@MaCuon)            
END
GO

--Nhập đơn mượn
CREATE PROC NhapDonMuon
@MaDonMuon NVARCHAR(10),
@MaNhanVien NVARCHAR(10),
@MaKhach NVARCHAR(10),
@NgayMuon DATETIME
AS
BEGIN
	INSERT INTO dbo.DonMuon VALUES(@MaDonMuon,@MaNhanVien,@MaKhach,@NgayMuon)
END
GO 

--Nhập đơn trả
CREATE PROC NhapDonTra
@MaDonTra NVARCHAR(10),
@MaDonMuon NVARCHAR(10)
AS 
BEGIN
	INSERT INTO dbo.DonTra VALUES (@MaDonTra,@MaDonMuon)
END 
GO 

--Nhập chi tiết đơn trả
CREATE PROC NhapChiTietDonTra
@MaDonTra NVARCHAR(10),
@MaCuon NVARCHAR(10),
@NgayTra DATETIME,
@TienPhat MONEY
AS
BEGIN
    INSERT INTO dbo.ChiTietDonTra VALUES(@MaDonTra,@MaCuon,@NgayTra,@TienPhat)
END
GO

--Nhập nhân viên
CREATE PROC NhapNhanVien
@MaNhanVien NVARCHAR(10),
@TenNhanVien NVARCHAR(30),
@NgaySinh DATETIME,
@CMND NVARCHAR(12),
@GioiTinh NVARCHAR(6),
@EmailNhanVien NVARCHAR(30),
@DiaChi NVARCHAR(60),
@SDT NVARCHAR(10),
@ChucVu NVARCHAR(10)
AS
BEGIN
    INSERT INTO dbo.NhanVien VALUES(@MaNhanVien,@TenNhanVien,@NgaySinh,@CMND,@GioiTinh,@EmailNhanVien,@DiaChi,@SDT,@ChucVu)
END
GO 

--Nhập nhà xuất bản
CREATE PROC NhapNhaXuatBan
@MaNXB NVARCHAR(10),
@TenNXB NVARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.NXB VALUES(@MaNXB,@TenNXB)
END
GO