use projectDBMS
go

------------KhachHang------------
create procedure KhachHang_add_proc(@Ho char(30),@Ten char(30),@NgaySinh date,@SDT char(10),@GioiTinh char(10),@Avatar image)
as
begin
	insert into KhachHang(Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar) values(@Ho,@Ten,@NgaySinh,@SDT,@GioiTinh,@Avatar)
end
go
create procedure KhachHang_del_proc(@ID_KH int)
as
begin
	Delete from KhachHang where ID_KH=@ID_KH
end
go
create procedure KhachHang_upd_proc(@ID_KH int,@Ho char(30),@Ten char(30),@NgaySinh date,@SDT char(10),@GioiTinh char(10),@Avatar image)
as
begin
	UPDATE KhachHang SET
        Ho = Case WHEN @Ho is Not NULL THEN @Ho Else Ho End,
		Ten = Case WHEN @Ten is Not NULL THEN @Ten Else Ten End,
		NgaySinh = Case WHEN @NgaySinh is Not NULL THEN @NgaySinh Else Ho End,
		SDT = Case WHEN @SDT is Not NULL THEN @SDT Else SDT End,
		GioiTinh = Case WHEN @GioiTinh is Not NULL THEN @GioiTinh Else GioiTinh End,
		Avatar = Case WHEN @Avatar is Not NULL THEN @Avatar Else Avatar End
	WHERE ID_KH=@ID_KH
end
go

------------NhanVien------------
create procedure NhanVien_add_proc(@Ho char(30),@Ten char(30),@NgaySinh date,@SDT char(10),@GioiTinh char(10),@Avatar image,@Luong float,@ChucVu char(30))
as
begin
	insert into NhanVien(Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar,Luong,ChucVu) values(@Ho,@Ten,@NgaySinh,@SDT,@GioiTinh,@Avatar,@Luong,@ChucVu)
end
go
create procedure NhanVien_del_proc(@ID_NV int)
as
begin
	Delete from NhanVien where ID=@ID_NV
end
go
create procedure NhanVien_upd_sort_proc(@ID_NV int,@Ho char(30),@Ten char(30),@NgaySinh date,@SDT char(10),@GioiTinh char(10),@Avatar image)
as
begin
	UPDATE NhanVien SET
        Ho = Case WHEN @Ho is Not NULL THEN @Ho Else Ho End,
		Ten = Case WHEN @Ten is Not NULL THEN @Ten Else Ten End,
		NgaySinh = Case WHEN @NgaySinh is Not NULL THEN @NgaySinh Else Ho End,
		SDT = Case WHEN @SDT is Not NULL THEN @SDT Else SDT End,
		GioiTinh = Case WHEN @GioiTinh is Not NULL THEN @GioiTinh Else GioiTinh End,
		Avatar = Case WHEN @Avatar is Not NULL THEN @Avatar Else Avatar End
	WHERE ID=@ID_NV
end
go

create procedure NhanVien_upd_full_proc(@ID_NV int,@Ho char(30),@Ten char(30),@NgaySinh date,@SDT char(10),@GioiTinh char(10),@Avatar image,@Luong float,@ChucVu char(30))
as
begin
	UPDATE NhanVien SET
        Ho = Case WHEN @Ho is Not NULL THEN @Ho Else Ho End,
		Ten = Case WHEN @Ten is Not NULL THEN @Ten Else Ten End,
		NgaySinh = Case WHEN @NgaySinh is Not NULL THEN @NgaySinh Else NgaySinh End,
		SDT = Case WHEN @SDT is Not NULL THEN @SDT Else SDT End,
		GioiTinh = Case WHEN @GioiTinh is Not NULL THEN @GioiTinh Else GioiTinh End,
		Avatar = Case WHEN @Avatar is Not NULL THEN @Avatar Else Avatar End,
		Luong = Case WHEN @Luong is Not NULL THEN @Luong Else Luong End,
		ChucVu = Case WHEN @ChucVu is Not NULL THEN @ChucVu Else ChucVu End

	WHERE ID=@ID_NV
end
go

------------AccountNhanVien------------

create procedure AccountNV_add_proc(@username char(18),@password char(18),@ID_NV int)
as
begin
	insert into AccountNhanVien(Username,Password,ID_NV) values(@username,@password,@ID_NV)
end
go

create procedure AccountNV_del_proc(@Username char(18))
as
begin
	delete from PhanQuyen where username= @Username
	delete from AccountNhanVien where Username = @Username
end
go


create procedure AccountNV_upd_proc(@Username char(18),@Password char(18))
as
begin
	update AccountNhanVien
	set Password= (case when @Password is not null then @Password else Password end)
	where Username=@Username
end
go

------------Phong------------

create procedure Phong_add_proc(@TenPhong char(30),@Vitri char(50),@Photo image,@Gia float)
as
begin
	insert into Phong(TenPhong,Vitri,Photo,Gia) values(@TenPhong,@Vitri,@Photo,@Gia)
end
go
create procedure Phong_del_proc(@ID_Phong int)
as
begin
	Delete from Phong where ID_Phong=@ID_Phong
end
go
create procedure Phong_upd_sort_proc(@ID_Phong int,@TenPhong char(30),@Vitri char(50),@Photo image)
as
begin
	UPDATE Phong SET
		TenPhong = Case WHEN @TenPhong is Not NULL THEN @TenPhong Else TenPhong End,
		Vitri = Case WHEN @Vitri is Not NULL THEN @Vitri Else Vitri End,
		Photo = Case WHEN @Photo is Not NULL THEN @Photo Else Photo End
	WHERE ID_Phong=@ID_Phong
end
go

create procedure Phong_upd_full_proc(@ID_Phong int,@TenPhong char(30),@Vitri char(50),@Photo image,@Gia float)
as
begin
	UPDATE Phong SET
		TenPhong = Case WHEN @TenPhong is Not NULL THEN @TenPhong Else TenPhong End,
		Vitri = Case WHEN @Vitri is Not NULL THEN @Vitri Else Vitri End,
		Photo = Case WHEN @Photo is Not NULL THEN @Photo Else Photo End,
		Gia = Case WHEN @Gia is Not NULL THEN @Gia Else Gia End
	WHERE ID_Phong=@ID_Phong
end
go

------------DatPhong------------
create procedure DatPhong_add_proc(@ID_KH int,@ID_Phong int,@ID_NV int)
as
begin
	insert into DatPhong(ID_KH,ID_Phong,ID_NV) values(@ID_KH,@ID_Phong,@ID_NV)
end
go

create procedure DatPhong_doiPhong_proc(@MaDat int,@ID_Phong int)
as
begin
	update DatPhong set ID_Phong=@ID_Phong where DatPhong.MaDat = @MaDat
end
go


------------Kho------------
create procedure Kho_add_proc(@TenMon char(30),@SoLuong int,@GiaGoc float,@GiaBan float,@Photo Image)
as
begin
	insert into Kho(TenMon,SoLuong,GiaGoc,GiaBan,Photo) values (@TenMon,@SoLuong,@GiaGoc,@GiaBan,@Photo)
end
go
create procedure Kho_del_proc(@ID_Mon int)
as
begin
	Delete from Kho where @ID_Mon=ID_Mon
end
go
create procedure Kho_upd_proc(@ID_Mon int,@TenMon char(30),@SoLuong int,@GiaGoc float,@GiaBan float,@Photo Image)
as
begin
	UPDATE Kho SET
        TenMon = Case WHEN @TenMon is Not NULL THEN @TenMon Else TenMon End,
	SoLuong = Case WHEN @SoLuong is Not NULL THEN @SoLuong Else SoLuong End,
        GiaGoc = Case WHEN @GiaGoc is Not NULL THEN @GiaGoc Else GiaGoc End,
        GiaBan = Case WHEN @GiaBan is Not NULL THEN @GiaBan Else GiaBan End,
	Photo = Case WHEN @Photo is Not NULL THEN @Photo Else Photo End
	WHERE ID_Mon = @ID_Mon
end
go

------------DatMon------------
create procedure DatMon_add_proc(@ID_DatPhong int,@ID_Mon int,@Soluong int)
as
begin
	insert into DatMon(ID_DatPhong,ID_Mon,SoLuong) values(@ID_DatPhong,@ID_Mon,@Soluong)
end
go

------------NhapKhho------------
create procedure NhapKho_add_proc(@ID_Mon int,@SoLuong int,@ID_NVNhap int)
as
begin
	insert into NhapKho(ID_Mon,SoLuong,ID_NVNhap) values (@ID_Mon,@SoLuong,@ID_NVNhap)
end
go

------------ThanhToan------------
create procedure ThanhToan_add_proc(@ID_DatPhong int,@ID_NVThanhToan int)
as
begin
	declare @TongTien float
	set @TongTien=dbo.ThanhToan_TongTienPhong_func(@ID_DatPhong)
	Insert into ThanhToan(ID_DatPhong,ID_NVThanhToan,TongTien) values(@ID_DatPhong,@ID_NVThanhToan,@TongTien)
end
go

------------PhanQuyen------------
create procedure PhanQuyen_add_proc(@username char(18),@tenQuyen char(100))
as
begin
	insert into PhanQuyen(username,quyen) values(@username,@tenQuyen)
end
go
create procedure PhanQuyen_del_proc(@username char(18),@tenQuyen char(100))
as
begin
	delete from PhanQuyen where username=Trim(@username) and quyen=Trim(@tenQuyen)
end
go

create procedure PhanQuyen_excute_KhachHang(@username char(18),@head char(10))
as
begin
	exec (@head+' EXEC on KhachHang_add_proc to '+@username)
	exec (@head+' EXEC on KhachHang_del_proc to '+@username)
	exec (@head+' EXEC on KhachHang_upd_proc to '+@username)
end
go


create procedure PhanQuyen_excute_NhanVien(@username char(18),@head char(10))
as
begin
	declare @role char(20)
	select @role=dbo.AccountNV_getRole_func(@username)
	if(Trim(@role)='TiepVien')
		exec (@head+' EXEC on NhanVien_upd_sort_proc to '+@username)
	else
	begin
		exec (@head+' EXEC on NhanVien_upd_full_proc to '+@username)
		exec (@head+' EXEC on NhanVien_add_proc to '+@username)
		exec (@head+' EXEC on NhanVien_del_proc to '+@username)
	end
end
go

create procedure PhanQuyen_excute_AccountNV(@username char(18),@head char(10))
as
begin
	exec (@head+' EXEC on AccountNV_upd_proc to '+@username)
	declare @role char(20)
	select @role=dbo.AccountNV_getRole_func(@username)
	if(Trim(@role)!='TiepVien')
	begin
		exec (@head+' EXEC on AccountNV_add_proc to '+@username)
		exec (@head+' EXEC on AccountNV_del_proc to '+@username)
	end
end
go

create procedure PhanQuyen_excute_Phong(@username char(18),@head char(10))
as
begin
	exec (@head+' EXEC on Phong_add_proc to '+@username)
	exec (@head+' EXEC on Phong_del_proc to '+@username)
	declare @role char(20)
	select @role=dbo.AccountNV_getRole_func(@username)
	if(Trim(@role)='TiepVien')
		exec (@head+' EXEC on Phong_upd_sort_proc to '+@username)
	else
		exec (@head+' EXEC on Phong_upd_full_proc to '+@username)
end
go

create procedure PhanQuyen_excute_DatPhong(@username char(18),@head char(10))
as
begin
	exec (@head+' EXEC on DatPhong_add_proc to '+@username)
	exec (@head+' EXEC on DatPhong_doiPhong_proc to '+@username)
end
go

create procedure PhanQuyen_excute_Kho(@username char(18),@head char(10))
as
begin
	exec (@head+' EXEC on Kho_add_proc to '+@username)
	exec (@head+' EXEC on Kho_del_proc to '+@username)
	exec (@head+' EXEC on Kho_upd_proc to '+@username)
end
go



create procedure PhanQuyen_excute_NhapKho(@username char(18),@head char(10))
as
begin
	exec (@head+' EXEC on NhapKho_add_proc to '+@username)
end
go

create procedure PhanQuyen_excute_DatMon(@username char(18),@head char(10))
as
begin
	exec (@head+' EXEC on DatMon_add_proc to '+@username)
end
go

create procedure PhanQuyen_excute_ThanhToan(@username char(18),@head char(10))
as
begin
	exec (@head+' EXEC on ThanhToan_add_proc to '+@username)
end
go

create procedure PhanQuyen_QuanLy_Default(@username char(18))
as
begin
	
	exec ('Grant'+' Select on KhachHang_detail_view to '+@username)
	exec ('Grant'+' Select on NhanVien_detail_view to '+@username)
	exec ('Grant'+' Select on AccountNV_detail_view to '+@username)
	exec ('Grant'+' Select on Phong_trangthai_view to '+@username)
	exec ('Grant'+' Select on Phong_Available_view to '+@username)
	exec ('Grant'+' Select on Kho_detail_view to '+@username)
	exec ('Grant'+' Select on Kho_Available_view to '+@username)
	exec ('Grant'+' Select on NhapKho_TongNhap_view to '+@username)
	exec ('Grant'+' Select on NhapKho_detail_view to '+@username)
	exec ('Grant'+' Select on DatPhong_detail_view to '+@username)
	exec ('Grant'+' Select on DatMon_detail_view to '+@username)
	exec ('Grant'+' Select on ThanhToan_detail_view to '+@username)

	exec ('Grant'+' Select on KhachHang_searchByID_func to '+@username)
	exec ('Grant'+' Select on KhachHang_searchFilter_func to '+@username)
	exec ('Grant'+' Select on NhanVien_searchByID_func to '+@username)
	exec ('Grant'+' Select on AccountNV_login_func to '+@username)
	exec ('Grant'+' EXEC on AccountNV_getRole_func to '+@username)
	exec ('Grant'+' Select on Phong_searchByID_func to '+@username)
	exec ('Grant'+' Select on Phong_searchFilter_func to '+@username)
	exec ('Grant'+' Select on Kho_searchByID_func to '+@username)
	exec ('Grant'+' Select on Kho_searchFilter_func to '+@username)
	exec ('Grant'+' Select on NhapKho_searchByID_func to '+@username)
	exec ('Grant'+' EXEC on DatPhong_TongTienDatPhong_func to '+@username)
	exec ('Grant'+' Select on DatPhong_search_func to '+@username)
	exec ('Grant'+' EXEC on DatPhong_getMaDatAvaiByIDPhong_func to '+@username)
	exec ('Grant'+' Select on DatMon_listDaDat_func to '+@username)
	exec ('Grant'+' EXEC on DatMon_tongTienDatMon_func to '+@username)
	exec ('Grant'+' EXEC on ThanhToan_TongTienPhong_func to '+@username)

	exec ('Grant'+' SELECT on PhanQuyen_detail_view to '+@username)
	exec ('Grant'+' SELECT on PhanQuyen_seachByIDNV_func to '+@username)
	exec ('Grant'+' SELECT on PhanQuyen_seachByID_func to '+@username)

	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_KhachHang')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_NhanVien')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_AccountNV')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_Phong')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_Kho')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_DatPhong')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_DatMon')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_ThanhToan')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_NhapKho')
end
go
create procedure PhanQuyen_TiepTan_Default(@username char(18))
as
begin
	exec ('Grant'+' Select on KhachHang_detail_view to '+@username)
	exec ('Grant'+' Select on Phong_trangthai_view to '+@username)
	exec ('Grant'+' Select on Phong_Available_view to '+@username)
	exec ('Grant'+' Select on Kho_detail_view to '+@username)
	exec ('Grant'+' Select on Kho_Available_view to '+@username)
	exec ('Grant'+' Select on DatPhong_detail_view to '+@username)
	exec ('Grant'+' Select on DatMon_detail_view to '+@username)
	exec ('Grant'+' Select on ThanhToan_detail_view to '+@username)

	exec ('Grant'+' Select on KhachHang_searchByID_func to '+@username)
	exec ('Grant'+' Select on KhachHang_searchFilter_func to '+@username)
	exec ('Grant'+' Select on NhanVien_searchByID_func to '+@username)
	exec ('Grant'+' Select on AccountNV_login_func to '+@username)
	exec ('Grant'+' EXEC on AccountNV_getRole_func to '+@username)
	exec ('Grant'+' Select on Phong_searchByID_func to '+@username)
	exec ('Grant'+' Select on Phong_searchFilter_func to '+@username)
	exec ('Grant'+' Select on Kho_searchByID_func to '+@username)
	exec ('Grant'+' Select on Kho_searchFilter_func to '+@username)
	exec ('Grant'+' Select on NhapKho_searchByID_func to '+@username)
	exec ('Grant'+' EXEC on DatPhong_TongTienDatPhong_func to '+@username)
	exec ('Grant'+' Select on DatPhong_search_func to '+@username)
	exec ('Grant'+' EXEC on DatPhong_getMaDatAvaiByIDPhong_func to '+@username)
	exec ('Grant'+' Select on DatMon_listDaDat_func to '+@username)
	exec ('Grant'+' EXEC on DatMon_tongTienDatMon_func to '+@username)
	exec ('Grant'+' EXEC on ThanhToan_TongTienPhong_func to '+@username)
	

	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_KhachHang')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_NhanVien')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_AccountNV')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_Phong')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_Kho')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_DatPhong')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_DatMon')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_ThanhToan')
	Insert into PhanQuyen(username,quyen) values (@username,'PhanQuyen_excute_NhapKho')
end
go