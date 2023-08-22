create database AdvancedDB
use AdvancedDB

-- Create the Employees table
create table Employees
(Employeeld int primary key ,
FirstName nvarchar(50),
LastName nvarchar(50),
BirthDate date ,
Salary float
)

-- Create the Products table
CREATE TABLE Products (
    Productld int PRIMARY KEY,
    ProductName nvarchar(50),
    Description nvarchar(100),
    Price money,
    ReleaseDate datetime
)

-- Create the Orders table
CREATE TABLE Orders (
    Orderld int PRIMARY KEY,
    OrderDate datetime,
    Quantity smallint,
    Discount float,
    IsShipped bit
)

-- Insert data into the Employees table
INSERT INTO Employees (Employeeld, FirstName, LastName, BirthDate, Salary)
VALUES (1, 'Sam', 'Dicosta', '2001-03-15', 60000.00),
       (2, 'Jane', 'Smith', '1998-07-22', 75000.00)
       
-- Insert data into the Products table
INSERT INTO Products (Productld, ProductName, Description, Price, ReleaseDate)
VALUES (101, 'Laptop', 'HP Notebook 15', 29900.99, '2023-01-10'),
       (102, 'Books', 'The Ramayan', 190.99, '2023-03-05')
       
-- Insert data into the Orders table
INSERT INTO Orders (Orderld, OrderDate, Quantity, Discount, IsShipped)
VALUES (1001, '2023-02-15', 3, 0.1, 1),
       (1002, '2023-04-20', 5, 0.05, 0)

	   select * from Employees
	   select * from Products
	   select * from Orders