use haidilao 
go
CREATE TABLE Level
(
  LevelID CHAR(11) NOT NULL,
  Name VARCHAR(45) NOT NULL,
  Description VARCHAR(50) NOT NULL,
  PRIMARY KEY (LevelID)
);

CREATE TABLE Promotion
(
  PromotionID CHAR(11) NOT NULL,
  Name VARCHAR(50) NOT NULL,
  Discount FLOAT NOT NULL,
  Description VARCHAR(50) NOT NULL,
  Starttime DATE NOT NULL,
  EndTime DATE NOT NULL,
  PRIMARY KEY (PromotionID)
);

CREATE TABLE Room
(
  RoomID CHAR(11) NOT NULL,
  Name VARCHAR(50) NOT NULL,
  Description VARCHAR(50) NOT NULL,
  PRIMARY KEY (RoomID)
);

CREATE TABLE PromotionDetailForLevel
(
  Description VARCHAR(45) NOT NULL,
  LevelID CHAR(11) NOT NULL,
  PromotionID CHAR(11) NOT NULL,
  PRIMARY KEY (LevelID, PromotionID),
  FOREIGN KEY (LevelID) REFERENCES Level(LevelID),
  FOREIGN KEY (PromotionID) REFERENCES Promotion(PromotionID)
);

CREATE TABLE Unit
(
  UnitID CHAR(11) NOT NULL,
  Name VARCHAR(45) NOT NULL,
  Description VARCHAR(50) NOT NULL,
  PRIMARY KEY (UnitID)
);

CREATE TABLE Department
(
  DepartmentID CHAR(11) NOT NULL,
  Name VARCHAR(45) NOT NULL,
  Description VARCHAR(45) NOT NULL,
  PRIMARY KEY (DepartmentID)
);

CREATE TABLE Position
(
  PositionID CHAR(11) NOT NULL,
  Name VARCHAR(45) NOT NULL,
  Desciption VARCHAR(45) NOT NULL,
  DepartmentID CHAR(11) NOT NULL,
  PRIMARY KEY (PositionID),
  FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID)
);

CREATE TABLE Shifts
(
  ShiftID CHAR(11) NOT NULL,
  Name VARCHAR(45) NOT NULL,
  StartTime DATE NOT NULL,
  EndTime DATE NOT NULL,
  PRIMARY KEY (ShiftID)
);

CREATE TABLE RequestType
(
  RequestTypeID CHAR(11) NOT NULL,
  Name VARCHAR(50) NOT NULL,
  MaxNumber VARCHAR(50) NOT NULL,
  Description VARCHAR(50) NOT NULL,
  PRIMARY KEY (RequestTypeID)
);

CREATE TABLE Allowance
(
  AllowanceID CHAR(11) NOT NULL,
  Name VARCHAR(45) NOT NULL,
  Description VARCHAR(45) NOT NULL,
  Bonus FLOAT NOT NULL,
  PRIMARY KEY (AllowanceID)
);

CREATE TABLE Insurance
(
  InsuranceID INT NOT NULL,
  Name VARCHAR(45) NOT NULL,
  Fee FLOAT NOT NULL,
  StartDate DATE NOT NULL,
  Status VARCHAR(45) NOT NULL
);

CREATE TABLE Customers
(
  CustormerID CHAR(10) NOT NULL,
  Name VARCHAR(45) NOT NULL,
  Phone VARCHAR(45) NOT NULL,
  Address VARCHAR(45) NOT NULL,
  Password VARCHAR(45) NOT NULL,
  Point INT NOT NULL,
  LevelID CHAR(11) NOT NULL,
  PRIMARY KEY (CustormerID),
  FOREIGN KEY (LevelID) REFERENCES Level(LevelID)
);

CREATE TABLE Transactions
(
  TransactionID CHAR(11) NOT NULL,
  TotalPrice FLOAT NOT NULL,
  Date DATE NOT NULL,
  CustormerID CHAR(10) NOT NULL,
  PRIMARY KEY (TransactionID),
  FOREIGN KEY (CustormerID) REFERENCES Customers(CustormerID)
);

CREATE TABLE KindFood
(
  KindFoodID CHAR(11) NOT NULL,
  Name VARCHAR(45) NOT NULL,
  Description VARCHAR(45) NOT NULL,
  RoomID CHAR(11) NOT NULL,
  PRIMARY KEY (KindFoodID),
  FOREIGN KEY (RoomID) REFERENCES Room(RoomID)
);
CREATE TABLE Commodity
(
  ComodityID CHAR(11) NOT NULL,
  Name VARCHAR(45) NOT NULL,
  Number FLOAT NOT NULL,
  Description VARCHAR(45) NOT NULL,
  UnitID CHAR(11) NOT NULL,
  PRIMARY KEY (ComodityID),
  FOREIGN KEY (UnitID) REFERENCES Unit(UnitID)
);

CREATE TABLE Staff
(
  StaffID CHAR(11) NOT NULL,
  Name VARCHAR(45) NOT NULL,
  Dateofbirth DATE NOT NULL,
  Nationality VARCHAR(45) NOT NULL,
  Phone CHAR(10) NOT NULL,
  identityCard CHAR(45) NOT NULL,
  DateIdentityCard DATE NOT NULL,
  PlaceidentityCard VARCHAR(45) NOT NULL,
  CurrentAddress VARCHAR(45) NOT NULL,
  PermanentAddress VARCHAR(45) NOT NULL,
  BankID CHAR(45) NOT NULL,
  NameBank VARCHAR(45) NOT NULL,
  Salary FLOAT NOT NULL,
  Sex VARCHAR(45) NOT NULL,
  URLIMAGE TEXT NOT NULL,
  Status VARCHAR(45) NOT NULL,
  PositionID CHAR(11) NOT NULL,
  PRIMARY KEY (StaffID),
  FOREIGN KEY (PositionID) REFERENCES Position(PositionID)
);

CREATE TABLE ImportOrders
(
  ImportOrderID INT NOT NULL,
  Name INT NOT NULL,
  StaffID CHAR(11) NOT NULL,
  PRIMARY KEY (ImportOrderID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);

CREATE TABLE ImportOrdersDetails
(
  Number FLOAT NOT NULL,
  ImportOrderID INT NOT NULL,
  ComodityID CHAR(11) NOT NULL,
  PRIMARY KEY (ImportOrderID, ComodityID),
  FOREIGN KEY (ImportOrderID) REFERENCES ImportOrders(ImportOrderID),
  FOREIGN KEY (ComodityID) REFERENCES Commodity(ComodityID)
);

CREATE TABLE WorkProgress
(
  WorkProgressID CHAR(11) NOT NULL,
  StartDate DATE NOT NULL,
  EndDate DATE NOT NULL,
  Description VARCHAR(45) NOT NULL,
  StaffID CHAR(11) NOT NULL,
  PositionID CHAR(11) NOT NULL,
  PRIMARY KEY (WorkProgressID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
  FOREIGN KEY (PositionID) REFERENCES Position(PositionID)
);

CREATE TABLE FamilyRelationship
(
  FamilyRelationshipID CHAR(11) NOT NULL,
  Name VARCHAR(45) NOT NULL,
  Relationship VARCHAR(45) NOT NULL,
  Sex VARCHAR(45) NOT NULL,
  StaffID CHAR(11) NOT NULL,
  PRIMARY KEY (FamilyRelationshipID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);

CREATE TABLE Account
(
  AccountID CHAR(11) NOT NULL,
  Username VARCHAR(45) NOT NULL,
  Password VARCHAR(45) NOT NULL,
  StaffID CHAR(11) NOT NULL,
  PRIMARY KEY (AccountID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);

CREATE TABLE ArrangeShifts
(
  Date INT NOT NULL,
  Status INT NOT NULL,
  ArrangeShifts CHAR(11) NOT NULL,
  StaffID CHAR(11) NOT NULL,
  ShiftID CHAR(11) NOT NULL,
  PRIMARY KEY (ArrangeShifts),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
  FOREIGN KEY (ShiftID) REFERENCES Shifts(ShiftID)
);

CREATE TABLE Requets
(
  RequestID CHAR(11) NOT NULL,
  Date DATE NOT NULL,
  Description INT NOT NULL,
  StaffID CHAR(11) NOT NULL,
  RequestTypeID CHAR(11) NOT NULL,
  PRIMARY KEY (RequestID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
  FOREIGN KEY (RequestTypeID) REFERENCES RequestType(RequestTypeID)
);

CREATE TABLE TimekeepingSum
(
  TimekeepingID CHAR(11) NOT NULL,
  ActualWT FLOAT NOT NULL,
  Date DATE NOT NULL,
  TheCalendarWT FLOAT NOT NULL,
  Deduction INT NOT NULL,
  Locked INT NOT NULL,
  DateLocked DATE NOT NULL,
  StaffID CHAR(11) NOT NULL,
  ArrangeShifts CHAR(11) NOT NULL,
  PRIMARY KEY (TimekeepingID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
  FOREIGN KEY (ArrangeShifts) REFERENCES ArrangeShifts(ArrangeShifts)
);

CREATE TABLE Payroll
(
  PayrollID CHAR(11) NOT NULL,
  TimeHourW FLOAT NOT NULL,
  NDAYOFF INT NOT NULL,
  Bonus FLOAT NOT NULL,
  Overtime INT NOT NULL,
  TotalSalary FLOAT NOT NULL,
  Tax FLOAT NOT NULL,
  SocialInsurance FLOAT NOT NULL,
  Unionfee INT NOT NULL,
  Date INT NOT NULL,
  NDAYW INT NOT NULL,
  StaffID CHAR(11) NOT NULL,
  TimekeepingID CHAR(11) NOT NULL,
  PRIMARY KEY (PayrollID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
  FOREIGN KEY (TimekeepingID) REFERENCES TimekeepingSum(TimekeepingID)
);

CREATE TABLE Menu
(
  MenuID INT NOT NULL,
  Name INT NOT NULL,
  Price INT NOT NULL,
  Point INT NOT NULL,
  URLImage INT NOT NULL,
  KindFoodID CHAR(11) NOT NULL,
  PRIMARY KEY (MenuID),
  FOREIGN KEY (KindFoodID) REFERENCES KindFood(KindFoodID)
);

CREATE TABLE ExportOrders
(
  ExportOrderID INT NOT NULL,
  Date INT NOT NULL,
  StaffID CHAR(11) NOT NULL,
  PRIMARY KEY (ExportOrderID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);

CREATE TABLE MaterialsDetails
(
  Number FLOAT NOT NULL,
  MenuID INT NOT NULL,
  ComodityID CHAR(11) NOT NULL,
  PRIMARY KEY (MenuID, ComodityID),
  FOREIGN KEY (MenuID) REFERENCES Menu(MenuID),
  FOREIGN KEY (ComodityID) REFERENCES Commodity(ComodityID)
);

CREATE TABLE ExportOrdersDetails
(
  Number FLOAT NOT NULL,
  ComodityID CHAR(11) NOT NULL,
  ExportOrderID INT NOT NULL,
  PRIMARY KEY (ComodityID, ExportOrderID),
  FOREIGN KEY (ComodityID) REFERENCES Commodity(ComodityID),
  FOREIGN KEY (ExportOrderID) REFERENCES ExportOrders(ExportOrderID)
);

CREATE TABLE TransactionDetail
(
  Number INT NOT NULL,
  Price FLOAT NOT NULL,
  TransactionID CHAR(11) NOT NULL,
  MenuID INT NOT NULL,
  PRIMARY KEY (TransactionID, MenuID),
  FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID),
  FOREIGN KEY (MenuID) REFERENCES Menu(MenuID)
);