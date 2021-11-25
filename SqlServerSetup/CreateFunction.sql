use projectDBMS
go
--20
------------KhachHang------------
create function KhachHang_searchByID_func(@ID_kh int) returns table
as
return select * from KhachHang_detail_view where @ID_kh=ID_KH
go

create function KhachHang_searchFilter_func(@name char(30)) returns table
as
return select * from KhachHang_detail_view where CONCAT(Ho,Ten) like CONCAT('%',trim(@name),'%')
go

------------NhanVien------------

create function NhanVien_searchByID_func(@id int) returns table
as
return select * from NhanVien_detail_view where ID_NV=@id
go
create function NhanVien_searchFilter_func(@name char(30)) returns table
as
return select * from NhanVien_detail_view where CONCAT(Ho,Ten) like concat('%',trim(@name),'%')
go

create function NhanVien_getRole_func(@id_nv int) returns char(10)
as 
begin
	declare @role char(20)
	select @role=ChucVu from NhanVien where id=@id_nv
	return @role
end
go

------------AccountNhanVien------------
create function AccountNV_login_func(@username char(18),@password char(18)) returns table
as
return select * from AccountNV_detail_view where Username=@username and Password=@password
go

create function AccountNV_getRole_func(@username char(18)) returns char(20)
as 
begin
	declare @role char(20)
	select @role=ChucVU from AccountNV_detail_view where Trim(Username)=TRIM(@username) 
	return @role
end
go

------------Phong------------

create function Phong_searchByID_func(@ID_Phong int) returns table
as
return select * from Phong_trangthai_view where @ID_Phong=ID_Phong
go

create function Phong_searchFilter_func(@TenPhong char(20)) returns table
as
return select * from Phong_trangthai_view where TenPhong like CONCAT('%',TRIM(@TenPhong),'%')
go

------------DatPhong------------
create function DatPhong_TongTienDatPhong_func (@MaDat int) returns float
as
begin
	Declare  @Ngaydat datetime, @soNgayDat int, @giaPhong float,@ID_Phong int
	Select @ID_Phong=ID_Phong,@Ngaydat=NgayDat from DatPhong where MaDat=@MaDat
	Select @giaPhong=Gia from Phong where @ID_Phong=ID_Phong
	Set @soNgayDat=DATEDIFF(day, GETDATE(), @Ngaydat)
	if(@soNgayDat=0) set @soNgayDat=1
	return @soNgayDat * @giaPhong
end
go

create function DatPhong_search_func (@MaDat int) returns table
as
return select * from DatPhong_detail_view where MaDat=@MaDat
go

create function DatPhong_getMaDatAvaiByIDPhong_func(@ID_phong int) returns int
as
begin
	declare @Madat int
	select @Madat=MaDat from DatPhong where @ID_phong=ID_Phong and TrangThai='Chua Thanh Toan'
	return @Madat
end
go


------------Kho------------

create function Kho_searchByID_func(@ID_Mon int) returns table
as
return select * from Kho_detail_view where ID_Mon=@ID_Mon
go

create function Kho_searchFilter_func(@name char(30)) returns table
as
return select * from Kho_detail_view where TenMon like CONCAT('%',Trim(@name),'%')
go

------------DatMon------------
create function DatMon_listDaDat_func(@MaDat int) returns table
as
return Select DatMon.ID_DatMon,DatMon.ID_Mon,Kho.TenMon,Kho.GiaBan,DatMon.SoLuong,(DatMon.SoLuong*Kho.GiaBan) as TongTien,DatMon.ThoiGianDat 
from DatMon,Kho where DatMon.ID_Mon=Kho.ID_Mon and DatMon.ID_DatPhong=@MaDat
go

create function DatMon_tongTienDatMon_func(@MaDat int) returns float
as 
begin
declare @tongTienAn float
Select @tongTienAn = SUM(DatMon.SoLuong*GiaBan) from DatMon,Kho where ID_DatPhong=@MaDat and DatMon.ID_Mon=Kho.ID_Mon
	group by ID_DatPhong
if @tongTienAn is null
return 0
return @tongTienAn
end
go

------------NhapKhho------------
create function NhapKho_searchByID_func(@ID_NhapKho int) returns table
as
return select * from NhapKho_detail_view where ID_NhapKho=@ID_NhapKho
go

------------ThanhToan------------
create function ThanhToan_TongTienPhong_func(@MaDat int) Returns float
as
begin
	declare @tongThanhToan float,@tongTienPhong float,@tongTienAn float
	set @tongTienPhong=dbo.DatPhong_TongTienDatPhong_func(@MaDat)
	set @tongTienAn=dbo.DatMon_tongTienDatMon_func(@MaDat)
	set @tongThanhToan=@tongTienAn+@tongTienPhong
	return @tongThanhToan
end
go

------------PhanQuyen------------

create function PhanQuyen_seachByIDNV_func(@username char(18)) returns table
as
return select * from PhanQuyen_detail_view where Username=@username
go

create function PhanQuyen_seachByID_func(@id_PhanQuyen int) returns table
as
return select * from PhanQuyen_detail_view where ID_PhanQuyen=@id_PhanQuyen
go


