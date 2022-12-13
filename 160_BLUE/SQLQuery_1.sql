USE JacksSteakHOUSE; 

-- CREATE DATABASE JacksSteakHOUSE

CREATE TABLE Locations(
    id INT PRIMARY KEY IDENTITY(1,1) not NULL,
    address NVARCHAR(100) NOT NULL,
    phoneNumber CHAR (15) NOT NULL,
    grandOpening DATETIME2 not NULL,
);

--insert ..add stuff..
INSERT INTO Locations(address, phoneNumber, grandOpening) VALUES 
('1122 Somewhere lane','1-123-222-4444', '2022-12-01'),
('17 Steakhouse Blvd','1-123-222-3333', '2020-11-01'), 

--reading data *
SELECT * FROM Locations

--Reading Data Address and Phone#
SELECT Address, phoneNumber, From Locations

--reading grand openings
SELECT grandOpening From Locations

--Reading data by alias 'l'
SELECT l.id, l.phoneNumber from Locations l

-- Make an Employee this nees fk to loctions
Create table Employee(
EmployeeId INT primary key identity (1,1),
FirstName nvarchar(150) not null,
LastName nvarchar(100) not null,
ApplicationSubmissionDate Datetime2,
HireDate Datetime2 not null,
LOCATIONId int FOREIGN KEY REFERENCES Locations(id),
);

--Add Multiple Employee to DB
insert into Employee(FirstName, LastName, ApplicationSubmissionDate, HireDate, LOCATIONId) VALUES
('Beiber', 'Ben', null, '2022-12-01'),
('Google', 'Greg', '11-30-2022', '2022-12-11'),
('Smith', 'John', '11-15-2022', '2022-12-11')

insert into Employee(FirstName, LastName, ApplicationSubmissionDate, HireDate, LOCATIONId) VALUES
('BLAH', 'BLAH', NULL, '2022-12-01')

--Do an Update BE CAREFUL YOU CAN UPDATE EVERYTHING AT ONCE!!!!
Update Employee Set LOCATIONId =1 where Employee.Employeeid =1
Update Employee Set LOCATIONId =1 where Employee.Employeeid >2



--Do an Update BE CAREFUL YOU CAN DELETE EVERYTHING AS ONCE!!
insert into Employee(FirstName, LastName, ApplicationSubmissionDate, HireDate, LOCATIONId) VALUES
DELETE Employee WHERE Employee.EmployeeId = 5

--create more tables
CREATE Table MenuItem(
    id int PRIMARY KEY IDENTITY (1,10) not NULL,
    mealName Nvarchar(150) not Null,
    MealDescription NVARCHAR(150) not null,
    price DECIMAL not null,
);

create table Customer(
CustomerId int primary key IDENTITY(2,2),
FirstName NVARCHAR(250) not null,
LastName NVARCHAR (250) not null,
);

--Joining Table
CREATE table CustomerOrders(
OrderId int PRIMARY Key IDENTITY (1,1),
OrderDate Datetime2 not null,
CustomerId Int foreign key references Customer(CustomerId) not null,
MenuItemId INT FOREIGN key references MenuItem(id) not null,
);

-- add menu items
Insert into MenuItem(mealName, MealDescription, price) VALUES
('Prime Rib', 'Beautiful Steak', 129.99),
('Porterhouse Steak', 'Thick steak with side of mac and cheese', 129.99),
('Pork Chop', 'County chop smothered in gravy with a side of rice', 29.99),
('Fried Chicken', 'chrispy golden fried chicken, side three biscuits', 29.99),
('Kids Meal', 'a burger, small fies. and a toy', 10.99)

--Add Customers
INSERT INTO Customer(FirstName, LastName,)VALUES
('Stevery', 'Wonder'),
('Whitney', 'Houston'),
('Keith','Sweat'),
('Shaka', 'Khan')

--Add CustomerOrders
INSERT into CustomerOrders (CustomerId, MenuItemId, OrderDate)VALUES
(1,3, '22-11-28'),
(1,2, '22-10-02'),
(3,3, '22-11-28'),
(1,3, '22-9-10'),
(3,3, '22-07-27'),
(4,3, '22-06-22')

--DELETE MenuItem Where id >41
SELECT
co.OrderDate [Order Date],
c.FirstName + '' + c.LastName [Customer],
m.mealName [Meal]
m.price [Meal Price]
FROM CustomerOrders co 
LEFT join MenuItem m on co.MenuItemId =m.id
LEFT JOIN Customer c on co.CustomerId = co.CustomerId
Order by c.LastName