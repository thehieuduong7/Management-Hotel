use projectDBMS
go

------------KhachHang------------
create view KhachHang_detail_view(ID_KH,Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar)
as
select ID_KH,Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar from KhachHang
go

------------NhanVIen------------
create view NhanVien_detail_view(ID_NV,Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar,Luong,ChucVu)
as
select ID,Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar,Luong,ChucVu from NhanVien
go

------------AccountNhanVIen------------


create view AccountNV_detail_view(Username,Password,ID_NV,TenNV,ChucVU)
as
select AccountNhanVien.Username,AccountNhanVien.Password,AccountNhanVien.ID_NV,NhanVien.Ten,NhanVien.ChucVu from AccountNhanVien,NhanVien
where AccountNhanVien.ID_NV=NhanVien.ID
go

------------Phong------------

create view Phong_trangthai_view(ID_Phong,TenPhong,Vitri,Photo,Gia,TrangThai)
as
select ID_Phong,TenPhong,Vitri,Photo,Gia,(case when ID_Phong in 
			(select ID_Phong from DatPhong where TrangThai='Chua Thanh Toan') 
			then 'Dang Su Dung' else 'Con Trong' end) 
from Phong
go

create view Phong_Available_view(ID_Phong,TenPhong,Vitri,Photo,Gia,TrangThai)
as
select * from Phong_trangthai_view where TrangThai='Con Trong'
go


------------DatPhong------------

create view DatPhong_detail_view(MaDat,ID_KH,TenKhachHang,ID_Phong,TenPhong,GiaPhong,ID_NV,
TenNVDat,NgayDat,TrangThai)
as
select DatPhong.MaDat,DatPhong.ID_KH,KhachHang.Ten,Phong.ID_Phong,Phong.TenPhong,Phong.Gia,DatPhong.ID_NV,
NhanVien.Ten,DatPhong.NgayDat,DatPhong.TrangThai
from DatPhong,Phong,NhanVien,KhachHang
where DatPhong.ID_KH=KhachHang.ID_KH and DatPhong.ID_NV=NhanVien.ID and
DatPhong.ID_Phong=Phong.ID_Phong
go

------------Kho------------


create view Kho_detail_view(ID_Mon,TenMon,SoLuong,GiaGoc,GiaBan,Photo)
as
select ID_Mon,TenMon,SoLuong,GiaGoc,GiaBan,Photo from Kho
go


create view Kho_Available_view(ID_Mon,TenMon,SoLuong,GiaGoc,GiaBan,Photo)
as
select ID_Mon,TenMon,SoLuong,GiaGoc,GiaBan,Photo from Kho where SoLuong>0
go

------------DatMon------------

create view DatMon_detail_view(ID_DatMon,MaDat,TenKH,TenPhong,TenMon,GiaMon,SoLuong,ThoiGianDat)
as
select DatMon.ID_DatMon,DatPhong.MaDat,KhachHang.Ten,Phong.TenPhong, Kho.TenMon,Kho.GiaBan,DatMon.SoLuong,DatMon.ThoiGianDat
from DatPhong,Phong,KhachHang,DatMon,Kho
where KhachHang.ID_KH=DatPhong.ID_KH and Phong.ID_Phong=DatPhong.ID_Phong 
and DatPhong.MaDat=DatMon.ID_DatPhong and DatMon.ID_Mon=Kho.ID_Mon
go

------------NhapKho------------

create view NhapKho_TongNhap_view(ID_Mon,TenMon,TongSoLuongDaNhap,GiaGoc,GiaBan,Photo)
as
select Kho.ID_Mon,Kho.TenMon,Nhap.TongSoluong,Kho.GiaGoc,Kho.GiaBan,Kho.Photo from Kho
left join (select NhapKho.ID_Mon,Sum(NhapKho.SoLuong) as TongSoluong from NhapKho group by NhapKho.ID_Mon)as Nhap
on Kho.id_mon=Nhap.ID_Mon
go


create view NhapKho_detail_view(ID_NhapKho,ID_Mon,TenMon,SoluongNhap,GiaGoc,GiaBan,Photo,ThoiGianNhap)
as
select NhapKho.ID_NhapKho,NhapKho.ID_Mon,Kho.TenMon,NhapKho.SoLuong,Kho.GiaGoc,Kho.GiaBan,Kho.Photo,NhapKho.ThoiGianNhap from NhapKho,Kho
where NhapKho.ID_Mon=kho.ID_Mon
go


------------ThanhToan------------

create view ThanhToan_detail_view(ID_ThanhToan,ID_DatPhong,TenKH,TenPhong,TenNVTT,TongTien,ThoiGianThanhToan) 
as
select ThanhToan.ID_ThanhToan,ThanhToan.ID_DatPhong,KhachHang.Ten,Phong.TenPhong,NhanVien.Ten,ThanhToan.TongTien,ThanhToan.ThoiGianThanhToan
from ThanhToan,DatPhong,NhanVien,KhachHang,Phong
where ThanhToan.ID_NVThanhToan=NhanVien.ID and ThanhToan.ID_DatPhong=DatPhong.MaDat and
DatPhong.ID_KH=KhachHang.ID_KH and DatPhong.ID_Phong=Phong.ID_Phong
go

------------PhanQuyen------------

create view PhanQuyen_detail_view(ID_PhanQuyen,Username,ID_nv,ChucVu,TenQuyen)
as
select PhanQuyen.id_quyen,PhanQuyen.username,NhanVien.ID,NhanVien.ChucVu,PhanQuyen.quyen from PhanQuyen,AccountNhanVien,NhanVien where PhanQuyen.username=AccountNhanVien.Username
and AccountNhanVien.ID_NV=NhanVien.ID
go