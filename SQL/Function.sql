--Liệt kê sách với tình trạng
CREATE FUNCTION LietKeSachVoiTinhTrang(@TinhTrang NVARCHAR(15))
RETURNS @RES TABLE (MaSach NVARCHAR(10),TuaSach NVARCHAR(100),
		GiaMua MONEY, GiaThue MONEY,KeSach INT,Tang INT)
AS 
BEGIN
	INSERT INTO @RES
	SELECT A.MaSach,B.TuaSach,A.GiaMua,A.GiaThue,A.KeSach,A.Tang
	FROM CuonSach AS A, DauSach AS B
	WHERE A.MaSach = B.MaSach AND @TinhTrang=A.TinhTrangSach
	RETURN
END 
GO 

--Liệt kê sách với tên tác giả
CREATE FUNCTION LietKeSachVoiTenTacGia(@TenTacGia NVARCHAR(30))
RETURNS @RES TABLE (MaSach NVARCHAR(10),TuaSach NVARCHAR(50),MaNXB NVARCHAR(10),
					GiaMua MONEY, GiaThue MONEY, ThoiGianMuonToiDa int)
AS
BEGIN
	INSERT INTO @RES
	SELECT B.MaSach, A.TuaSach, A.MaNXB, C.GiaMua, C.GiaThue,A.ThoiGianMuonToiDa
	FROM DauSach AS A, TacGia AS B, CuonSach AS C
	WHERE A.MaSach = B.MaSach AND B.TenTacGia = @TenTacGia AND B.MaSach=C.MaSach
	RETURN
END
GO

--Liệt kê sách với nhà xuất bản và tác giả
CREATE FUNCTION	LietKeSachVoiVaoNXBVaTacGia(@TenTacGia NVARCHAR(30), @TenNXB NVARCHAR(30))
RETURNS @RES TABLE(MaSach NVARCHAR(10), TuaSach NVARCHAR(50), TenNXB NVARCHAR(30), TenTacGia NVARCHAR(30)) 
AS
BEGIN
	INSERT INTO @RES
	SELECT B.MaSach, B.TuaSach, C.TenNXB, A.TenTacGia
	FROM TacGia AS A, DauSach AS B, NXB AS C
	WHERE A.MaSach = B.MaSach AND C.MaNXB = B.MaNXB AND
		  A.TenTacGia = @TenTacGia AND C.TenNXB = @TenNXB
	RETURN
END
GO

--Liệt kê nhân viên với chức vụ
CREATE FUNCTION LietKeNhanVienVoiChucVu(@ChucVu NVARCHAR(10))
RETURNS @RES TABLE(MaNhanVien NVARCHAR(10),TenNhanVien NVARCHAR(30),NgaySinh DATETIME,CMND NVARCHAR(12),GioiTinh NVARCHAR(6),
	EmailNhanVien NVARCHAR(30),DiaChi NVARCHAR(60),SDT NVARCHAR(10))
AS
BEGIN
    INSERT INTO @RES
    SELECT MaNhanVien,TenNhanVien,NgaySinh,CMND,GioiTinh,EmailNhanVien,DiaChi,SDT
	FROM dbo.NhanVien
	WHERE ChucVu=@ChucVu
	RETURN
END
GO 

--Liệt kê sách với kệ sách 
CREATE FUNCTION LietKeSachVoiKeSach(@KeSach INT)
RETURNS @RES TABLE(MaSach NVARCHAR(10),MaCuon NVARCHAR(10),TuaSach NVARCHAR(100),TinhTrangSach NVARCHAR(15),
	DoMoiCuaSach NVARCHAR(5),GiaMua MONEY,GiaThue MONEY,Tang INT)
AS
BEGIN
    INSERT INTO @RES
    SELECT A.MaSach,A.MaCuon,B.TuaSach,A.TinhTrangSach,A.DoMoiCuaSach,A.GiaMua,A.GiaThue,A.Tang
	FROM dbo.CuonSach AS A,dbo.DauSach AS B
	WHERE A.MaSach=B.MaSach AND A.KeSach=@KeSach
	RETURN        
END
GO 

--Liệt kê nhân viên với khác hàng
CREATE FUNCTION LietKeNhanVienVoiKhach(@TenKhach NVARCHAR(30))
RETURNS @RES TABLE(MaNhanVien NVARCHAR(10),TenNhanVien NVARCHAR(30),NgaySinh DATETIME,CMND NVARCHAR(12),GioiTinh NVARCHAR(6),
	EmailNhanVien NVARCHAR(30),DiaChi NVARCHAR(60),SDT NVARCHAR(10),ChucVu NVARCHAR(10))
AS
BEGIN
    INSERT INTO @RES
	SELECT C.MaNhanVien,C.TenNhanVien,C.NgaySinh,C.CMND,C.GioiTinh,C.EmailNhanVien,C.DiaChi,C.SDT,C.ChucVu
	FROM dbo.KhachHang AS A,dbo.DonMuon AS B,dbo.NhanVien AS C
	WHERE A.MaKhach=B.MaKhach AND B.MaNhanVien=C.MaNhanVien AND A.TenKhach=@TenKhach
	GROUP BY C.MaNhanVien,C.TenNhanVien,C.NgaySinh,C.CMND,C.GioiTinh,C.EmailNhanVien,C.DiaChi,C.SDT,C.ChucVu
	RETURN
END
GO 

--Liệt kê sách với giá mua nằm trong khoảng
CREATE FUNCTION LietKeSachVoiGiaMuaTrongKhoang(@Min MONEY,@Max MONEY)
RETURNS @RES TABLE(MaSach NVARCHAR(10),MaCuon NVARCHAR(10),TuaSach NVARCHAR(100),TinhTrangSach NVARCHAR(15),
	DoMoiCuaSach NVARCHAR(5),GiaThue MONEY,KeSach INT, Tang INT)
AS
BEGIN
    INSERT INTO @RES
    SELECT A.MaSach,A.MaCuon,B.TuaSach,A.TinhTrangSach,A.DoMoiCuaSach,A.GiaThue,A.KeSach,A.Tang
	FROM dbo.CuonSach AS A,dbo.DauSach AS B
	WHERE A.MaSach=B.MaSach AND A.GiaMua>=@Min AND A.GiaMua<=@Max
	RETURN  
END
GO 

--Liệt kê sách với giá thuê nằm trong khoảng
CREATE FUNCTION LietKeSachVoiGiaThueTrongKhoang(@Min MONEY,@Max MONEY)
RETURNS @RES TABLE(MaSach NVARCHAR(10),MaCuon NVARCHAR(10),TuaSach NVARCHAR(100),TinhTrangSach NVARCHAR(15),
	DoMoiCuaSach NVARCHAR(5),GiaMua MONEY,KeSach INT, Tang INT)
AS
BEGIN
    INSERT INTO @RES
    SELECT A.MaSach,A.MaCuon,B.TuaSach,A.TinhTrangSach,A.DoMoiCuaSach,A.GiaMua,A.KeSach,A.Tang
	FROM dbo.CuonSach AS A,dbo.DauSach AS B
	WHERE A.MaSach=B.MaSach AND A.GiaThue>=@Min AND A.GiaThue<=@Max
	RETURN  
END
GO

--Liệt kê khách hàng với địa chỉ
CREATE FUNCTION LietKeKhachHangVoiDiaChi(@DiaChiKhach NVARCHAR(60))
RETURNS @RES TABLE(MaKhach NVARCHAR(10),TenKhach NVARCHAR(30),Email NVARCHAR(30),DienThoaiKhach NVARCHAR(10))
AS
BEGIN
    INSERT INTO @RES
	SELECT MaKhach,TenKhach,Email,DienThoaiKhach
	FROM dbo.KhachHang
	WHERE DiaChiKhach=@DiaChiKhach
	RETURN
END
GO

--Liệt kê nhà xuất bản với thể loại
CREATE FUNCTION LietKeNhaXuatBanVoiTheLoai(@TheLoai NVARCHAR(20))
RETURNS @RES TABLE(MaNXB NVARCHAR(10),TenNXB NVARCHAR(50))
AS
BEGIN
    INSERT INTO @RES
    SELECT A.MaNXB,A.TenNXB
	FROM dbo.NXB AS A,dbo.DauSach AS B
	WHERE A.MaNXB=B.MaNXB AND B.TheLoai=@TheLoai
	RETURN
END
GO 
