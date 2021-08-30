--Kiểm tra đầu sách
CREATE TRIGGER KiemTraTruocKhiThemDauSach
ON dbo.DauSach INSTEAD OF INSERT
AS
BEGIN
	DECLARE @COUNT INT=0
	SELECT @COUNT = COUNT(*)
	FROM NXB AS A, inserted AS B
	WHERE A.MaNXB = B.MaNXB
	IF (@COUNT =0) 
	BEGIN
		PRINT(N'Không tồn tại nhà xuất bản trên!')
		ROLLBACK
	END
	ELSE IF(@COUNT!=0)
    BEGIN     
	  PRINT(N'Đã thêm thành công!!')
        INSERT INTO dbo.DauSach
                ( MaSach ,
                  TuaSach ,
                  MaNXB ,
                  NgonNgu ,
                  TheLoai ,
                  ThoiGianMuonToiDa
                )      
        SELECT *
        FROM inserted 
    END
END
GO

--Kiểm tra khách hàng
CREATE TRIGGER KiemTraKhachTonTai
ON dbo.KhachHang INSTEAD OF  INSERT
AS
BEGIN
	DECLARE @COUNT INT=0
	SELECT @COUNT = COUNT(*) 
	FROM inserted AS A,dbo.KhachHang AS  B
	where  A.MaKhach = B.MaKhach
	IF (@COUNT !=0) 	
	BEGIN
		PRINT(N'Đã tồn tại khách trên!')
		ROLLBACK TRAN
	END
 ELSE 
    BEGIN     
	  PRINT(N'Đã thêm thành công!!')
        INSERT INTO dbo.KhachHang
                ( MaKhach ,
                  TenKhach ,
                  Email ,
                  DiaChiKhach ,
                  DienThoaiKhach)
      
        SELECT * 
        FROM inserted i
    END
END
GO

--Kiểm tra tác giả
CREATE TRIGGER KiemTraTruocKhiThemTacGia
ON TacGia  INSTEAD of  INSERT
AS
BEGIN
    DECLARE @COUNT INT
    SELECT @COUNT = COUNT(A.MaSach)
    FROM DauSach AS A, inserted AS B
    WHERE A.MaSach = B.MaSach
    IF (@COUNT =0) 
    BEGIN
        PRINT(N'Không tồn tại đầu sách trên!')
		ROLLBACK TRAN
    END
    ELSE	
    BEGIN     
	  PRINT(N'Đã thêm thành công!!')
        INSERT INTO TacGia(MaSach,TenTacGia)
        SELECT * 
        FROM inserted i
    END
END
GO

--Kiểm tra cuốn sách
CREATE TRIGGER KiemTraTruocKhiThemCuonSach
ON CuonSach INSTEAD OF INSERT
AS
BEGIN
	DECLARE @COUNT INT
	SELECT @COUNT = COUNT(A.MaSach)
	FROM DauSach AS A, inserted AS B
	WHERE A.MaSach = B.MaSach

	IF (@COUNT = 0) 
	BEGIN
		PRINT(N'Không tồn tại đầu sách trên!')
		ROLLBACK
	END
	 ELSE 
    BEGIN     
	  PRINT(N'Đã thêm thành công!!')
        INSERT INTO dbo.CuonSach
                ( MaSach ,
                  MaCuon ,
                  TinhTrangSach ,
                  DoMoiCuaSach ,
                  GiaMua ,
                  GiaThue ,
                  KeSach ,
                  Tang
                )    
        SELECT * 
        FROM inserted i
    END
END
GO

--Kiểm tra chi tiết đơn mượn
CREATE TRIGGER KiemTraTruocKhiThemChiTietDonMuon
ON dbo.ChiTietDonMuon INSTEAD OF INSERT
AS 
BEGIN
	DECLARE @COUNT INT
	SELECT @COUNT = COUNT(A.MaCuon)
	FROM dbo.CuonSach AS A, inserted AS B, dbo.DonMuon AS C
	WHERE A.MaCuon = B.MaCuon AND B.MaDonMuon=C.MaDonMuon
	IF (@COUNT =0)
	BEGIN
		PRINT(N'Không tồn tại cuốn sách trên hoặc không tồn tại đơn mượn trên')
		ROLLBACK
	END
	 ELSE 
    BEGIN     
	  PRINT(N'*********')
        INSERT INTO dbo.ChiTietDonMuon
                ( MaDonMuon, MaCuon )     
        SELECT * 
        FROM inserted i
    END
END
GO 

--Kiểm tra đơn mượn
CREATE TRIGGER KiemTraTruocKhiThemDonMuon
ON dbo.DonMuon INSTEAD OF INSERT
AS
BEGIN
	DECLARE @COUNT INT
	SELECT @COUNT=COUNT(A.MaKhach)
	FROM dbo.KhachHang AS A, dbo.NhanVien AS B, Inserted AS C
	WHERE A.MaKhach=C.MaKhach AND  B.MaNhanVien=C.MaNhanVien
	IF(@COUNT=0)
	BEGIN
		PRINT(N'Không tồn tại khách hàng hoặc nhân viên nói trên!')
		ROLLBACK
	END  
	 ELSE 
    BEGIN     
	  PRINT(N'Đã thêm thành công!!')
        INSERT INTO dbo.DonMuon
                ( MaDonMuon ,
                  MaNhanVien ,
                  MaKhach ,
                  NgayMuon
                )    
        SELECT * 
        FROM inserted i
    END
END
GO 

--Kiểm tra đơn trả
CREATE TRIGGER KiemTraTruocKhiThemDonTra
ON dbo.DonTra INSTEAD OF INSERT
AS
BEGIN
	DECLARE @COUNT INT
	SELECT @COUNT=COUNT(A.MaDonMuon)
	FROM dbo.DonMuon AS A,Inserted AS B
	WHERE A.MaDonMuon=B.MaDonMuon
	IF(@COUNT=0)
	BEGIN
		PRINT(N'Khồng tồn tại đơn mượn trên!')
		ROLLBACK
	END
	 ELSE 
    BEGIN     
	  PRINT(N'Đã thêm thành công!!')
        INSERT INTO dbo.DonTra
                ( MaDonTra, MaDonMuon )
        SELECT * 
        FROM inserted i
    END
END
GO  

--Kiểm tra chi tiết đơn trả
CREATE TRIGGER KiemTraTruocKhiThemChiTietDonTra
ON dbo.ChiTietDonTra INSTEAD OF INSERT
AS
BEGIN
    DECLARE @COUNT INT
	SELECT @COUNT=COUNT(A.MaDonTra)
	FROM dbo.DonTra AS A,Inserted AS B
	WHERE A.MaDonTra=B.MaDonTra
	IF(@COUNT=0)
	BEGIN
	    PRINT(N'Không tồn tại đơn trả trên!')
		ROLLBACK
	END
	 ELSE 
    BEGIN     
	  PRINT(N'Đã thêm thành công!!')
        INSERT INTO dbo.ChiTietDonTra
                ( MaDonTra, MaCuon, NgayTra, TienPhat )
        SELECT * 
        FROM inserted i
    END
END
GO  

--Kiểm tra nhà xuất bản
CREATE TRIGGER KiemTraNhaXuatBanTonTai
ON dbo.NXB INSTEAD OF  INSERT
AS
BEGIN
	DECLARE @COUNT INT=0
	SELECT @COUNT = COUNT(*) 
	FROM inserted AS A,dbo.NXB AS  B
	where  A.MaNXB = B.MaNXB
	IF (@COUNT !=0) 	
	BEGIN
		PRINT(N'Đã tồn tại nhà xuất bản trên!')
		ROLLBACK TRAN
	END
 ELSE 
    BEGIN     
	  PRINT(N'Đã thêm thành công!!')
        INSERT INTO dbo.NXB
                ( MaNXB ,
                  TenNXB)
        SELECT * 
        FROM inserted i
    END
END
GO

--Kiểm tra nhân viên
CREATE TRIGGER KiemTraNhanVienTonTai
ON dbo.NhanVien INSTEAD OF  INSERT
AS
BEGIN
	DECLARE @COUNT INT=0
	SELECT @COUNT = COUNT(*) 
	FROM inserted AS A,dbo.NhanVien AS  B
	where  A.MaNhanVien = B.MaNhanVien
	IF (@COUNT !=0) 	
	BEGIN
		PRINT(N'Đã tồn tại nhân viên trên!')
		ROLLBACK TRAN
	END
 ELSE 
    BEGIN     
	  PRINT(N'Đã thêm thành công!!')
        INSERT INTO dbo.NhanVien
                ( MaNhanVien ,
                  TenNhanVien ,
                  NgaySinh ,
                  CMND ,
				  GioiTinh,
				  EmailNhanVien,
				  DiaChi,
				  SDT,
				  ChucVu)
        SELECT * 
        FROM inserted i
    END
END
GO