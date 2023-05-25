CREATE TABLE `Employee` (
  `employeeID` int PRIMARY KEY,
  `employeeType` ENUM ('Chef', 'Waiter', 'Bartender'),
  `firstName` string,
  `lastName` string,
  `dateOfBirth` DateTime,
  `password` string
);

CREATE TABLE `Customer` (
  `customerID` int PRIMARY KEY,
  `customerName` string,
  `phoneNumber` int,
  `feedback` string
);

CREATE TABLE `Order` (
  `orderID` int PRIMARY KEY,
  `tableNumber` int,
  `totalPrice` double,
  `paymentID` int
);

CREATE TABLE `Tables` (
  `tableID` int PRIMARY KEY,
  `capacity` int,
  `ocuppided` bool
);

CREATE TABLE `Reservation` (
  `reservationID` int PRIMARY KEY,
  `tableNumber` int,
  `date` DateTime,
  `customerID` int
);

CREATE TABLE `MenuItem` (
  `itemID` int PRIMARY KEY,
  `description` string,
  `price` double,
  `contains` int
);

CREATE TABLE `StockItem` (
  `stockID` int PRIMARY KEY,
  `stockName` string,
  `quantity` int
);

CREATE TABLE `Payment` (
  `paymentID` int PRIMARY KEY,
  `paymentMethod` PaymentMethod,
  `amount` double
);

CREATE TABLE `Feedback` (
  `feedbackID` int PRIMARY KEY,
  `customerID` int,
  `date` DateTime,
  `description` string
);

ALTER TABLE `Customer` ADD FOREIGN KEY (`feedback`) REFERENCES `Feedback` (`feedbackID`);

ALTER TABLE `Order` ADD FOREIGN KEY (`tableNumber`) REFERENCES `Tables` (`tableID`);

ALTER TABLE `Order` ADD FOREIGN KEY (`paymentID`) REFERENCES `Payment` (`paymentID`);

ALTER TABLE `Tables` ADD FOREIGN KEY (`tableID`) REFERENCES `Reservation` (`tableNumber`);

ALTER TABLE `Customer` ADD FOREIGN KEY (`customerID`) REFERENCES `Reservation` (`customerID`);

CREATE TABLE `StockItem_MenuItem` (
  `StockItem_stockID` int,
  `MenuItem_contains` int,
  PRIMARY KEY (`StockItem_stockID`, `MenuItem_contains`)
);

ALTER TABLE `StockItem_MenuItem` ADD FOREIGN KEY (`StockItem_stockID`) REFERENCES `StockItem` (`stockID`);

ALTER TABLE `StockItem_MenuItem` ADD FOREIGN KEY (`MenuItem_contains`) REFERENCES `MenuItem` (`contains`);


CREATE TABLE `Customer_Feedback` (
  `Customer_customerID` int,
  `Feedback_customerID` int,
  PRIMARY KEY (`Customer_customerID`, `Feedback_customerID`)
);

ALTER TABLE `Customer_Feedback` ADD FOREIGN KEY (`Customer_customerID`) REFERENCES `Customer` (`customerID`);

ALTER TABLE `Customer_Feedback` ADD FOREIGN KEY (`Feedback_customerID`) REFERENCES `Feedback` (`customerID`);

