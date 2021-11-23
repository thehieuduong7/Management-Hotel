Use projectDBMS

----------------------Trigger PhanQuyen
go
create Trigger PhanQuyen_add_trig on PhanQuyen after insert		-- them quyen thi grant vao login
as 
begin
	begin transaction
	declare @username char(18),@quyen char(50),@exec char(100)
	select @username=username,@quyen=quyen from inserted
	set @exec= CONCAT(Trim(@quyen),' ','''',Trim(@username),'''',',''Grant''',' ')
	exec(@exec)
	commit transaction
end

go
create Trigger PhanQuyen_del_trig on PhanQuyen after delete			-- bo quyen thi revoke login
as 
begin
	begin transaction
	declare @username char(18),@quyen char(50),@exec char(100)
	select @username=username,@quyen=quyen from deleted
	if(@username=null) commit transaction
	set @exec= CONCAT(Trim(@quyen),' ','''',Trim(@username),'''',',''Revoke''',' ')
	exec(@exec)
	commit transaction
end




----------------Trigger  AccountNV
go
create Trigger AccountNV_add_trig on AccountNhanVien after insert		-- tao account thi khoi tao quyen cho user
as 
begin
	begin transaction
	declare @username char(18),@pass char(18),@id_nv int
	select @username=Username,@pass=Password,@id_nv=ID_NV from inserted
	declare @role char(10)
	set @role= dbo.NhanVien_getRole_func(@id_nv)
	declare @createLogin char(100),@createUser char(100)
	set @createLogin=CONCAT('create login ',Trim(@username),' with Password =''',TRIM(@pass),'''')
	set @createUser = concat('create user ',Trim(@username),' for login ',Trim(@username))
	exec(@createLogin)

	exec(@createUser)
	if(TRIM(@role)='TiepTan')
		exec PhanQuyen_TiepTan_Default @Username
	else
		exec  PhanQuyen_QuanLy_Default @Username
	commit transaction
end
go

create Trigger AccountNV_del_trig on AccountNhanVien for delete		--  xoa account thi drop user va login
as 
begin
	begin transaction
	declare @username char(18),@pass char(18),@id_nv int
	select @username=Username,@pass=Password,@id_nv=ID_NV from deleted
	declare @role char(10)
	declare @dropLogin char(100),@dropUser char(100)
	set @dropUser = concat('Drop user ',Trim(@username))
	set @dropLogin=CONCAT('Drop login ',Trim(@username))
	exec(@dropUser)
	exec(@dropLogin)
	commit transaction
end
go


------------Nhap Kho
go
create Trigger NhapKho_add_trig on NhapKho after insert		-- them nhap kho thi so luong trong kho tang len
as 
begin
	begin transaction 
	declare @id_mon int,@sl int
	select @id_mon=i.ID_Mon, @sl=i.SoLuong from inserted as i
	update Kho
	set SoLuong=SoLuong+@sl
	where ID_Mon=@id_mon
	commit transaction 
end
go

------------Dat Mon
create Trigger DatMon_add_trig on DatMon after insert	-- them dat mon thi` tru so luong o kho
as 
begin
	begin transaction 
	declare @id_mon int,@sl int,@sl_kho int
	select @id_mon=i.ID_Mon, @sl=i.SoLuong from inserted as i
	select @sl_kho=Kho.SoLuong from Kho where Kho.ID_Mon=@id_mon
	if(@sl>@sl_kho) 
		rollback
	else 
	begin
	update Kho
	set SoLuong=SoLuong-@sl
	where ID_Mon=@id_mon
	commit transaction 
	end
end
go

------------Dat Phong
create Trigger DatPhong_add_upd_trig on DatPhong after insert,update			-- kiem tra phong dat co dang trong hay khong
as 
begin
	begin transaction
	declare @id_phong_ins int
	select @id_phong_ins=ID_Phong from inserted
	
	declare @count int
	select @count=count(*) from DatPhong where ID_Phong=@id_phong_ins and TrangThai='Chua Thanh Toan'
	if(@count>1) rollback transaction
	else
	commit transaction
end
go

------------Thanh Toan
Create trigger ThanhToan_add_trig on ThanhToan for insert	-- thanh toan thi chuyen trang thai phong sang 'Da Thanh Toan'
as
begin
	begin transaction 
	declare @id_madat int
	select @id_madat = i.ID_DatPhong from inserted as i
	if(@id_madat not in (select MaDat from DatPhong where TrangThai like 'Chua Thanh Toan'))
		rollback
	update DatPhong
	set TrangThai='Da Thanh Toan'
	where MaDat=@id_madat
	commit transaction 
end
