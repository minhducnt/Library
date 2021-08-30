--Xóa chi tiết đơn mượn
CREATE PROC XoaChiTietDonMuon
@MaDonMuon NVARCHAR(10), @MaCuon NVARCHAR(10)
AS
BEGIN 
	DELETE Dbo.ChiTietDonMuon WHERE MaDonMuon=@MaDonMuon AND MaCuon=@MaCuon
END
GO

--Xóa chi tiết đơn trả
CREATE PROC XoaChiTietDonTra
@MaDonTra NVARCHAR(10),  @MaCuon NVARCHAR(10)
AS
BEGIN 
	DELETE Dbo.ChiTietDonTra WHERE MaDonTra=@MaDonTra And MaCuon=@MaCuon
END
GO

--Xóa đơn mượn
CREATE PROC XoaDonMuon
@MaDonMuon NVARCHAR(10)
AS
BEGIN 
	DELETE Dbo.DonMuon WHERE MaDonMuon=@MaDonMuon
END
GO

--Xóa đơn trả
CREATE PROC XoaDonTra
@MaDonTra NVARCHAR(10)
AS
BEGIN 
	DELETE Dbo.DonTra WHERE MaDonTra=@MaDonTra
END
GO

--Xóa Tác Giả
CREATE PROC XoaTacGia
@MaSach NVARCHAR(10), @TenTacGia NVARCHAR(30)
AS
BEGIN 
	DELETE Dbo.TacGia WHERE MaSach=@MaSach AND TenTacGia=@TenTacGia
END
GO

--Xóa đầu sách
CREATE PROC XoaDauSach
@MaSach NVARCHAR(10)
AS
BEGIN 
	DELETE Dbo.DauSach WHERE MaSach=@MaSach
END
GO

--Xóa nhà xuất bản
CREATE PROC XoaNXB
@MaNXB NVARCHAR(10)
AS
BEGIN 
	DELETE Dbo.NXB WHERE MaNXB=@MaNXB 
END
GO

--Xóa cuốn sách
CREATE PROC XoaCuonSach
@MaCuon NVARCHAR(10)
AS
BEGIN 
	DELETE Dbo.CuonSach WHERE MaCuon=@MaCuon
END
GO

--Xóa nhân viên
CREATE PROC XoaNhanVien
@MaNhanVien NVARCHAR(10)
AS
BEGIN 
	DELETE Dbo.NhanVien WHERE MaNhanVien=@MaNhanVien
END
GO

--Xóa khách hàng
CREATE PROC XoaKhachHang  
@MaKhach NVARCHAR(10)
AS
BEGIN
	DELETE dbo.KhachHang WHERE MaKhach=@MaKhach
END 
GO 