CREATE TABLE `Employee` (
  `employeeID` int PRIMARY KEY,
  `employeeType` varchar(20),
  `firstName` varchar(50),
  `lastName` varchar(50),
  `dateOfBirth` DateTime,
  `password` varchar(50)
);

CREATE TABLE `Order` (
  `orderID` int PRIMARY KEY,
  `tableNumber` int,
  `totalPrice` double,
  `paymentID` int,
  `contains` int
);

CREATE TABLE `Tables` (
  `tableID` int PRIMARY KEY,
  `capacity` int,
  `ocuppided` bit
);

CREATE TABLE `MenuItem` (
  `menuItemID` int PRIMARY KEY,
  `description` varchar(4000),
  `price` double,
  `contains` int
);

CREATE TABLE `InventoryItem` (
  `itemID` int PRIMARY KEY,
  `itemName` varchar(50),
  `quantity` int
);

CREATE TABLE `Payment` (
  `paymentID` int PRIMARY KEY,
  `amount` double
);

CREATE TABLE `Bill` (
  `billID` int PRIMARY KEY,
  `paymentID` int
);

ALTER TABLE `Order` ADD FOREIGN KEY (`tableNumber`) REFERENCES `Tables` (`tableID`);

ALTER TABLE `Order` ADD FOREIGN KEY (`paymentID`) REFERENCES `Payment` (`paymentID`);

ALTER TABLE `MenuItem` ADD FOREIGN KEY (`menuItemID`) REFERENCES `Order` (`contains`);

CREATE TABLE `InventoryItem_MenuItem` (
  `InventoryItem_itemID` int,
  `MenuItem_contains` int,
  PRIMARY KEY (`InventoryItem_itemID`, `MenuItem_contains`)
);

ALTER TABLE `InventoryItem_MenuItem` ADD FOREIGN KEY (`InventoryItem_itemID`) REFERENCES `InventoryItem` (`itemID`);

ALTER TABLE `InventoryItem_MenuItem` ADD FOREIGN KEY (`MenuItem_contains`) REFERENCES `MenuItem` (`contains`);


ALTER TABLE `Payment` ADD FOREIGN KEY (`paymentID`) REFERENCES `Bill` (`paymentID`);
