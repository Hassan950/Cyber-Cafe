
-----------------Database Creation---------------------
CREATE DATABASE Cyber_Cafe
GO
USE Cyber_Cafe

CREATE TABLE [User]
(
ID int check (ID >= 10000 and ID <= 99999),
Usertype int not null, --1 is manager --2 is emplyee --3 is customer
[password] binary(64) not null,
primary key(ID),
)


CREATE TABLE Employee
(
ID int foreign key references [user] on update cascade  primary key ,
name varchar(20),
salary int check (salary > 0), 
start_time time, 
end_time time,
complaint_no int check (complaint_no >= 0),
constraint chk_time check (end_time > start_time),
)

CREATE TABLE Customer
(
ID int foreign key references [user] on update cascade primary key,
name varchar(20),
email varchar(50) unique,
phone_no varchar(13) unique
)


CREATE TABLE Offer
(
[name] varchar(20) primary key,
[type] varchar(50),
discount int check (discount > 0),
[start_date] date,
[end_date] date,
constraint chk_date check ([end_date] > [start_date])
)


CREATE TABLE FoodNDrinks
(
name varchar(20),
[type] varchar(20),
primary key(name, [type]),
price int check (price > 0) not null,
stock int check (stock >= 0) not null,
)

CREATE TABLE Room
(
number int check (number > 0),
[type] varchar(10),
available bit,
primary key (number),
)

CREATE TABLE Game
(
name varchar(20) primary key,
total_number int check (total_number >= 0),
)

CREATE TABLE Tournament
(
name varchar(50) unique ,
[date] date,
primary key(name, [date]),
[status] varchar(20),
comp_no int check (comp_no > 0),
)

CREATE TABLE Shift_Logs
(
ID int foreign key references Employee on update cascade ,
[Date] date,
primary key(ID, [Date])
)

CREATE TABLE Reserve
(
EID int,
[Date] date,
foreign key(EID, [Date]) references Shift_Logs on update cascade  ,
room_no int foreign key references Room on update cascade  ,
game_name varchar(20) foreign key references Game on update cascade  ,
CID int foreign key references Customer on update No action  ,
[start_time] time,
primary key(EID, room_no, game_name, CID, [Date],start_time),
end_time time not null,
constraint chk_time1 check ([end_time] > [start_time]),
)

CREATE TABLE Screen
(
room_no int foreign key references Room on update cascade  primary key,
[type] varchar(20),
condition varchar(20)
)

CREATE TABLE Console
(
room_no int foreign key references Room on update cascade  primary key,
name varchar(20),
condition varchar(20)
)

CREATE TABLE Held
(
t_name varchar(50),
t_date date,
foreign key(t_name, t_date) references Tournament on update cascade ,
g_name varchar(20) foreign key references Game on update cascade ,
room_no int foreign key references Room on update cascade  ,
primary key(t_name, t_date, g_name, room_no)
)

CREATE TABLE Feedback
(
[Date] date,
CID int foreign key references Customer on update no action ,
[description] varchar(500),
[type] varchar(10) check ([type] ='feedback' OR [type] ='request') ,
primary key([Date],CID,[description],[type])
)

CREATE TABLE Customer_Offer
(
CID int foreign key references Customer on update no action ,
offer_name varchar(20) references Offer on update cascade  ,
primary key(CID, offer_name)
)


CREATE TABLE Order_Shift
(
name varchar(20),
[type] varchar(20),
foreign key(name, [type]) references FoodNDrinks(name, [type]) on update cascade  , 
EID int,
[Date] date,
foreign key(EID, [Date]) references Shift_Logs on update cascade  ,
primary key(name, [type], EID, [Date]),
quantity int check (quantity > 0) not null,
)

CREATE TABLE Cust_Tourn
(
t_name varchar(50),
t_date date,
foreign key(t_name, t_date) references Tournament  ,
CID int foreign key references Customer on update cascade ,
primary key(t_name, t_date, CID),
reg_date date,
constraint chk_date1 check (reg_date >= t_date),
)

---------------------Value Insertion----------------------

insert into [User]
values 
(10000,1,HASHBYTES('SHA2_512', 'user0'+'P@ssw0rd')),
(11111,2,HASHBYTES('SHA2_512', 'user1'+'P@ssw0rd')),
(22222,2,HASHBYTES('SHA2_512', 'user2'+'P@ssw0rd')),
(33333,3,HASHBYTES('SHA2_512', 'user3'+'P@ssw0rd')),
(44444,3,HASHBYTES('SHA2_512', 'user4'+'P@ssw0rd')),
(55555,3,HASHBYTES('SHA2_512', 'user5'+'P@ssw0rd')),
(66666,3,HASHBYTES('SHA2_512', 'user6'+'P@ssw0rd'))

insert into Employee
values
(11111,'Mohamed',2500,'00:00:00','11:59:59',0),
(22222,'Ahmed',2000,'12:00:00','23:59:59',0)

insert into Customer
values
(33333,'Hassan','Hassan@hotmail.com','0123456789'),
(44444,'Arafat','Arafat@gmail.com','0123344557'),
(55555,'Mostafa','Hassan@eng.cu.edu.com','0112349876'),
(66666,'Seif','Hassan@yahoo.com','0198765431')

insert into Offer
values
('Opening Discount','Discount',10,'2019-12-06','2019-12-29')

insert into FoodNDrinks
values 
('Pepsi','Drink',5,50),
('Tea','Drink',5,100),
('Coffee','Drink',8,100),
('Indomi','Food',10,20),
('Sandwich','Food',20,10)

insert into Room
values 
(1,'Private',1),
(2,'Private',1),
(3,'Private',1)

insert into Game
values
('Fifa',4),
('Pes',4)

insert into Tournament
values
('Tournamnet1','2019-12-06','ongoing',4)

insert into Shift_Logs
values 
(11111,'2019-12-10'),
(11111,'2019-12-11'),
(11111,'2019-12-12'),
(22222,'2019-12-10'),
(22222,'2019-12-11'),
(22222,'2019-12-12')

insert into Reserve
values 
(11111,'2019-12-10',1,'Fifa',33333,'9:00:00','11:00:00'),
(11111,'2019-12-10',2,'Fifa',44444,'10:00:00','11:00:00'),
(11111,'2019-12-10',3,'Pes',55555,'8:00:00','10:00:00'), --employee 11111 in date 12-10

(11111,'2019-12-11',1,'Pes',55555,'7:00:00','10:00:00'),
(11111,'2019-12-11',2,'Fifa',33333,'8:00:00','9:00:00'),
(11111,'2019-12-11',3,'Pes',44444,'8:00:00','10:00:00'), --employee 11111 in date 12-11

(11111,'2019-12-12',3,'Pes',66666,'7:00:00','8:00:00'),
(11111,'2019-12-12',2,'Pes',55555,'7:00:00','9:00:00'),
(11111,'2019-12-12',1,'Pes',33333,'7:00:00','10:00:00'), --employee 11111 in date 12-12

(22222,'2019-12-10',1,'Fifa',66666,'13:00:00','14:00:00'),
(22222,'2019-12-10',2,'Pes',33333,'14:00:00','16:00:00'),
(22222,'2019-12-10',3,'Fifa',55555,'14:00:00','18:00:00'), --employee 22222 in date 12-10

(22222,'2019-12-11',3,'Pes',44444,'18:00:00','20:00:00'),
(22222,'2019-12-11',2,'Pes',55555,'15:00:00','18:00:00'),
(22222,'2019-12-11',1,'Pes',66666,'19:00:00','21:00:00'), --employee 22222 in date 12-11

(22222,'2019-12-12',2,'Pes',33333,'21:00:00','23:00:00'),
(22222,'2019-12-12',1,'Fifa',55555,'13:00:00','16:00:00'),
(22222,'2019-12-12',3,'Fifa',44444,'15:00:00','20:00:00')  --employee 22222 in date 12-12

insert into Screen
values 
(1,'4K','okay'),
(2,'FHD','okay'),
(3,'FHD','okay')

insert into Console 
values 
(1,'Ps4','okay'),
(2,'Ps4','okay'),
(3,'Ps4','okay')

insert into Held
values
('Tournamnet1','2019-12-06','Fifa',1)

insert into Customer_Offer
values 
(44444,'Opening Discount'),
(66666,'Opening Discount')

insert into Order_Shift
values
('Pepsi','Drink',11111,'2019-12-10',1),
('Pepsi','Drink',11111,'2019-12-11',1),
('Tea','Drink',11111,'2019-12-10',2),
('Tea','Drink',11111,'2019-12-12',5),
('Coffee','Drink',22222,'2019-12-10',3),
('Coffee','Drink',22222,'2019-12-11',1),
('Indomi','Food',22222,'2019-12-12',1),
('Indomi','Food',22222,'2019-12-10',1),
('Sandwich','Food',11111,'2019-12-11',4),
('Sandwich','Food',11111,'2019-12-12',2)


insert into Cust_Tourn
values
('Tournamnet1','2019-12-06',33333,'2019-12-07'),
('Tournamnet1','2019-12-06',44444,'2019-12-07'),
('Tournamnet1','2019-12-06',55555,'2019-12-07'),
('Tournamnet1','2019-12-06',66666,'2019-12-07')

alter table Console
ALTER COLUMN condition bool;