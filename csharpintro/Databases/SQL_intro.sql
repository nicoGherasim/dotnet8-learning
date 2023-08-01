CREATE DATABASE MyTestDatabase;

USE MyTestDatabase;

CREATE TABLE Books
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title VARCHAR(150),
    YearOfPublishing INT,
    NumberOfPages INT,
    HardCover BIT
);

ALTER TABLE Books
ADD ReadyToBeSaled INT;

ALTER TABLE Books
ALTER COLUMN ReadyToBeSaled BIT;

ALTER TABLE Books
DROP COLUMN ReadyToBeSaled;

DROP TABLE Books;

CREATE TABLE Persons 
(
    Id INT NOT NULL UNIQUE,
    LastName VARCHAR(255) NOT NULL,
    FirstName VARCHAR(255) NOT NULL,
    Age INT CHECK (Age>=18),
    City VARCHAR(255) DEFAULT 'Bucuresti',
);

INSERT INTO Books(Title, YearOfPublishing, NumberOfPages, HardCover)
VALUES('Cats', 2022, 200, 1);

INSERT INTO Books
VALUES('Dogs', 2020, 100, 0);

INSERT INTO Persons
VALUES  (1, 'Ana', 'Maria', 34, 'Iasi');

-- error because of duplicated id
INSERT INTO Persons
VALUES(1, 'Ana', 'Maria', 19, 'Brasov');

-- error because of NULL LastName
INSERT INTO Persons
VALUES(2, NULL, 'Maria', 19, 'Brasov');

-- error because of too small age
INSERT INTO Persons
VALUES(2, 'Ana', 'Maria', 15, 'Brasov');

-- works with default 'Bucuresti' as City
INSERT INTO Persons(Id, LastName, FirstName, Age)
VALUES  (2, 'Ana', 'Maria', 34);

SELECT *
FROM Books;

SELECT *
FROM Persons; 

SELECT Id, Title, YearOfPublishing
FROM Books;

SELECT Id, Title, YearOfPublishing
FROM Books
WHERE YearOfPublishing > 2020;

SELECT *
FROM Books
WHERE HardCover = 1;

UPDATE Books
SET YearOfPublishing = 2000;

UPDATE Books
SET HardCover = 0
WHERE Id = 1;

DELETE
FROM Books;

DELETE
FROM Books
WHERE YearOfPublishing > 2020; 

-- The following database structure is the one from the PDF
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

SELECT 30 + 20;

SELECT *
FROM Customers
WHERE Age <> 20;

SELECT * 
FROM Customers
WHERE AddressId = ALL (SELECT Id from Addresses WHERE City = 'Brasov');

SELECT * 
FROM Customers
WHERE AddressId = 1 AND Age > 25;

SELECT * 
FROM Customers
WHERE AddressId = 1 OR Age > 25;

SELECT * 
FROM Customers
WHERE Age BETWEEN 15 AND 25;

SELECT * 
FROM Customers
WHERE Age IN (15, 25, 40);

SELECT * 
FROM Addresses
WHERE City LIKE 'Br%';

SELECT * 
FROM Addresses
WHERE City LIKE '%a%';

SELECT * 
FROM Addresses
WHERE City NOT LIKE '%a%';

-- UNION
SELECT *
FROM Customers;

SELECT *
FROM Orders;

SELECT Id, StreetName FROM Addresses
UNION
SELECT Age, Name FROM Customers;

-- JOINS
SELECT *
FROM Customers;

SELECT *
FROM Orders;

SELECT *
FROM Customers
INNER JOIN Orders ON Customers.Id = Orders.CustomerId;

SELECT *
FROM Customers
LEFT JOIN Orders ON Customers.Id = Orders.CustomerId;

SELECT *
FROM Customers
RIGHT JOIN Orders ON Customers.Id = Orders.CustomerId;

SELECT *
FROM Customers
FULL OUTER JOIN Orders ON Customers.Id = Orders.CustomerId;

-- Display all customers with their corresponding addresses
SELECT *
FROM Customers
JOIN Addresses ON Customers.AddressId = Addresses.Id;

-- Display all customers with their corresponding addresses with only a subset of details
SELECT Customers.Name, Addresses.StreetName, Addresses.StreetNumber
FROM Customers
JOIN Addresses ON Customers.AddressId = Addresses.Id;