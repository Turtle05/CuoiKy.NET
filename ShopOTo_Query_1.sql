use ShopOTo
create table member
(
member_id int identity(1,1) primary key,
member_name nvarchar(255),
gender nvarchar(30),
nationality nvarchar(255),
addr nvarchar(255),
phone varchar(255),
email varchar(255),
pass varchar(255),
role varchar(50)
);

create table car_type
(
cartype_id nvarchar(50) primary key,
cartype_name nvarchar(255),
);

create table car_class
(
car_class_id nvarchar(50) primary key,
car_class_name nvarchar(255),
cartype_id nvarchar(50)
foreign key (cartype_id)
references car_type(cartype_id)
on update cascade
on delete cascade
);

create table car
(
car_id int identity(1,1) primary key,
car_name varchar(255),
cartype nvarchar(50)
foreign key (cartype)
references car_type(cartype_id)
on update cascade
on delete cascade,
car_class nvarchar(50)
foreign key (car_class)
references car_class(car_class_id),
color nvarchar(50),
car_seat int,
energy_type nvarchar(50),
price float,
car_info nvarchar(4000),
intitial_quantity float,
quantity float
)

create table booking
(
booking_id int identity(1,1) primary key,
member_id int
foreign key(member_id)
references member(member_id)
on update cascade
on delete cascade,
car_id int 
foreign key(car_id)
references car(car_id)
on update cascade
on delete cascade,
amount float,
total_price float
)
drop table booking;
drop table car

-- Insert in to member
insert into member
values (N'Nguyễn Nho Song Hoàng',N'Nam','VietNam',N'Đà Nẵng','0905000001','abc123@gmail.com','123456','ADMIN');
insert into member
values (N'Lê Huy Ngọ',N'Nam','VietNam',N'Đà Nẵng','0905000002','abc1234@gmail.com','123456','USER');
insert into member
values (N'Nguyễn Chiếm Giang',N'Nam','VietNam',N'Quãng Ngãi','0905000003','abcd123@gmail.com','123456','USER');
insert into member
values (N'Nguyễn Thanh Nhàn',N'Nam','VietNam',N'Quãng Ngãi','0905000004','abcd1234@gmail.com','123456','USER');
insert into member
values (N'Nguyễn Ngọc Mạnh',N'Nam','VietNam',N'Hà Tĩnh','0905000005','abcd12345@gmail.com','123456','USER');
insert into member
values (N'Nguyễn Quốc Cường',N'Nam','VietNam',N'Đà Nẵng','0905000006','abcde12345@gmail.com','123456','USER');
insert into member
values (N'Phan Mạnh Cường',N'Nam','VietNam',N'Đà Nẵng','0905000007','abcdef12345@gmail.com','123456','USER');
insert into member
values (N'Nguyễn Thị Thảo',N'Nữ','VietNam',N'Đà Nẵng','0905000008','abcdef123456@gmail.com','123456','USER');
insert into member
values (N'Nguyễn Lương Thiện',N'Nam','VietNam',N'Đà Nẵng','0905000009','abcdefg12345@gmail.com','123456','USER');
insert into member
values (N'Lê Trung Hoàng',N'Nam','VietNam',N'Đà Nẵng','0905000010','abcdefg123456@gmail.com','123456','USER');
insert into member
values (N'Lê Văn An',N'Nam','VietNam',N'Quãng Ngãi','0905000011','abcdefg1234567@gmail.com','123456','USER');
insert into member
values (N'Phan Bình',N'Nam','VietNam',N'Hà Tĩnh','0905000012','abcdefg123@gmail.com','123456','USER');
insert into member
values (N'Nguyễn Tiến Hùng',N'Nam','VietNam',N'Quảng Bình','0905000013','abcdefg1234@gmail.com','123456','USER');
insert into member
values (N'Đặng Huỳnh Khánh Dương',N'Nam','VietNam',N'Đà Nẵng','0905000014','abcdefgh1234@gmail.com','123456','USER');

-- Insert car_class 
insert into car_class 
values ('A', 'A Class', 'Sedan');
insert into car_class 
values ('AMG-C', 'AMG Class', 'Coupe');
insert into car_class 
values ('AMG-GT', 'AMG Class', 'Coupe');
insert into car_class 
values ('C', 'C Class', 'Sedan');
insert into car_class 
values ('E', 'E Class', 'Sedan');
insert into car_class 
values ('S', 'S Class', 'Sedan');
insert into car_class 
values ('EQS', 'EQS Class', 'Sedan');
insert into car_class 
values ('C-Coupe', 'C Class', 'Coupe');
insert into car_class 
values ('E-Coupe', 'E Class', 'Coupe');
insert into car_class 
values ('G', 'G Class', 'SUV');
insert into car_class 
values ('GLC', 'GLC Class', 'SUV');
insert into car_class 
values ('GLE', 'GLE Class', 'SUV');
insert into car_class 
values ('GLS', 'GLS Class', 'SUV');
insert into car_class 
values ('EQB', 'EQB Class', 'SUV');

-- Insert into car
insert into car
values ('A200','Sedan','A',N'Trắng',4,N'Xăng',1399000000,N'Mercedes-benz A200.Chiều dài cơ sở: 4199 (mm).Dung tích xi lanh: 1595 (cc).Dung tích bình nhiên liệu: 50 (litre)',10);
insert into car
values ('A220','Sedan','A',N'Trắng',4,N'Xăng',1699000000,N'Mercedes-benz A220.Chiều dài cơ sở: 4299 (mm).Dung tích xi lanh: 1991 (cc).Dung tích bình nhiên liệu: 50/6 (litre)',10),
('A45','Sedan','A',N'Trắng',5,N'Xăng',2249000000,N'Mercedes-benz A45.Chiều dài cơ sở: 4299 (mm).Dung tích xi lanh: 1991 (cc).Dung tích bình nhiên liệu: 50 (litre)',10),
('C43','Sedan','C',N'Trắng',5,N'Xăng',2249000000,N'Mercedes-benz C43.Chiều dài cơ sở: 4299 (mm).Dung tích xi lanh: 2996 (cc).Dung tích bình nhiên liệu: 66 (litre)',10),
('C200','Sedan','C',N'Trắng',5,N'Xăng',1499000000,N'Mercedes-benz C200.Chiều dài cơ sở: 4686 (mm).Dung tích xi lanh: 1497 (cc).Dung tích bình nhiên liệu: 60 (litre)',10),
('C300','Sedan','C',N'Trắng',5,N'Xăng',1939000000,N'Mercedes-benz C300.Chiều dài cơ sở: 4686 (mm).Dung tích xi lanh: 1991 (cc).Dung tích bình nhiên liệu: 66 (litre)',10),
('EQS','Sedan','E',N'Trắng',5,N'Điện',2399000000,N'Mercedes-benz EQS.Chiều dài cơ sở: 5265 (mm).Phạm vi hoạt động: 770 (km)',10),
('E200','Sedan','E',N'Trắng',5,N'Xăng',2310000000,N'Mercedes-benz E200.Chiều dài cơ sở: 2939 (mm).Dung tích xi lanh: 1991 (cc).Dung tích bình nhiên liệu: 66 (litre)',10),
('E300','Sedan','E',N'Xám',5,N'Xăng',2950000000,N'Mercedes-benz E300.Chiều dài cơ sở: 4923 (mm).Dung tích xi lanh: 1991 (cc).Dung tích bình nhiên liệu: 66 (litre)',10),
('E350','Sedan','E',N'Xanh',5,N'Xăng',2890000000,N'Mercedes-benz E350.Chiều dài cơ sở: 4922 (mm).Dung tích xi lanh: 1991 (cc).Dung tích bình nhiên liệu: 66 (litre)',10),
('E43','Sedan','E',N'ĐeN',5,N'Xăng',1939000000,N'Mercedes-benz E43.Chiều dài cơ sở: 4686 (mm).Dung tích xi lanh: 1991 (cc).Dung tích bình nhiên liệu: 66 (litre)',10),
('S450','Sedan','S',N'Trắng',5,N'Xăng',5059000000,N'Mercedes-benz S450.Chiều dài cơ sở: 5300 (mm).Dung tích xi lanh: 2999 (cc).Dung tích bình nhiên liệu: 93 (litre)',10),
('S500','Sedan','S',N'Trắng',5,N'Xăng',2550000000,N'Mercedes-Benz S500.Chiều dài cơ sở: 5255 (mm).Dung tích xi lanh: 3982 (cc).Dung tích bình nhiên liệu: 80 (litre)',10),
('S600','Sedan','S',N'Đen',5,N'Xăng',14448000000,N'Mercedes-Maybach S600.Chiều dài cơ sở: 5453 (mm).Dung tích xi lanh: 5980 (cc).Dung tích bình nhiên liệu: 80 (litre)',10),
('S680','Sedan','S',N'Đỏ Rubellite',5,N'Xăng',18500000000,N'Mercedes-Maybach S680.Chiều dài cơ sở: 5468 (mm).Dung tích xi lanh: 1991 (cc).Dung tích bình nhiên liệu: 66 (litre)',10),
('S65','Sedan','S',N'Đen',5,N'Xăng',12800000000,N'Mercedes-Maybach S65.Chiều dài cơ sở: 5287 (mm).Dung tích xi lanh: 5980 (cc).Dung tích bình nhiên liệu: 80 (litre)',10),
('GLC300','SUV','GLC',N'Trắng',5,N'Xăng',2569000000,N'Mercedes-benz GLC300.Chiều dài cơ sở: 4670 (mm).Dung tích xi lanh: 1991 (cc).Dung tích bình nhiên liệu: 50 (litre)',10),
('GLC350','SUV','GLC',N'Xanh',5,N'Xăng',4209000000,N'Mercedes-benz GLC350.Chiều dài cơ sở: 5130 (mm).Dung tích xi lanh: 1991 (cc).Dung tích bình nhiên liệu: 50 (litre)',10),
('GLC400','SUV','GLC',N'Xám',5,N'Xăng',2569000000,N'Mercedes-benz GLC300.Chiều dài cơ sở: 4670 (mm).Dung tích xi lanh: 1991 (cc).Dung tích bình nhiên liệu: 50 (litre)',10),
('GLE300','SUV','GLE',N'Xám',5,N'Xăng',6400000000,N'Mercedes-benz GLE300.Chiều dài cơ sở: 4670 (mm).Dung tích xi lanh: 1991 (cc).Dung tích bình nhiên liệu: 50 (litre)',10),
('GLE400','SUV','GLE',N'Xanh',5,N'Xăng',3899000000,N'Mercedes-benz GLE400.Chiều dài cơ sở: 4819 (mm).Dung tích xi lanh: 2996 (cc).Dung tích bình nhiên liệu: 93 (litre)',10),
('GLE500','SUV','GLE',N'Đen',5,N'Xăng',2569000000,N'Mercedes-benz GLE500.Chiều dài cơ sở: 4670 (mm).Dung tích xi lanh: 1991 (cc).Dung tích bình nhiên liệu: 50 (litre)',10),
('GLS400','SUV','GLS',N'Trắng',7,N'xăng',4599000000,N'Mercedes-benz GLS400.Chiều dài cơ sở: 5207 (mm).Dung tích xi lanh: 2999 (cc).Dung tích bình nhiên liệu: 90 (litre)',10),
('GLS500','SUV','GLS',N'Xanh',7,N'Xăng',7829000000,N'Mercedes-benz GLS500.Chiều dài cơ sở: 5212 (mm).Dung tích xi lanh: 4691 (cc).Dung tích bình nhiên liệu: 90 (litre)',10),
('G400','SUV','G',N'Xanh',5,N'xăng',4050000000,N'Mercedes-AMG G400.Chiều dài cơ sở: 5207 (mm).Dung tích xi lanh: 2999 (cc).Dung tích bình nhiên liệu: 90 (litre)',10),
('G63','SUV','G',N'Trắng',5,N'Xăng',10950000000,N'Mercedes-AMG G63.Chiều dài cơ sở: 4874 (mm).Dung tích xi lanh: 3982 (cc).Dung tích bình nhiên liệu: 100 (litre)',10),
('EQS','Sedan','E',N'Trắng',7,N'Điện',2399000000,N'Mercedes-benz EQB.Chiều dài cơ sở: 4634 (mm).Phạm vi hoạt động: 419 (km)',10),
('AMG-GT2','Coupe','AMG-GT',N'Xanh',2,N'xăng',4050000000,N'Mercedes-AMG GT.Chiều dài cơ sở: 4544 (mm).Dung tích xi lanh: 2999 (cc).Dung tích bình nhiên liệu: 90 (litre)',10),
('AMG-GT4','Coupe','AMG-GT',N'Xanh',2,N'Xăng',6719000000,N'Mercedes-AMG GT.Chiều dài cơ sở: 4874 (mm).Dung tích xi lanh: 3982 (cc).Dung tích bình nhiên liệu: 100 (litre)',10),
('AMG-C43','Coupe','AMG-C',N'Đen',2,N'xăng',4150000000,N'Mercedes-AMG C43.Chiều dài cơ sở: 4669 (mm).Dung tích xi lanh: 2996 (cc).Dung tích bình nhiên liệu: 66 (litre)',10),
('AMG-C63','Coupe','AMG-C',N'Trắng',2,N'Xăng',4678000000,N'Mercedes-AMG C63.Chiều dài cơ sở: 4757 (mm).Dung tích xi lanh: 3982 (cc).Dung tích bình nhiên liệu: 66 (litre)',10),
('E300-Coupe','Coupe','E-Coupe',N'Trắng',2,N'xăng',3099000000,N'Mercedes-benz E300 Coupe.Chiều dài cơ sở: 4826 (mm).Dung tích xi lanh: 2996 (cc).Dung tích bình nhiên liệu: 66 (litre)',10),
('E400-Coupe','Coupe','E-Coupe',N'Đỏ',2,N'Xăng',4678000000,N'Mercedes-benz E400 Coupe.Chiều dài cơ sở: 4757 (mm).Dung tích xi lanh: 3982 (cc).Dung tích bình nhiên liệu: 66 (litre)',10),
('C200-Coupe','Coupe','C-Coupe',N'Xanh',2,N'xăng',2517000000,N'Mercedes-benz C200 Coupe.Chiều dài cơ sở: 4696 (mm).Dung tích xi lanh: 2996 (cc).Dung tích bình nhiên liệu: 66 (litre)',10),
('C300-Coupe','Coupe','C-Coupe',N'Xám',4,N'Xăng',2699000000,N'Mercedes-benz C300 Coupe.Chiều dài cơ sở: 4686 (mm).Dung tích xi lanh: 1991 (cc).Dung tích bình nhiên liệu: 66 (litre)',10);


-- Create procedure
create procedure Check_Email
@email varchar(255)
as
select pass from member where email = @email
exec Check_Email @email = 'abcdefgh123456@gmail.com'

create procedure Add_Member
@member_name nvarchar(255),
@gender nvarchar(30),
@nationality nvarchar(255),
@addr nvarchar(255),
@phone varchar(255),
@email varchar(255),
@pass varchar(255),
@role varchar(50)
as
	insert into member
	values (@member_name,@gender,@nationality,@addr,@phone,@email,@pass,@role);
