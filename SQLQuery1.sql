
DROP TABLE [dbo].[Order];
DROP TABLE [dbo].[Customer];
DROP TABLE [dbo].[Room];

CREATE TABLE [dbo].[Customer] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
	[UserId] nvarchar(max)  NOT NULL,
	[PhoneNumber] int NOT NULL,
	[IsAdmin]  BIT  NOT NULL
	primary key (Id)
);
GO

CREATE TABLE [dbo].[Room] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
	[RoomType] nvarchar(max) NOT NULL,
    [Price] float  NOT NULL,
	[State] BIT NOT NULL
	primary key (Id)
);
GO

CREATE TABLE [dbo].[Order] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CustomerId] int  NOT NULL,
    [RoomId] int  NOT NULL,
	[Check-inDate] date NOT NULL,
    [Check-outDate] date  NOT NULL,
	[TotalPrice] float NOT NULL,
	[Comments] nvarchar(max)
	primary key (Id),
	foreign key (CustomerId) references Customer(Id),
	foreign key (RoomId) references Room(Id)

);
GO

