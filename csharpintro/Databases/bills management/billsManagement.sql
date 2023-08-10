/* 1. Create a database structure that would allow bills management for gas and electricity.
   2. Populate the database with at least 5 entries to the tables created previously (where applicable).
      Make sure a that at least two customers have more than one address.
      Make sure that at least 3 customers have multiple contracts.
      Make sure that there is one customer with no contract. */

--DROP DATABASE BillsManagement;

CREATE DATABASE BillsManagement;

USE BillsManagement;

CREATE TABLE Customers
(
Id INT IDENTITY(1,1) PRIMARY KEY,
FirstName VARCHAR(50),
LastName VARCHAR(50),
Email VARCHAR(50)
);

CREATE TABLE Addresses
(
Id INT IDENTITY(1,1) PRIMARY KEY,
StreetName VARCHAR(150),
StreetNumber INT,
City VARCHAR(150),
CustomerId INT REFERENCES Customers(Id)
);

CREATE TABLE Contracts
(
Id INT IDENTITY(1,1) PRIMARY KEY,
ContractType VARCHAR(50),
StartDate DATE,  
EndDate DATE
);

CREATE TABLE Customers_Contracts
(
Id INT IDENTITY(1,1) PRIMARY KEY,
CustomerId INT REFERENCES Customers(Id),
ContractId INT REFERENCES Contracts(Id)
);

CREATE TABLE Bills
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Amount MONEY,  
Deadline DATE,
IsPaid BIT,
ContractId INT REFERENCES Contracts(Id),
);

INSERT INTO Customers
VALUES ('ana', 'mitrea', 'am@gmail.com');
INSERT INTO Customers
VALUES ('andrei', 'stan', 'as@gmail.com');
INSERT INTO Customers
VALUES ('diana', 'ciocan', 'ac@gmail.com');
INSERT INTO Customers
VALUES ('teodor', 'nistor', 'tn@gmail.com');
INSERT INTO Customers
VALUES ('stefania', 'iancu', 'si@gmail.com');

SELECT *
FROM Customers;

INSERT INTO Addresses
VALUES('s1', 10, 'Iasi', 1);
INSERT INTO Addresses
VALUES('s2', 56, 'Iasi', 1);
INSERT INTO Addresses
VALUES('s3', 43, 'Brasov', 2);
INSERT INTO Addresses
VALUES('s4', 180, 'Cluj', 2);
INSERT INTO Addresses
VALUES('s5', 98, 'Iasi', 3);
INSERT INTO Addresses
VALUES('s6', 432, 'Iasi', 4);
INSERT INTO Addresses
VALUES('s7', 21, 'Iasi', 5);

SELECT *
FROM Addresses;

-- Create ContractTypes tables to enforce all the contracts to use only two options for contract type (gas and electricity)
CREATE TABLE ContractTypes
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(20) 
);

ALTER TABLE Contracts
DROP COLUMN ContractType;

ALTER TABLE Contracts
ADD ContractType INT REFERENCES ContractTypes(Id);

INSERT INTO ContractTypes
VALUES ('gas');
INSERT INTO ContractTypes
VALUES ('electricity');

SELECT * 
FROM ContractTypes;

INSERT INTO Contracts
VALUES('2022-01-01', '2025-01-01', 1);
INSERT INTO Contracts
VALUES('2022-01-01', '2025-01-01', 2);
INSERT INTO Contracts
VALUES('2022-01-01', '2025-01-01', 1);
INSERT INTO Contracts
VALUES('2022-01-01', '2025-01-01', 2);
INSERT INTO Contracts
VALUES('2022-01-01', '2025-01-01', 1);
INSERT INTO Contracts
VALUES('2022-01-01', '2025-01-01', 2);
INSERT INTO Contracts
VALUES('2012-01-01', '2031-01-01', 1);
INSERT INTO Contracts
VALUES('2019-01-01', '2017-01-01', 2);

SELECT *
FROM Contracts;

SELECT *
FROM Customers;

SELECT *
FROM Contracts;

INSERT INTO Customers_Contracts
VALUES(1, 1);
INSERT INTO Customers_Contracts
VALUES(1, 2);
INSERT INTO Customers_Contracts
VALUES(2, 3);
INSERT INTO Customers_Contracts
VALUES(3, 4);
INSERT INTO Customers_Contracts
VALUES(3, 5);
INSERT INTO Customers_Contracts
VALUES(4, 6);
INSERT INTO Customers_Contracts
VALUES(4, 7);
INSERT INTO Customers_Contracts
VALUES(4, 8);

SELECT *
FROM Customers_Contracts;

INSERT INTO Bills
VALUES(234,'2022-12-25',  1, 1);
INSERT INTO Bills
VALUES(567,'2021-12-25',  1, 2);
INSERT INTO Bills
VALUES(12,'2020-12-25',  0, 2);
INSERT INTO Bills
VALUES(654,'2023-12-25',  0, 3);
INSERT INTO Bills
VALUES(98,'2019-11-25',  0, 4);
INSERT INTO Bills
VALUES(23,'2024-10-25',  0, 5);
INSERT INTO Bills
VALUES(243,'2023-10-25',  0, 6);
INSERT INTO Bills
VALUES(223,'2022-09-25',  1, 7);
INSERT INTO Bills
VALUES(2356,'2023-02-25',  1, 8);
INSERT INTO Bills
VALUES(2783,'2028-01-25',  0, 8);

SELECT *
FROM Bills;

-- 3. Display all the customers' information ordered by the last name descending.
SELECT *
FROM Customers
ORDER BY LastName DESC;

-- 4. Display information about the bill with the highest amount.
SELECT * 
FROM Bills
WHERE Amount = (SELECT MAX(Amount) FROM Bills);

-- 5. Display the customers' information (just customer id, email address, street name, street number and city) togheter with their corresponding addresses.
SELECT c.Id, c.Email, a.StreetName, a.StreetNumber, a.City
FROM Customers c
INNER JOIN Addresses a ON c.Id = a.CustomerId;

-- 6. Pretend that one bill was paid today. Update it's corresponding information to reflect that.
UPDATE Bills 
SET IsPaid = 1
WHERE Id = 9;

SELECT *
FROM Bills;

-- 7. Display the contract's information (contract id, start date, end date, bill id, amount, deadline, isPaid) togheter with their corresponding bills.
SELECT c.Id, c.StartDate, c.EndDate, b.Id, b.Amount, b.Deadline, b.IsPaid
FROM Contracts c
INNER JOIN Bills b ON c.Id = b.ContractId; 

-- 8. Display the contract's information (contract id, start date, end date, contract type, bill id, amount, deadline, isPaid) togheter with their corresponding bills.
SELECT c.Id, c.StartDate, c.EndDate, ct.Name, b.Id, b.Amount, b.Deadline, b.IsPaid
FROM Contracts c
INNER JOIN Bills b ON c.Id = b.ContractId
JOIN ContractTypes ct on c.ContractType = ct.Id;

-- 9. Display the customers' information (just customer id, email address, contract end date & contract type) togheter with their corresponding contract type(s).
SELECT cu.Id, cu.Email, c.EndDate, ct.Name
FROM Customers cu 
JOIN Customers_Contracts cc ON cu.ID = cc.CustomerId
JOIN Contracts c ON cc.ContractId = c.Id 
JOIN ContractTypes ct ON c.ContractType = ct.Id;

-- 10. On exercise above make sure to display even the customers who don't have yet a contract.
SELECT cu.Id, cu.Email, c.EndDate, ct.Name
FROM Customers cu 
LEFT JOIN Customers_Contracts cc ON cu.ID = cc.CustomerId
LEFT JOIN Contracts c ON cc.ContractId = c.Id 
LEFT JOIN ContractTypes ct ON c.ContractType = ct.Id;

-- 11. Display the number of addresses a user has based on his / her email.
-- Tip: use the customer's email when counting and grouping the records.
SELECT count(c.Email) as NumberOfAddreses
FROM Customers c 
JOIN Addresses a on c.Id = a.CustomerId
GROUP By c.Email
HAVING c.Email = 'am@gmail.com';

-- 12. Create a function that for a specific customer email returns the number of addresses that he / she has registered.
-- The final column name should have the alias 'NumberOfAddreses'.
GO
CREATE FUNCTION dbo.GetNumberOfAddressesByCustomerEmail(
    @customerEmail Varchar(50))
RETURNS INT
AS
BEGIN
    DECLARE @numberOfAddreses INT;
    SET @numberOfAddreses =
        ( SELECT COUNT(uc.Email) AS NumberOfAddreses
        FROM Addresses ua 
        JOIN Customers uc ON ua.CustomerId = uc.Id 
        GROUP BY uc.Email
        HAVING uc.Email = @customerEmail);
    RETURN @numberOfAddreses;
END;
GO

-- call the function
select dbo.GetNumberOfAddressesByCustomerEmail('am@gmail.com') AS NumberOfAddreses;
select dbo.GetNumberOfAddressesByCustomerEmail('as@gmail.com') AS NumberOfAddreses;
-- call the function with an email address that does not exist
select dbo.GetNumberOfAddressesByCustomerEmail('noemail@gmail.com') AS NumberOfAddreses;

-- 13. Create a view that contains all the information about the customers (id, email) who have unpaid bills, including the bill amount to be paid and the deadlind.
-- a) Query the view to get all data.
-- b) Query the view to get all bills that have a deadline in the future. Tip: GETDATE() function might be useful.
GO
CREATE VIEW GetDataForUnpaidBills
AS
SELECT uc.Id, uc.Email, b.Amount, b.Deadline, b.IsPaid
FROM Customers uc 
JOIN Customers_Contracts ucc ON uc.ID = ucc.CustomerId
JOIN Contracts c ON ucc.ContractId = c.Id 
JOIN Bills b ON b.ContractId = c.Id
WHERE b.IsPaid = 0;
GO

-- a)
SELECT *
FROM GetDataForUnpaidBills;

-- b)
SELECT *
FROM GetDataForUnpaidBills
WHERE Deadline > GETDATE();