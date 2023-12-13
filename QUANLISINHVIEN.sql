﻿CREATE DATABASE QUANLINHASACH
USE QUANLINHASACH

CREATE TABLE SACH 
(
	MASACH INT IDENTITY(1,1) PRIMARY KEY,
	TENSACH NVARCHAR(100),
	TACGIA NVARCHAR(50),	
	NXB NVARCHAR(50),
	SOLUONGTON INT,
	DONGIANHAP INT,
	DONGIABAN INT
)
GO

CREATE TABLE TAIKHOAN
(
	USERNAME NCHAR(100) PRIMARY KEY,
	PASS NCHAR(100),
	LOAITK INT
)
GO

CREATE TABLE NHANVIEN
(
	MANV INT IDENTITY(1,1) PRIMARY KEY,
	HOTEN NVARCHAR(50),
	SDT CHAR(11),
	DIACHI NVARCHAR(100),
	GIOITINH NVARCHAR(5),
	USERNAME NCHAR(100) FOREIGN KEY REFERENCES TAIKHOAN(USERNAME)
)
GO

CREATE TABLE HOADON
(
	MAHD INT IDENTITY(1,1) PRIMARY KEY,
	NGAYLAP DATE,
	MANV INT,
	TONGTIEN INT,
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
)
GO

CREATE TABLE CTHD
(
	MAHD INT FOREIGN KEY REFERENCES HOADON(MAHD),
	MASACH INT FOREIGN KEY REFERENCES SACH(MASACH),
	SOLUONG INT,
	THANHTIEN INT
	PRIMARY KEY (MAHD,MASACH)
)
GO

CREATE TABLE PHIEUNHAP
(
	MAPN INT IDENTITY(1,1) PRIMARY KEY,
	NGAYLAP DATE,
	TONGTIEN INT
)
GO

CREATE TABLE CTPN
(
	MAPN INT IDENTITY(1,1) FOREIGN KEY REFERENCES PHIEUNHAP(MAPN),
	MASACH INT FOREIGN KEY REFERENCES SACH(MASACH),
	SOLUONG INT,
	DONGIANHAP INT,
	DONGIABAN INT,
	THANHTIEN INT
)
GO

--add Account
INSERT INTO TAIKHOAN VALUES ('K9','1',1) --quanli
INSERT INTO TAIKHOAN VALUES ('staff','1', 0) --nhanvien
INSERT INTO TAIKHOAN VALUES ('QUANHAO', '22520584', 0)
go

--add Book

INSERT INTO SACH VALUES (N'Ác mộng trong đêm',N'john',N'ocb',120,30000,37000)
INSERT INTO SACH VALUES (N'Kính vạn hoa',N'Thảo Điền',N'Kim Đồng',100,80000,98000)
INSERT INTO SACH VALUES (N'Harry Porter',N'Rowling',N'Trẻ',130,80000,105000)
INSERT INTO SACH VALUES (N'Nhà giả kim',N'Paulo',N'Nhã Nam',100,88000,100000)
INSERT INTO SACH VALUES (N'Pháp luật đại cương',N'Lê Vũ Nam',N'Sự thật',100,72000,95000)
INSERT INTO SACH VALUES (N'Tam Quốc Diễn Nghĩa',N'La Quán Trung','Trẻ',150,102000,130000)
INSERT INTO SACH VALUES (N'Tết ở làng địa ngục',N'Thảo Trang',N'Thanh niên',110,100000,126000)
INSERT INTO SACH VALUES (N'Luật nhân quả',N'Thích Lí Chơn',N'Phật giáo',40,3000,12000)
INSERT INTO SACH VALUES (N'Đắc nhân tâm',N'Dale',N'Trí Việt',100,75000,86000)
INSERT INTO SACH VALUES (N'Thép đã tôi thế đấy',N'Ostrosvky',N'Văn học',800,132000,165000)
INSERT INTO SACH VALUES (N'Chiến tranh tiền tệ',N'Song Hong Bing',N'Lao động',30,102000,165000)
INSERT INTO SACH VALUES (N'Cây cam ngọt của tôi',N'Jaue Maro',N'Văn học',37,75000,108000)
INSERT INTO SACH VALUES (N'Thỏ bảy màu',N'Huỳnh Thái Ngọc',N'Dân trí',123,84000,100000)
INSERT INTO SACH VALUES (N'Tâm lí học tội phạm',N'Diệp Hồng Vũ',N'Thanh niên',68,101000,145000)
INSERT INTO SACH VALUES (N'Đạo làm con',N'Thanh Duy',N'Phật giáo',40,19000,27000)

--ADD STAFF
INSERT INTO NHANVIEN VALUES (N'Trình Quan Hạo','0979128232',N'Đồng Nai',N'Nam','QUANHAO')
INSERT INTO NHANVIEN VALUES (N'Trương Tuấn Huy','0362621369',N'Tây Ninh',N'Nam','staff')

--add Bill
SET DATEFORMAT DMY

INSERT INTO HOADON VALUES ('11/12/2023',1, 137000)
INSERT INTO HOADON VALUES ('11/12/2023',1, 127000)
INSERT INTO HOADON VALUES ('12/12/2023',1, 145000)
INSERT INTO HOADON VALUES ('12/12/2023',2, 108000)
INSERT INTO HOADON VALUES ('12/12/2023',2, 98000)

--add BillInfo
INSERT INTO CTHD VALUES (1,13,1, 100000)
INSERT INTO CTHD VALUES (1,1,1, 37000)
INSERT INTO CTHD VALUES (2,4,1, 100000)
INSERT INTO CTHD VALUES (2,15,1, 27000)
INSERT INTO CTHD VALUES (3,14,1, 145000)
INSERT INTO CTHD VALUES (4,12,1, 108000)
INSERT INTO CTHD VALUES (5,2,1, 98000)

--PROC
CREATE PROC USP_GetBookStock
@name NVARCHAR(100), @auth NVARCHAR(50)
AS
BEGIN
	SELECT * FROM SACH
	WHERE TENSACH = @name AND TACGIA = @auth
END
GO

CREATE PROC USP_Login
@username NCHAR(100), @password NCHAR(100)
AS
BEGIN
	SELECT * FROM TAIKHOAN WHERE USERNAME = @username AND PASS = @password
END
GO

CREATE PROC USP_GetFilteredBookList
@bookname NVARCHAR(100)
AS
BEGIN
	SELECT * FROM SACH WHERE TENSACH LIKE '%'+@bookname+'%'
END
GO

CREATE PROC USP_GetBookList
AS SELECT * FROM SACH
GO

--bill list
CREATE PROC USP_GetBillList
AS SELECT * FROM HOADON
GO

