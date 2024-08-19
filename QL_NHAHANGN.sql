﻿CREATE DATABASE QL_NHAHANGN
GO
USE QL_NHAHANGN

--Bảng Loại Sản phẩm
CREATE TABLE LOAISP
(
  MALOAI char(4) not null,
  TENLOAI nvarchar(25)
  CONSTRAINT PK_LOAISP PRIMARY KEY(MALOAI)
)
--Insert dữ liệu bảng LOAISP
INSERT dbo.LOAISP
VALUES ('KV',N'Món khai vị');
INSERT dbo.LOAISP
VALUES ('AV',N'Đồ ăn vặt');
INSERT dbo.LOAISP
VALUES ('AK',N'Đồ ăn kèm')
INSERT dbo.LOAISP
VALUES ('ĐU',N'Đồ uống')
INSERT dbo.LOAISP
VALUES ('MC',N'Món chính')
INSERT dbo.LOAISP
VALUES ('TM',N'Tráng miệng')

----------------------------------------------------------------------------------------------------------------------
--Bảng Nhà cung cấp
CREATE TABLE NCC
(
   MANCC char(6) not null,
   TENNCC nvarchar(25) not null,
   DIACHI nvarchar(20),
   DTHOAI char(12),
   CONSTRAINT PK_NCC PRIMARY KEY(MANCC)
)
--Thêm ràng buộc cho bảng NCC
ALTER TABLE NCC
ADD CONSTRAINT UNI_DTHOAI UNIQUE(DTHOAI)
--Inser dữ liệu cho bảng NCC
INSERT dbo.NCC
VALUES('MC',N'Masan Group Corporation',N'Quận Tân Phú','0868526345');
INSERT dbo.NCC
VALUES('CP',N'C.P. Vietnam Corporation',N'Quận 1','0725127865');
INSERT dbo.NCC
VALUES('CT',N'Công ty Nông sản Cần Thơ',N'Quận 7','0345697824');
INSERT dbo.NCC
VALUES('AC',N'Acecook',N'Quận Bình Tân','0865247891');
INSERT dbo.NCC
VALUES('SP',N'Suntory Pepsico Vietnam',N'Quận 3','0347891358');
INSERT dbo.NCC
VALUES('CC',N'Coca-Cola Vietnam',N'Quận 1','0465782896');
INSERT dbo.NCC
VALUES('SBC',N'Công ty SABECO',N'Quận Phú Nhuận','0792413257');
INSERT dbo.NCC
VALUES('AS',N'Anova Seafood',N'Quận 3','0896564823');
INSERT dbo.NCC
VALUES('DG',N'Dabaco Group',N'Quận 2','0568341895');
INSERT dbo.NCC
VALUES('LL',N'Lock&Lock',N'Quận 8','0367541236');
INSERT dbo.NCC
VALUES('PL',N'Philips Vietnam',N'Quận 8','0952364829');
INSERT dbo.NCC
VALUES('EV',N'Electrolux Vietnam',N'Quận Tân Phú','0687654158');
INSERT dbo.NCC
VALUES('SH',N'Sunhouse',N'Quận Gò Vấp','0687154863');
INSERT dbo.NCC
VALUES('AJ',N'Công ty AJI Việt Nam',N'Quận 1','0687155863');
INSERT dbo.NCC
VALUES('U',N'Unilever',N'Quận Phú Nhuận','0793413257');
INSERT dbo.NCC
VALUES('SV',N'Công ty Sen Việt',N'Quận Phú Nhuận','0493413257');
INSERT dbo.NCC
VALUES('ML',N'Công ty gốm sứ Minh Long',N'Quận Phú Nhuận','0495413257');

--------------------------------------------------------------------------------------------------------------------------
-- Bảng thực đơn
CREATE TABLE THUCDON
(
  MASP char(6) not null,
  TENSP nvarchar(50),
  MALOAI char(4),
  DVT nvarchar(4),
  DONGIA MONEY,
  CONSTRAINT PK_SANPHAM PRIMARY KEY(MASP),
  CONSTRAINT FK_SANPHAM_LOAISP FOREIGN KEY (MALOAI) REFERENCES LOAISP(MALOAI),
)
--Thêm ràng buộc bảng THUCDON
ALTER TABLE THUCDON
ADD CONSTRAINT CHK_DONGIATD CHECK (DONGIA>0)
ALTER TABLE THUCDON
ADD CONSTRAINT CHK_DVTTD CHECK (DVT=N'phần' OR DVT=N'đĩa' OR DVT=N'chai' OR DVT=N'ly' OR DVT=N'lon')
-- Insert dữ liệu cho bảng THUCDON
INSERT dbo.THUCDON
VALUES('G01',N'Gà nướng ngũ vị','MC',N'phần',160000);
INSERT dbo.THUCDON
VALUES('G02',N'Gà hầm nấm','MC',N'phần',120000);
INSERT dbo.THUCDON
VALUES('G03',N'Lẩu gà lá é','MC',N'phần',230000);
INSERT dbo.THUCDON
VALUES('B01',N'Bò hầm sốt vang','MC',N'phần',350000);
INSERT dbo.THUCDON
VALUES('B02',N'Bò kho','MC',N'phần',300000);
INSERT dbo.THUCDON
VALUES('B03',N'Bò sốt tiêu đen','MC',N'phần',350000);
INSERT dbo.THUCDON
VALUES('H01',N'Nầm heo nướng chao','MC',N'phần',110000);
INSERT dbo.THUCDON
VALUES('H02',N'Sườn nướng ngũ vị','MC',N'phần',175000);
INSERT dbo.THUCDON
VALUES('H03',N'Ba chỉ heo cháy tỏi','MC',N'phần',130000);
INSERT dbo.THUCDON
VALUES('TB01',N'Cơm chiên dương châu','MC',N'phần',85000);
INSERT dbo.THUCDON
VALUES('TB02',N'Mì xào bò','MC',N'phần',76000);
INSERT dbo.THUCDON
VALUES('TB03',N'Mì xào hải sản','MC',N'phần',82000);
INSERT dbo.THUCDON
VALUES('AK03',N'Bánh mì','AK',N'đĩa',18000);
INSERT dbo.THUCDON
VALUES('AK04',N'Rau sống','AK',N'đĩa',15000);
INSERT dbo.THUCDON
VALUES('AK05',N'Bún','AK',N'đĩa',20000);
INSERT dbo.THUCDON
VALUES('AK06',N'Cơm trắng','AK',N'đĩa',25000);
INSERT dbo.THUCDON
VALUES('AV01',N'khoai tây lắc phô mai','AV',N'đĩa',25000);
INSERT dbo.THUCDON
VALUES('AV02',N'Viên chiên sốt mắm tỏi','AV',N'đĩa',45000);
INSERT dbo.THUCDON
VALUES('AV03',N'Bánh bao chiên chấm sữa','AV',N'đĩa',35000);
INSERT dbo.THUCDON
VALUES('AV04',N'Bánh tráng cuốn chiên','AV',N'đĩa',35000);
INSERT dbo.THUCDON
VALUES('KV01',N'Bò tái chanh','KV',N'đĩa',55000);
INSERT dbo.THUCDON
VALUES('KV02',N'Salad cầu vồng','KV',N'đĩa',30000);
INSERT dbo.THUCDON
VALUES('KV03',N'Chả giò tôm mayonaise','KV',N'đĩa',65000);
INSERT dbo.THUCDON
VALUES('KV04',N'Gỏi cuốn tôm thịt','KV',N'đĩa',68000);
INSERT dbo.THUCDON
VALUES('KV05',N'Súp hải sản','KV',N'phần',95000);
INSERT dbo.THUCDON
VALUES('DU01',N'Bia hơi','ĐU',N'ly',25000);
INSERT dbo.THUCDON
VALUES('DU02',N'Bia đen','ĐU',N'ly',45000);
INSERT dbo.THUCDON
VALUES('DU04',N'Tiger xanh','ĐU',N'lon',20000);
INSERT dbo.THUCDON
VALUES('DU05',N'333','ĐU',N'lon',15000);
INSERT dbo.THUCDON
VALUES('DU06',N'Coca-Cola','ĐU',N'lon',25000);
INSERT dbo.THUCDON
VALUES('DU07',N'Pepsi','ĐU',N'lon',25000);
INSERT dbo.THUCDON
VALUES('DU08',N'7-Up','ĐU',N'lon',25000)
INSERT dbo.THUCDON
VALUES('DU09',N'Nước suối Lavie','ĐU',N'chai',20000)
INSERT dbo.THUCDON
VALUES('DU10',N'Rượu vang','ĐU',N'chai',445000);
INSERT dbo.THUCDON
VALUES('TM01',N'Bánh Flan','TM',N'phần',35000);
INSERT dbo.THUCDON
VALUES('TM02',N'Rau câu dừa','TM',N'phần',35000);
INSERT dbo.THUCDON
VALUES('TM03',N'Trái cây tươi','TM',N'phần',55000);
INSERT dbo.THUCDON
VALUES('TM04',N'Panna cotta','TM',N'phần',45000);
INSERT dbo.THUCDON
VALUES('TM05',N'Kem','TM',N'phần',35000);

--------------------------------------------------------------------------------------------------------------------
--Bảng khách hàng
CREATE TABLE KHACHHANG
(
  MAKH char(6) not null,
  TENKH nvarchar(25),
  DIACHI nvarchar(15),
  DTHOAI char(11),
  CONSTRAINT PK_KHACHHANG PRIMARY KEY(MAKH)
)
--Thêm ràng buộc cho bảng KHACHHANG
ALTER TABLE KHACHHANG
ADD CONSTRAINT UNI_DTHOAIKH UNIQUE(DTHOAI)
--Insert dữ liệu bảng khách hàng
INSERT dbo.KHACHHANG
VALUES ('KH001',N'Nguyễn Thu Tâm',N'Quận 7','0989751723');
INSERT dbo.KHACHHANG
VALUES ('KH002',N'Đinh Bảo Lộc',N'Quận Tân Phú','0918234654');
INSERT dbo.KHACHHANG
VALUES ('KH003',N'Trần Thanh Diệu',N'Quận 12','0978123765');
INSERT dbo.KHACHHANG
VALUES ('KH004',N'Hồ Tuấn Thành',N'Quận Gò Vấp','0909456768');
INSERT dbo.KHACHHANG
VALUES ('KH005',N'Huỳnh Kim Ánh',N'Quận Bình Tân','0932987567');
INSERT dbo.KHACHHANG
VALUES ('KH006',N'Trần Văn Nam',N'Quận Gò Vấp','0928396452');
INSERT dbo.KHACHHANG
VALUES ('KH007',N'Phạm Trọng Khanh',N'Quận 12','0897653214');
INSERT dbo.KHACHHANG
VALUES ('KH008',N'Nguyễn Thị Quỳnh Như',N'Quận Tân Phú','0897662437');
INSERT dbo.KHACHHANG
VALUES ('KH009',N'Nguyễn Hoàng Long',N'Quận 3','0826541325');
INSERT dbo.KHACHHANG
VALUES ('KH010',N'Trần Thị Thanh Phương',N'Quận 12','0986253546');

-----------------------------------------------------------------------------------------------------------------
-- Bảng bộ phận
CREATE TABLE BOPHAN
(
  MABP char(6) not null,
  TENBP nvarchar(25),
  CONSTRAINT PK_BOPHAN PRIMARY KEY(MABP)
)
--Insert dữ liệu bảng BOPHAN
INSERT dbo.BOPHAN
VALUES ('QL',N'Quản lý');
INSERT dbo.BOPHAN
VALUES ('DV',N'Dịch vụ');
INSERT dbo.BOPHAN
VALUES ('B',N'Bếp');
INSERT dbo.BOPHAN
VALUES ('PV',N'Phục vụ');
INSERT dbo.BOPHAN
VALUES ('VS',N'Vệ sinh');
INSERT dbo.BOPHAN
VALUES ('AN',N'An ninh');

------------------------------------------------------------------------------------------------------------------------
-- Bảng ca làm
CREATE TABLE CALAM
(
  TENCA nvarchar(30) not null,
  GBD time,
  GKT time,
  CONSTRAINT PK_CALAM PRIMARY KEY(TENCA)
)
-- Thêm ràng buộc bảng CALAM
ALTER TABLE CALAM
ADD CONSTRAINT CHK_GVL CHECK (GBD<GKT)
ALTER TABLE CALAM
ADD CONSTRAINT CHK_TENCA CHECK (TENCA=N'Sáng' OR TENCA=N'Chiều' OR TENCA=N'Hành chính')
-- Insert dữ liệu bảng CALAM
INSERT dbo.CALAM
VALUES (N'Sáng','10:00:00','16:00:00');
INSERT dbo.CALAM
VALUES (N'Chiều','16:00:00','22:00:00');
INSERT dbo.CALAM
VALUES (N'Hành chính','08:00:00','17:00:00');

-------------------------------------------------------------------------------------------------------------
--Bảng chức vụ
CREATE TABLE CHUCVU
(
  MACV char(6) not null,
  TENCV nvarchar (25),
  MABP char(6),
  LUONG MONEY,
  CONSTRAINT PK_CHUCVU PRIMARY KEY(MACV),
  CONSTRAINT FK_CHUCVU_BOPHAN FOREIGN KEY (MABP) REFERENCES BOPHAN(MABP)
)
-- Thêm ràng buộc bảng CHUCVU
ALTER TABLE CHUCVU
ADD CONSTRAINT CHK_LUONG CHECK (LUONG>0)
--Insert dữ liệu bảng CHUCVU
INSERT dbo.CHUCVU
VALUES ('GĐ',N'Giám đốc','QL',60000000);
INSERT dbo.CHUCVU
VALUES ('TBP',N'Trưởng bộ phận','QL',25000000);
INSERT dbo.CHUCVU
VALUES ('QLNH',N'Quản lý nhà hàng','QL',20000000);
INSERT dbo.CHUCVU
VALUES ('BT',N'Bếp trưởng','B',40000000);
INSERT dbo.CHUCVU
VALUES ('BP',N'Bếp phó','B',28000000);
INSERT dbo.CHUCVU
VALUES ('LC',N'Lao công','VS',28000000);
INSERT dbo.CHUCVU
VALUES ('NV',N'Nhân viên phục vụ','PV',7000000);
INSERT dbo.CHUCVU
VALUES ('CSKH',N'Nhân viên CSKH','DV',10000000);
INSERT dbo.CHUCVU
VALUES ('BV',N'Bảo vệ','AN',8000000);
INSERT dbo.CHUCVU
VALUES ('GSC',N'Giám sát Camera','AN',10000000);
INSERT dbo.CHUCVU
VALUES ('TX',N'Trông xe','AN',7000000);
INSERT dbo.CHUCVU
VALUES ('ĐB',N'Đầu bếp','B',12000000);

------------------------------------------------------------------------------------------------------------------
--Bảng nhân viên
CREATE TABLE NHANVIEN
(
  MANV char(6) not null,
  TENNV nvarchar(35),
  GTINH nvarchar(6),
  DIACHI nvarchar(15),
  DTHOAI char(11),
  NGAYSINH date,
  NGAYVL date,
  MACV char(6),
  TENCA nvarchar(30),
  MATKHAU char (20),
  CONSTRAINT PK_NHANVIEN PRIMARY KEY(MANV),
  CONSTRAINT FK_NHANVIEN_CHUCVU FOREIGN KEY (MACV) REFERENCES CHUCVU(MACV),
  CONSTRAINT FK_NHANVIEN_CALAM FOREIGN KEY (TENCA) REFERENCES CALAM(TENCA)
)
--Thêm ràng buộc bảng nhân viên
ALTER TABLE NHANVIEN
ADD CONSTRAINT CHK_NHANVIEN_GTINH CHECK (GTINH=N'Nam' OR GTINH=N'Nữ')
ALTER TABLE NHANVIEN
ADD CONSTRAINT CHK_TUOI CHECK (YEAR(GETDATE())-(YEAR(NGAYSINH)) BETWEEN 18 AND 50)
ALTER TABLE NHANVIEN
ADD CONSTRAINT UNI_DTHOAINV UNIQUE(DTHOAI)
ALTER TABLE NHANVIEN
ADD CONSTRAINT UNI_MATKHAU UNIQUE(MATKHAU)
ALTER TABLE NHANVIEN
ADD CONSTRAINT CHK_NVL CHECK ((YEAR(NGAYVL) BETWEEN 2015 AND YEAR(GETDATE())))
--Insert dữ liệu bảng NHANVIEN
INSERT dbo.NHANVIEN
VALUES ('NV001',N'Nguyễn Hoài Thu',N'Nữ',N'Quận 4','0989751723','19891215','20221001','GĐ',N'Hành chính','GD123456');
INSERT dbo.NHANVIEN
VALUES ('NV002',N'Đinh Thu Trang',N'Nữ',N'Quận Tân Phú','0918234654','19921215','20221001','TBP',N'Hành chính','TBP123456');
INSERT dbo.NHANVIEN
VALUES ('NV003',N'Đặng Bảo Long',N'Nam',N'Quận 12','0978123765','19860325','20180518','BT',N'Sáng','BT1123456');
INSERT dbo.NHANVIEN
VALUES ('NV004',N'Nguyễn Anh Tuấn',N'Nam',N'Quận Gò Vấp','0909456768','19910526','20180721','BT',N'Chiều','BT2123456');
INSERT dbo.NHANVIEN
VALUES ('NV005',N'Huỳnh Thanh Tâm',N'Nữ',N'Quận Bình Tân','0932987567','19940417','20160628','BP',N'Sáng','BP1123456');
INSERT dbo.NHANVIEN
VALUES ('NV006',N'Trần Đình Hoàng',N'Nam',N'Quận Gò Vấp','0928396452','19931120','20190817','BP',N'Chiều','BP2123456');
INSERT dbo.NHANVIEN
VALUES ('NV007',N'Nguyễn Lan Hương',N'Nữ',N'Quận Bình Thạnh','0897653214','19970318','20201125','ĐB',N'Sáng','DB1123456');
INSERT dbo.NHANVIEN
VALUES ('NV008',N'Nguyễn Lan Anh',N'Nữ',N'Quận Bình Tân','0897653215','19980418','20201125','ĐB',N'Sáng','DB2123456');
INSERT dbo.NHANVIEN
VALUES ('NV009',N'Nguyễn Kim Tú',N'Nữ',N'Quận 7','0897653216','19980518','20201125','ĐB',N'Sáng','DB3123456');
INSERT dbo.NHANVIEN
VALUES ('NV010',N'Nguyễn Mạnh Nam',N'Nam',N'Quận 3','0897653217','19990618','20201125','ĐB',N'Sáng','DB4123456');
INSERT dbo.NHANVIEN
VALUES ('NV011',N'Trần Mai Hương',N'Nữ',N'Quận 12','0897653218','19990716','20201125','ĐB',N'Chiều','DB5123456');
INSERT dbo.NHANVIEN
VALUES ('NV012',N'Trần Văn Lan Anh',N'Nữ',N'Quận 10','0897653219','19990814','20201125','ĐB',N'Chiều','DB6123456');
INSERT dbo.NHANVIEN
VALUES ('NV013',N'Nguyễn Đức Tú',N'Nam',N'Quận 2','0897653220','19970712','20201125','ĐB',N'Chiều','DB7123456');
INSERT dbo.NHANVIEN
VALUES ('NV014',N'Nguyễn Quốc Dũng',N'Nam',N'Quận Gò Vấp','0897653221','19990716','20201125','ĐB',N'Chiều','DB8123456');
INSERT dbo.NHANVIEN
VALUES ('NV015',N'Nguyễn Đức Khiêm',N'Nam',N'Quận Tân Phú','0897662437','19840428','20170526','BV',N'Sáng','BV1123456');
INSERT dbo.NHANVIEN
VALUES ('NV016',N'Nguyễn Tài Cao',N'Nam',N'Quận 12','0897662438','19870828','20170526','BV',N'Chiều','BV2123456');
INSERT dbo.NHANVIEN
VALUES ('NV017',N'Nguyễn Văn Mạnh',N'Nam',N'Quận Phú Nhuận','0897662439','19850728','20170526','GSC',N'Sáng','GSC1123456');
INSERT dbo.NHANVIEN
VALUES ('NV018',N'Nguyễn Tài Cao',N'Nam',N'Quận 7','0897662440','19900928','20170526','GSC',N'Chiều','GSC2123456');
INSERT dbo.NHANVIEN
VALUES ('NV019',N'Trần Cao Tiến',N'Nam',N'Quận 10','0897662441','19910928','20170526','TX',N'Sáng','TX1123456');
INSERT dbo.NHANVIEN
VALUES ('NV020',N'Nguyễn Tài Cao',N'Nam',N'Quận 7','0897662442','19920928','20170526','TX',N'Chiều','TX2123456');
INSERT dbo.NHANVIEN
VALUES ('NV021',N'Nguyễn Thị Cúc',N'Nữ',N'Quận 12','0365895413','19900125','20160526','CSKH',N'Hành chính','CSKH1123456');
INSERT dbo.NHANVIEN
VALUES ('NV022',N'Nguyễn Thị Mận',N'Nữ',N'Quận Gò Vấp','0365895414','19910725','20160526','CSKH',N'Hành chính','CSKH2123456');
INSERT dbo.NHANVIEN
VALUES ('NV023',N'Nguyễn Thế Thành',N'Nam',N'Quận Tân Phú','0745123678','19931224','20170526','QLNH',N'Hành chính','QLNH123456');
INSERT dbo.NHANVIEN
VALUES ('NV024',N'Nguyễn Văn A',N'Nam',N'Quận Bình Tân','0745133678','19931217','20180526','NV',N'Sáng','NV1123456');
INSERT dbo.NHANVIEN
VALUES ('NV025',N'Nguyễn Thế B',N'Nam',N'Quận Hóc Môn','0745143678','19931215','20180526','NV',N'Sáng','NV2123456');
INSERT dbo.NHANVIEN
VALUES ('NV026',N'Nguyễn Văn C',N'Nữ',N'Quận 12','0745153678','19931124','20180526','NV',N'Sáng','NV3123456');
INSERT dbo.NHANVIEN
VALUES ('NV027',N'Nguyễn Văn D',N'Nữ',N'Quận 2','0745163678','19931024','20180526','NV',N'Sáng','NV4123456');
INSERT dbo.NHANVIEN
VALUES ('NV028',N'Nguyễn Văn E',N'Nam',N'Quận 7','0745173678','19931228','20180526','NV',N'Sáng','NV5123456');
INSERT dbo.NHANVIEN
VALUES ('NV029',N'Nguyễn Văn F',N'Nam',N'Quận 10','0746133678','19931217','20180526','NV',N'Chiều','NV6123456');
INSERT dbo.NHANVIEN
VALUES ('NV030',N'Nguyễn Thế G',N'Nam',N'Quận Hóc Môn','0755143678','19931215','20180526','NV',N'Chiều','NV7123456');
INSERT dbo.NHANVIEN
VALUES ('NV031',N'Nguyễn Văn H',N'Nữ',N'Quận 12','0747153678','19971128','20180526','NV',N'Chiều','NV8123456');
INSERT dbo.NHANVIEN
VALUES ('NV032',N'Nguyễn Văn I',N'Nữ',N'Quận Gò Vấp','0785163678','19990824','20180526','NV',N'Chiều','NV9123456');
INSERT dbo.NHANVIEN
VALUES ('NV033',N'Nguyễn Văn J',N'Nữ',N'Quận Gò Vấp','0749173678','19991228','20180526','NV',N'Chiều','NV10123456');
INSERT dbo.NHANVIEN
VALUES ('NV034',N'Nguyễn Văn K',N'Nữ',N'Quận 12','0749174678','19891128','20180126','LC',N'Sáng','LC1123456');
INSERT dbo.NHANVIEN
VALUES ('NV035',N'Nguyễn Văn L',N'Nữ',N'Quận Gò Vấp','0749173778','19881027','20180526','LC',N'Sáng','LC2123456');
INSERT dbo.NHANVIEN
VALUES ('NV036',N'Nguyễn Văn M',N'Nữ',N'Quận Phú Nhuận','0849173678','19860228','20180429','LC',N'Chiều','LC3123456');
INSERT dbo.NHANVIEN
VALUES ('NV037',N'Nguyễn Văn O',N'Nữ',N'Quận Gò Vấp','0749273678','19890628','20180626','LC',N'Chiều','LC4123456');

---------------------------------------------------------------------------------------------------------------------------
--Bảng bàn ăn
CREATE TABLE BANAN
(
  MABAN char(6) not null,
  SOCN int,
  CONSTRAINT PK_BANAN PRIMARY KEY(MABAN),
)
--Thêm ràng buộc bảng BANAN
ALTER TABLE BANAN
ADD CONSTRAINT CHK_SOCN CHECK (SOCN>0)
--Insert Dữ liệu bàn ăn
INSERT dbo.BANAN
VALUES ('D01',2);
INSERT dbo.BANAN
VALUES ('D02',2);
INSERT dbo.BANAN
VALUES ('D03',2);
INSERT dbo.BANAN
VALUES ('D04',2);
INSERT dbo.BANAN
VALUES ('D05',2);
INSERT dbo.BANAN
VALUES ('N06',5);
INSERT dbo.BANAN
VALUES ('N07',5);
INSERT dbo.BANAN
VALUES ('N08',5);
INSERT dbo.BANAN
VALUES ('N09',5);
INSERT dbo.BANAN
VALUES ('N10',5);
INSERT dbo.BANAN
VALUES ('M11',10);
INSERT dbo.BANAN
VALUES ('M12',10);
INSERT dbo.BANAN
VALUES ('M13',10);
INSERT dbo.BANAN
VALUES ('M14',10);
INSERT dbo.BANAN
VALUES ('M15',10);

--------------------------------------------------------------------------------------------
--Bảng đơn hàng
CREATE TABLE DONHANG
(
  MADH char(6) not null,
  MABAN char(6),
  TONGTIEN MONEY,
  CONSTRAINT PK_DONHANG PRIMARY KEY(MADH),
  CONSTRAINT FK_DONHANG_BANAN FOREIGN KEY (MABAN) REFERENCES BANAN(MABAN)
)
--------------------------------------------------------------------------------------------
--Bảng chi tiết đơn hàng
CREATE TABLE CTDONHANG
(
  MADH char(6) not null,
  MASP char(6) not null,
  SOLUONG int,
  DONGIA MONEY,
  CONSTRAINT PK_CTDONHANG PRIMARY KEY(MADH,MASP),
  CONSTRAINT FK_CTDONHANG_DONHANG FOREIGN KEY (MADH) REFERENCES DONHANG(MADH),
  CONSTRAINT FK_CTDONHANG_THUCDON FOREIGN KEY (MASP) REFERENCES THUCDON(MASP)
)
--------------------------------------------------------------------------------------------
--Bảng hóa đơn
CREATE TABLE HOADON
(
  MAHD char(6) not null,
  MANV char(6),
  MAKH char(6),
  MABAN char(6),
  NGAYHD date,
  HTTT nvarchar (25),
  TONGTIEN MONEY,
  CONSTRAINT PK_HOADON PRIMARY KEY(MAHD),
  CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
  CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
  CONSTRAINT FK_HOADON_BANAN FOREIGN KEY (MABAN) REFERENCES BANAN(MABAN)
)
--Thêm ràng buộc bảng hóa đơn
ALTER TABLE HOADON
ADD CONSTRAINT CHK_TONGTIENHD CHECK (TONGTIEN>0)
ALTER TABLE HOADON
ADD CONSTRAINT CHK_HTTT CHECK (HTTT=N'Tiền mặt' OR HTTT=N'CHuyển khoản' OR HTTT=N'Thẻ' OR HTTT=N'Ví điện tử')
ALTER TABLE HOADON
ADD CONSTRAINT CHK_NGAYHD CHECK (NGAYHD<=GETDATE())
ALTER TABLE HOADON
ADD CONSTRAINT DF_TONGTIEN DEFAULT 1 FOR TONGTIEN
-- Insert dữ liệu bảng hóa đơn
INSERT INTO HOADON (MAHD,MANV,NGAYHD,MAKH,MABAN,HTTT)
VALUES('HD001','NV001','20221001','KH001','D02',N'Tiền mặt');
INSERT INTO HOADON (MAHD,MANV,NGAYHD,MAKH,MABAN,HTTT)
VALUES('HD002','NV001','20221215','KH005','M11',N'Thẻ');
INSERT INTO HOADON (MAHD,MANV,NGAYHD,MAKH,MABAN,HTTT)
VALUES('HD003','NV002','20220914','KH004','N09',N'Tiền mặt');
INSERT INTO HOADON (MAHD,MANV,NGAYHD,MAKH,MABAN,HTTT)
VALUES('HD004','NV001','20221103','KH005','D05',N'Tiền mặt');
INSERT INTO HOADON (MAHD,MANV,NGAYHD,MAKH,MABAN,HTTT)
VALUES('HD005','NV002','20221005','KH001','M12',N'Chuyển khoản');
INSERT INTO HOADON (MAHD,MANV,NGAYHD,MAKH,MABAN,HTTT)
VALUES('HD006','NV002','20221107','KH003','N08',N'Thẻ');
INSERT INTO HOADON (MAHD,MANV,NGAYHD,MAKH,MABAN,HTTT)
VALUES('HD007','NV001','20221212','KH002','M14',N'Thẻ');
INSERT INTO HOADON (MAHD,MANV,NGAYHD,MAKH,MABAN,HTTT)
VALUES('HD008','NV002','20210930','KH004','D01',N'Ví điện tử');
INSERT INTO HOADON (MAHD,MANV,NGAYHD,MAKH,MABAN,HTTT)
VALUES('HD009','NV002','20211030','KH002','D01',N'Ví điện tử');
INSERT INTO HOADON (MAHD,MANV,NGAYHD,MAKH,MABAN,HTTT)
VALUES('HD010','NV002','20211130','KH003','D01',N'Ví điện tử');
INSERT INTO HOADON (MAHD,MANV,NGAYHD,MAKH,MABAN,HTTT)
VALUES('HD011','NV001','20231001','KH001','D02',N'Tiền mặt');
INSERT INTO HOADON (MAHD,MANV,NGAYHD,MAKH,MABAN,HTTT)
VALUES('HD012','NV002','20231130','KH002','D01',N'Ví điện tử');

--------------------------------------------------------------------------------------------
--Bảng chi tiết hóa đơn
CREATE TABLE CHITIETHD
(
 MAHD char(6) not null,
 MASP char(6) not null,
 SOLUONG int,
 DONGIA MONEY,
 CONSTRAINT PK_CHITIETHD PRIMARY KEY(MAHD,MASP),
 CONSTRAINT FK_CHITIETHD_HOADON FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD),
 CONSTRAINT FK_CHITIETHD_THUCDON FOREIGN KEY (MASP) REFERENCES THUCDON(MASP)
)
-- Thêm ràng buộc bảng CHITIETHD
ALTER TABLE CHITIETHD
ADD CONSTRAINT CHK_SOLUONGCTHD CHECK (SOLUONG>0)
ALTER TABLE CHITIETHD
ADD CONSTRAINT CHK_DONGIACTHD CHECK (DONGIA>0)
-- Insert dữ liệu bảng CHITIETHD
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD008','B02',3);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD001','DU10',1);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD003','G01',3);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD008','DU02',3);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD007','DU04',12);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD007','G03',1);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD007','G01',2);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD006','AV03',2);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD006','B02',2);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD005','TB01',2);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD002','TB01',3);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD004','B02',2);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD009','B02',7);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD010','B02',12);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD010','AK05',7);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD011','H02',4);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD012','H01',5);
INSERT INTO CHITIETHD (MAHD,MASP,SOLUONG)
VALUES('HD012','AK06',3);
-- Cập nhật đơn giá cho bảng CHITIETHD và TONGTIEN cho bảng HOADON
UPDATE CHITIETHD
SET DONGIA = (SELECT THUCDON.DONGIA
                       FROM THUCDON
					   WHERE CHITIETHD.MASP=THUCDON.MASP)

UPDATE HOADON
SET TONGTIEN = (SELECT SUM(SOLUONG*DONGIA)
                       FROM CHITIETHD
					   WHERE HOADON.MAHD=CHITIETHD.MAHD)
----------------------------------------------------------------------------------
-- Bảng loại hàng hóa
CREATE TABLE LOAIHH
(
  MALOAI char(4) not null,
  TENLOAI nvarchar(25)
  CONSTRAINT PK_LOAIHH PRIMARY KEY(MALOAI)
)
--Insert dữ liệu cho bảng LOAIHH
INSERT dbo.LOAIHH
VALUES('DL',N'Đông lạnh');
INSERT dbo.LOAIHH
VALUES('RC',N'Rau củ');
INSERT dbo.LOAIHH
VALUES('GV',N'Gia vị');
INSERT dbo.LOAIHH
VALUES('DU',N'Đồ uống');
INSERT dbo.LOAIHH
VALUES('TS',N'Tươi sống');
INSERT dbo.LOAIHH
VALUES('GD',N'Gia dụng');
INSERT dbo.LOAIHH
VALUES('TPK',N'Thực phẩm khác');
INSERT dbo.LOAIHH
VALUES('NYP',N'Nhu yếu phẩm');

-----------------------------------------------------------------------------------------------------
-- Bảng hàng hóa
CREATE TABLE HANGHOA
(
  MAHH char(6) not null,
  TENHH nvarchar(50),
  NSX date,
  HSD date,
  MALOAI char(4),
  MANCC char(6),
  DVT nvarchar(8),
  DONGIA MONEY,
  SOLUONG int,
  CONSTRAINT PK_HANGHOA PRIMARY KEY(MAHH),
  CONSTRAINT FK_HANGHOA_LOAIHH FOREIGN KEY (MALOAI) REFERENCES LOAIHH(MALOAI),
  CONSTRAINT FK_HANGHOA_NCC FOREIGN KEY (MANCC) REFERENCES NCC(MANCC),
)
-- Thêm ràng buộc bảng hàng hóa
ALTER TABLE HANGHOA
ADD CONSTRAINT CHK_HSD CHECK (NSX<HSD)
ALTER TABLE HANGHOA
ADD CONSTRAINT CHK_SOLUONGHH CHECK (SOLUONG>=0)
ALTER TABLE HANGHOA
ADD CONSTRAINT CHK_DVTHH CHECK (DVT IN (N'Chai',N'Lon',N'Cái',N'Gói',N'quả','kg',N'Đôi'))
-- Insert dữ liệu bảng hàng hóa
INSERT dbo.HANGHOA
VALUES('GV001',N'Nước Mắm Nam Ngư','20180101','20250101','GV','MC',N'Chai',15000,45);
INSERT dbo.HANGHOA
VALUES('GV002',N'Bột ngọt Ajinomoto','20170101','20240101','GV','AJ',N'Gói',7000,80);
INSERT dbo.HANGHOA
VALUES('GV003',N'Hạt nêm Knor','20190101','20260101','GV','U',N'Gói',10000,110);
INSERT dbo.HANGHOA
VALUES('GV004',N'Dầu ăn','20180101','20250101','GV','MC',N'Chai',25000,75);
INSERT dbo.HANGHOA
VALUES('GV005',N'Sốt BBQ','20180101','20250101','GV','SV',N'Chai',40000,95);
INSERT dbo.HANGHOA
VALUES('GV006',N'Nước tương','20190101','20260101','GV','MC',N'Chai',10000,95);
INSERT dbo.HANGHOA
VALUES('GV007',N'Dầu hào','20190101','20260101','GV','MC',N'Chai',13000,95);
INSERT dbo.HANGHOA
VALUES('GV008',N'Ngũ vị hương','20200101','20260101','GV','SV',N'Gói',1000,225);
INSERT dbo.HANGHOA
VALUES('GV009',N'Đường kính trắng','20200101','20260101','GV','SV',N'Gói',5000,225);
INSERT dbo.HANGHOA
VALUES('GV010',N'Đường thốt nốt','20200101','20260101','GV','SV',N'Gói',8000,225);
INSERT dbo.HANGHOA
VALUES('GV012',N'Muối Iot','20200101','20260101','GV','SV',N'Gói',3500,225);
INSERT dbo.HANGHOA
VALUES('GV011',N'Mật ong nguyên chất','20200101','20260101','GV','SV',N'Chai',42000,225);

INSERT dbo.HANGHOA
VALUES('RC001',N'Khoai tây','20230915','20231002','RC','CT',N'kg',15000,120);
INSERT dbo.HANGHOA
VALUES('RC002',N'Khoai lang','20230915','20231002','RC','CT',N'kg',11000,70);
INSERT dbo.HANGHOA
VALUES('RC003',N'Cần tây','20230915','20231002','RC','CT',N'kg',2000,50);
INSERT dbo.HANGHOA
VALUES('RC004',N'Rau muống','20230915','20231002','RC','CT',N'kg',3000,65);
INSERT dbo.HANGHOA
VALUES('RC005',N'Hành tây','20230915','20231002','RC','CT',N'kg',2200,45);
INSERT dbo.HANGHOA
VALUES('RC024',N'Hành tím','20230915','20231002','RC','CT',N'kg',3400,45);
INSERT dbo.HANGHOA
VALUES('RC025',N'Tỏi','20230915','20231002','RC','CT',N'kg',5200,45);
INSERT dbo.HANGHOA
VALUES('RC006',N'Lá É','20230915','20231002','RC','CT',N'kg',7100,95);
INSERT dbo.HANGHOA
VALUES('RC007',N'Cà chua','20230915','20231002','RC','CT',N'kg',4000,95);
INSERT dbo.HANGHOA
VALUES('RC008',N'Cà chua bi','20230915','20231002','RC','CT',N'kg',6000,95);
INSERT dbo.HANGHOA
VALUES('RC009',N'Nấm kim châm','20230915','20231002','RC','CT',N'kg',8600,95);
INSERT dbo.HANGHOA
VALUES('RC010',N'Cải thảo','20230915','20231002','RC','CT',N'kg',4000,95);
INSERT dbo.HANGHOA
VALUES('RC011',N'Bắp cải tím','20230915','20231002','RC','CT',N'kg',5400,95);
INSERT dbo.HANGHOA
VALUES('RC012',N'Bắp','20230915','20231002','RC','CT',N'kg',10000,95);
INSERT dbo.HANGHOA
VALUES('RC013',N'Cà rốt','20230915','20231002','RC','CT',N'kg',11000,95);
INSERT dbo.HANGHOA
VALUES('RC014',N'Củ cải trắng','20230915','20231002','RC','CT',N'kg',10000,95);
INSERT dbo.HANGHOA
VALUES('RC015',N'Hành lá','20230915','20231002','RC','CT',N'kg',12000,95);
INSERT dbo.HANGHOA
VALUES('RC016',N'Rau thơm','20230915','20231002','RC','CT',N'kg',4500,95);
INSERT dbo.HANGHOA
VALUES('RC017',N'Chanh','20230915','20231002','RC','CT',N'kg',17000,95);
INSERT dbo.HANGHOA
VALUES('RC018',N'Tắc','20230915','20231002','RC','CT',N'kg',12000,95);
INSERT dbo.HANGHOA
VALUES('RC019',N'Táo','20230915','20231002','RC','CT',N'kg',30000,95);
INSERT dbo.HANGHOA
VALUES('RC020',N'Thơm','20230915','20231002','RC','CT',N'kg',15000,95);
INSERT dbo.HANGHOA
VALUES('RC021',N'Dưa hấu','20230915','20231002','RC','CT',N'kg',14000,95);
INSERT dbo.HANGHOA
VALUES('RC022',N'Ổi','20230915','20231002','RC','CT',N'kg',8000,95);
INSERT dbo.HANGHOA
VALUES('RC023',N'Xoài','20230915','20231002','RC','CT',N'kg',9000,95);

INSERT dbo.HANGHOA
VALUES('DL01',N'Thăn bò Mỹ','20230615','20231202','DL','CP',N'kg',57000,195);
INSERT dbo.HANGHOA
VALUES('DL02',N'Lõi vai bò Úc','20230615','20231202','DL','CP',N'kg',68000,195);
INSERT dbo.HANGHOA
VALUES('DL03',N'Ba chỉ bò Mỹ','20230615','20231202','DL','CP',N'kg',40000,195);
INSERT dbo.HANGHOA
VALUES('DL04',N'Bắp bò Mỹ','20230615','20231202','DL','CP',N'kg',59000,195);
INSERT dbo.HANGHOA
VALUES('DL05',N'Bò viên','20230615','20231202','DL','MC',N'kg',30000,195);
INSERT dbo.HANGHOA
VALUES('DL06',N'Bào ngư Hàn Quốc','20230615','20231202','DL','AS',N'kg',75000,195);

INSERT dbo.HANGHOA
VALUES('TS01',N'Sườn heo','20230615','20231202','TS','CP',N'kg',65000,195);
INSERT dbo.HANGHOA
VALUES('TS02',N'Cua','20230615','20231202','TS','AS',N'kg',120000,195);
INSERT dbo.HANGHOA
VALUES('TS03',N'Cua Hoàng đế','20230615','20231202','TS','AS',N'kg',450000,195);
INSERT dbo.HANGHOA
VALUES('TS05',N'Tôm hùm','20230615','20231202','TS','AS',N'kg',380000,195);
INSERT dbo.HANGHOA
VALUES('TS06',N'Ba chỉ heo','20230615','20231202','TS','CP',N'kg',160000,195);
INSERT dbo.HANGHOA
VALUES('TS07',N'Nầm heo','20230615','20231202','TS','CP',N'kg',180000,195);
INSERT dbo.HANGHOA
VALUES('TS08',N'Tôm sú','20230615','20231202','TS','AS',N'kg',80000,195);
INSERT dbo.HANGHOA
VALUES('TS09',N'Tôm càng xanh','20230615','20231202','TS','AS',N'kg',95000,195);
INSERT dbo.HANGHOA
VALUES('TS10',N'Thăn bò','20230615','20231202','TS','CP',N'kg',150000,195);
INSERT dbo.HANGHOA
VALUES('TS11',N'Nạm bò','20230615','20231202','TS','CP',N'kg',140000,195);
INSERT dbo.HANGHOA
VALUES('TS12',N'Gân bò','20230615','20231202','TS','CP',N'kg',96000,195);
INSERT dbo.HANGHOA
VALUES('TS13',N'Bắp bò','20230615','20231202','TS','CP',N'kg',160000,195);
INSERT dbo.HANGHOA
VALUES('TS14',N'Gà ta','20230615','20231202','TS','CP',N'kg',120000,195);
INSERT dbo.HANGHOA
VALUES('TS15',N'Đùi gà','20230615','20231202','TS','CP',N'kg',80000,195);
INSERT dbo.HANGHOA
VALUES('TS16',N'Cánh gà','20230615','20231202','TS','CP',N'kg',95000,195);

INSERT dbo.HANGHOA
VALUES('TPK01',N'Gạo','20200101','20260101','TPK','MC',N'kg',9000,225);
INSERT dbo.HANGHOA
VALUES('TPK02',N'Nếp','20200101','20260101','TPK','MC',N'kg',4900,225);
INSERT dbo.HANGHOA
VALUES('TPK03',N'Bột mì','20200101','20260101','TPK','MC',N'kg',2600,225);
INSERT dbo.HANGHOA
VALUES('TPK04',N'Bột bắp','20200101','20260101','TPK','MC',N'kg',3000,225);
INSERT dbo.HANGHOA
VALUES('TPK05',N'Bột chiên xù','20200101','20260101','TPK','MC',N'kg',6000,225);
INSERT dbo.HANGHOA
VALUES('TPK06',N'Bột chiên giòn','20200101','20260101','TPK','MC',N'kg',7000,225);
INSERT dbo.HANGHOA
VALUES('TPK11',N'Mì','20200101','20260101','TPK','AC',N'kg',2400,225);
INSERT dbo.HANGHOA
VALUES('TPK07',N'Bún','20200101','20260101','TPK','MC',N'kg',5000,225);
INSERT dbo.HANGHOA
VALUES('TPK08',N'Bánh bao','20200101','20260101','TPK','MC',N'kg',5000,225);
INSERT dbo.HANGHOA
VALUES('TPK09',N'Trứng gà','20230101','20230501','TPK','DG',N'quả',1800,225);
INSERT dbo.HANGHOA
VALUES('TPK10',N'Trứng vịt','20230101','20230501','TPK','DG',N'quả',2500,225);

INSERT dbo.HANGHOA
VALUES('NYP01',N'Giấy ăn','20200101','20260101','NYP','U',N'Gói',7000,225);
INSERT dbo.HANGHOA
VALUES('NYP02',N'Nước rửa chén','20200101','20260101','NYP','U',N'Chai',25000,75);
INSERT dbo.HANGHOA
VALUES('NYP03',N'Nước lau sàn','20200101','20260101','NYP','U',N'Chai',26000,55);
INSERT dbo.HANGHOA
VALUES('NYP04',N'Dung dịch vệ sinh bếp','20200101','20260101','NYP','U',N'Chai',19000,25);
INSERT dbo.HANGHOA
VALUES('NYP05',N'Bình xịt côn trùng','20200101','20260101','NYP','U',N'Chai',18000,45);
INSERT dbo.HANGHOA
VALUES('NYP06',N'Thuốc tẩy','20200101','20260101','NYP','U',N'Chai',15000,45);
INSERT dbo.HANGHOA
VALUES('NYP07',N'Bột giặt','20200101','20260101','NYP','U',N'Gói',25000,45);

INSERT dbo.HANGHOA
VALUES('GD01',N'Bàn ăn 1m','20200101','20300101','GD','LL',N'Cái',42000,30);
INSERT dbo.HANGHOA
VALUES('GD02',N'Bàn ăn 2m','20200101','20300101','GD','LL',N'Cái',58000,30);
INSERT dbo.HANGHOA
VALUES('GD03',N'Bàn ăn 3m','20200101','20300101','GD','LL',N'Cái',60000,30);
INSERT dbo.HANGHOA
VALUES('GD04',N'Ghế ngồi','20200101','20300101','GD','LL',N'Cái',40000,86);
INSERT dbo.HANGHOA
VALUES('GD05',N'Khăn trải bàn','20200101','20300101','GD','LL',N'Cái',25000,66);
INSERT dbo.HANGHOA
VALUES('GD06',N'Máy lọc nước','20200101','20300101','GD','EV',N'Cái',1890000,8);
INSERT dbo.HANGHOA
VALUES('GD07',N'Bếp từ','20200101','20300101','GD','SH',N'Cái',1250000,6);
INSERT dbo.HANGHOA
VALUES('GD08',N'Lò nướng','20200101','20300101','GD','SH',N'Cái',1680000,7);
INSERT dbo.HANGHOA
VALUES('GD09',N'Quạt','20200101','20260101','GD','EV',N'Cái',200000,16);
INSERT dbo.HANGHOA
VALUES('GD10',N'Máy rửa chén','20200101','20260101','GD','PL',N'Cái',2000000,6);
INSERT dbo.HANGHOA
VALUES('GD11',N'Kệ bếp','20200101','20260101','GD','LL',N'Cái',163000,9);
INSERT dbo.HANGHOA
VALUES('GD12',N'Chén','20200101','20260101','GD','LL',N'Cái',5800,276);
INSERT dbo.HANGHOA
VALUES('GD13',N'Đũa','20200101','20260101','GD','LL',N'Đôi',4000,326);
INSERT dbo.HANGHOA
VALUES('GD14',N'Nồi 25cm','20200101','20260101','GD','SH',N'Cái',29000,21);
INSERT dbo.HANGHOA
VALUES('GD15',N'Nồi 30cm','20200101','20260101','GD','SH',N'Cái',18000,18);
INSERT dbo.HANGHOA
VALUES('GD16',N'Nồi hấp','20200101','20260101','GD','SH',N'Cái',29000,18);
INSERT dbo.HANGHOA
VALUES('GD17',N'Chảo 15cm','20200101','20260101','GD','SH',N'Cái',37000,18);
INSERT dbo.HANGHOA
VALUES('GD18',N'Chảo 30cm','20200101','20260101','GD','SH',N'Cái',36000,18);
INSERT dbo.HANGHOA
VALUES('GD19',N'Đĩa','20200101','20260101','GD','LL',N'Cái',6000,18);
INSERT dbo.HANGHOA
VALUES('GD20',N'Tô','20200101','20260101','GD','LL',N'Cái',7000,18);
INSERT dbo.HANGHOA
VALUES('GD21',N'Nĩa','20200101','20260101','GD','LL',N'Cái',5000,18);
INSERT dbo.HANGHOA
VALUES('GD22',N'Dao','20200101','20260101','GD','SH',N'Cái',36000,18);
INSERT dbo.HANGHOA
VALUES('GD23',N'Kéo','20200101','20260101','GD','SH',N'Cái',25000,18);
INSERT dbo.HANGHOA
VALUES('GD24',N'Thớt','20200101','20260101','GD','SH',N'Cái',75000,18);
INSERT dbo.HANGHOA
VALUES('GD25',N'Bếp chiên','20200101','20260101','GD','EV',N'Cái',125000,8);

INSERT dbo.HANGHOA
VALUES('DU01',N'Bia đen','20200101','20220101','DU','SBC',N'Chai',25000,72);
INSERT dbo.HANGHOA
VALUES('DU02',N'Bia tươi','20200101','20220101','DU','SBC',N'Chai',16000,72);
INSERT dbo.HANGHOA
VALUES('DU03',N'Bia 333','20200101','20220101','DU','SBC',N'Lon',8000,172);
INSERT dbo.HANGHOA
VALUES('DU04',N'Bia Tiger xanh','20200101','20220101','DU','SBC',N'Lon',9500,72);
INSERT dbo.HANGHOA
VALUES('DU05',N'Rượu vang','20200101','20220101','DU','SBC',N'Chai',150000,52);
INSERT dbo.HANGHOA
VALUES('DU06',N'Coca-Cola','20200101','20220101','DU','CC',N'Lon',7000,72);
INSERT dbo.HANGHOA
VALUES('DU07',N'Pepsi','20200101','20220101','DU','CC',N'Lon',7000,72);
INSERT dbo.HANGHOA
VALUES('DU08',N'Nước suối Lavie','20200101','20220101','DU','CC',N'Chai',3000,72);

----------------------------------------------------------------------------------------------------------
-- Bảng phiếu nhập
CREATE TABLE PHIEUNHAP
(
  MAPN char(6) not null,
  NGAYNHAP date,
  MALOAI char(4),
  THANHTIEN MONEY,
  CONSTRAINT PK_PHIEUNHAP PRIMARY KEY(MAPN),
  CONSTRAINT FK_PHIEUNHAP_LOAIHH FOREIGN KEY (MALOAI) REFERENCES LOAIHH(MALOAI),
)
--Thêm ràng buộc bảng PHIEUNHAP
ALTER TABLE PHIEUNHAP
ADD CONSTRAINT CHK_THANHTIENPN CHECK (THANHTIEN>0)
ALTER TABLE PHIEUNHAP
ADD CONSTRAINT CHK_NGNHAP CHECK (NGAYNHAP<=GETDATE())
--Insert dữ liệu bảng phiếu nhập
INSERT INTO PHIEUNHAP (MAPN,NGAYNHAP,MALOAI)
VALUES('PH001','20221206','GD');
INSERT INTO PHIEUNHAP (MAPN,NGAYNHAP,MALOAI)
VALUES('PH002','20221028','GV');
INSERT INTO PHIEUNHAP (MAPN,NGAYNHAP,MALOAI)
VALUES('PH003','20221206','NYP');
INSERT INTO PHIEUNHAP (MAPN,NGAYNHAP,MALOAI)
VALUES('PH004','20220719','RC');
INSERT INTO PHIEUNHAP (MAPN,NGAYNHAP,MALOAI)
VALUES('PH005','20221123','TPK');
INSERT INTO PHIEUNHAP (MAPN,NGAYNHAP,MALOAI)
VALUES('PH006','20221206','TS');
INSERT INTO PHIEUNHAP (MAPN,NGAYNHAP,MALOAI)
VALUES('PH007','20221206','DL');
INSERT INTO PHIEUNHAP (MAPN,NGAYNHAP,MALOAI)
VALUES('PH008','20221206','DU');

----------------------------------------------------------------------------------------
-- Bảng Chi tiết phiếu nhập
CREATE TABLE CTPHIEUNHAP
(   
  MAPN char(6) not null,
  MAHH char(6),
  MANCC char(6),
  DVT nvarchar(7),
  SOLUONG int,
  DONGIA MONEY,
  CONSTRAINT PK_CTPHIEUNHAP PRIMARY KEY(MAPN,MAHH),
  CONSTRAINT FK_CTPHIEUNHAP_PHIEUNHAP FOREIGN KEY (MAPN) REFERENCES PHIEUNHAP(MAPN),
  CONSTRAINT FK_CTPHIEUNHAP_HANGHOA FOREIGN KEY (MAHH) REFERENCES HANGHOA(MAHH),
  CONSTRAINT FK_CTPHIEUNHAP_NCC FOREIGN KEY (MANCC) REFERENCES NCC(MANCC)
)
--Thêm ràng buộc bảng CTPHIEUNHAP
ALTER TABLE CTPHIEUNHAP
ADD CONSTRAINT CHK_SOLUONGPN CHECK (SOLUONG>0)
ALTER TABLE CTPHIEUNHAP
ADD CONSTRAINT CHK_DONGIAPN CHECK (DONGIA>0)
-- Insert dữ liệu bảng CTPHIEUNHAP
INSERT INTO CTPHIEUNHAP(MAPN,MAHH,SOLUONG,DONGIA)
VALUES ('PH001','TS06',48,70000)
INSERT INTO CTPHIEUNHAP(MAPN,MAHH,SOLUONG,DONGIA)
VALUES ('PH001','TS09',64,190000)
INSERT INTO CTPHIEUNHAP(MAPN,MAHH,SOLUONG,DONGIA)
VALUES ('PH002','DL01',30,105000)
INSERT INTO CTPHIEUNHAP(MAPN,MAHH,SOLUONG,DONGIA)
VALUES ('PH002','DL03',72,220000)
INSERT INTO CTPHIEUNHAP(MAPN,MAHH,SOLUONG,DONGIA)
VALUES ('PH003','DU01',30,56000)
INSERT INTO CTPHIEUNHAP(MAPN,MAHH,SOLUONG,DONGIA)
VALUES ('PH003','DU05',15,126000)
INSERT INTO CTPHIEUNHAP(MAPN,MAHH,SOLUONG,DONGIA)
VALUES ('PH004','TPK07',7,15000)
INSERT INTO CTPHIEUNHAP(MAPN,MAHH,SOLUONG,DONGIA)
VALUES ('PH005','RC008',20,7000)
INSERT INTO CTPHIEUNHAP(MAPN,MAHH,SOLUONG,DONGIA)
VALUES ('PH006','GV005',10,18000)
INSERT INTO CTPHIEUNHAP(MAPN,MAHH,SOLUONG,DONGIA)
VALUES ('PH007','GD12',25,10000)
INSERT INTO CTPHIEUNHAP(MAPN,MAHH,SOLUONG,DONGIA)
VALUES ('PH008','NYP01',22,8000)

--Cập nhật cột MANCC, DVT cho bảng CTPHIEUNHAP
UPDATE CTPHIEUNHAP
SET MANCC = (SELECT HANGHOA.MANCC FROM HANGHOA WHERE CTPHIEUNHAP.MAHH=HANGHOA.MAHH)
UPDATE CTPHIEUNHAP
SET DVT = (SELECT HANGHOA.DVT FROM HANGHOA WHERE CTPHIEUNHAP.MAHH=HANGHOA.MAHH)
UPDATE CTPHIEUNHAP
SET DONGIA = (SELECT HANGHOA.DONGIA
                       FROM HANGHOA
					   WHERE CTPHIEUNHAP.MAHH=HANGHOA.MAHH)
--Cập nhật cột TONGTIEN cho bang PHIEUNHAP
UPDATE PHIEUNHAP
SET THANHTIEN = (SELECT SUM(SOLUONG*DONGIA)
                       FROM CTPHIEUNHAP
					   WHERE PHIEUNHAP.MAPN=CTPHIEUNHAP.MAPN)
----------------------------------------------------------------------------------------------------------------
