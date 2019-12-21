
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
(66666,3,HASHBYTES('SHA2_512', 'user6'+'P@ssw0rd')),
(66667,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(66668,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(66669,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(77771,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(77772,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(77773,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(77774,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(77775,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(77776,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(77777,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(77778,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(77779,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(88888,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(99999,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(99991,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(99992,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd')),
(99993,3,HASHBYTES('SHA2_512', 'user10'+'P@ssw0rd'))

insert into Employee
values
(11111,'Mohamed',2500,'00:00:00','11:59:59',0),
(22222,'Ahmed',2000,'12:00:00','23:59:59',0)

insert into Customer
values
(33333,'Hassan','Hassan@hotmail.com','0123456789'),
(44444,'Arafat','Arafat@gmail.com','0123344557'),
(55555,'Mostafa','Hassan@eng.cu.edu.com','0112349876'),
(66666,'Seif','Seif@yahoo.com','0188765431'),
(66667,'Seif','Seif1@yahoo.com','0178765431'),
(66668,'Mohamed','Mohamed@yahoo.com','0168765431'),
(66669,'Hussien','Hussien@yahoo.com','0158765431'),
(77771,'Mahmoud','Mahmoud@yahoo.com','0148765431'),
(77772,'Hana','Hana@yahoo.com','0138765431'),
(77773,'Menna','menna@yahoo.com','0128765431'),
(77774,'Dai','dai@yahoo.com','0118765431'),
(77775,'Ali','ali@yahoo.com','0193765431'),
(77776,'Adel','adel@yahoo.com','0194765431'),
(77777,'Salama','Salaama@yahoo.com','0195765431'),
(77778,'Abdo','avdooo@yahoo.com','0196765431'),
(77779,'Mostafa','sasassaa@yahoo.com','0197765431'),
(88888,'Hassan','sonson@yahoo.com','0191765431'),
(99999,'Arafat','aarfat@yahoo.com','0190765431'),
(99991,'Ahmed','hamada@yahoo.com','0190065431'),
(99992,'Seif','Sosoeldele3@yahoo.com','0198565431'),
(99993,'Ahmed','momae@yahoo.com','01980095431')

insert into Offer
values
('Opening Discount'  ,'Discount',10,'2019-12-06','2019-12-29'),           
('Opening Discount2' ,'Discount',10,'2019-12-06','2019-12-29'),
('Opening Discount3' ,'Discount',20,'2019-12-06','2019-12-29'),
('Opening Discount4' ,'Discount',20,'2019-12-06','2019-12-29'),
('Opening Discount5' ,'Discount',20,'2019-12-06','2019-12-29'),
('Opening Discount6' ,'Discount',20,'2019-12-06','2019-12-29'),
('Opening Discount7' ,'Discount',34,'2019-12-06','2019-12-29'),
('Opening Discount8' ,'Discount',34,'2019-12-06','2019-12-29'),
('Opening Discount9' ,'Discount',34,'2019-12-06','2019-12-29'),
('Playing Discount'  ,'Discount',34,'2019-12-09','2019-12-25'),
('Playing Discount2' ,'Discount',34,'2019-12-09','2019-12-25'),
('Playing Discount3' ,'Discount',70,'2019-12-09','2019-12-25'),
('Playing Discount4' ,'Discount',70,'2019-12-09','2019-12-25'),
('Playing Discount5' ,'Discount',70,'2019-12-09','2019-12-25'),
('Playing Discount6' ,'Discount',70,'2019-12-09','2019-12-25'),
('Playing Discount7' ,'Discount',70,'2019-12-09','2019-12-25'),
('Playing Discount8' ,'Discount',70,'2019-12-09','2019-12-25'),
('Playing Discount9' ,'Discount',15,'2019-12-09','2019-12-25'),
('Playing Discount10','Discount',20,'2019-12-09','2019-12-25'),
('Playing Discount11','Discount',100,'2019-12-06','2019-12-29')

insert into FoodNDrinks
values 
('Pepsi','Drink',5,50),
('Tea','Drink',5,100),
('Coffee','Drink',8,100),
('Indomi','Food',10,20),
('Pizza','Food',25,5),
('Sandwich','Food',20,10),
('Sandwich1','Food',20,10),
('Sandwich2','Food',20,10),
('Sandwich3','Food',20,10),
('Sandwich4','Food',20,10),
('Sandwich5','Food',20,10),
('Sandwich6','Food',20,10),
('Sandwich7','Food',20,10),
('Sandwich8','Food',20,10),
('Sandwich9','Food',20,10),
('Sevenup','Drink',20,10),
('Cocacola','Drink',20,10),
('MountainDew','Drink',20,10),
('Fanta','Drink',20,10),
('Fayrouz','Drink',20,10)

insert into Room
values 
(1,'Private',1),
(2,'Private',1),
(3,'Private',1),
(4,'Private',1),
(5,'Private',1),
(6,'Private',1),
(7,'Private',1),
(8,'Private',1),
(9,'Private',1),
(10,'Private',1),
(11,'Private',1),
(12,'Private',1),
(13,'Private',1),
(14,'Private',1),
(15,'Private',1),
(16,'Private',1),
(17,'Private',1),
(18,'Private',1),
(19,'Private',1),
(20,'Private',1),
(21,'Private',1)

insert into Game
values
('Fifa',4),
('Fifa10',4),
('Fifa11',4),
('Fifa12',4),
('Fifa13',4),
('Fifa14',4),
('Fifa15',4),
('Fifa16',4),
('Fifa17',4),
('Fifa18',4),
('Fifa19',4),
('Fifa20',4),
('Pes',8),
('Pes17',4),
('Pes18',4),
('Pes19',4),
('Pes20',4),
('Mortal Kombat',4),
('Fortnight',4),
('COD',4),
('COD 2',4)


insert into Tournament
values
('Tournamnet1','2019-12-06','ongoing',4),
('Tournamnet2','2019-12-06','ongoing',4),
('Tournamnet3','2019-12-06','ongoing',4),
('Tournamnet4','2019-12-07','ongoing',4),
('Tournamnet5','2019-12-07','ongoing',16),
('Tournamnet6','2019-12-07','ongoing',16),
('Tournamnet7','2019-12-07','ongoing',16),
('Tournamnet8','2019-12-07','ongoing',16),
('Tournamnet9','2019-12-08','ongoing',16),
('Tournamnet10','2019-12-09','ongoing',32)

insert into Shift_Logs
values 
(11111,'2019-12-10'),
(11111,'2019-12-11'),
(11111,'2019-12-12'),
(11111,'2019-12-13'),
(11111,'2019-12-14'),
(11111,'2019-12-15'),
(11111,'2019-12-16'),
(11111,'2019-12-17'),
(11111,'2019-12-18'),
(11111,'2019-12-19'),
(11111,'2019-12-20'),
(11111,'2019-12-21'),
(22222,'2019-12-10'),
(22222,'2019-12-11'),
(22222,'2019-12-12'),
(22222,'2019-12-13'),
(22222,'2019-12-14'),
(22222,'2019-12-15'),
(22222,'2019-12-16'),
(22222,'2019-12-17'),
(22222,'2019-12-18'),
(22222,'2019-12-19'),
(22222,'2019-12-20'),
(22222,'2019-12-21')

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

(11111,'2019-12-13',3,'Pes',66666,'7:00:00','8:00:00'),
(11111,'2019-12-13',2,'Pes',55555,'7:00:00','9:00:00'),
(11111,'2019-12-13',1,'Pes',33333,'7:00:00','10:00:00'), --employee 11111 in date 12-13

(22222,'2019-12-10',1,'Fifa',66666,'13:00:00','14:00:00'),
(22222,'2019-12-10',2,'Pes',33333,'14:00:00','16:00:00'),
(22222,'2019-12-10',3,'Fifa',55555,'14:00:00','18:00:00'), --employee 22222 in date 12-10

(22222,'2019-12-11',3,'Pes',44444,'18:00:00','20:00:00'),
(22222,'2019-12-11',2,'Pes',55555,'15:00:00','18:00:00'),
(22222,'2019-12-11',1,'Pes',66666,'19:00:00','21:00:00'), --employee 22222 in date 12-11

(22222,'2019-12-12',2,'Pes',33333,'21:00:00','23:00:00'),
(22222,'2019-12-12',1,'Fifa',55555,'13:00:00','16:00:00'),
(22222,'2019-12-12',3,'Fifa',44444,'15:00:00','20:00:00'),  --employee 22222 in date 12-12

(22222,'2019-12-13',2,'Pes',33333,'21:00:00','23:00:00'),
(22222,'2019-12-13',1,'Fifa',55555,'13:00:00','16:00:00'),
(22222,'2019-12-13',3,'Fifa',44444,'15:00:00','20:00:00')  --employee 22222 in date 12-13

insert into Screen
values 
(1,'4K','okay'),
(2,'FHD','okay'),
(3,'FHD','okay'),
(4,'FHD','okay'),
(5,'FHD','okay'),
(6,'FHD','okay'),
(7,'FHD','okay'),
(8,'FHD','okay'),
(9,'FHD','okay'),
(10,'FHD','okay'),
(11,'FHD','okay'),
(12,'FHD','okay'),
(13,'FHD','okay'),
(14,'FHD','okay'),
(15,'FHD','okay'),
(16,'FHD','okay'),
(17,'FHD','okay'),
(18,'FHD','okay'),
(19,'FHD','okay'),
(20,'FHD','okay'),
(21,'FHD','okay')

insert into Console 
values 
(1,'Ps4','okay'),
(2,'Ps4','okay'),
(3,'Ps4','okay'),
(4,'Ps4','okay'),
(5,'Ps4','okay'),
(6,'Ps4','okay'),
(7,'Ps4','okay'),
(8,'Ps4','okay'),
(9,'Ps4','okay'),
(10,'Ps4','okay'),
(11,'Xbox','okay'),
(12,'Xbox','okay'),
(13,'Xbox','okay'),
(14,'Xbox','okay'),
(15,'Xbox','okay'),
(16,'Xbox','okay'),
(17,'Xbox','okay'),
(18,'Xbox','okay'),
(19,'Xbox','okay'),
(20,'Xbox','okay'),
(21,'Xbox','okay')

insert into Held
values
('Tournamnet1','2019-12-06','Fifa',1),
('Tournamnet2','2019-12-06','Fifa',2),
('Tournamnet3','2019-12-06','Fifa',3),
('Tournamnet4','2019-12-07','Fifa',4),
('Tournamnet5','2019-12-07','Pes',5),
('Tournamnet6','2019-12-07','Pes',6),
('Tournamnet7','2019-12-07','Pes',7),
('Tournamnet8','2019-12-07','Pes',8),
('Tournamnet9','2019-12-08','Pes',9),
('Tournamnet10','2019-12-09','Fifa',12)

insert into Customer_Offer
values 
(44444,'Opening Discount'),
(66666,'Opening Discount2'),
(66666,'Opening Discount3'),
(66666,'Opening Discount4'),
(55555,'Opening Discount2'),
(55555,'Opening Discount3'),
(55555,'Opening Discount4'),
(55555,'Opening Discount5'),
(99999,'Opening Discount2'),
(99999,'Opening Discount3'),
(99999,'Opening Discount4'),
(99999,'Opening Discount5'),
(99999,'Opening Discount6'),
(44444,'Opening Discount6'),
(44444,'Opening Discount7'),
(44444,'Opening Discount8'),
(44444,'Opening Discount9'),
(44444,'Opening Discount2'),
(99991,'Opening Discount5'),
(99991,'Opening Discount2'),
(99991,'Opening Discount3'),
(99991,'Opening Discount7'),
(66666,'Opening Discount9')

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
('Pizza','Food',11111,'2019-12-11',4),
('Pizza','Food',11111,'2019-12-12',2),
('Pizza','Food',11111,'2019-12-13',4),
('Pizza','Food',11111,'2019-12-14',2),
('Sevenup','Drink',22222,'2019-12-11',4),
('Sevenup','Drink',22222,'2019-12-12',2),
('Sevenup','Drink',22222,'2019-12-13',4),
('Sevenup','Drink',22222,'2019-12-15',2),
('Sevenup','Drink',11111,'2019-12-11',4),
('Fayrouz','Drink',11111,'2019-12-12',2),
('Fayrouz','Drink',22222,'2019-12-14',4),
('Fayrouz','Drink',22222,'2019-12-16',2),
('Fayrouz','Drink',22222,'2019-12-18',4),
('Sandwich2','Food',11111,'2019-12-19',2),
('Sandwich2','Food',11111,'2019-12-20',4),
('Sandwich2','Food',11111,'2019-12-21',2)


insert into Cust_Tourn
values
('Tournamnet1','2019-12-06',33333,'2019-12-07'),
('Tournamnet1','2019-12-06',44444,'2019-12-07'),
('Tournamnet1','2019-12-06',55555,'2019-12-07'),
('Tournamnet1','2019-12-06',66666,'2019-12-07'),
('Tournamnet1','2019-12-06',77777,'2019-12-07'),
('Tournamnet1','2019-12-06',88888,'2019-12-07'),
('Tournamnet2','2019-12-06',33333,'2019-12-07'),
('Tournamnet2','2019-12-06',44444,'2019-12-07'),
('Tournamnet2','2019-12-06',55555,'2019-12-07'),
('Tournamnet2','2019-12-06',66666,'2019-12-07'),
('Tournamnet2','2019-12-06',77777,'2019-12-07'),
('Tournamnet2','2019-12-06',88888,'2019-12-07'),
('Tournamnet2','2019-12-06',99999,'2019-12-07'),
('Tournamnet2','2019-12-06',99991,'2019-12-07'),
('Tournamnet2','2019-12-06',99992,'2019-12-07'),
('Tournamnet3','2019-12-06',33333,'2019-12-07'),
('Tournamnet3','2019-12-06',44444,'2019-12-07'),
('Tournamnet3','2019-12-06',55555,'2019-12-07'),
('Tournamnet3','2019-12-06',66666,'2019-12-07'),
('Tournamnet3','2019-12-06',77777,'2019-12-07'),
('Tournamnet3','2019-12-06',88888,'2019-12-07'),
('Tournamnet3','2019-12-06',99999,'2019-12-07')


insert into Feedback
values
('2019-12-06',33333,'Test','feedback'),
('2019-12-07',33333,'Test','feedback'),
('2019-12-08',33333,'Test','feedback'),
('2019-12-09',33333,'Test','feedback'),
('2019-12-06',44444,'Test','request'),
('2019-12-07',44444,'Test','request'),
('2019-12-08',44444,'Test','request'),
('2019-12-09',44444,'Test','request'),
('2019-12-06',55555,'Test','request'),
('2019-12-08',55555,'Test','request'),
('2019-12-09',55555,'Test','feedback'),
('2019-12-09',99999,'Test','feedback'),
('2019-12-08',99999,'Test','feedback'),
('2019-12-07',99999,'Test','feedback'),
('2019-12-09',66666,'Test','request'),
('2019-12-06',66666,'Test','request'),
('2019-12-05',66666,'Test','request'),
('2019-12-01',77777,'Test','request'),
('2019-12-03',77777,'Test','request'),
('2019-12-04',77777,'Test','feedback'),
('2019-12-02',88888,'Test','feedback'),
('2019-12-09',88888,'Test','feedback')