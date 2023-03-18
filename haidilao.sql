USE [haidilao]
GO
/****** Object:  Table [dbo].[CTdonnhap]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTdonnhap](
	[madonnhap] [char](10) NOT NULL,
	[mahanghoa] [char](10) NOT NULL,
	[soluong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[madonnhap] ASC,
	[mahanghoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTdonxuathang]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTdonxuathang](
	[madonxuat] [char](10) NOT NULL,
	[mahanghoa] [char](10) NOT NULL,
	[soluong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[madonxuat] ASC,
	[mahanghoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CThoadon]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CThoadon](
	[mahoadon] [char](10) NOT NULL,
	[mamonan] [char](10) NOT NULL,
	[soluong] [int] NULL,
	[dogia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC,
	[mamonan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTnguyenlieu]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTnguyenlieu](
	[mahanghoa] [char](10) NOT NULL,
	[mamonan] [char](10) NOT NULL,
	[soluong] [float] NULL,
	[donvitinh] [nvarchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[mahanghoa] ASC,
	[mamonan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTUD]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTUD](
	[mahang] [char](10) NOT NULL,
	[mauadai] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mahang] ASC,
	[mauadai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[donnhaphang]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[donnhaphang](
	[madonnhap] [char](10) NOT NULL,
	[ngaynhap] [date] NULL,
	[manhanvien] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[madonnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[donxuathang]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[donxuathang](
	[madonxuat] [char](10) NOT NULL,
	[ngaynhap] [date] NULL,
	[manhanvien] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[madonxuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hanghoa]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hanghoa](
	[mahanghoa] [char](10) NOT NULL,
	[ten] [nvarchar](45) NULL,
	[soluong] [float] NULL,
	[donvitinh] [nvarchar](45) NULL,
	[maloaihanghoa] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[mahanghoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangKhachHang]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangKhachHang](
	[mahang] [char](10) NOT NULL,
	[tenhang] [nvarchar](45) NULL,
	[mota] [nvarchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[mahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[mahoadon] [char](10) NOT NULL,
	[dongia] [float] NULL,
	[ngaythanhtoan] [date] NULL,
	[makhachhang] [char](10) NULL,
	[mauadai] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[makhachhang] [char](10) NOT NULL,
	[ten] [nvarchar](45) NULL,
	[sdt] [varchar](10) NULL,
	[diachi] [nvarchar](45) NULL,
	[matkhau] [nvarchar](45) NULL,
	[tichdiem] [int] NULL,
	[mahang] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[makhachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiHangHoa]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHangHoa](
	[maLoaiHangHoa] [char](10) NOT NULL,
	[tenLoaiHangHoa] [nvarchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[maLoaiHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loaimonan]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaimonan](
	[maloaimonan] [char](10) NOT NULL,
	[tenloaimon] [nvarchar](45) NULL,
	[maphong] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[maloaimonan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[monan]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[monan](
	[mamonan] [char](10) NOT NULL,
	[ten] [nvarchar](45) NULL,
	[giaban] [float] NULL,
	[anh] [text] NULL,
	[diem] [int] NULL,
	[maloaimonan] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[mamonan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manhanvien] [char](10) NOT NULL,
	[hoten] [nvarchar](45) NULL,
	[ngaysinh] [date] NULL,
	[quoctich] [nvarchar](45) NULL,
	[cmnd] [nvarchar](45) NULL,
	[ngaycap] [date] NULL,
	[noicap] [nvarchar](45) NULL,
	[trinhdohocvan] [nvarchar](45) NULL,
	[diachihientai] [nvarchar](45) NULL,
	[diachithuongtru] [nvarchar](45) NULL,
	[taikhoannganhang] [nvarchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phongchucnang]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phongchucnang](
	[maphong] [char](10) NOT NULL,
	[tenphong] [nvarchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[maphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UaDai]    Script Date: 18/03/2023 11:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UaDai](
	[mauadai] [char](10) NOT NULL,
	[hinhthucuadai] [nvarchar](45) NULL,
	[hanuadai] [date] NULL,
	[capbacuadai] [bit] NULL,
	[dienkienapdung] [nvarchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[mauadai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CTdonnhap]  WITH CHECK ADD  CONSTRAINT [FK_CTdonnhap_donnhaphang] FOREIGN KEY([madonnhap])
REFERENCES [dbo].[donnhaphang] ([madonnhap])
GO
ALTER TABLE [dbo].[CTdonnhap] CHECK CONSTRAINT [FK_CTdonnhap_donnhaphang]
GO
ALTER TABLE [dbo].[CTdonnhap]  WITH CHECK ADD  CONSTRAINT [FK_CTdonnhap_hanghoa] FOREIGN KEY([mahanghoa])
REFERENCES [dbo].[hanghoa] ([mahanghoa])
GO
ALTER TABLE [dbo].[CTdonnhap] CHECK CONSTRAINT [FK_CTdonnhap_hanghoa]
GO
ALTER TABLE [dbo].[CTdonxuathang]  WITH CHECK ADD  CONSTRAINT [FK_CTdonxuathang_donnhaphang] FOREIGN KEY([madonxuat])
REFERENCES [dbo].[donxuathang] ([madonxuat])
GO
ALTER TABLE [dbo].[CTdonxuathang] CHECK CONSTRAINT [FK_CTdonxuathang_donnhaphang]
GO
ALTER TABLE [dbo].[CTdonxuathang]  WITH CHECK ADD  CONSTRAINT [FK_CTdonxuathang_hanghoa] FOREIGN KEY([mahanghoa])
REFERENCES [dbo].[hanghoa] ([mahanghoa])
GO
ALTER TABLE [dbo].[CTdonxuathang] CHECK CONSTRAINT [FK_CTdonxuathang_hanghoa]
GO
ALTER TABLE [dbo].[CThoadon]  WITH CHECK ADD  CONSTRAINT [FK_CThoadon_hoadon] FOREIGN KEY([mahoadon])
REFERENCES [dbo].[hoadon] ([mahoadon])
GO
ALTER TABLE [dbo].[CThoadon] CHECK CONSTRAINT [FK_CThoadon_hoadon]
GO
ALTER TABLE [dbo].[CThoadon]  WITH CHECK ADD  CONSTRAINT [FK_CThoadon_monan] FOREIGN KEY([mamonan])
REFERENCES [dbo].[monan] ([mamonan])
GO
ALTER TABLE [dbo].[CThoadon] CHECK CONSTRAINT [FK_CThoadon_monan]
GO
ALTER TABLE [dbo].[CTnguyenlieu]  WITH CHECK ADD  CONSTRAINT [FK_CTnguyenlieu_hanghoa] FOREIGN KEY([mahanghoa])
REFERENCES [dbo].[hanghoa] ([mahanghoa])
GO
ALTER TABLE [dbo].[CTnguyenlieu] CHECK CONSTRAINT [FK_CTnguyenlieu_hanghoa]
GO
ALTER TABLE [dbo].[CTnguyenlieu]  WITH CHECK ADD  CONSTRAINT [FK_CTnguyenlieu_monan] FOREIGN KEY([mamonan])
REFERENCES [dbo].[monan] ([mamonan])
GO
ALTER TABLE [dbo].[CTnguyenlieu] CHECK CONSTRAINT [FK_CTnguyenlieu_monan]
GO
ALTER TABLE [dbo].[CTUD]  WITH CHECK ADD  CONSTRAINT [FK_CTUD_hoadon] FOREIGN KEY([mahang])
REFERENCES [dbo].[HangKhachHang] ([mahang])
GO
ALTER TABLE [dbo].[CTUD] CHECK CONSTRAINT [FK_CTUD_hoadon]
GO
ALTER TABLE [dbo].[CTUD]  WITH CHECK ADD  CONSTRAINT [FK_CTUD_monan] FOREIGN KEY([mauadai])
REFERENCES [dbo].[UaDai] ([mauadai])
GO
ALTER TABLE [dbo].[CTUD] CHECK CONSTRAINT [FK_CTUD_monan]
GO
ALTER TABLE [dbo].[donnhaphang]  WITH CHECK ADD  CONSTRAINT [FK_donnhaphang_nhanvien] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([manhanvien])
GO
ALTER TABLE [dbo].[donnhaphang] CHECK CONSTRAINT [FK_donnhaphang_nhanvien]
GO
ALTER TABLE [dbo].[donxuathang]  WITH CHECK ADD  CONSTRAINT [FK_donxuathang_nhanvien] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([manhanvien])
GO
ALTER TABLE [dbo].[donxuathang] CHECK CONSTRAINT [FK_donxuathang_nhanvien]
GO
ALTER TABLE [dbo].[hanghoa]  WITH CHECK ADD  CONSTRAINT [FK_hanghoa_LoaiHangHoa] FOREIGN KEY([mahanghoa])
REFERENCES [dbo].[LoaiHangHoa] ([maLoaiHangHoa])
GO
ALTER TABLE [dbo].[hanghoa] CHECK CONSTRAINT [FK_hanghoa_LoaiHangHoa]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_khachhang] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[khachhang] ([makhachhang])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_khachhang]
GO
ALTER TABLE [dbo].[khachhang]  WITH CHECK ADD  CONSTRAINT [FK_khachhang_hang] FOREIGN KEY([mahang])
REFERENCES [dbo].[HangKhachHang] ([mahang])
GO
ALTER TABLE [dbo].[khachhang] CHECK CONSTRAINT [FK_khachhang_hang]
GO
ALTER TABLE [dbo].[loaimonan]  WITH CHECK ADD  CONSTRAINT [FK_loaimon_Phongchucnang] FOREIGN KEY([maphong])
REFERENCES [dbo].[phongchucnang] ([maphong])
GO
ALTER TABLE [dbo].[loaimonan] CHECK CONSTRAINT [FK_loaimon_Phongchucnang]
GO
ALTER TABLE [dbo].[monan]  WITH CHECK ADD  CONSTRAINT [FK_monan_loaimonan] FOREIGN KEY([maloaimonan])
REFERENCES [dbo].[loaimonan] ([maloaimonan])
GO
ALTER TABLE [dbo].[monan] CHECK CONSTRAINT [FK_monan_loaimonan]
GO
