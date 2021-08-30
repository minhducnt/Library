--Top 10 nhà xuất bản nhiều đầu sách nhất
CREATE VIEW Top10NXBXuatBanNhieuDauSachNhat
AS
	SELECT TOP(10) B.MaNXB,B.TenNXB, COUNT(A.MaSach) AS SoLuongDauSach
	FROM DauSach AS A,dbo.NXB AS B
	WHERE A.MaNXB=B.MaNXB
	GROUP BY B.MaNXB,B.TenNXB
	ORDER BY SoLuongDauSach DESC
GO

--Top 10 Tác giả viết nhiều đầu sách nhất
CREATE VIEW Top10TacGiaVietNhieuSachNhat
AS
	SELECT TOP(10) A.TenTacGia, COUNT(A.MaSach) AS SoLuongDauSach
	FROM TacGia AS A
	GROUP BY A.TenTacGia
	ORDER BY SoLuongDauSach DESC
GO

--Top 10 đầu sách có nhiều sách nhất
CREATE VIEW Top10DauSachCoNhieuCuonSachNhat
AS
	SELECT TOP(10) B.MaSach,B.TuaSach, COUNT(A.MaCuon) AS SoLuongCuonSach
	FROM CuonSach AS A,dbo.DauSach AS B
	WHERE A.MaSach=B.MaSach
	GROUP BY B.MaSach,B.TuaSach
	ORDER BY SoLuongCuonSach DESC
GO

--Top 10 Khách hàng mượn nhiều cuốn sách nhất
CREATE VIEW Top10KhachHangMuonNhieuSachNhat
AS
	SELECT TOP(10) C.MaKhach,C.TenKhach, COUNT(A.MaCuon) AS SoLuongDauSach
	FROM ChiTietDonMuon AS A, DonMuon AS B,dbo.KhachHang AS C
	WHERE A.MaDonMuon = B.MaDonMuon AND B.MaKhach=C.MaKhach
	GROUP BY C.MaKhach,C.TenKhach
	ORDER BY SoLuongDauSach DESC
GO
 
--Top 10 sách trả quá hạn nhất
CREATE VIEW Top10SachTraQuaHanNhat
AS
	SELECT TOP (10)E.MaSach,E.TuaSach, (datediff(year,B.NgayMuon, F.NgayTra )- E.ThoiGianMuonToiDa) AS SoNamQuaHan
	FROM DonTra AS A, DonMuon AS B, ChiTietDonMuon AS C,
		 CuonSach AS D, DauSach AS E, ChiTietDonTra AS F
	WHERE A.MaDonMuon = B.MaDonMuon AND B.MaDonMuon = C.MaDonMuon AND 
		  C.MaCuon = D.MaCuon AND D.MaSach = E.MaSach AND
		  ((datediff(year, B.NgayMuon,F.NgayTra )- E.ThoiGianMuonToiDa) > 0) AND A.MaDonTra = F.MaDonTra
	GROUP BY E.MaSach,E.TuaSach,b.NgayMuon,F.NgayTra,E.ThoiGianMuonToiDa
	ORDER BY SoNamQuaHan DESC
GO
 