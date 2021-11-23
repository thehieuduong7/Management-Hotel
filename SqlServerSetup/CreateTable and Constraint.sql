
--KhachHang
--NhanVien
--AccountNhanVien
--Phong
--DatPhong
--Kho
--DatMon
--NhapKhho
--ThanhToan
--PhanQuyen




USE [master]
GO
CREATE DATABASE [projectDBMS]
GO
USE [projectDBMS]




/****** Object:  Table [dbo].[KhachHang] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID_KH] [int] IDENTITY(1,1) NOT NULL,
	[Ho] [char](30) NOT NULL,
	[Ten] [char](30) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[SDT] [char](10) NULL,
	[GioiTinh] [char](10) NOT NULL,
	[Avatar] [IMAGE] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[ID_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[NhanVien] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ho] [char](30) NOT NULL,
	[Ten] [char](30) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[SDT] [char](10) NULL,
	[GioiTinh] [char](10) NOT NULL,
	[Avatar] [IMAGE] NULL,
	[Luong] [float] NOT NULL,
	[ChucVu] [char](30) NOT Null,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[AccountNhanVien]******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountNhanVien](
	[Username] [char](18) NOT NULL,
	[Password] [char](18) NOT NULL,
	[ID_NV] [int] NOT NULL,
 CONSTRAINT [PK_AccountNhanVien] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Phong]******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[ID_Phong] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [char](30) NOT NULL,
	[Vitri] [char](50) NOT NULL,
	[Photo] [IMAGE] NULL,
	[Gia] [float] NOT NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[ID_Phong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[DatPhong]  ******/
CREATE TABLE [dbo].[DatPhong](
	[MaDat] [int] IDENTITY(1,1) NOT NULL,
	[ID_KH] [int] NOT NULL,
	[ID_Phong] [int] NOT NULL,
	[ID_NV] [int] NOT NULL,
	[NgayDat] [datetime] NOT NULL,
	[TrangThai] [char](50) NOT NULL,
 CONSTRAINT [PK_DatPhong] PRIMARY KEY CLUSTERED 
(
	[MaDat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Kho] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[ID_Mon] [int] IDENTITY(1,1) NOT NULL,
	[TenMon] [char](30) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GiaGoc] [float] NOT NULL,
	[GiaBan] [float] NOT NULL,
	[Photo] [IMAGE] NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[ID_Mon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[DatMon] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatMon](
	[ID_DatMon] [int] IDENTITY(1,1) NOT NULL,
	[ID_DatPhong] [int] NOT NULL,
	[ID_Mon] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThoiGianDat] [datetime] NOT NULL,
 CONSTRAINT [PK_DatMon] PRIMARY KEY CLUSTERED 
(
	[ID_DatMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[NhapKho]******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapKho](
	[ID_NhapKho] [int] IDENTITY(1,1) NOT NULL,
	[ID_Mon] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ID_NVNhap] [int] NOT NULL,
	[ThoiGianNhap] [datetime] NOT NULL,
 CONSTRAINT [PK_NhapKho] PRIMARY KEY CLUSTERED 
(
	[ID_NhapKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[ThanhToan]******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhToan](
	[ID_ThanhToan] [int] IDENTITY(1,1) NOT NULL,
	[ID_DatPhong] [int] NOT NULL,
	[ID_NVThanhToan] [int] NOT NULL,
	[TongTien] [float] NOT NULL,
	[ThoiGianThanhToan] [datetime] NOT NULL,
 CONSTRAINT [PK_ThanhToan] PRIMARY KEY CLUSTERED 
(
	[ID_ThanhToan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 11/14/2021 5:49:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[id_quyen] [int] IDENTITY(1,1) NOT NULL,
	[username] [char](18) NOT NULL,
	[quyen] [char](50) NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[id_quyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Constraint Foreign Key ******/

ALTER TABLE [dbo].[AccountNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_AccountNhanVien_NhanVien] FOREIGN KEY([ID_NV])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[AccountNhanVien] CHECK CONSTRAINT [FK_AccountNhanVien_NhanVien]
GO
ALTER TABLE [dbo].[DatMon]  WITH CHECK ADD  CONSTRAINT [FK_DatMon_DatPhong] FOREIGN KEY([ID_DatPhong])
REFERENCES [dbo].[DatPhong] ([MaDat])
GO
ALTER TABLE [dbo].[DatMon] CHECK CONSTRAINT [FK_DatMon_DatPhong]
GO
ALTER TABLE [dbo].[DatMon]  WITH CHECK ADD  CONSTRAINT [FK_DatMon_Kho] FOREIGN KEY([ID_Mon])
REFERENCES [dbo].[Kho] ([ID_Mon])
GO
ALTER TABLE [dbo].[DatMon] CHECK CONSTRAINT [FK_DatMon_Kho]
GO

ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_DatPhong_KhachHang] FOREIGN KEY([ID_KH])
REFERENCES [dbo].[KhachHang] ([ID_KH])
GO
ALTER TABLE [dbo].[DatPhong] CHECK CONSTRAINT [FK_DatPhong_KhachHang]
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_DatPhong_NhanVien] FOREIGN KEY([ID_NV])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[DatPhong] CHECK CONSTRAINT [FK_DatPhong_NhanVien]
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_DatPhong_Phong] FOREIGN KEY([ID_Phong])
REFERENCES [dbo].[Phong] ([ID_Phong])
GO
ALTER TABLE [dbo].[DatPhong] CHECK CONSTRAINT [FK_DatPhong_Phong]
GO
ALTER TABLE [dbo].[NhapKho]  WITH CHECK ADD  CONSTRAINT [FK_NhapKho_Kho] FOREIGN KEY([ID_Mon])
REFERENCES [dbo].[Kho] ([ID_Mon])
GO
ALTER TABLE [dbo].[NhapKho] CHECK CONSTRAINT [FK_NhapKho_Kho]
GO
ALTER TABLE [dbo].[NhapKho]  WITH CHECK ADD  CONSTRAINT [FK_NhapKho_NhanVien] FOREIGN KEY([ID_NVNhap])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[NhapKho] CHECK CONSTRAINT [FK_NhapKho_NhanVien]
GO
ALTER TABLE [dbo].[ThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_ThanhToan_DatPhong] FOREIGN KEY([ID_DatPhong])
REFERENCES [dbo].[DatPhong] ([MaDat])
GO
ALTER TABLE [dbo].[ThanhToan] CHECK CONSTRAINT [FK_ThanhToan_DatPhong]
GO
ALTER TABLE [dbo].[ThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_ThanhToan_NhanVien] FOREIGN KEY([ID_NVThanhToan])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[ThanhToan] CHECK CONSTRAINT [FK_ThanhToan_NhanVien]
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_AccountNhanVien] FOREIGN KEY([username])
REFERENCES [dbo].[AccountNhanVien] ([Username])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_AccountNhanVien]
GO
/****** Constraint ******/

ALTER TABLE DatPhong ADD CONSTRAINT Cstr_trangthaidp DEFAULT 'Chua Thanh Toan' FOR TrangThai;
ALTER TABLE ThanhToan ADD CONSTRAINT Cstr_timett DEFAULT Getdate() FOR ThoiGianThanhToan;
ALTER TABLE DatPhong ADD CONSTRAINT Cstr_timedp DEFAULT Getdate() FOR NgayDat;
ALTER TABLE NhapKho ADD CONSTRAINT Cstr_timenk DEFAULT Getdate() FOR ThoiGianNhap;
ALTER TABLE DatMon ADD CONSTRAINT Cstr_timedm DEFAULT Getdate() FOR ThoiGianDat;
Alter table Phong add constraint Cstr_phong Check(Gia>0)
--Alter table AccountNhanVIen add constraint Cstr_Account Unique(Username)
Alter table DatPhong add CONSTRAINT  Cstr_DP Check(TrangThai in ('Chua Thanh Toan','Da Thanh Toan'))
Alter table KhachHang add constraint Cstr_kh Check(NgaySinh > '1/1/1900' and GioiTinh in ('Nam','Nu'))
Alter table NhanVien add constraint Cstr_nv Check(NgaySinh > '1/1/1900' and GioiTinh in ('Nam','Nu') and luong>0 and ChucVu in('TiepTan','QuanLy'))
Alter table NhapKho add constraint Cstr_nk Check(Soluong>0)
Alter table Kho add constraint Cstr_kho Check(GiaGoc>0 and GiaBan>0)
Alter table  DatMon add constraint Cstr_datmon Check(Soluong>0)
Alter table  PhanQuyen add constraint Cstr_PhanQuyen Unique(username,quyen)
