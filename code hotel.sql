g
create table Shifts(
	id int primary key,
	time_start time not null,
	time_end time not null,
)
go 
insert into Shifts values(1,'6:30','14:30')
insert into Shifts values(2,'14:30','22:30')
insert into Shifts values(3,'22:30','6:30')
go
create table Position(
	id int primary key,
	name_position char(50) not null,
	salary float ,				--default money
	fine_money float,			--tien phat
	over_money float			--tang ca
)
go
insert into Position values(1,'Manager',null,null,null)
insert into Position values(2,'Receptionist',60,120,120)
insert into Position values(3,'Labourer',40,80,80)
go

create table Employee(
	id int primary key,
	first_name char(50) not null,
	last_name char(50) not null,
	id_position int not null,
	Foreign key (id_position) references Position,
	gender char(10) not null,
	dob Date not null,
	phone char(12) not null,
	address char(50) not null,
	picture Image not null,
)

create table Account(
	id_employee int not null,
	Foreign key(id_employee) references Employee,
	username char(20) primary key,
	password char(20) not null,
)

create table Assign(
	id int primary key,
	id_employee int not null,
	Foreign key(id_employee) References Employee,
	id_shift int not null,
	Foreign key(id_shift) References Shifts,
	day_start Date not null,
)
use master 
go
drop table Phong
drop table guest
use DB_Hotel
go
create table Guest(
	id_guest int primary key,
	full_name char(30) not null,
	age int not null,
	gender char(10) not null,
	phone char(11) not null,
)

create table Room(
	id_phong char(10) primary key,
	loai char(10) not null,
	so_giuong int not null,
	vitri char(10) not null,
	giaPhong float not null
)
go
insert into Room values('101','Thuong',2,'Tang 1',50000)
insert into Room values('102','Thuong',1,'Tang 1',50000)
insert into Room values('V102','VIP',1,'Tang 1',70000)
use DB_Hotel
go
drop table OrderRoom
go

create table OrderRoom(
	id_order char(10) primary key,
	id_room char(10) not null,
	id_guest int null,
	day_order datetime not null,
	status char(10) not null,
	foreign key(id_room) references Room,
	foreign key(id_guest) references Guest,
)
select * from Account
select * from Employee
select * from Division
use DB_Hotel
go
select * from OrderRoom
select Room.id_phong,Room.loai,Room.so_giuong,Room.vitri,Room.giaPhong from Room
inner join 
(Select Room.id_phong as id_room from Room
except 
select OrderRoom.id_room from OrderRoom where status = 'Open') as available
on room.id_phong=available.id_room
use DB_Hotel
go
drop table Food
create table Food(
	id_food char(10) primary key,
	picture Image null,
	name_food char(20) not null,
	amount int not null,
	price float not null
)
drop table OrderFood
go
create table OrderFood(
	id_order char(10) not null,
	id_food char(10) not null,
	amount int not null,
	day_order datetime not null
	foreign key(id_order) references OrderRoom,
	foreign key(id_food) references Food,
)
select * from OrderFood
select * from OrderRoom

select Food.id_food,Food.picture,Food.name_food,Food.amount,Food.price from OrderFood,Food 
where id_order='10323464' and Food.id_food=OrderFood.id_food;

