CREATE DATABASE SimpleSqlHomework;

USE SimpleSqlHomework;

CREATE TABLE Addresses
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StreetName VARCHAR(100),
    StreetNumber INT,
    City VARCHAR(50),
);

CREATE TABLE Customers
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(150),
    Age INT,
    AddressId INT REFERENCES Addresses(Id)
);

CREATE TABLE Orders
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Details VARCHAR(150),
    CustomerId INT REFERENCES Customers(Id)
);

CREATE TABLE Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(150)
);

CREATE TABLE Orders_Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    OrderId INT REFERENCES Orders(Id),
    ProductId INT REFERENCES Products(Id)
);

INSERT INTO Addresses
VALUES ('Independentei', 10, 'Iasi');
INSERT INTO Addresses
VALUES ('Eroilor', 34, 'Brasov');
INSERT INTO Addresses
VALUES ('Unirii', 53, 'Bucuresti');
INSERT INTO Addresses
VALUES ('Independentei', 23, 'Brasov');
INSERT INTO Addresses
VALUES ('Eroilor', 35, 'Brasov');

SELECT *
FROM Addresses;

INSERT INTO Customers
VALUES ('Nico', 20, 1);
INSERT INTO Customers
VALUES ('Alex', 30, 2);
INSERT INTO Customers
VALUES ('Daniel', 40, 3);

SELECT *
FROM Customers;

INSERT INTO Orders
VALUES ('First Order for Nico', 1);
INSERT INTO Orders
VALUES ('Second Order for Nico', 1);
INSERT INTO Orders
VALUES ('First Order for Alex', 2);
INSERT INTO Orders (Details)
VALUES ('First Order for Unknown');

SELECT *
FROM Orders;

INSERT INTO Products
VALUES ('Book about cats');
INSERT INTO Products
VALUES ('Book about c# development');
INSERT INTO Products
VALUES ('Book about databases');
INSERT INTO Products
VALUES ('Book about neuroscience');

SELECT * 
FROM Products;

INSERT INTO Orders_Products
VALUES (1, 1);
INSERT INTO Orders_Products
VALUES (1, 2);
INSERT INTO Orders_Products
VALUES (2, 4);
INSERT INTO Orders_Products
VALUES (3, 1);

SELECT * 
FROM Orders_Products;

--1. Insert at least 5 more records in each table. Pay attention to matching the data from one table to the data in another table.
-- insert samples above

-- 2. Display all the Customers that are older than 15.
SELECT * 
FROM Customers 
WHERE Age > 15;

-- 3. Display the total number of Addresses.
SELECT COUNT(*) AS TotalNumberOfAddresses 
FROM Addresses;

-- 4. Update the name of each Product to some other value.
UPDATE Products
SET Name = 'Self development book '
WHERE Id = 1;

UPDATE Products
SET Name = 'Computer science book'
WHERE Id = 2; -- and so on

SELECT *
FROM Products;

-- 5. Alter the structure of one table by adding a new column.
Alter Table Customers
ADD LastName VARCHAR(50);

-- 6. Populate the value of the newly added column with relevant data.
UPDATE Customers
SET LastName = 'Last Name1'
WHERE Id = 1;

UPDATE Customers
SET LastName = 'Last Name2'
WHERE Id = 2; -- and so on

SELECT *
FROM Customers;

-- 7. Display all the customers' information together with their orders.
SELECT c.Id as CustomerId, c.Name, c.Age, o.Details
FROM Customers c
JOIN Orders o ON c.Id = o.Id;

-- 8. Display all the customers' information together with their orders and their addresses.
SELECT c.Name, c.Age, a.StreetName, o.Details, a.StreetNumber, a.City
FROM Customers c
JOIN Addresses a On c.AddressId = a.Id
JOIN Orders o ON c.Id = o.CustomerId;