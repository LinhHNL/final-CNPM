
use haidilao
go
----customer 
CREATE TRIGGER CheckCustomerExists
ON Customers
INSTEAD OF INSERT
AS
BEGIN
 -- Kiểm tra trường Phone
    IF EXISTS (
        SELECT *
        FROM inserted i
        WHERE i.Phone  In (
            SELECT Phone
            FROM Customers
            WHERE Phone = i.Phone
        )
    )
BEGIN
RAISERROR ('Customer with phone number  already exists', 16, 1);
ROLLBACK TRANSACTION;
	
RETURN;
END
ELSE
	INSERT Customers(name, phone, address, password, point, levelid)
   SELECT name, phone, address, password,0,1 FROM  inserted
END
GO


CREATE TRIGGER tr_UpdateCustomer
ON Customers
AFTER UPDATE
AS
BEGIN
    -- Kiểm tra khóa ngoại LevelID
    IF EXISTS (
        SELECT *
        FROM inserted i
        LEFT JOIN Level l ON i.LevelID = l.LevelID
        WHERE l.LevelID IS NULL
    )
    BEGIN
        RAISERROR('LevelID is invalid', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
    
    -- Kiểm tra trường Phone
    IF EXISTS (
        SELECT *
        FROM Customers c
        INNER JOIN inserted i ON c.CustormerID = i.CustormerID
        WHERE c.Phone <> i.Phone AND EXISTS (
            SELECT *
            FROM Customers
            WHERE Phone = i.Phone
        )
    )
    BEGIN
        RAISERROR('Phone is already in use', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
END
Go

CREATE TRIGGER trg_check_kind_food_id
ON Menu
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT * FROM inserted i WHERE NOT EXISTS (SELECT * FROM KindFood kf WHERE kf.KindFoodid = i.kindfoodid))
    BEGIN
        RAISERROR('Kind food does not exist.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END
Go
CREATE TRIGGER trg_check_room_id
ON Menu
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT * FROM inserted i WHERE NOT EXISTS (SELECT * FROM Room r WHERE r.roomid = i.roomid))
    BEGIN
        RAISERROR('Room does not exist.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END



Go
CREATE TRIGGER tr_delete_menu
ON Menu
AFTER DELETE
AS
BEGIN
    DELETE FROM MaterialsDetails WHERE MenuID IN (SELECT deleted.MenuID FROM deleted);
END
GO



CREATE TRIGGER trg_Position_DepartmentID
ON Position
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS(SELECT 1 FROM inserted WHERE DepartmentID NOT IN (SELECT DepartmentID FROM Department))
    BEGIN
        RAISERROR('Invalid DepartmentID', 16, 1)
        ROLLBACK TRANSACTION
    END
END
Go
CREATE TRIGGER tr_CheckShiftTime
ON Shift
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @ShiftID INT, @StartTime DATE, @EndTime DATE

    SELECT @ShiftID = ShiftID, @StartTime = StartTime, @EndTime = EndTime FROM inserted

    IF DATEDIFF(HOUR, @StartTime, @EndTime) < 4
    BEGIN
        RAISERROR('The time difference between start and end must be at least 4 hours.', 16, 1)
        ROLLBACK TRANSACTION
    END
END
GO


CREATE TRIGGER tr_DeleteShift
ON Shift
AFTER DELETE
AS
BEGIN
  DECLARE @ShiftID INT;
  SELECT @ShiftID = deleted.ShiftID FROM deleted;
  
  IF EXISTS(SELECT * FROM Staff WHERE ShiftID = @ShiftID)
  BEGIN
    RAISERROR ('Cannot delete this shift because there are still staffs assigned to it.', 16, 1);
    ROLLBACK TRANSACTION;
  END
END

Go
CREATE TRIGGER tr_InsertStaff
ON Staff
FOR INSERT
AS
BEGIN
    -- Check if PositionID is valid
    IF NOT EXISTS (SELECT * FROM Position WHERE PositionID IN (SELECT PositionID FROM inserted))
    BEGIN
        RAISERROR ('Invalid PositionID.', 16, 1);
        ROLLBACK;
        RETURN;
    END
    
    -- Check if ShiftID is valid
    IF NOT EXISTS (SELECT * FROM Shift WHERE ShiftID IN (SELECT ShiftID FROM inserted))
    BEGIN
        RAISERROR ('Invalid ShiftID.', 16, 1);
        ROLLBACK;
        RETURN;
    END
    
    -- Check if age is between 18 and 60
    IF EXISTS (
        SELECT * 
        FROM inserted 
        WHERE DATEDIFF(YEAR, DateOfBirth, GETDATE()) NOT BETWEEN 18 AND 60
    )
    BEGIN
        RAISERROR ('Staff must be between 18 and 60 years old.', 16, 1);
        ROLLBACK;
        RETURN;
    END
END
go

CREATE TRIGGER tr_InsertTransaction
ON Transactions
FOR INSERT,Update
AS
BEGIN
    DECLARE @CustomerId INT
    SELECT @CustomerId = inserted.CustormerID
    FROM inserted
    LEFT JOIN Customers ON inserted.CustormerID = Customers.CustormerID
    WHERE Customers.CustormerID IS NULL

    IF @CustomerId IS NOT NULL
    BEGIN
        RAISERROR ('Invalid customer ID.', 16, 1)
        ROLLBACK TRANSACTION
    END
END



go 

CREATE TRIGGER trg_UpdateCustomerLevel
ON Transactions
AFTER INSERT, UPDATE
AS
BEGIN
  UPDATE Customers
  SET LevelID = (
    SELECT TOP 1 LevelID
    FROM Level
    WHERE condition <= (
      SELECT SUM(TotalPrice)
      FROM Transactions
      WHERE CustormerID = inserted.CustormerID
    )
    ORDER BY condition DESC
  )
  FROM Customers
  INNER JOIN inserted ON Customers.CustormerID = inserted.CustormerID
END
GO


CREATE TRIGGER trg_AddTransactionDetail
ON TransactionDetail
INSTEAD OF INSERT, UPDATE
AS
BEGIN
  -- Check if the TransactionID and MenuID exist in Transactions and Menu tables
  IF NOT EXISTS (SELECT * FROM Transactions WHERE TransactionID = inserted.TransactionID)
    BEGIN
      RAISERROR ('Invalid TransactionID.', 16, 1);
      ROLLBACK TRANSACTION;
      RETURN;
    END

  IF NOT EXISTS (SELECT * FROM Menu WHERE MenuID = inserted.MenuID)
    BEGIN
      RAISERROR ('Invalid MenuID.', 16, 1);
      ROLLBACK TRANSACTION;
      RETURN;
    END
END

Go
CREATE TRIGGER trg_CheckUnitID
ON Commodity
AFTER INSERT
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM Unit WHERE UnitID IN (SELECT UnitID FROM inserted))
    BEGIN
        RAISERROR('Unit does not exist', 16, 1);
        ROLLBACK TRANSACTION;
    END
END
Go

CREATE TRIGGER trg_CheckUnitID
ON Commodity
FOR INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted i
               LEFT JOIN Unit u ON i.UnitID = u.UnitID
               WHERE u.UnitID IS NULL)
    BEGIN
        RAISERROR('Unit does not exist', 16, 1);
        ROLLBACK TRANSACTION;
    END
END
Go
CREATE TRIGGER trg_AddMaterialsDetail
ON MaterialsDetails
FOR INSERT, UPDATE
AS
BEGIN
  IF EXISTS (SELECT * FROM inserted i JOIN Menu m ON i.MenuID = m.MenuID JOIN Commodity c ON i.ComodityID = c.ComodityID)
  BEGIN
    INSERT INTO MaterialsDetails(Number, MenuID, ComodityID)
    SELECT Number, MenuID, ComodityID
    FROM inserted
  END
  ELSE
  BEGIN
    RAISERROR('Invalid data', 16, 1)
  END
END
Go
CREATE TRIGGER trg_UpdateMaterialQuantity
ON MaterialsDetails
AFTER INSERT
AS
BEGIN
  UPDATE MaterialsDetails
  SET Number +=  inserted.Number
  FROM MaterialsDetails
  JOIN inserted ON MaterialsDetails.MenuID = inserted.MenuID
END
Go


CREATE TRIGGER trg_ImportCoupon_Insert
ON ImportCoupon
INSTEAD OF INSERT
AS
BEGIN
  DECLARE @StaffID INT;
  SELECT @StaffID = StaffID FROM inserted;

  IF NOT EXISTS (SELECT * FROM Staff WHERE StaffID = @StaffID)
  BEGIN
    RAISERROR('Invalid staff ID', 16, 1);
  END
  ELSE
  BEGIN
    INSERT INTO ImportCoupon (Date, StaffID)
    SELECT Date, StaffID
    FROM inserted;
  END
END
go
CREATE TRIGGER trg_ImportCoupon_Update
ON ImportCoupon
INSTEAD OF UPDATE
AS
BEGIN
  DECLARE @IDCoupon INT;
  DECLARE @Date DATE;
  DECLARE @StaffID INT;
  
  SELECT @IDCoupon = IDCoupon, @Date = Date, @StaffID = StaffID FROM inserted;

  IF NOT EXISTS (SELECT * FROM ImportCoupon WHERE IDCoupon = @IDCoupon)
  BEGIN
    RAISERROR('Invalid ImportCoupon ID', 16, 1);
  END
  ELSE IF NOT EXISTS (SELECT * FROM Staff WHERE StaffID = @StaffID)
  BEGIN
    RAISERROR('Invalid staff ID', 16, 1);
  END
  ELSE
  BEGIN
    UPDATE ImportCoupon
    SET Date = @Date, StaffID = @StaffID
    WHERE IDCoupon = @IDCoupon;
  END
END


go
CREATE TRIGGER CouponDetail_CheckForeignKeys
ON CouponDetail
AFTER INSERT, UPDATE
AS
BEGIN
  IF NOT EXISTS (SELECT * FROM Commodity c WHERE c.ComodityID IN (SELECT i.ComodityID FROM inserted i))
  BEGIN
    RAISERROR('The ComodityID does not exist in the Commodity table.', 16, 1);
    ROLLBACK TRANSACTION;
    RETURN;
  END

  IF NOT EXISTS (SELECT * FROM ImportCoupon ic WHERE ic.IDCoupon IN (SELECT i.IDCoupon FROM inserted i))
  BEGIN
    RAISERROR('The IDCoupon does not exist in the ImportCoupon table.', 16, 1);
    ROLLBACK TRANSACTION;
    RETURN;
  END
END
Go


CREATE TRIGGER ExportOrder_CheckStaffID
ON ExportOrders
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @StaffID int
    SELECT @StaffID = StaffID FROM inserted

    IF NOT EXISTS(SELECT * FROM Staff WHERE StaffID = @StaffID)
    BEGIN
        RAISERROR('Invalid StaffID', 16, 1)
        ROLLBACK TRANSACTION;
        RETURN;
    END
END
go
CREATE TRIGGER ExportOrdersDetails_CheckForeignKeys
ON ExportOrdersDetails
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS(SELECT * FROM inserted i JOIN Commodity c ON i.ComodityID = c.ComodityID WHERE c.ComodityID IS NULL)
    BEGIN
        RAISERROR('Invalid CommodityID', 16, 1)
        ROLLBACK TRANSACTION;
        RETURN;
    END

    IF EXISTS(SELECT * FROM inserted i JOIN ExportOrders eo ON i.ExportOrderID = eo.ExportOrderID WHERE eo.ExportOrderID IS NULL)
    BEGIN
        RAISERROR('Invalid ExportOrderID', 16, 1)
        ROLLBACK TRANSACTION;
        RETURN;
    END
END

GO
CREATE TRIGGER ExportOrderDetails_UpdateNumberCommodity_Insert
ON ExportOrdersDetails
AFTER INSERT
AS
BEGIN
  DECLARE @CommodityID int
  DECLARE @Number float
  DECLARE @ExportOrderID int

  SELECT @CommodityID = inserted.ComodityID,
         @Number = inserted.Number,
         @ExportOrderID = inserted.ExportOrderID
  FROM inserted

  UPDATE Commodity
  SET Number = Number - @Number
  WHERE ComodityID = @CommodityID
END

Go
CREATE TRIGGER ExportOrderDetails_UpdateNumberCommodity_Update
ON ExportOrdersDetails
AFTER Update
AS
BEGIN
  DECLARE @CommodityID int
  DECLARE @Number float
  DECLARE @ExportOrderID int
  DECLARE @NumberOld int
  SELECT @CommodityID = inserted.ComodityID,
         @Number = inserted.Number,
         @ExportOrderID = inserted.ExportOrderID
  FROM inserted
  Set @NumberOld  = (Select Number from ExportOrdersDetails where ExportOrderID = @ExportOrderID and ComodityID = @CommodityID)
  UPDATE Commodity
  SET Number = Number + @NumberOld -@Number
  WHERE ComodityID = @CommodityID
END
go



---Import
CREATE TRIGGER ImportOrder_CheckStaffID
ON ImportOrders
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @StaffID int
    SELECT @StaffID = StaffID FROM inserted

    IF NOT EXISTS(SELECT * FROM Staff WHERE StaffID = @StaffID)
    BEGIN
        RAISERROR('Invalid StaffID', 16, 1)
        ROLLBACK TRANSACTION;
        RETURN;
    END
END
go
CREATE TRIGGER ImportOrdersDetails_CheckForeignKeys
ON ImportOrdersDetails
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS(SELECT * FROM inserted i JOIN Commodity c ON i.ComodityID = c.ComodityID WHERE c.ComodityID IS NULL)
    BEGIN
        RAISERROR('Invalid CommodityID', 16, 1)
        ROLLBACK TRANSACTION;
        RETURN;
    END

    IF EXISTS(SELECT * FROM inserted i JOIN ImportOrders eo ON i.ImportOrderID = eo.ImportOrderID WHERE eo.ImportOrderID IS NULL)
    BEGIN
        RAISERROR('Invalid ImportOrderID', 16, 1)
        ROLLBACK TRANSACTION;
        RETURN;
    END
END

GO
CREATE TRIGGER ImportOrderDetails_UpdateNumberCommodity_Insert
ON ImportOrdersDetails
AFTER INSERT
AS
BEGIN
  DECLARE @CommodityID int
  DECLARE @Number float
  DECLARE @ImportOrderID int

  SELECT @CommodityID = inserted.ComodityID,
         @Number = inserted.Number,
         @ImportOrderID = inserted.ImportOrderID
  FROM inserted

  UPDATE Commodity
  SET Number = Number - @Number
  WHERE ComodityID = @CommodityID
END

Go
CREATE TRIGGER ImportOrderDetails_UpdateNumberCommodity_Update
ON ImportOrdersDetails
AFTER Update
AS
BEGIN
  DECLARE @CommodityID int
  DECLARE @Number float
  DECLARE @ImportOrderID int
  DECLARE @NumberOld int
  SELECT @CommodityID = inserted.ComodityID,
         @Number = inserted.Number,
         @ImportOrderID = inserted.ImportOrderID
  FROM inserted
  Set @NumberOld  = (Select Number from ImportOrdersDetails where ImportOrderID = @ImportOrderID and ComodityID = @CommodityID)
  UPDATE Commodity
  SET Number = Number + @NumberOld -@Number
  WHERE ComodityID = @CommodityID
END
go
Create TRIGGER CreateAccount_Check
ON Account
INSTEAD OF INSERT, UPDATE
AS
BEGIN
    IF EXISTS(SELECT 1 FROM inserted i
              JOIN Staff s ON i.StaffID = s.StaffID
              JOIN Account a ON i.Username = a.Username
              WHERE i.AccountID <> a.AccountID)
    BEGIN
        RAISERROR('Username already exists or StaffID does not exist', 16, 1)
    END
    ELSE
    BEGIN
        UPDATE Account
        SET Username = i.Username, Password = i.Password, StaffID = i.StaffID
        FROM inserted i
        WHERE Account.AccountID = i.AccountID
        INSERT INTO Account (Username, Password, StaffID)
        SELECT Username, Password, StaffID FROM inserted
        WHERE NOT EXISTS(SELECT 1 FROM Account a WHERE a.Username = inserted.Username)
    END
END
GO
CREATE TRIGGER trg_StaffCheckAge
ON Staff
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT * FROM inserted
        WHERE DATEDIFF(year, DateOfBirth, GETDATE()) < 18 OR DATEDIFF(year, DateOfBirth, GETDATE()) > 60
    )
    BEGIN
        RAISERROR ('Staff age must be between 18 and 60.', 16, 1);
        ROLLBACK;
    END
END
GO