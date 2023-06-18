Scripts: 
USE [prjdb21]
CREATE TABLE Employee (
  employeeID int PRIMARY KEY, --AUTO_INCREMENT,
  employeeType varchar(20) NOT NULL,
  firstName varchar(50) NOT NULL,
  lastName varchar(50) NOT NULL,
  dateOfBirth DateTime NOT NULL,
  password varchar(50) NOT NULL
);
 
 
CREATE TABLE Tables (
  tableID int PRIMARY KEY,
  capacity int,
  ocuppided bit
);
 
CREATE TABLE MenuItem (
  menuItemID int PRIMARY KEY,
  description varchar(4000),
  price float,
  [contains] int
);
 
CREATE TABLE InventoryItem (
  itemID int PRIMARY KEY,
  itemName varchar(50),
  quantity int
);
 
alter TABLE InventoryItem
ALTER COLUMN itemName VARCHAR(100);
 
CREATE TABLE Payment (
  paymentID int PRIMARY KEY, --AUTO_INCREMENT,
  amount float
);
 
CREATE TABLE Bill (
  billID int PRIMARY KEY,
  paymentID int
);
 
ALTER TABLE [Order] ADD FOREIGN KEY (tableNumber) REFERENCES Tables (tableID);
 
ALTER TABLE [Order] ADD FOREIGN KEY (paymentID) REFERENCES Payment (paymentID);
 
ALTER TABLE [Order] ADD FOREIGN KEY ([contains]) REFERENCES [menuItem] ([menuItemID]);
 
CREATE TABLE InventoryItem_MenuItem (
  InventoryItem_itemID int,
  MenuItem_contains int,
  PRIMARY KEY (InventoryItem_itemID, MenuItem_contains)
);
 
ALTER TABLE InventoryItem_MenuItem ADD FOREIGN KEY (InventoryItem_itemID) REFERENCES InventoryItem (itemID);
 
ALTER TABLE InventoryItem_MenuItem ADD FOREIGN KEY (MenuItem_contains) REFERENCES MenuItem ([contains]);
 
 
ALTER TABLE Payment ADD FOREIGN KEY (paymentID) REFERENCES Bill (paymentID);
 
INSERT INTO MenuItem (menuItemID, [description], price, [contains])
VALUES
    (27, 'Fried cod with curry sabayon', 14.50, 1),
    (133, 'Linguini with mushroom sauce', 13.50, 1),
    (45, 'White chocolate and speculoos cake with mandarin', 5.50, 10),
    (36, 'Fresh madeleines with fig compote and creme patissier with Grand Marnier', 6.50, 10),
    (62, '3 types of farmer’s cheeses with rye raisin bread', 5.00, 10),
    (12, 'Veal tartar with tuna mayonnaise and fried mussels', 8.50, 10),
    (86, 'Pate of pheasant with Monegasque onions', 8.50, 10),
    (97, 'Crab salmon cookies with sweet and sour chili sauce', 9.00, 10),
    (675, 'Provencal fish soup with rouille and croutons', 6.50, 10),
    (43, 'Pheasant consomme with spring onion and green herbs', 7.50, 10),
    (23, 'On the skin fried cod fillet with curry-sabayon', 17.50, 10),
    (55, 'Fried tenderloin with veal gravy with pink peppers', 22.50, 10),
    (807, 'Venison steak with own stew and red cabbage', 25.00, 10),
    (67, 'Cafe surprise (Coffee with homemade pralines)', 5.50, 10),
    (54, 'Cherry Baby (Whipped ice cream with warm cherries)', 6.50, 10),
    (42, 'Port e Fromage (different cheeses with a glass of port)', 7.50, 10),
    (61, 'Spa red(glass)', 2.50, 10),
    (76, 'Spa green(glass)', 2.50, 10),
    (98, 'Coca Cola Light(glass)', 2.50, 10),
    (80, 'Coca Cola(glass)', 2.50, 10),
    (90, 'Tonic(glass)', 2.50, 10),
    (10, 'Bitter Lemon(glass)', 2.50, 10),
    (20, 'Hertog Jan(tap)', 3.00, 10),
    (39, 'Duvel(tap)', 4.50, 10),
    (60, 'Kriek(tap)', 4.00, 10),
    (6, 'Leffe Triple(tap)', 4.50, 10),
    (30, 'White house wine(bottle)', 28.50, 10),
    (53, 'White house wine(glass)', 6.50, 10),
    (48, 'Red house wine(bottle)', 32.00, 10),
    (47, 'Red house wine(glass)', 7.50, 10),
    (203, 'Champagne(bottle)', 50.00, 10),
    (64, 'Young Jenever(unit)', 3.50, 10),
    (68, 'Whisky(unit)', 5.00, 10),
    (87, 'Rum(unit)', 4.50, 10),
    (908, 'Vieux(unit)', 4.50, 10),
    (65, 'Berenburg(unit)', 3.50, 10),
    (34, 'Coffee', 2.50, 10),
    (605, 'Cappuccino', 3.50, 10),
    (28, 'Espresso', 3.00, 10),
    (601, 'Tea', 2.50, 10),
    (88, 'Pate of pheasant with Monegasque onions', 8.50, 10),
    (52, 'Provencal fish soup with rouille, aged cheese and croutons', 6.50, 10),
    (99, 'Deer stew with red cabbage', 12.50, 1),
    (13, 'Steak tartare with truffle mayonnaise', 7.50, 10);
 
ALTER TABLE MenuItem
ADD category VARCHAR(50);
 
ALTER TABLE MenuItem
ADD sequence INT;
 
UPDATE MenuItem
SET category = 'Lunch'
WHERE menuItemID IN (13, 88, 52);
 
UPDATE MenuItem
SET category = 'Lunch'
WHERE menuItemID IN (99, 27,133);
 
UPDATE MenuItem
SET category = 'Lunch'
WHERE menuItemID IN (45, 36, 62);
 
UPDATE MenuItem
SET [sequence] = CASE
    WHEN menuItemID IN (13, 88, 52) THEN 1 -- Starters - Entrees
    WHEN menuItemID IN (99, 27, 133) THEN 2 -- Mains - Le plat principal
    WHEN menuItemID IN (45, 36, 62) THEN 3 -- Deserts - Les Desserts
    ELSE 0 -- For any other items, you can set a default value or handle it accordingly
END;
 
UPDATE MenuItem
SET category = 'Diner', sequence = 1
WHERE menuItemID IN (12, 86, 97);
 
UPDATE MenuItem
SET category = 'Diner', sequence = 2
WHERE menuItemID IN (675, 43);
 
UPDATE MenuItem
SET category = 'Diner', sequence = 3
WHERE menuItemID IN (23, 55, 807);
 
UPDATE MenuItem
SET category = 'Diner', sequence = 4
WHERE menuItemID IN (67, 54, 42);
 
UPDATE MenuItem
SET category = 'Soft drinks by the glass',
    sequence = CASE
        WHEN [description] = 'Spa red(glass)' THEN 1
        WHEN [description] = 'Spa green(glass)' THEN 2
        WHEN [description] = 'Coca Cola Light(glass)' THEN 3
        WHEN [description] = 'Coca Cola(glass)' THEN 4
        WHEN [description] = 'Sisi(glass)' THEN 5
        WHEN [description] = 'Tonic(glass)' THEN 6
        WHEN [description] = 'Bitter Lemon(glass)' THEN 7
        ELSE 0
    END
WHERE [description] IN ('Spa red(glass)', 'Spa green(glass)', 'Coca Cola Light(glass)', 'Coca Cola(glass)', 'Sisi(glass)', 'Tonic(glass)', 'Bitter Lemon(glass)');
 
UPDATE MenuItem
SET category = 'Beers on tap',
    sequence = CASE
        WHEN [description] = 'Hertog Jan(tap)' THEN 1
        WHEN [description] = 'Duvel(tap)' THEN 2
        WHEN [description] = 'Kriek(tap)' THEN 3
        WHEN [description] = 'Leffe Triple(tap)' THEN 4
        ELSE 0
    END
WHERE [description] IN ('Hertog Jan(tap)', 'Duvel(tap)', 'Kriek(tap)', 'Leffe Triple(tap)');
 
UPDATE MenuItem
SET category = 'Wines',
    sequence = CASE
        WHEN [description] IN ('White house wine(bottle)', 'White house wine(glass)') THEN 1
        WHEN [description] IN ('Red house wine(bottle)', 'Red house wine(glass)') THEN 2
        WHEN [description] = 'Champagne(bottle)' THEN 3
        ELSE 0
    END
WHERE [description] IN ('White house wine(bottle)', 'White house wine(glass)', 'Red house wine(bottle)', 'Red house wine(glass)', 'Champagne(bottle)');
 
 
UPDATE MenuItem
SET category = 'Spirit drinks',
    sequence = CASE
        WHEN [description] = 'Young Jenever(unit)' THEN 1
        WHEN [description] = 'Whisky(unit)' THEN 2
        WHEN [description] = 'Rum(unit)' THEN 3
        WHEN [description] = 'Vieux(unit)' THEN 4
        WHEN [description] = 'Berenburg(unit)' THEN 5
        ELSE 0
    END
WHERE [description] IN ('Young Jenever(unit)', 'Whisky(unit)', 'Rum(unit)', 'Vieux(unit)', 'Berenburg(unit)');
 
UPDATE MenuItem
SET category = 'Coffee / Tea',
    sequence = CASE
        WHEN [description] = 'Coffee' THEN 1
        WHEN [description] = 'Cappuccino' THEN 2
        WHEN [description] = 'Espresso' THEN 3
        WHEN [description] = 'Tea' THEN 4
        ELSE 0
    END
WHERE [description] IN ('Coffee', 'Cappuccino', 'Espresso', 'Tea');
 
    UPDATE MenuItem
SET category = 'Soft drinks by the glass',
    sequence = CASE
        WHEN [description] = 'Spa red(glass)' THEN 1
        WHEN [description] = 'Spa green(glass)' THEN 2
        WHEN [description] = 'Coca Cola Light(glass)' THEN 3
        WHEN [description] = 'Coca Cola(glass)' THEN 4
        WHEN [description] = 'Sisi(glass)' THEN 5
        WHEN [description] = 'Tonic(glass)' THEN 6
        WHEN [description] = 'Bitter Lemon(glass)' THEN 7
        ELSE 0
    END
WHERE category = 'Soft drinks by the glass';
 
SELECT [description]
FROM MenuItem
WHERE category = 'Lunch'
order by [sequence];
 
SELECT [description]
FROM MenuItem
WHERE category ='Diner'
order by [sequence];
 
SELECT [description]
FROM MenuItem
WHERE category = 'Soft drinks by the glass'
ORDER BY sequence;
 
SELECT [description]
FROM MenuItem
WHERE category = 'Beers on tap'
ORDER BY sequence;
 
SELECT [description]
FROM MenuItem
WHERE category = 'Wines'
ORDER BY sequence;
 
SELECT [description]
FROM MenuItem
WHERE category = 'Spirit drinks'
ORDER BY sequence;
 
SELECT [description]
FROM MenuItem
WHERE category = 'Coffee / Tea'
ORDER BY sequence;
 
alter table menuItem
Add vat_category BIT;
 
SELECT [description]
 
 
UPDATE MenuItem
SET vat_category = 0;
 
 
UPDATE MenuItem
set price=7.50
WHERE [description]='Steak tartare with truffle mayonnaise';
 
UPDATE MenuItem
set [contains]=10
WHERE menuItemID=27 --AND menuItemID=133 And menuItemID=22 AND menuItemID=27;
 
-- you need to add a filed called type in the menu item.
 
SELECT *
FROM MenuItem;
 
 
ALTER TABLE MenuItem
Add type VARCHAR(20);
 
UPDATE MenuItem
set [MenuItem.]='Beer on Tap'
WHERE [description]='beer';
 
 
INSERT INTO Employee(employeeID, employeeType, firstName, lastName, dateOfBirth, [password])
VALUES
(43, 'Manager', 'Andrew', 'Tate', 01-12-1986, 4567),
(13, 'Waiter', 'Olivia', 'Johnson', 07/05/1992, 1234),
(64, 'Waiter', 'Ethan', 'Davis', 18/01/1998, 5543),
(9, 'Bartender', 'Amelia', 'Lee', 22/05/2000, 2343),
(67, 'Bartender', 'John', 'Cena', 17/11/2002, 0987),
(45, 'Chef', 'Gordon', 'Ramsay', 08/11/1966, 2137),
(99, 'Chef', 'Snoop', 'Dogg', 20/10/1971, 0420);
 
INSERT INTO [Order](orderID, tableNumber, totalPrice) --paymentID, [contains])
VALUES
(31, 1, 20.00), --1,6),
(13, 2, 1232.00),-- 2 ,5),
(11, 3, 1632.00);-- 3 ,9);
 
 
 
INSERT INTO Tables(tableID, capacity, ocuppided)
VALUES
(1, 5, 0),
(2, 10, 1),
(3, 2, 1);
 
 
INSERT INTO Payment(paymentID, amount)
VALUES
(3,123.00),
(1, 20.00),
(2, 1232.00);
 
 
INSERT INTO Bill(billID, paymentID)
VALUES
(1, 1),
(2, 2);
 
SELECT *
FROM Tables;
SELECT *
FROM Employee;
SELECT *
FROM Bill;
SELECT *
FROM InventoryItem;
SELECT *
FROM [Order];
SELECT *
FROM MenuItem;
select *
FROM Payment;
 
 
insert into InventoryItem(itemID,itemName,quantity)
VALUES
(27, 'Fried cod with curry sabayon', 14),
(45, 'White chocolate and speculoos cake with mandarin', 5),
(36, 'Fresh madeleines with fig compote and creme pâtissier with Grand Marnier', 6),
(12, 'Veal tartar with tuna mayonnaise and fried mussels', 8),
(86, 'Pâté of pheasant with Monegasque onions', 8),
(97, 'Crab salmon cookies with sweet and sour chili sauce', 9),
(55, 'Fried tenderloin with veal gravy with pink peppers', 22),
(807, 'Venison steak with own stew and red cabbage', 25),
(133, 'Linguini with mushroom sauce', 13),
(62, '3 types of farmer’s cheeses with rye raisin bread', 5),
(675, 'Provencal fish soup with rouille and croutons', 6),
(43, 'Pheasant consommé with spring onion and green herbs', 7),
(23, 'On the skin fried cod fillet with curry-sabayon', 17),
(67, 'Café surprise (Coffee with homemade pralines)', 5),
(54, 'Cherry Baby (Whipped ice cream with warm cherries)', 6),
(42, 'Port e Fromage (different cheeses with a glass of port)', 7),
(61, 'Spa red(glass)', 2),
(76, 'Spa green(glass)', 2),
(98, 'Coca Cola Light(glass)', 2),
(80, 'Coca Cola(glass)', 2),
(90, ' Tonic(glass)', 2),
(10, 'Bitter Lemon(glass)', 2),
(20, 'Hertog Jan(tap)', 3),
(39, 'Duvel(tap)', 4),
(60, 'Kriek(tap)', 4),
(6, 'Leffe Triple(tap)', 4),
(30, 'White house wine(bottle)', 28),
(53, 'White house wine(glass)', 6),
(48, 'Red house wine(bottle)', 32),
(47, 'Red house wine(glass)', 7),
(203, 'Champagne(bottle)', 50),
(64, 'Young Jenever(unit)', 3),
(68, 'Whisky(unit)', 5),
(87, 'Rum(unit)', 42),
(908, 'Vieux(unit)', 44),
(65, 'Berenburg(unit)', 31),
(34, 'Coffee', 2),
(605, 'Cappuccino', 44),
(28, 'Espresso', 3),
(601, 'Tea', 2),
(88, 'Pâté of pheasant with Monegasque onions', 8),
(52, 'Provencal fish soup with rouille, aged cheese and croutons',6),
(99, 'Deer stew with red cabbage', 12),
(13, 'Steak tartare with truffle mayonnaise', 7);
 
 
CREATE TABLE PaymentHistory (
    PaymentHistoryID INT IDENTITY(1, 1) PRIMARY KEY,
    TotalAmount DECIMAL(10, 2) NOT NULL,
    Tip DECIMAL(10, 2) NULL,
    Feedback VARCHAR(100) NULL,
    TableNumber INT NOT NULL
);
 
ALTER TABLE PaymentHistory
ADD PaymentMethods VARCHAR(MAX) NULL;
 
ALTER TABLE PaymentHistory
ALTER COLUMN PaymentHistoryID INT IDENTITY(1, 1)
 
 
CREATE TABLE PaymentMethod (
    PaymentMethodID INT PRIMARY KEY,
    PaymentMethodName VARCHAR(50) NOT NULL
);

 
CREATE TABLE [MenuItem] (
  menuItemID int PRIMARY KEY,
  [description] varchar(4000),
  price float,
  [contains] int
);
 
CREATE TABLE [OrderTable] (
  orderID int PRIMARY KEY,
  tableNumber int,
  totalPrice float,
  paymentID int,
  [contains] int,
);
INSERT INTO [OrderTable] (orderID, tableNumber, totalPrice, paymentID)
VALUES
    (4, 2, 18.75, 24680),
    (5, 3, 33.25, 13579),
    (6, 1, 21.99, 86420),
    (7, 4, 10.50, 97531),
    (8, 2, 28.50, 46802),
    (9, 3, 15.75, 21987),
    (10, 1, 27.50, 75319),
    (11, 4, 19.99, 38062),
    (12, 2, 35.25, 16273),
    (13, 3, 12.50, 90817),
    (14, 1, 31.50, 53624),
    (15, 4, 22.99, 27189),
    (16, 2, 38.75, 65472),
    (17, 3, 17.25, 29183),
    (18, 1, 29.50, 72654),
    (19, 4, 16.99, 41937),
    (20, 2, 45.25, 98372),
    (21, 3, 14.50, 62749),
    (22, 1, 32.50, 38496),
    (23, 4, 24.99, 71935),
    (24, 2, 51.75, 16284),
    (25, 3, 19.25, 53697),
    (26, 1, 37.50, 27148),
    (27, 4, 13.99, 81536),
    (28, 2, 44.25, 35967),
    (29, 3, 11.75, 72481),
    (30, 1, 26.50, 46753),
    (31, 4, 18.99, 90274),
    (32, 2, 34.25, 53619),
    (33, 3, 9.50, 27164),
    (34, 1, 30.50, 81536),
    (35, 4, 23.99, 35967);
    -- Add more rows as needed
    
 
SELECT *
from OrderTable
SELECT *
from MenuItem
 
Drop table InventoryItem_MenuItem;
select *
from OrderTable join MenuItem on MenuItem.[contains]=OrderTable.orderID;
 
CREATE TABLE MenuItem (
  menuItemID int PRIMARY KEY,
  [description] varchar(4000),
  price float,
  [contains] int,
  vat_category BIT,
);
CREATE TABLE [OrderTable] (
  tableNumber int PRIMARY key NOT NULL,
  totalPrice float,
  paymentID int
);
create table OrderItems(
TotalPrice float,    --FOREIGN KEY REFERENCES [OrderTable](orderID)
tableNumber int,
[itemName] VARCHAR(50),
);
 
create table OrderHistory(
item VARCHAR(50),
price FLOAT,
)
 
INSERT INTO OrderTable(tableNumber)
VALUES (2),
(3),
(4),
(5),
(6),
(7);
 
SELECT *
from PaymentHistory;
 
select *
from MenuItem
 
ALTER TABLE OrderItems
ADD  IsAlcoholic ;
 
 
ALTER TABLE orderItems
ALTER COLUMN PricePerItem DECIMAL(10, 2);
 
alter table orderItems
add Comments varchar(100); 
 
SELECT *
from OrderItems
