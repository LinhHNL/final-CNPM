use haidilao;
GO
CREATE TABLE Level
(
  LevelID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(45) NOT NULL,
  Description ntext NOT NULL,
  condition float NOT NULL,
  PRIMARY KEY (LevelID)
);
GO
CREATE TABLE Promotion
(
  PromotionID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(50) NOT NULL,
  Discount FLOAT NOT NULL,
  Description ntext NOT NULL,
  Starttime DATE NOT NULL,
  EndTime DATE NOT NULL,
  PRIMARY KEY (PromotionID)
);
GO
CREATE TABLE Room
(
  RoomID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(50) NOT NULL,
  Description ntext NOT NULL,
  PRIMARY KEY (RoomID)
);
GO
CREATE TABLE PromotionDetailForLevel
(
  Description ntext NOT NULL,
  LevelID INT NOT NULL,
  PromotionID INT NOT NULL,
  PRIMARY KEY (LevelID, PromotionID),
  FOREIGN KEY (LevelID) REFERENCES Level(LevelID),
  FOREIGN KEY (PromotionID) REFERENCES Promotion(PromotionID)
);
GO
CREATE TABLE Unit
(
  UnitID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(45) NOT NULL,
  Description ntext NOT NULL,
  PRIMARY KEY (UnitID)
);
GO
CREATE TABLE Department
(
  DepartmentID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(45) NOT NULL,
  Description ntext NOT NULL,
  PRIMARY KEY (DepartmentID)
);
GO
CREATE TABLE Position
(
  PositionID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(45) NOT NULL,
  Description nvarchar(45) NOT NULL,
  DepartmentID INT NOT NULL,
  PRIMARY KEY (PositionID),
  FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID)
);
GO
CREATE TABLE Shift
(
  ShiftID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(45) NOT NULL,
  StartTime DATE NOT NULL,
  EndTime DATE NOT NULL,
  PRIMARY KEY (ShiftID)
);
GO
CREATE TABLE RequestType
(
  RequestTypeID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(50) NOT NULL,
  MaxNumber nvarchar(50) NOT NULL,
  Description ntext NOT NULL,
  PRIMARY KEY (RequestTypeID)
);
GO
CREATE TABLE Allowance
(
  AllowanceID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(45) NOT NULL,
  Description ntext NOT NULL,
  Bonus FLOAT NOT NULL,
  PRIMARY KEY (AllowanceID)
);
GO
CREATE TABLE Insurance
(
  InsuranceID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(45) NOT NULL,
  Fee FLOAT NOT NULL,
  StartDate DATE NOT NULL,
  Status nvarchar(45) NOT NULL,
  PRIMARY KEY (InsuranceID)
);
GO
CREATE TABLE Combo
(
  Id INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(45) NOT NULL,
  Cost nvarchar(45) NOT NULL,
  ImageURL ntext  NOT NULL,
  status bit,
  Description ntext  NOT NULL,
  PRIMARY KEY (Id)
);
GO

CREATE TABLE Customers
(
  CustormerID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(45) NOT NULL,
  Phone varchar(11) NOT NULL unique,
  Address nvarchar(45) NOT NULL,
  Password nvarchar(45) NOT NULL,
  Point INT NOT NULL,
  LevelID INT NOT NULL,
  PRIMARY KEY (CustormerID),
  FOREIGN KEY (LevelID) REFERENCES Level(LevelID)
);
GO
CREATE TABLE Transactions
(
  TransactionID INT IDENTITY(1,1) NOT NULL,
  TotalPrice FLOAT NOT NULL,
  Date DATE NOT NULL,
  CustormerID INT NOT NULL,
  PRIMARY KEY (TransactionID),
  FOREIGN KEY (CustormerID) REFERENCES Customers(CustormerID)
);
GO
CREATE TABLE KindFood
(
  KindFoodID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(45) NOT NULL,
  Description ntext NOT NULL,
  PRIMARY KEY (KindFoodID),
  
);
GO
CREATE TABLE Commodity
(
  ComodityID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(45) NOT NULL,
  Number FLOAT NOT NULL,
  Description ntext NOT NULL,
  UnitID INT NOT NULL,
  PRIMARY KEY (ComodityID),
  FOREIGN KEY (UnitID) REFERENCES Unit(UnitID)
);
GO
CREATE TABLE Staff
(
  StaffID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(45) NOT NULL,
  Dateofbirth DATE NOT NULL,
  Nationality nvarchar(45) NOT NULL,
  Phone CHAR(10) NOT NULL,
  identityCard CHAR(45) NOT NULL,
  DateIdentityCard DATE NOT NULL,
  PlaceidentityCard nvarchar(45) NOT NULL,
  CurrentAddress nvarchar(45) NOT NULL,
  PermanentAddress nvarchar(45) NOT NULL,
  BankID CHAR(45) NOT NULL,
  NameBank nvarchar(45) NOT NULL,
  Salary FLOAT NOT NULL,
  Sex nvarchar(45) NOT NULL,
  Status nvarchar(45) NOT NULL,
  URLImage nvarchar(45) NOT NULL,
  PositionID INT NOT NULL,
  ShiftID INT NOT NULL,
  PRIMARY KEY (StaffID),
  FOREIGN KEY (PositionID) REFERENCES Position(PositionID),
  FOREIGN KEY (ShiftID) REFERENCES Shift(ShiftID)
);
GO
CREATE TABLE ImportOrders
(
  ImportOrderID INT IDENTITY(1,1) NOT NULL,
  Date date NOT NULL,
  StaffID INT NOT NULL,
  PRIMARY KEY (ImportOrderID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);
GO
CREATE TABLE ImportOrdersDetails
(
  Number FLOAT NOT NULL,
  ImportOrderID INT NOT NULL,
  ComodityID INT NOT NULL,
  PRIMARY KEY (ImportOrderID, ComodityID),
  FOREIGN KEY (ImportOrderID) REFERENCES ImportOrders(ImportOrderID),
  FOREIGN KEY (ComodityID) REFERENCES Commodity(ComodityID)
);
GO
CREATE TABLE FamilyRelationship
(
  FamilyRelationshipID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(45) NOT NULL,
  Relationship nvarchar(45) NOT NULL,
  Sex nvarchar(45) NOT NULL,
  StaffID INT NOT NULL,
  PRIMARY KEY (FamilyRelationshipID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);
GO
CREATE TABLE Account
(
  AccountID INT IDENTITY(1,1) NOT NULL,
  Username nvarchar(45) NOT NULL,
  Password nvarchar(45) NOT NULL,
  StaffID INT NOT NULL,
  PRIMARY KEY (AccountID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);
GO
CREATE TABLE ArrangeShifts
(
  Date INT NOT NULL,
  Status INT NOT NULL,
  ArrangeShifts INT NOT NULL,
  StaffID INT NOT NULL,
  PRIMARY KEY (ArrangeShifts),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);
GO
CREATE TABLE Requets
(
  RequestID INT IDENTITY(1,1) NOT NULL,
  Date DATE NOT NULL,
  Description INT NOT NULL,
  StaffID INT NOT NULL,
  RequestTypeID INT NOT NULL,
  Status Int NOT NULL,
  PRIMARY KEY (RequestID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
  FOREIGN KEY (RequestTypeID) REFERENCES RequestType(RequestTypeID)
);
GO
CREATE TABLE TimekeepingSum
(
  TimekeepingID INT IDENTITY(1,1) NOT NULL,
  ActualWT FLOAT NOT NULL,
  Date DATE NOT NULL,
  TheCalendarWT FLOAT NOT NULL,
  Deduction INT NOT NULL,
  Locked INT NOT NULL,
  DateLocked bit  NOT NULL,
  OverTime FLOAT NOT NULL,
  StaffID INT NOT NULL,
  ArrangeShifts INT NOT NULL,
  PRIMARY KEY (TimekeepingID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
  FOREIGN KEY (ArrangeShifts) REFERENCES ArrangeShifts(ArrangeShifts)
);
GO
CREATE TABLE Payroll
(
  PayrollID INT IDENTITY(1,1) NOT NULL,
  TimeHourW FLOAT NOT NULL,
  NDAYOFF INT NOT NULL,
  Bonus FLOAT NOT NULL,
  Overtime FLOAT NOT NULL,
  TotalSalary FLOAT NOT NULL,
  Tax FLOAT NOT NULL,
  SocialInsurance FLOAT NOT NULL,
  Unionfee FLOAT NOT NULL,
  Date date NOT NULL,
  NDAYW INT NOT NULL,
  StaffID INT NOT NULL,
  TimekeepingID INT NOT NULL,
  PRIMARY KEY (PayrollID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
  FOREIGN KEY (TimekeepingID) REFERENCES TimekeepingSum(TimekeepingID)
);
GO
CREATE TABLE SocialInsurance
(
  id INT IDENTITY(1,1) NOT NULL,
  StartDateSI Date NOT NULL,
  EndDateSI date NOT NULL,
  CodeSI INT NOT NULL,
  StartDateHI date NOT NULL,
  EndDateHI date NOT NULL,
  StaffID INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);
GO
CREATE TABLE Menu
(
  MenuID INT IDENTITY(1,1) NOT NULL,
  Name nvarchar(45) NOT NULL,
  Price FLOAT NOT NULL,
  Point INT NOT NULL,
  URLImage varchar(MAX) NOT NULL,
  KindFoodID INT NOT NULL,
  RoomID INT NOT NULL,
  status int not null,
  Initual BIT not null ,
  PRIMARY KEY (MenuID),
  FOREIGN KEY (KindFoodID) REFERENCES KindFood(KindFoodID),
  FOREIGN KEY (RoomID) REFERENCES Room(RoomID)
);
GO
CREATE TABLE ExportOrders
(
  ExportOrderID INT IDENTITY(1,1) NOT NULL,
  Date date NOT NULL,
  StaffID INT NOT NULL,
  PRIMARY KEY (ExportOrderID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);
GO
CREATE TABLE MaterialsDetails
(
  Number FLOAT NOT NULL,
  MenuID INT NOT NULL,
  ComodityID INT NOT NULL,
  PRIMARY KEY (MenuID, ComodityID),
  FOREIGN KEY (MenuID) REFERENCES Menu(MenuID),
  FOREIGN KEY (ComodityID) REFERENCES Commodity(ComodityID)
);
GO
CREATE TABLE ExportOrdersDetails
(
  Number FLOAT NOT NULL,
  ComodityID INT NOT NULL,
  ExportOrderID INT NOT NULL,
  PRIMARY KEY (ComodityID, ExportOrderID),
  FOREIGN KEY (ComodityID) REFERENCES Commodity(ComodityID),
  FOREIGN KEY (ExportOrderID) REFERENCES ExportOrders(ExportOrderID)
);
Go
CREATE TABLE TransactionDetail
(
  Number INT NOT NULL,
  Price FLOAT NOT NULL,
  TransactionID INT NOT NULL,
  MenuID INT NOT NULL,
  PRIMARY KEY (TransactionID, MenuID),
  FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID),
  FOREIGN KEY (MenuID) REFERENCES Menu(MenuID)
);
Go


CREATE TABLE DetailComBo
(
  MenuID INT NOT NULL,
  Id INT NOT NULL,
  Number int not null,
  PRIMARY KEY (MenuID, Id),
  FOREIGN KEY (MenuID) REFERENCES Menu(MenuID),
  FOREIGN KEY (Id) REFERENCES Combo(Id)
);
Go
CREATE TABLE ImportCoupon
(
  IDCoupon INT IDENTITY(1,1) NOT NULL,
  Date DATE NOT NULL,
  StaffID INT NOT NULL,
  PRIMARY KEY (IDCoupon),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);
Go
CREATE TABLE CouponDetail
(
  Number INT  NOT NULL,
  ComodityID INT NOT NULL,
  IDCoupon INT NOT NULL,
  PRIMARY KEY (ComodityID, IDCoupon),
  FOREIGN KEY (ComodityID) REFERENCES Commodity(ComodityID),
  FOREIGN KEY (IDCoupon) REFERENCES ImportCoupon(IDCoupon)
);
Go
Create table TempBill(
	Id int identity(1,1) not null,
	CustomerId int not null,
	status  bit not null, 
	Price float not null,
	Token varchar(45) unique,
	primary key(Id),
	FOREIGN KEY (CustomerId) REFERENCES Customers(CustormerID)
)
Go 

CREATE TABLE TempBillDetails (
    TempBillId INT NOT NULL,
    MenuID INT NOT NULL,
    Number INT NOT NULL,
    Price FLOAT NOT NULL,
    Status BIT NOT NULL,
    PRIMARY KEY (TempBillId, MenuID),
    FOREIGN KEY (MenuID) REFERENCES Menu(MenuID),
    FOREIGN KEY (TempBillId) REFERENCES TempBill(Id)
)
GO

