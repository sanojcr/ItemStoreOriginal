

create database Store
go

use Store
select * from [Item]

CREATE TABLE [Item]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(50) NULL, 
    [Weight] NUMERIC NULL, 
    [Price] NUMERIC NULL, 
    [IsActive] BIT NULL, 
    [ManufacturedDate] DATETIME2 NULL, 
    [Format] INT NULL, 
    [Category] NVARCHAR(50) NULL
)
go








