Create database haidilao
Go
Use database haidilao
Go
Create table phongchucnang (
	maphong char(10) primary key,
	tenphong nvarchar(45)
)
Go
Create table loaimonan(
	maloaimonan char(10),
	tenloaimon nvarchar(45), 
	maphong char(10),
	Primary key (maloaimonan, maphong),
	Constraint FK_loaimon_Phongchucnang foreign key (maphong) references phongchucnang (maphong)
)
Go
Create table monan(
    mamonan char(10),
    ten nvarchar(45),
    giaban float,
    anh text,
	maloaimonan char(10),
	maphong char(10),
	Primary key (maloaimonan,mamonan),
	Constraint FK_monan_loaimonan foreign key (maloaimonan,maphong) references loaimonan(maloaimonan,maphong)
)
Go
INSERT INTO phongchucnang values('P01','Phong 1')
INSERT INTO phongchucnang values('P02','Phong 2')
INSERT INTO phongchucnang values('P03','Phong 3')
go
INSERT INTO loaimonan values('LMA01','Loai mon an 1','P01')
INSERT INTO loaimonan values('LMA02','Loai mon an 2','P02')
INSERT INTO loaimonan values('LMA03','Loai mon an 3','P03')
INSERT INTO loaimonan values('LMA04','Loai mon an 4','P03')
go
INSERT INTO monan values('MA01','Mon an 01',1000,'a.jpg','LMA01','P01')
INSERT INTO monan values('MA02','Mon an 02',1300,'b.jpg','LMA02','P02')
INSERT INTO monan values('MA03','Mon an 03',1600,'c.jpg','LMA03','P03')
INSERT INTO monan values('MA04','Mon an 04',1800,'d.jpg','LMA04','P03')
go
select * from phongchucnang
select * from loaimonan
select * from monan