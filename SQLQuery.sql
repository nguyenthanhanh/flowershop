CREATE DATABASE do_an_asp_net

CREATE TABLE SanPham (
	ID int NOT NULL primary key IDENTITY(1,1),
	TenSP nvarchar(255),
	GiaTien int,
	AnhSanPham text,
	LoaiSP int
)

INSERT INTO SanPham (TenSP, GiaTien, AnhSanPham)
VALUES 
(N'Hoa hồng gai', 20000, 'hoa-1.jpg'),
(N'Hoa tulip', 10000, 'hoa-2.jpg'),
(N'Hoa sơn trà', 10000, 'hoa-3.jpg'),
(N'Hoa loa kèn', 10000, 'hoa-4.jpg'),
(N'Hoa chuông', 10000, 'hoa-5.jpg'),
(N'Hoa tầm gởi', 10000, 'hoa-6.jpg'),
(N'Hoa ly', 10000, 'hoa-7.jpg'),
(N'Hoa hồng đen', 10000, 'hoa-8.jpg')