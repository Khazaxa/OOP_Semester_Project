USE [master]
GO

IF DB_ID(N'CarRent') IS NOT NULL
BEGIN
    ALTER DATABASE [CarRent] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [CarRent];
END
GO

CREATE DATABASE [CarRent]
GO

USE [CarRent]
GO

CREATE TABLE [dbo].[Brands]
(
    [ID] INT NOT NULL PRIMARY KEY,
    [Name] VARCHAR(50) NOT NULL
)

INSERT INTO [dbo].[Brands] ([ID], [Name])
VALUES
    (1, 'Brand1'),
    (2, 'Brand2'),
    (3, 'Brand3'),
    (4, 'Brand4'),
    (5, 'Brand5'),
    (6, 'Brand6'),
    (7, 'Brand7'),
    (8, 'Brand8'),
    (9, 'Brand9'),
    (10, 'Brand10')

CREATE TABLE [dbo].[Cars]
(
    [ID] INT NOT NULL PRIMARY KEY,
    [BrandID] INT NOT NULL,
    [Model] VARCHAR(50) NOT NULL,
    [Year] INT NOT NULL,
    [RegistrationNumber] VARCHAR(20) NOT NULL,
    [IsSelected] BIT NOT NULL,
    FOREIGN KEY ([BrandID]) REFERENCES [dbo].[Brands]([ID])
)

INSERT INTO [dbo].[Cars] ([ID], [BrandID], [Model], [Year], [RegistrationNumber], [IsSelected])
VALUES
    (1, 1, 'Model1', 2021, 'ABC123', 0),
    (2, 1, 'Model2', 2022, 'DEF456', 0),
    (3, 2, 'Model3', 2020, 'GHI789', 0),
    (4, 2, 'Model4', 2021, 'JKL012', 0),
    (5, 3, 'Model5', 2022, 'MNO345', 0),
    (6, 3, 'Model6', 2019, 'PQR678', 0),
    (7, 4, 'Model7', 2020, 'STU901', 0),
    (8, 4, 'Model8', 2021, 'VWX234', 0),
    (9, 5, 'Model9', 2022, 'YZA567', 0),
    (10, 5, 'Model10', 2023, 'BCD890', 0)

CREATE TABLE [dbo].[Customers]
(
    [ID] INT NOT NULL PRIMARY KEY,
    [FirstName] VARCHAR(50) NOT NULL,
    [LastName] VARCHAR(50) NOT NULL,
    [Phone] VARCHAR(20) NOT NULL,
    [Email] VARCHAR(100) NOT NULL
)

INSERT INTO [dbo].[Customers] ([ID], [FirstName], [LastName], [Phone], [Email])
VALUES
    (1, 'John', 'Doe', '123456789', 'john.doe@example.com'),
    (2, 'Jane', 'Smith', '987654321', 'jane.smith@example.com'),
    (3, 'Michael', 'Johnson', '456789123', 'michael.johnson@example.com'),
    (4, 'Emily', 'Davis', '321654987', 'emily.davis@example.com'),
    (5, 'David', 'Anderson', '789123456', 'david.anderson@example.com'),
    (6, 'Sarah', 'Wilson', '654987321', 'sarah.wilson@example.com'),
    (7, 'Robert', 'Brown', '852963741', 'robert.brown@example.com'),
    (8, 'Jennifer', 'Taylor', '369258147', 'jennifer.taylor@example.com'),
    (9, 'Daniel', 'Miller', '147852369', 'daniel.miller@example.com'),
    (10, 'Lisa', 'Moore', '258741369', 'lisa.moore@example.com')

CREATE TABLE [dbo].[Rentals]
(
    [ID] INT NOT NULL PRIMARY KEY,
    [CarID] INT NULL,
    [CustomerID] INT NOT NULL,
    [RentalDate] DATE NULL,
    [ReturnDate] DATE NULL,
    FOREIGN KEY ([CarID]) REFERENCES [dbo].[Cars]([ID]),
    FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customers]([ID])
)

INSERT INTO [dbo].[Rentals] ([ID], [CarID], [CustomerID], [RentalDate], [ReturnDate])
VALUES
    (1, 1, 1, '2023-06-01', '2023-06-05'),
    (2, 2, 2, '2023-06-02', '2023-06-07'),
    (3, 3, 3, '2023-06-03', '2023-06-06'),
    (4, 4, 4, '2023-06-04', '2023-06-08'),
    (5, 5, 5, '2023-06-05', '2023-06-10'),
    (6, 6, 6, '2023-06-06', '2023-06-09'),
    (7, 7, 7, '2023-06-07', '2023-06-11'),
    (8, 8, 8, '2023-06-08', '2023-06-13'),
    (9, 9, 9, '2023-06-09', '2023-06-12'),
    (10, 10, 10, '2023-06-10', '2023-06-14')
