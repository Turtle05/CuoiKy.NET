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
car_id int primary key,
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
