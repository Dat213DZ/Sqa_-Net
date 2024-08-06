CREATE DATABASE QUANLI_TH_SPA
GO
USE QUANLI_TH_SPA
GO

restore database QUANLI_TH_SPA
from disk ='C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\Backup\QUANLI_TH_SPA.bak'
with norecovery

restore database QUANLI_TH_SPA
from disk ='C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\Backup\QUANLI_TH_SPA_LogBackup_2023-11-13_22-31-30.bak'
with recovery

-- NHÂN VIÊN
CREATE TABLE NHANVIEN(
	ID VARCHAR(20) PRIMARY KEY,
	PASSWORD VARCHAR(12),
	TENNV NVARCHAR(50),
	SDT INT,
	EMAIL NVARCHAR(50),
	DIACHI NVARCHAR(80),
	CHUCVU NVARCHAR(50),
	TRINHDO NVARCHAR(50),
	SINHNAM DATE,
	GIOITINH NVARCHAR(50) CHECK(GIOITINH = N'Nam' OR GIOITINH = N'Nữ')
)

CREATE TABLE KHACHHANG(
	ID VARCHAR(20) PRIMARY KEY,
	TENKH NVARCHAR(50),
	SDT INT,
	EMAIL NVARCHAR(50),
	DIACHI NVARCHAR(80),
	SINHNAM DATE,
	GIOITINH NVARCHAR(50),
	NV_ID VARCHAR(20),	
	TINHTRANG NVARCHAR(50),
	FOREIGN KEY (NV_ID) REFERENCES NHANVIEN(ID),
	CHECK((GIOITINH = N'Nam' OR GIOITINH = N'Nữ') AND(TINHTRANG = N'Đã đến' OR TINHTRANG = N'Chưa đến'))
)

-- SẢN PHẨM
CREATE TABLE SANPHAM(
	ID VARCHAR(20) PRIMARY KEY,
	TENSP NVARCHAR(50),
	SOLUONG INT DEFAULT 1,
	GIA INT DEFAULT 1000,
	MOTA NVARCHAR(500),
	NV_ID VARCHAR(20),
	FOREIGN KEY (NV_ID) REFERENCES NHANVIEN(ID)	
)
-- DỊCH VỤ
CREATE TABLE DICHVU(
	ID VARCHAR(20) PRIMARY KEY,
	TENDV NVARCHAR(50),
	MOTA NVARCHAR(500),
	GIA INT DEFAULT 1000,
	NV_ID VARCHAR(20),
	FOREIGN KEY (NV_ID) REFERENCES NHANVIEN(ID)
)
-- GÓI DỊCH VỤ
CREATE TABLE GOIDV(
	ID VARCHAR(20) PRIMARY KEY,
	TENGOIDV NVARCHAR(50),
	MOTA NVARCHAR(500),
	GIA INT DEFAULT 1000,
	NV_ID VARCHAR(20),
	FOREIGN KEY (NV_ID) REFERENCES NHANVIEN(ID)
)
-- CHI TIẾT GÓI DỊCH VỤ
CREATE TABLE CT_GOIDV(
	GDV_ID VARCHAR(20),
	DV_ID VARCHAR(20),
	PRIMARY KEY (GDV_ID, DV_ID),
	FOREIGN KEY (GDV_ID) REFERENCES GOIDV(ID),
	FOREIGN KEY (DV_ID) REFERENCES DICHVU(ID)
)
-- LIỆU TRÌNH
CREATE TABLE LIEUTRINH(
	ID VARCHAR(20) PRIMARY KEY,
	TENLT NVARCHAR(50),
	MOTA NVARCHAR(500),
	GIA INT DEFAULT 1000,
	NV_ID VARCHAR(20),
	FOREIGN KEY (NV_ID) REFERENCES NHANVIEN(ID)
)
-- LỊCH HẸN
CREATE TABLE LICHHEN(
	ID VARCHAR(20) PRIMARY KEY,
	KH_ID VARCHAR(20),
	NGAYDAT DATE DEFAULT GETDATE(),
	NGAYDEN DATE,	
	FOREIGN KEY (KH_ID) REFERENCES KHACHHANG(ID)
)
-- HÓA ĐƠN
CREATE TABLE HOADON(	
	ID VARCHAR(20) PRIMARY KEY,
	NV_ID VARCHAR(20),
	NGAYTAO DATE DEFAULT GETDATE(),		
	THANHTIEN INT,
	FOREIGN KEY (NV_ID) REFERENCES NHANVIEN(ID)
)
-- HÓA ĐƠN
CREATE TABLE CT_HOADON(	
	ID VARCHAR(20) PRIMARY KEY,	
	HD_ID VARCHAR(20),
	SP_ID VARCHAR(20),
	SOLUONG INT DEFAULT 1,
	DV_ID VARCHAR(20),
	GOIDV_ID VARCHAR(20),
	LT_ID VARCHAR(20),
	TONGTIEN INT DEFAULT 1000,
	FOREIGN KEY (HD_ID) REFERENCES HOADON(ID),
	FOREIGN KEY (SP_ID) REFERENCES SANPHAM(ID),
	FOREIGN KEY (DV_ID) REFERENCES DICHVU(ID),
	FOREIGN KEY (GOIDV_ID) REFERENCES GOIDV(ID),
	FOREIGN KEY (LT_ID) REFERENCES LIEUTRINH(ID)	
)


---INSERT---

INSERT INTO NHANVIEN
VALUES
('NV01', '123456', N'Nguyễn Văn Hùng', 1234567890, 'hungnguyen123@mail.com', N'123 Đường Nguyễn Thị Minh Khai, Phường Bến Nghé, Quận 1', N'Nhân viên', N'Bình Thường', '1980', N'Nam'),
('NV02', 'abcd', N'Lê Thị Mai', 1876543210, 'maile234@mail.com', N'100 Đường Điện Biên Phủ, Phường 10, Quận Bình Thạnh', N'Nhân viên', N'Bình Thường', '1985', N'Nữ'),
('NV03', '123456', N'Trần Ngọc Huyền', 1112223333, 'huyentran123@mail.com', N'789 Đường Nguyễn Văn Cừ, Phường 2, Quận 5', N'Quản lí', N'Bình Thường', '1990', N'Nữ'),
('NV04', '0123ab', N'Phạm Đức Thành', 1445556666, 'thanhphamduc@mail.com', N'1011 Đường Nguyễn Trãi, Phường 2, Quận 5', N'Nhân viên', N'Bình Thường', '1995', N'Nam'),
('NV05', '147cbd', N'Huỳnh Khánh Ly', 1778889999, 'lykhanhhuynh@mail.com', N'1213 Đường Điện Biên Phủ, Phường 15, Quận Bình Thạnh', N'Nhân viên', N'Bình Thường', '2000', N'Nữ');


INSERT INTO KHACHHANG
VALUES
('KH01', N'Bảo Long Trần', 1234567888, 'baolong@example.com', N'123 Đường Nguyễn Thị Minh Khai, Phường Bến Nghé, Quận 1', '1970', N'Nam', 'NV01', N'Đã đến'),
('KH02', N'Diệu Linh Lê', 1876543999, 'linhlisa@example.com', N'456 Đường Lê Văn Sỹ, Phường 10, Quận Phú Nhuận', '1975', N'Nữ','NV02', N'Đã đến' ),
('KH03', N'Diễm Quỳnh Phạm', 1112223333, 'phamjohnson@example.com', N'789 Đường Nguyễn Văn Cừ, Phường 2, Quận 5', '1980', N'Nữ', 'NV03', N'Đã đến'),
('KH04', N'Quang Minh Nguyễn', 1445556555, 'sarahquang@example.com', N'1011 Đường Nguyễn Trãi, Phường 2, Quận 5', '1985', N'Nam', 'NV03', N'Chưa đến'),
('KH05', N'Thế Đạt Huỳnh', 1778889666, 'daviddat@example.com', N'1213 Đường Điện Biên Phủ, Phường 15, Quận Bình Thạnh', '1990', N'Nam', 'NV04', N'Chưa đến'),
('KH06', N'Long Trần', 0147852369, 'baolog@example.com', N'123 Đường Nguyễn Thị Minh Khai, Phường Bến Nghé, Quận 1', '1980', N'Nam', 'NV01', N'Đã đến'),
('KH07', N'Diệu Thanh Linh', 0123698547, 'linhli@example.com', N'456 Đường Lê Văn Sỹ, Phường 10, Quận Phú Nhuận', '1995', N'Nữ','NV01', N'Đã đến' ),
('KH08', N'Diễm Quỳnh', 0014587965, 'phamjohn@example.com', N'789 Đường Nguyễn Văn Cừ, Phường 2, Quận 5', '1989', N'Nữ', 'NV01', N'Đã đến'),
('KH09', N'Quang Minh', 025889745, 'sahquang@example.com', N'1011 Đường Nguyễn Trãi, Phường 2, Quận 5', '1995', N'Nam', 'NV03', N'Chưa đến'),
('KH10', N'Đạt Huỳnh', 0001243694, 'viddat@example.com', N'1213 Đường Điện Biên Phủ, Phường 15, Quận Bình Thạnh', '1990', N'Nam', 'NV02', N'Chưa đến');

INSERT INTO SANPHAM
VALUES
('SP01', N'Mặt nạ', 10, 10000, N'Một sản phẩm phổ biến trong các liệu trình chăm sóc da mặt.', 'NV01'),
('SP02', N'Serum', 20, 20000, N'Một sản phẩm chăm sóc da chuyên sâu, có tác dụng thẩm thấu sâu vào da để mang lại hiệu quả cao', 'NV02'),
('SP03', N'Kem dưỡng da', 30, 30000, N'Một sản phẩm chăm sóc da cơ bản, giúp giữ ẩm và bảo vệ da.', 'NV05'),
('SP04', N'Dầu dưỡng da', 40, 40000, N'Một sản phẩm chăm sóc da giúp dưỡng ẩm và làm mềm da. ', 'NV02'),
('SP05', N'Sữa rửa mặt', 50, 50000, N'Một sản phẩm chăm sóc da cơ bản, giúp làm sạch da và loại bỏ bụi bẩn, bã nhờn.', 'NV04');

INSERT INTO DICHVU
VALUES
('DV01', N'Chăm sóc da mặt', N'Dịch vụ này bao gồm các bước làm sạch da, tẩy tế bào chết, massage, đắp mặt nạ,... để giúp da sạch khỏe, mịn màng.', 100000, 'NV01'),
('DV02', N'Triệt lông', N'Dịch vụ được nhiều khách hàng lựa chọn để loại bỏ lông thừa trên cơ thể.', 150000, 'NV01'),
('DV03', N'Tắm trắng', N'Dịch vụ giúp da trắng sáng và đều màu.', 200000, 'NV01'),
('DV04', N'Giảm béo chân', N'Dịch vụ giúp mỡ tan đi.', 150000, 'NV03'),
('DV05', N'Giảm béo bụng', N'Dịch vụ giúp mỡ tan đi.', 150000, 'NV03'),
('DV06', N'Giảm béo tay', N'Dịch vụ giúp mỡ tan đi.', 150000, 'NV03'),
('DV07', N'massage mặt', N'giúp các cơ thư giản, giảm đơ cứng và đau nhức.', 350000, 'NV04'),
('DV08', N'massage cổ, vai, ngái', N'giúp các cơ thư giản, giảm đơ cứng và đau nhức.', 350000, 'NV04'),
('DV09', N'massage chân, tay', N'giúp các cơ thư giản, giảm đơ cứng và đau nhức.', 350000, 'NV04');

INSERT INTO GOIDV
VALUES
('GDV01', N'Gói chăm sóc da mặt', N'các bước làm sạch da, tẩy tế bào chết, massage, đắp mặt nạ,...', 250000, 'NV01'),
('GDV02', N'Gói triệt lông toàn thân', N'giúp loại bỏ lông thừa trên toàn bộ cơ thể, mang lại làn da mịn màng, không còn vết thâm.', 350000, 'NV01'),
('GDV03', N'Gói massage thư giãn', N'giúp giảm căng thẳng, mệt mỏi, cải thiện giấc ngủ.', 250000,  'NV04'),
('GDV04', N'Gói giảm béo toàn thân', N'giúp giảm cân và thon gọn cơ thể, mang lại vóc dáng thon thả.', 250000,  'NV02'),
('GDV05', N'Gói tắm trắng toàn thân', N'giúp da trắng sáng, đều màu, rạng rỡ.', 250000,  'NV03');

INSERT INTO CT_GOIDV
VALUES
('GDV01', 'DV01'),
('GDV02', 'DV02'),
('GDV03', 'DV07'),
('GDV03', 'DV08'),
('GDV03', 'DV09'),
('GDV04', 'DV04'),
('GDV04', 'DV05'),
('GDV04', 'DV06'),
('GDV05', 'DV03')

INSERT INTO LIEUTRINH
VALUES
('LT01', N'Chăm sóc da mặt', N'Liệu trình này bao gồm các bước làm sạch da, tẩy tế bào chết, massage, đắp mặt nạ,...', 300000, 'NV02'),
('LT02', N'Triệt lông', N'Có nhiều phương pháp triệt lông khác nhau, phù hợp với từng vùng da và nhu cầu của khách hàng.', 400000, 'NV02'),
('LT03', N'Massage', N'Có nhiều loại massage khác nhau, phù hợp với từng nhu cầu của khách hàng', 300000, 'NV04'),
('LT04', N'Giảm béo', N'Có nhiều phương pháp giảm béo khác nhau, phù hợp với từng cơ địa và nhu cầu của khách hàng.', 300000, 'NV03'),
('LT05', N'Tắm trắng', N'Có nhiều phương pháp tắm trắng khác nhau, phù hợp với từng loại da và nhu cầu của khách hàng.', 300000, 'NV03')

INSERT INTO LICHHEN
VALUES
('LH01', 'KH01', '2023-10-25', '2023-10-26'),
('LH02', 'KH04', '2023-10-26', '2023-10-27'),
('LH03', 'KH05', '2023-10-27', '2023-10-28'),
('LH04', 'KH01', '2023-11-25', '2023-12-26'),
('LH05', 'KH04', '2023-9-26', '2023-10-27')

CREATE TRIGGER UPD_TIENHD ON CT_HOADON
FOR INSERT, UPDATE
AS
	IF UPDATE(Tongtien)
	BEGIN
		UPDATE HOADON
		SET THANHTIEN = CT_HOADON.Tongtien
		FROM CT_HOADON
		WHERE HOADON.Id = CT_HOADON.Hd_Id
	END

--3 update thành tiền trên hóa đơn mỗi khi tổng tiền của ct_hoadon update
CREATE TRIGGER UPD_TONGTIEN1 ON CT_HOADON
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE CT_HOADON
			SET Tongtien = S.Gia*inserted.Soluong + D.Gia + G.Gia + L.Gia 
			FROM SANPHAM S, DICHVU D, GOIDV G, LIEUTRINH L,inserted 
			WHERE S.Id = inserted.Sp_Id AND D.Id = inserted.Dv_Id AND G.Id = inserted.Goidv_Id AND L.Id = inserted.Lt_Id AND CT_HOADON.Hd_Id = inserted.Hd_Id
	END

INSERT INTO HOADON
VALUES
('HD01', 'NV01', '2023-10-25',NULL),
('HD02', 'NV02', '2023-10-26',NULL),
('HD03', 'NV03', '2023-10-27',NULL)

INSERT INTO CT_HOADON 
VALUES
('CTHD01', 'HD01', 'SP01', 5, 'DV01',  'GDV01', 'LT02', NULL),
('CTHD02', 'HD02', 'SP04', 10, 'DV01',  'GDV03', 'LT01', NULL),
('CTHD03', 'HD03', 'SP02', 5, 'DV02',  'GDV02', 'LT03', NULL)

-----------------------------
SELECT * FROM NHANVIEN
SELECT * FROM KHACHHANG
SELECT * FROM SANPHAM
SELECT * FROM DICHVU
SELECT * FROM GOIDV
SELECT * FROM CT_GOIDV
SELECT * FROM LIEUTRINH
SELECT * FROM LICHHEN
SELECT * FROM HOADON
SELECT * FROM CT_HOADON
-----------------------------