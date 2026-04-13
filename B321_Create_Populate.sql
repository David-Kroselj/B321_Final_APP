/*
--------------------------------------------------------------------------------
   Developers: David Kroselj, Zach Sellers
   Course: B321
   Project: Final
   Semester: Spring
   Professor: Dr. Erdei 
--------------------------------------------------------------------------------
*/

-- ======================================================================
------------------------------ Drop Tables ------------------------------
-- ======================================================================

DROP TABLE IF EXISTS [dbo].[Performance_Bridge];
DROP TABLE IF EXISTS [dbo].[Comfort_Bridge];
DROP TABLE IF EXISTS [dbo].[OrderLineItems];
DROP TABLE IF EXISTS [dbo].[Orders];
DROP TABLE IF EXISTS [dbo].[Performance];
DROP TABLE IF EXISTS [dbo].[Comfort];
DROP TABLE IF EXISTS [dbo].[Body_Colors];
DROP TABLE IF EXISTS [dbo].[Trims];
DROP TABLE IF EXISTS [dbo].[Styles];
DROP TABLE IF EXISTS [dbo].[Models];
DROP TABLE IF EXISTS [dbo].[Customers];
GO

-- =========================================================================
------------------------------ Catalog Tables ------------------------------
-- =========================================================================

CREATE TABLE Customers (
    Customer_ID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50)  NOT NULL UNIQUE,
    [Password] VARCHAR(255) NOT NULL,
    Email VARCHAR(256) NOT NULL UNIQUE
);

CREATE TABLE Models (
    Model_ID INT IDENTITY(1,1) PRIMARY KEY,
    Model_Name VARCHAR(50) NOT NULL
);

CREATE TABLE Styles (
    Style_ID INT IDENTITY(1,1) PRIMARY KEY,
    Style_Name VARCHAR(50) NOT NULL
);

CREATE TABLE Trims (
    Trim_ID INT IDENTITY(1,1) PRIMARY KEY,
    Trim_Name VARCHAR(50) NOT NULL
);

CREATE TABLE Body_Colors (
    Body_Color_ID INT IDENTITY(1,1) PRIMARY KEY,
    Body_Color_Name VARCHAR(50) NOT NULL
);

CREATE TABLE Performance (
    Performance_Option_ID INT IDENTITY(1,1) PRIMARY KEY,
    Performance_Name VARCHAR(50) NOT NULL
);

CREATE TABLE Comfort (
    Comfort_Option_ID INT IDENTITY(1,1) PRIMARY KEY,
    Comfort_Name VARCHAR(50) NOT NULL
);
GO

-- =============================================================================
------------------------------ Transaction Tables ------------------------------
-- =============================================================================

CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    Customer_ID INT NOT NULL REFERENCES Customers(Customer_ID),
    Order_Date DATE NOT NULL DEFAULT GETDATE(),
    OrderStatus VARCHAR(50) NOT NULL
);

CREATE TABLE OrderLineItems (
    Order_Item_ID INT IDENTITY(1,1) PRIMARY KEY,
    Order_ID INT NOT NULL REFERENCES Orders(OrderID),
    Model_ID INT NOT NULL REFERENCES Models(Model_ID),
    Trim_ID INT NOT NULL REFERENCES Trims(Trim_ID),
    Body_Color_ID INT NOT NULL REFERENCES Body_Colors(Body_Color_ID),
    Style_ID INT NOT NULL REFERENCES Styles(Style_ID)
);

CREATE TABLE Performance_Bridge (
    Order_Item_ID INT NOT NULL REFERENCES OrderLineItems(Order_Item_ID),
    Performance_Option_ID INT NOT NULL REFERENCES Performance(Performance_Option_ID),
    CONSTRAINT PK_Performance_Bridge PRIMARY KEY (Order_Item_ID, Performance_Option_ID)
);

CREATE TABLE Comfort_Bridge (
    Order_Item_ID INT NOT NULL REFERENCES OrderLineItems(Order_Item_ID),
    Comfort_Option_ID INT NOT NULL REFERENCES Comfort(Comfort_Option_ID),
    CONSTRAINT PK_Comfort_Bridge PRIMARY KEY (Order_Item_ID, Comfort_Option_ID)
);
GO

-- ======================================================================
------------------------------ INSERT DATA ------------------------------
-- ======================================================================

SET IDENTITY_INSERT [Models] ON;
INSERT INTO [Models] ([Model_ID], [Model_Name]) VALUES
    (1, 'Breakout'),
    (2, 'Fatboy'),
    (3, 'Fatboy Gray Ghost');
SET IDENTITY_INSERT [Models] OFF;

SET IDENTITY_INSERT [Trims] ON;
INSERT INTO [Trims] ([Trim_ID], [Trim_Name]) VALUES
    (1, 'Chrome');
SET IDENTITY_INSERT [Trims] OFF;

SET IDENTITY_INSERT [Body_Colors] ON;
INSERT INTO [Body_Colors] ([Body_Color_ID], [Body_Color_Name]) VALUES
    (1, 'Billiard Gray'),
    (2, 'Vivid Black'),
    (3, 'Blood Orange'),
    (4, 'Iron Horse Metallic'),
    (5, 'Teal Thunder'),
    (6, 'White Onyx Pearl'),
    (7, 'Brilliant Red'),
    (8, 'Olive Steel Metallic / Vivid Black'),
    (9, 'Reflection');
SET IDENTITY_INSERT [Body_Colors] OFF;

SET IDENTITY_INSERT [Styles] ON;
INSERT INTO [Styles] ([Style_ID], [Style_Name]) VALUES
    (0, 'None'),
    (1, 'Redline Collection - Black'),
    (2, 'Redline Collection - Red'),
    (3, 'Redline Collection - Blue'),
    (4, 'Empire Collection');
SET IDENTITY_INSERT [Styles] OFF;

SET IDENTITY_INSERT [Performance] ON;
INSERT INTO [Performance] ([Performance_Option_ID], [Performance_Name]) VALUES
    (0, 'None'),
    (1, 'SE / Ohlins Suspension'),
    (2, 'Vortex Extreme Air Cleaner (Chrome)'),
    (3, 'Heavy Breather Air Cleaner (Chrome)'),
    (4, 'Wedge Air Cleaner (Chrome)'),
    (5, 'Round Air Cleaner');
SET IDENTITY_INSERT [Performance] OFF;

SET IDENTITY_INSERT [Comfort] ON;
INSERT INTO [Comfort] ([Comfort_Option_ID], [Comfort_Name]) VALUES
    (0, 'None'),
    (1, 'Sissy Bar Upright'),
    (2, 'Overwatch Touring Tail Bag'),
    (3, 'Overwatch Weekend Tail Bag'),
    (4, 'Detachable Saddlebags'),
    (5, 'Detachable Windshield'),
    (6, 'Get A Grip Handlebars (Chrome)'),
    (7, 'Hammock Comfort Seats'),
    (8, 'Engine Guard'),
    (9, 'Long Haul (FLBL)');
SET IDENTITY_INSERT [Comfort] OFF;
GO