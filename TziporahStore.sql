use TziporahStore
go

drop table Customer

create table Customer
(
	userID int identity,
	firstName varchar(20) not null,
	lastName varchar(30) not null,
	creditCard numeric(16,0) not null,
	houseNum int not null,
	street varchar(40) not null,
	city varchar(40) not null,
	usState varchar(20) not null,
	zip nvarchar(9) not null,
	phone numeric(10,0) not null,
	username varchar(20) not null,
	aPassword varchar(20) not null,
	constraint [PK_userID] primary key (userID)
)


insert into Customer
values ('Rachel', 'Wender', 2091483722839403, 23, 'Rose Lane', 'Milwaukee', 'Wisconsin', 39382, 7738268190, 'rwender', 'rachel'),
('Adina', 'Gettinger', 2290184930228176, 73, 'Coles Way', 'Lakewood', 'New Jersey', 08701, 7324491092, 'agettinger', 'adina'),
('Gila', 'Yarmusch', 3394029147739403, 19, 'North Mozart Avenue', 'Chicago', 'Illinois', 33910, 7739291174, 'gyarmusch', 'gila'),
('Nechama Rina', 'Wender', 0092817333648290, 636, 'Third Street', 'Lakewood', 'New Jersey', 08701, 3472819402, 'nrwender', 'nechamarina'),
('Tova', 'Tanenbaum', 3982749500393338, 8454, '118th Street', 'Kew Gardens', 'New York', 11415, 3472612658, 'ttanenbaum', 'tova'),
('Rena', 'Tanenbaum', 3939281755092718, 8454, '118th Street', 'Kew Gardens', 'New York', 11415, 3479988878, 'r&stanenbaum', 'peanutgallery'),
('Shana', 'Tanenbaum', 3392849409981744, 8454, '118th Street', 'Kew Gardens', 'New York', 11415, 3938958324, 'r&stanenbaum', 'peanutgallery')

drop table Account
create table Account
(
	accountID int identity,
	userID int not null,
	balance decimal(8,2) not null,
	constraint [PK_accountID] primary key (accountID),
	constraint [FK_userID] foreign key (userID) references Customer(userID)
)

insert into Account
values (1, 0.0),
(2, 0.0),
(3, 0.0),
(4, 0.0),
(5, 0.0),
(6, 0.0)


drop table Item

create table Item
(
	itemID int identity,
	price decimal(4,2) not null,
	descript varchar(40) not null,
	constraint [PK_itemID] primary key (itemID)
)

insert into Item
values(15.50, 'Sifsei Chaim, Tefillah'),
(89.95, 'Michtav MeEliyahu 6 vol set'),
(29.95, 'Chovos Halevavos Lev Tov, 2 vol'),
(63.0, 'Meorei Oros Hamussar'),
(16.50, 'Nach Malbim Hamaor Chamesh Megilos'),
(10.95, 'Kitzur Hilchos Shabbos'),
(12.00, 'Hirsch Haggada'),
(25.99, 'In Every Generation'),
(16.00, 'Forever My Jerusalem')

drop table Purchase

create table Purchase
(
	purchaseID int identity,
	custID int not null,
	itemNo int not null,
	quantity int not null,
	purchaseDate date not null,
	price decimal(6,2) not null,
	constraint [PK_purchaseID] primary key(purchaseID),
	constraint [FK_custID] foreign key (custID) references Customer(userID),
	constraint [FK_itemNo] foreign key (itemNo) references Item(itemID)
)

