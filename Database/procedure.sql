--check login  result = 0 là thất bạn 1 là thành công
use hadilao
go
CREATE PROCEDURE CheckLogin
    @phone VARCHAR(50),
    @password VARCHAR(50)
AS
BEGIN
    IF EXISTS (
        SELECT *
        FROM Customers
        WHERE Phone = @phone AND Password = @password
    )
    BEGIN
        SELECT *,'1' as Result
        FROM Customers 
        WHERE Phone = @phone AND Password = @password
    END
    ELSE
    BEGIN
        SELECT '0' AS Result
    END
END
GO
--lưu thông tin tài khoản mới trong đó result = 0 là thất bạn 1 là thành công
CREATE PROCEDURE AddCustomer
@name NVARCHAR(50),
@phone VARCHAR(20),
@address NVARCHAR(100),
@password VARCHAR(50)
AS
BEGIN
INSERT INTO Customers (name, phone, address, password, point, levelid)
VALUES (@name, @phone, @address, @password, 0, 1)
END
GO
CREATE PROCEDURE dbo.DeleteCustomer
    @customerId INT
AS
BEGIN
    DELETE FROM Customers
    WHERE CustormerID = @customerId
END
GO

CREATE PROCEDURE dbo.UpdateCustomer
    @customerId INT,
    @name NVARCHAR(45),
    @phone VARCHAR(11),
    @address NVARCHAR(45),
    @password NVARCHAR(45),
    @point INT,
    @levelId INT
AS
BEGIN
    UPDATE Customers
    SET 
        Name = @name,
        Phone = @phone,
        Address = @address,
        Password = @password,
        Point = @point,
        LevelID = @levelId
    WHERE CustormerID = @customerId
END
GO



--crud  room 
CREATE PROCEDURE Room_Insert
    @Name NVARCHAR(50),
    @Description NVARCHAR(100)
AS
BEGIN
    INSERT INTO Room (Name, Description)
    VALUES (@Name, @Description)
END
GO
CREATE PROCEDURE Room_Update
    @Id INT,
    @Name NVARCHAR(50),
    @Description NVARCHAR(100)
AS
BEGIN
    UPDATE Room
    SET Name = @Name, Description = @Description
    WHERE RoomID = @Id
END
Go
CREATE PROCEDURE Room_Delete
    @Id INT
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM Menu WHERE RoomId = @Id)
    BEGIN
        DELETE FROM Room WHERE RoomID = @Id
    END
    ELSE
    BEGIN
        RAISERROR('Cannot delete room because it has reservations', 16, 1)
    END
END
GO
CREATE PROCEDURE Room_GetById
    @Id INT
AS
BEGIN
    SELECT * FROM Room WHERE RoomID = @Id
END
GO

CREATE PROCEDURE Room_GetAll
AS
BEGIN
    SELECT * FROM Room 
END

GO

--crud kind food  
CREATE PROCEDURE KindFood_Insert
    @Name NVARCHAR(50),
    @Description NVARCHAR(100)
AS
BEGIN
   
        INSERT INTO KindFood (Name, Description)
        VALUES (@Name, @Description)
    
END
go
CREATE PROCEDURE KindFood_Update
    @Id INT,
    @Name NVARCHAR(50),
    @Description NVARCHAR(100)
AS
BEGIN
        UPDATE KindFood
        SET Name = @Name, Description = @Description
        WHERE KindFoodID = @Id
END
GO
CREATE PROCEDURE KindFood_Delete
    @Id INT
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM Menu WHERE KindFoodId = @Id)
    BEGIN
        DELETE FROM KindFood WHERE KindFoodId = @Id
    ENd
    ELSE
    BEGIN
        RAISERROR('Cannot delete kind of food because it has foods', 16, 1)
    END
END
GO

CREATE PROCEDURE KindFood_GetById
    @Id INT
AS
BEGIN
    SELECT * FROM KindFood WHERE KindFoodId = @Id
END
go
CREATE PROCEDURE KindFood_GetAll
   
AS
BEGIN
    SELECT * FROM KindFood 
END
GO

CREATE PROCEDURE Level_GetAll
    @Id INT
AS
BEGIN
    SELECT * FROM Level 
END
go
CREATE PROCEDURE Level_GetById
    @Id INT
AS
BEGIN
    SELECT * FROM Level WHERE LevelId = @Id
END
go
CREATE PROCEDURE Level_Delete
    @Id INT
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM Customers WHERE LevelId = @Id)
    BEGIN
        DELETE FROM Level WHERE LevelId = @Id
    END
    ELSE
    BEGIN
        RAISERROR('Cannot delete level because it has customers', 16, 1)
    END
END
go
CREATE PROCEDURE Level_Update
    @Id INT,
    @Name NVARCHAR(50),
    @Description NVARCHAR(100),
    @Condition FLOAT
AS
BEGIN
    UPDATE Level
    SET Name = @Name, Description = @Description, Condition = @Condition
    WHERE LevelId = @Id
END
go
CREATE PROCEDURE Level_Insert
    @Name NVARCHAR(50),
    @Description NVARCHAR(100),
    @Condition FLOAT
AS
BEGIN
    INSERT INTO Level (Name, Description, Condition)
    VALUES (@Name, @Description, @Condition)
END
Go




---status 1 là còn bán 2 là khóa món 0 là nghĩ bán 

--crud monan
CREATE PROCEDURE sp_add_menu
    @name NVARCHAR(50),
    @price INT,
    @point INT,
    @url_image VARCHAR(MAX),
    @kind_food_id INT,
    @room_id INT,
    @status INT
AS
BEGIN
    INSERT INTO Menu(name, price, point, urlimage, kindfoodid, roomid, status)
    VALUES (@name, @price, @point, @url_image, @kind_food_id, @room_id, @status);
END

Go
CREATE PROCEDURE sp_update_menu
    @id INT,
    @name NVARCHAR(50),
    @price INT,
    @point INT,
    @url_image VARCHAR(MAX),
    @kind_food_id INT,
    @room_id INT,
    @status BIT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT * FROM Menu WHERE Menuid = @id)
    BEGIN
        RAISERROR('Food does not exist.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM kindfood WHERE kindfoodid = @kind_food_id)
    BEGIN
        RAISERROR('Kind food does not exist.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM room WHERE roomid = @room_id)
    BEGIN
        RAISERROR('Room does not exist.', 16, 1);
        RETURN;
    END

    UPDATE Menu SET
        name = @name,
        price = @price,
        point = @point,
        urlimage = @url_image,
        kindfoodid = @kind_food_id,
        roomid = @room_id,
        status = @status
    WHERE Menuid = @id;
END
GO
CREATE PROCEDURE sp_delete_menu
    @id INT
AS
BEGIN
    DELETE FROM Menu WHERE MenuID = @id;
END
GO
Create proc sp_getAll_Menu
as 
begin
	Select * from Menu
end
GO
CREATE PROCEDURE sp_getMenuByID
	@ID INT
AS
BEGIN
	Select * from Menu where @ID=MenuID
END
GO
Create proc change_status
@id int,
@status int 
as 
begin
	update Menu 
	Set 
	status = @status
	where 
	MenuID = @id
end
GO
--- Câu này truyền vào 1 sẽ là ra còn bán và khóa món còn 0 là nghĩ bán
Create procedure getAllMenuByStatus 
@status int 
AS 
Begin 
	if (@status=0)  
		begin
			select * from Menu where Status  = 0
		end 
	else
		begin 
			select * from Menu where Status  = 1 or Status  = 2
		end
end
Go
-- crud department 
CREATE PROCEDURE [dbo].[CreateDepartment]
    @Name nvarchar(45),
    @Description ntext
AS
BEGIN
    INSERT INTO Department (Name, Description)
    VALUES (@Name, @Description)
END
go

CREATE PROCEDURE [dbo].[GetAllDepartments]
AS
BEGIN
    SELECT * FROM Department
END
go
CREATE PROCEDURE [dbo].[UpdateDepartment]
    @DepartmentID int,
    @Name nvarchar(45),
    @Description ntext
AS
BEGIN
    UPDATE Department
    SET Name = @Name,
        Description = @Description
    WHERE DepartmentID = @DepartmentID
END
go
CREATE PROCEDURE [dbo].[DeleteDepartment]
    @DepartmentID int
AS
BEGIN
    IF EXISTS (SELECT * FROM Position WHERE DepartmentID = @DepartmentID)
    BEGIN
        RAISERROR ('Cannot delete department because it has related positions.', 16, 1)
        RETURN
    END
    
    DELETE FROM Department
    WHERE DepartmentID = @DepartmentID
END

GO
CREATE PROCEDURE getByID_Department
    @DepartmentID INT
AS
BEGIN
    SELECT *
    FROM Department
    WHERE DepartmentID = @DepartmentID
END
GO

--crud Position
CREATE PROCEDURE InsertPosition
    @Name nvarchar(45),
    @Description nvarchar(45),
    @DepartmentID INT
AS
BEGIN
    INSERT INTO Position(Name, Description, DepartmentID)
    VALUES (@Name, @Description, @DepartmentID)
END
go

CREATE PROCEDURE GetPositions
AS
BEGIN
    SELECT * FROM Position
END
go

CREATE PROCEDURE GetPositionByID
@Id int
AS
BEGIN
    SELECT * FROM Position where PositionID = @Id
END
go

CREATE PROCEDURE UpdatePosition
    @PositionID INT,
    @Name nvarchar(45),
    @Description nvarchar(45),
    @DepartmentID INT
AS
BEGIN
    UPDATE Position
    SET Name = @Name, Description = @Description, DepartmentID = @DepartmentID
    WHERE PositionID = @PositionID
END
go
CREATE PROCEDURE DeletePosition
    @PositionID INT
AS
BEGIN
    IF NOT EXISTS(SELECT * FROM Staff WHERE PositionID = @PositionID)
    BEGIN
        DELETE FROM Position WHERE PositionID = @PositionID
    END
    ELSE
    BEGIN
        RAISERROR ('Cannot delete this position because there are still staffs assigned to it.', 16, 1);
    END
END
go

---Shift
CREATE PROCEDURE sp_GetShiftByID
  @ShiftID INT
AS
BEGIN
  SELECT * FROM Shift
  WHERE ShiftID = @ShiftID;
END
go
CREATE PROCEDURE sp_UpdateShift
  @ShiftID INT,
  @Name nvarchar(45),
  @StartTime DATE,
  @EndTime DATE
AS
BEGIN
      UPDATE Shift
      SET Name = @Name, StartTime = @StartTime, EndTime = @EndTime
      WHERE ShiftID = @ShiftID;
END
GO

CREATE PROCEDURE sp_DeleteShift
  @ShiftID INT
AS
BEGIN
  IF EXISTS(SELECT * FROM Shift WHERE ShiftID = @ShiftID)
  BEGIN
    DELETE FROM Shift
    WHERE ShiftID = @ShiftID;
  END
  ELSE
  BEGIN
    RAISERROR ('ShiftID not found.', 16, 1);
  END
END
GO

CREATE PROCEDURE sp_GetShifts
  @ShiftID INT
AS
BEGIN
  SELECT * FROM Shift

END
go
CREATE PROCEDURE insertShift
    @Name NVARCHAR(45),
    @StartTime DATE,
    @EndTime DATE
AS
BEGIN
    INSERT INTO Shift (Name, StartTime, EndTime)
    VALUES (@Name, @StartTime, @EndTime)
END
GO


----CRUD Staff
CREATE PROCEDURE InsertStaff
    @Name nvarchar(45),
    @DateOfBirth DATE,
    @Nationality nvarchar(45),
    @Phone CHAR(10),
    @IdentityCard CHAR(45),
    @DateIdentityCard DATE,
    @PlaceIdentityCard nvarchar(45),
    @CurrentAddress nvarchar(45),
    @PermanentAddress nvarchar(45),
    @BankID CHAR(45),
    @NameBank nvarchar(45),
    @Salary FLOAT,
    @Sex nvarchar(45),
    @Status nvarchar(45),
    @URLImage nvarchar(45),
    @PositionID INT,
    @ShiftID INT
AS
BEGIN
  
    INSERT INTO Staff (Name, DateOfBirth, Nationality, Phone, IdentityCard, DateIdentityCard, PlaceIdentityCard,
        CurrentAddress, PermanentAddress, BankID, NameBank, Salary, Sex, Status, URLImage, PositionID, ShiftID)
    VALUES (@Name, @DateOfBirth, @Nationality, @Phone, @IdentityCard, @DateIdentityCard, @PlaceIdentityCard,
        @CurrentAddress, @PermanentAddress, @BankID, @NameBank, @Salary, @Sex, @Status, @URLImage, @PositionID, @ShiftID);
    
    SELECT @@IDENTITY as StaffID;
END

Go
CREATE PROCEDURE GetStaffByID
    @staffID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- kiểm tra xem staff có tồn tại không
    IF NOT EXISTS(SELECT * FROM Staff WHERE StaffID = @staffID)
    BEGIN
        RAISERROR ('Staff not found', 16, 1);
        RETURN;
    END

    -- lấy thông tin của staff
   SELECT s.StaffID, s.Name, s.Dateofbirth, s.Nationality, s.Phone, s.identityCard,
    s.DateIdentityCard, s.PlaceidentityCard, s.CurrentAddress, s.PermanentAddress, s.BankID,
    s.NameBank, s.Salary, s.Sex, s.Status, s.URLImage, 
    p.Name AS PositionName, 
    sh.Name AS ShiftName, sh.StartTime, sh.EndTime
  FROM Staff s
  INNER JOIN Position p ON s.PositionID = p.PositionID
  INNER JOIN Shift sh ON s.ShiftID = sh.ShiftID
  WHERE s.StaffID = @StaffID;
END
go
CREATE PROCEDURE UpdateStaff
    @StaffID INT,
    @Name NVARCHAR(45),
    @Dateofbirth DATE,
    @Nationality NVARCHAR(45),
    @Phone CHAR(10),
    @identityCard CHAR(45),
    @DateIdentityCard DATE,
    @PlaceidentityCard NVARCHAR(45),
    @CurrentAddress NVARCHAR(45),
    @PermanentAddress NVARCHAR(45),
    @BankID CHAR(45),
    @NameBank NVARCHAR(45),
    @Salary FLOAT,
    @Sex NVARCHAR(45),
    @Status NVARCHAR(45),
    @URLImage NVARCHAR(45),
    @PositionID INT,
    @ShiftID INT
AS
BEGIN
    UPDATE Staff
    SET Name = @Name,
        Dateofbirth = @Dateofbirth,
        Nationality = @Nationality,
        Phone = @Phone,
        identityCard = @identityCard,
        DateIdentityCard = @DateIdentityCard,
        PlaceidentityCard = @PlaceidentityCard,
        CurrentAddress = @CurrentAddress,
        PermanentAddress = @PermanentAddress,
        BankID = @BankID,
        NameBank = @NameBank,
        Salary = @Salary,
        Sex = @Sex,
        Status = @Status,
        URLImage = @URLImage,
        PositionID = @PositionID,
        ShiftID = @ShiftID
    WHERE StaffID = @StaffID
END
go

Create Procedure GetStaffs
AS 
Begin 
	Select * from Staff
End 
Go 
Create Procedure GetStaffByID 
@ID int 
AS 
Begin 
	Select * from Staff where StaffID = @ID 
End

Go 
Create Procedure DeleteStaff
@Id int
AS 
Begin 
	Delete from Staff where StaffID = @ID
End
Go
--lưu thông tin lịch sử giao dịch
CREATE PROCEDURE InsertTransaction
    @TotalPrice FLOAT,
    @Date DATE,
    @CustomerId INT
AS
BEGIN
    INSERT INTO Transactions (TotalPrice, Date, CustormerID)
    VALUES (@TotalPrice, @Date, @CustomerId);
END
GO
CREATE PROCEDURE GetTransactionById
    @TransactionId INT
AS
BEGIN
    SELECT *
    FROM Transactions
    WHERE TransactionID = @TransactionId;
END
GO
CREATE PROCEDURE GetTransactions
   
AS
BEGIN
    SELECT *
    FROM Transactions
   
END
GO
CREATE PROCEDURE UpdateTransaction
    @TransactionId INT,
    @TotalPrice FLOAT,
    @Date DATE,
    @CustomerId INT
AS
BEGIN
    UPDATE Transactions
    SET TotalPrice = @TotalPrice, Date = @Date, CustormerID = @CustomerId
    WHERE TransactionID = @TransactionId;
END
GO
CREATE PROCEDURE DeleteTransaction
    @TransactionId INT
AS
BEGIN
    DELETE FROM Transactions
    WHERE TransactionID = @TransactionId;
END

GO

--- CRUD TrancsactionDetails
CREATE PROCEDURE AddTransactionDetail
  @Number INT,
  @Price FLOAT,
  @TransactionID INT,
  @MenuID INT
AS
BEGIN
  INSERT INTO TransactionDetail(Number, Price, TransactionID, MenuID)
  VALUES(@Number, @Price, @TransactionID, @MenuID);
END
GO
CREATE PROCEDURE GetTransactionDetailById
  @TransactionID INT,
  @MenuID INT
AS
BEGIN
  SELECT * FROM TransactionDetail
  WHERE TransactionID = @TransactionID AND MenuID = @MenuID;
END

Go
CREATE PROCEDURE GetTransactionDetails
  @TransactionID INT
AS
BEGIN
  SELECT * FROM TransactionDetail
  WHERE TransactionID = @TransactionID 
END

Go
CREATE PROCEDURE UpdateTransactionDetail
  @Number INT,
  @Price FLOAT,
  @TransactionID INT,
  @MenuID INT
AS
BEGIN
  UPDATE TransactionDetail
  SET Number = @Number, Price = @Price
  WHERE TransactionID = @TransactionID AND MenuID = @MenuID;
END
Go
CREATE PROCEDURE DeleteTransactionDetail
  @TransactionID INT,
  @MenuID INT
AS
BEGIN
  DELETE FROM TransactionDetail
  WHERE TransactionID = @TransactionID AND MenuID = @MenuID;
END
GO


CREATE PROCEDURE get_units
   
AS
BEGIN
    SELECT *
    FROM Unit
   
END
go
--crud unit 
CREATE PROCEDURE create_unit
    @Name nvarchar(45),
    @Description ntext
AS
BEGIN
    INSERT INTO Unit (Name, Description)
    VALUES (@Name, @Description)
END

go
CREATE PROCEDURE update_unit
    @UnitID INT,
    @Name nvarchar(45),
    @Description ntext
AS
BEGIN
    UPDATE Unit
    SET Name = @Name, Description = @Description
    WHERE UnitID = @UnitID
END
go
CREATE PROCEDURE get_unitbyid
    @UnitID INT
AS
BEGIN
    SELECT *
    FROM Unit
    WHERE UnitID = @UnitID
END
go
CREATE PROCEDURE delete_unit
    @UnitID INT
AS
BEGIN
    IF EXISTS (SELECT * FROM Commodity WHERE UnitID = @UnitID)
    BEGIN
        RAISERROR('This unit is being used by some products and cannot be deleted.', 16, 1)
        RETURN
    END

    DELETE FROM Unit
    WHERE UnitID = @UnitID
END
Go






-----CRUD Commodity
CREATE PROCEDURE CreateCommodity
    @Name NVARCHAR(45),
    @Number FLOAT,
    @Description NTEXT,
    @UnitID INT
AS
BEGIN
    INSERT INTO Commodity (Name, Number, Description, UnitID)
    VALUES (@Name, @Number, @Description, @UnitID);
    SELECT SCOPE_IDENTITY() AS CommodityID;
END

go
CREATE PROCEDURE getCommodity
    @CommodityID INT
AS
BEGIN
    

    SELECT c.ComodityID, c.Name, c.Number, c.Description, u.Name AS UnitName
    FROM Commodity c
    INNER JOIN Unit u ON c.UnitID = u.UnitID
    WHERE c.ComodityID = @CommodityID;
END
go
CREATE PROCEDURE getCommoditys
    @CommodityID INT
AS
BEGIN
    

    SELECT c.ComodityID, c.Name, c.Number, c.Description, u.Name AS UnitName
    FROM Commodity c
    INNER JOIN Unit u ON c.UnitID = u.UnitID
   
END
go
CREATE PROCEDURE DeleteCommodity
    @CommodityID INT
AS
BEGIN
   delete from Commodity where ComodityID = @CommodityID
END
go
CREATE PROCEDURE UpdateCommodity
    @CommodityID INT,
    @Name NVARCHAR(45),
    @Number FLOAT,
    @Description NTEXT,
    @UnitID INT
AS
BEGIN
   

    UPDATE Commodity
    SET Name = @Name,
        Number = @Number,
        Description = @Description,
        UnitID = @UnitID
    WHERE ComodityID = @CommodityID;
END

go


--crud chi tiết nguyên liệu
CREATE PROCEDURE AddMaterialsDetail
(
  @Number FLOAT,
  @MenuID INT,
  @ComodityID INT
)
AS
BEGIN
  INSERT INTO MaterialsDetails(Number, MenuID, ComodityID) 
  VALUES (@Number, @MenuID, @ComodityID)
END

go
CREATE PROCEDURE GetMaterialsDetails
@Id int
AS
BEGIN
  SELECT md.*,c.*,m.* FROM MaterialsDetails as md
  inner join  Commodity as c on c.ComodityID = md.ComodityID 
  inner join Menu as m on m.MenuID = md.MenuID
  where md.MenuID = @Id
END
go
CREATE PROCEDURE UpdateMaterialsDetail
(
  @Number FLOAT,
  @MenuID INT,
  @ComodityID INT
)
AS
BEGIN
    UPDATE MaterialsDetails 
    SET Number = @Number
    WHERE MenuID = @MenuID AND ComodityID = @ComodityID

END
go
CREATE PROCEDURE DeleteMaterialsDetail
(
  @MenuID INT,
  @ComodityID INT
)
AS
BEGIN
  -- Kiểm tra tính hợp lệ của dữ liệu trước khi xóa
  IF EXISTS (SELECT * FROM MaterialsDetails WHERE MenuID = @MenuID AND ComodityID = @ComodityID)
  BEGIN
    DELETE FROM MaterialsDetails
    WHERE MenuID = @MenuID AND ComodityID = @ComodityID
  END
   else
  begin
    RAISERROR('error', 16, 1);
	end
END

go


--Crud lập phiếu nhập hàng
CREATE PROCEDURE ImportCoupon_Insert
(
  @Date DATE,
  @StaffID INT
)
AS
BEGIN
  INSERT INTO ImportCoupon (Date, StaffID)
  VALUES (@Date, @StaffID)
END

go
CREATE PROCEDURE ImportCoupon_Update
(
  @IDCoupon INT,
  @Date DATE,
  @StaffID INT
)
AS
BEGIN
  UPDATE ImportCoupon
  SET Date = @Date, StaffID = @StaffID
  WHERE IDCoupon = @IDCoupon;
END

go
CREATE PROCEDURE ImportCoupon_GetAll
AS
BEGIN
  SELECT IC.* , s.Name
  FROM ImportCoupon as  IC 
  Inner Join Staff as s  on IC.StaffID = s.StaffID
END
go
CREATE PROCEDURE ImportCoupon_Delete 
@id int 
AS 
Begin 
	Delete from ImportCoupon where IDCoupon = @id 
end
go
CREATE PROCEDURE GetImportCoupon
@id int
AS
BEGIN
  SELECT IC.* , s.Name
  FROM ImportCoupon as  IC 
  Inner Join Staff as s  on IC.StaffID = s.StaffID
  where 
  IC.IDCoupon = @id
END
go



--Crud chi tiết phiếu nhập hàng 
CREATE PROCEDURE CouponDetail_Insert
(
  @Number INT,
  @ComodityID INT,
  @IDCoupon INT
)
AS
BEGIN
  INSERT INTO CouponDetail (Number, ComodityID, IDCoupon)
  VALUES (@Number, @ComodityID, @IDCoupon)
END

CREATE PROCEDURE CouponDetail_Update
(
  @ComodityID INT,
  @IDCoupon INT,
  @Number INT
)
AS
BEGIN
  IF NOT EXISTS (SELECT * FROM CouponDetail WHERE ComodityID = @ComodityID AND IDCoupon = @IDCoupon)
  BEGIN
           RAISERROR('error', 16, 1);

  END

  IF NOT EXISTS (SELECT * FROM Commodity WHERE ComodityID = @ComodityID)
  BEGIN
          RAISERROR('error', 16, 1);

  END

  IF NOT EXISTS (SELECT * FROM ImportCoupon WHERE IDCoupon = @IDCoupon)
  BEGIN
           RAISERROR('error', 16, 1);

  END

  UPDATE CouponDetail
  SET Number = @Number
  WHERE ComodityID = @ComodityID AND IDCoupon = @IDCoupon
END
go
CREATE PROCEDURE CouponDetail_GetAll
@id int
AS
BEGIN
  SELECT CouponDetail.* , Commodity.Name
  FROM CouponDetail 
  inner join Commodity on Commodity.ComodityID = CouponDetail.ComodityID
  where 
  CouponDetail.IDCoupon = @id
END
go

Create Procedure CouponDetail_Delete 
@CouponId int ,
@ComodityId int
as 
begin 
	Delete from CouponDetail 
	where CouponDetail.ComodityID = @ComodityId and CouponDetail.IDCoupon = @CouponId
end

go



--crud xuất hàng 
CREATE PROCEDURE InsertExportOrder
    @Date date,
    @StaffID int
AS
BEGIN
    IF EXISTS(SELECT * FROM Staff WHERE StaffID = @StaffID)
    BEGIN
        INSERT INTO ExportOrders (Date, StaffID)
        VALUES (@Date, @StaffID)
    END
    ELSE
    BEGIN
        RAISERROR('Invalid StaffID', 16, 1)
    END
END
go

CREATE PROCEDURE GetExportOrder
    @ExportOrder int
AS
BEGIN
    SELECT *
    FROM ExportOrder
    WHERE ExportOrderID = @ExportOrder
END
go
CREATE PROCEDURE GetAllExportOrder
 
AS
BEGIN
    SELECT *
    FROM ExportOrder
  
END
go
CREATE PROCEDURE DeleteExportOrder
    @ExportOrder int
AS
BEGIN
   Delete
    FROM ExportOrder
    WHERE ExportOrderID = @ExportOrder
END
go

CREATE PROCEDURE UpdateExportOrder
    @ExportOrderID int,
    @Date date,
    @StaffID int
AS
BEGIN
    IF EXISTS(SELECT * FROM Staff WHERE StaffID = @StaffID)
    BEGIN
        UPDATE ExportOrder
        SET Date = @Date,
            StaffID = @StaffID
        WHERE ExportOrderID = @ExportOrderID
    END
    ELSE
    BEGIN
        RAISERROR('Invalid StaffID', 16, 1)
    END
END

go




--crud nhập hàng
CREATE PROCEDURE InsertImportOrder
    @Date date,
    @StaffID int
AS
BEGIN
    IF EXISTS(SELECT * FROM Staff WHERE StaffID = @StaffID)
    BEGIN
        INSERT INTO ImportOrders (Date, StaffID)
        VALUES (@Date, @StaffID)
    END
    ELSE
    BEGIN
        RAISERROR('Invalid StaffID', 16, 1)
    END
END
go
CREATE PROCEDURE GetImportOrder
    @ImportOrderID int
AS
BEGIN
    SELECT *
    FROM ImportOrders
    WHERE ImportOrderID = @ImportOrderID
END
go

CREATE PROCEDURE GetImportOrderAll
AS
BEGIN
    SELECT *
    FROM ImportOrders
END
go

CREATE PROCEDURE UpdateImportOrder
    @ImportOrderID int,
    @Date date,
    @StaffID int
AS
BEGIN
    IF EXISTS(SELECT * FROM Staff WHERE StaffID = @StaffID)
    BEGIN
        UPDATE ImportOrders
        SET Date = @Date,
            StaffID = @StaffID
        WHERE ImportOrderID = @ImportOrderID
    END
    ELSE
    BEGIN
        RAISERROR('Invalid StaffID', 16, 1)
    END
END
go
CREATE PROCEDURE DeleteImportOrder
    @ImportOrderID int
AS
BEGIN
    Delete
    FROM ImportOrders
    WHERE ImportOrderID = @ImportOrderID
END
go

--crud chi tiết nhập hàng
CREATE PROCEDURE InsertImportOrderDetail
    @Number float,
    @CommodityID int,
    @ImportOrderID int
AS
BEGIN
    IF EXISTS(SELECT * FROM Commodity WHERE ComodityID = @CommodityID)
    BEGIN
        IF EXISTS(SELECT * FROM ImportOrders WHERE ImportOrderID = @ImportOrderID)
        BEGIN
            INSERT INTO ImportOrdersDetails (Number, ComodityID, ImportOrderID)
            VALUES (@Number, @CommodityID, @ImportOrderID)
        END
        ELSE
        BEGIN
            RAISERROR('Invalid ExportOrderID', 16, 1)
        END
    END
    ELSE
    BEGIN
        RAISERROR('Invalid CommodityID', 16, 1)
    END
END
go
CREATE PROCEDURE GetImportOrderDetail
    @CommodityID int,
    @ImportOrderID int
AS
BEGIN
    SELECT *
    FROM ImportOrdersDetails
    WHERE ComodityID = @CommodityID AND ImportOrderID = @ImportOrderID
END
go
CREATE PROCEDURE UpdateImportOrdersDetail
    @Number float,
    @CommodityID int,
    @ImportOrderID int
AS
BEGIN
    IF EXISTS(SELECT * FROM Commodity WHERE ComodityID = @CommodityID)
    BEGIN
        IF EXISTS(SELECT * FROM ImportOrders WHERE ImportOrderID = @ImportOrderID)
        BEGIN
            UPDATE ImportOrdersDetails
            SET Number = @Number
            WHERE ComodityID = @CommodityID AND ImportOrderID = @ImportOrderID
        END
        ELSE
        BEGIN
            RAISERROR('Invalid ExportOrderID', 16, 1)
        END
    END
    ELSE
    BEGIN
        RAISERROR('Invalid CommodityID', 16, 1)
    END
END
go
Create Procedure GetImportOrderDetailAllByID 
    @ImportOrderID int
AS
BEGIN
    SELECT *
    FROM ImportOrdersDetails
    WHERE ImportOrderID = @ImportOrderID
END
go
CREATE PROCEDURE DeleteImportOrderDetail
    @CommodityID int,
    @ImportOrderID int
AS
BEGIN
    Delete
    FROM ImportOrdersDetails
    WHERE ComodityID = @CommodityID AND ImportOrderID = @ImportOrderID
END
go
--crud chi tiết xuất hàng
CREATE PROCEDURE GetExportOrderDetail
    @CommodityID int,
    @ExportOrderID int
AS
BEGIN
    SELECT *
    FROM ExportOrdersDetails
    WHERE ComodityID = @CommodityID AND ExportOrderID = @ExportOrderID
END
go
CREATE PROCEDURE GetExportOrderDetailALLByID
    
    @ExportOrderID int
AS
BEGIN
    SELECT *
    FROM ExportOrdersDetails
    WHERE  ExportOrderID = @ExportOrderID
END
go
CREATE PROCEDURE InsertExportOrderDetail
    @Number float,
    @CommodityID int,
    @ExportOrderID int
AS
BEGIN
    IF EXISTS(SELECT * FROM Commodity WHERE ComodityID = @CommodityID)
    BEGIN
        IF EXISTS(SELECT * FROM ExportOrders WHERE ExportOrderID = @ExportOrderID)
        BEGIN
            INSERT INTO ExportOrdersDetails (Number, ComodityID, ExportOrderID)
            VALUES (@Number, @CommodityID, @ExportOrderID)
        END
        ELSE
        BEGIN
            RAISERROR('Invalid ExportOrderID', 16, 1)
        END
    END
    ELSE
    BEGIN
        RAISERROR('Invalid CommodityID', 16, 1)
    END
END
go
CREATE PROCEDURE UpdateExportOrderDetail
    @Number float,
    @CommodityID int,
    @ExportOrderID int
AS
BEGIN
    IF EXISTS(SELECT * FROM Commodity WHERE ComodityID = @CommodityID)
    BEGIN
        IF EXISTS(SELECT * FROM ExportOrders WHERE ExportOrderID = @ExportOrderID)
        BEGIN
            UPDATE ExportOrdersDetails
            SET Number = @Number
            WHERE ComodityID = @CommodityID AND ExportOrderID = @ExportOrderID
        END
        ELSE
        BEGIN
            RAISERROR('Invalid ExportOrderID', 16, 1)
        END
    END
    ELSE
    BEGIN
        RAISERROR('Invalid CommodityID', 16, 1)
    END
END
go
CREATE PROCEDURE DeleteExportOrderDetail
    @CommodityID int,
    @ExportOrderID int
AS
BEGIN
	Delete
    FROM ExportOrdersDetails
    WHERE ComodityID = @CommodityID AND ExportOrderID = @ExportOrderID
END
go
---CRUD account 
-- CREATE
CREATE PROCEDURE CreateAccount
    @Username nvarchar(45),
    @Password nvarchar(45),
    @StaffID INT
AS
BEGIN
    INSERT INTO Account (Username, Password, StaffID)
    VALUES (@Username, @Password, @StaffID)
END
GO
-- get
CREATE PROCEDURE GetAccountByID
    @AccountID INT
AS
BEGIN
    SELECT Account.* , Staff.Name
    FROM Account 
	inner join Staff on Account.AccountID = Staff.StaffID
    WHERE AccountID = @AccountID
END
GO
---GET ALL
CREATE PROCEDURE GetAccounts
    
AS
BEGIN
    SELECT Account.* , Staff.Name
    FROM Account 
	inner join Staff on Account.AccountID = Staff.StaffID
END
GO
-- UPDATE
CREATE PROCEDURE UpdateAccount
    @AccountID INT,
    @Username nvarchar(45),
    @Password nvarchar(45),
    @StaffID INT
AS
BEGIN
    UPDATE Account
    SET Username = @Username,
        Password = @Password,
        StaffID = @StaffID
    WHERE AccountID = @AccountID
END
GO
-- DELETE
CREATE PROCEDURE DeleteAccount
    @AccountID INT
AS
BEGIN
    DELETE FROM Account
    WHERE AccountID = @AccountID
END
GO

---Allowance 
CREATE PROCEDURE InsertAllowance
  @Name nvarchar(45),
  @Description ntext,
  @Bonus float
AS
BEGIN
  INSERT INTO Allowance(Name, Description, Bonus)
  VALUES (@Name, @Description, @Bonus);
END
Go
CREATE PROCEDURE GetAllowanceById
  @AllowanceID int
AS
BEGIN
  SELECT *
  FROM Allowance
  WHERE AllowanceID = @AllowanceID;
END
GO
CREATE PROCEDURE GetAllAllowances
AS
BEGIN
  SELECT *
  FROM Allowance;
END
GO
CREATE PROCEDURE UpdateAllowance
  @AllowanceID int,
  @Name nvarchar(45),
  @Description ntext,
  @Bonus float
AS
BEGIN
  UPDATE Allowance
  SET Name = @Name,
      Description = @Description,
      Bonus = @Bonus
  WHERE AllowanceID = @AllowanceID;
END

go
CREATE PROCEDURE DeleteAllowance
  @AllowanceID int
AS
BEGIN
  DELETE FROM Allowance
  WHERE AllowanceID = @AllowanceID;
END
go

---ArrangeShift
CREATE PROCEDURE ArrangeShifts_Create
    @Date INT,
    @Status INT,
    @StaffID INT
AS
BEGIN
    INSERT INTO ArrangeShifts(Date, Status, StaffID)
    VALUES (@Date, @Status, @StaffID)
END
Go
CREATE PROCEDURE ArrangeShifts_getAll
AS
BEGIN
    SELECT * FROM ArrangeShifts
END

go
CREATE PROCEDURE ArrangeShifts_getByID
    @ArrangeShiftsID INT
AS
BEGIN
    SELECT * FROM ArrangeShifts
    WHERE ArrangeShifts = @ArrangeShiftsID
END

go
CREATE PROCEDURE ArrangeShifts_Update
    @ArrangeShiftsID INT,
    @Date INT,
    @Status INT,
    @StaffID INT
AS
BEGIN
    UPDATE ArrangeShifts
    SET Date = @Date,
        Status = @Status,
        StaffID = @StaffID
    WHERE ArrangeShifts = @ArrangeShiftsID
END

go
CREATE PROCEDURE ArrangeShifts_DeleteByID
    @ArrangeShiftsID INT
AS
BEGIN
    DELETE FROM ArrangeShifts
    WHERE ArrangeShifts = @ArrangeShiftsID
END
go

---FamilyRelationship
-- Insert
CREATE PROCEDURE InsertFamilyRelationship
    @Name nvarchar(45),
    @Relationship nvarchar(45),
    @Sex nvarchar(45),
    @StaffID int
AS
BEGIN
    INSERT INTO FamilyRelationship (Name, Relationship, Sex, StaffID)
    VALUES (@Name, @Relationship, @Sex, @StaffID);
END
GO

-- Update
CREATE PROCEDURE UpdateFamilyRelationship
    @FamilyRelationshipID int,
    @Name nvarchar(45),
    @Relationship nvarchar(45),
    @Sex nvarchar(45),
    @StaffID int
AS
BEGIN
    UPDATE FamilyRelationship
    SET Name = @Name,
        Relationship = @Relationship,
        Sex = @Sex,
        StaffID = @StaffID
    WHERE FamilyRelationshipID = @FamilyRelationshipID;
END
GO

-- Delete by ID
CREATE PROCEDURE DeleteFamilyRelationship
    @FamilyRelationshipID int
AS
BEGIN
    DELETE FROM FamilyRelationship
    WHERE FamilyRelationshipID = @FamilyRelationshipID;
END
GO

-- Select by ID
CREATE PROCEDURE GetFamilyRelationshipByID
    @FamilyRelationshipID int
AS
BEGIN
    SELECT *
    FROM FamilyRelationship
    WHERE FamilyRelationshipID = @FamilyRelationshipID;
END
GO
--- Select All
CREATE PROCEDURE GetAllFamilyRelationshipsByStaff
    @StaffID int
AS
BEGIN
    SELECT *
    FROM FamilyRelationship
	where StaffID = @StaffID
  
END
GO
---Insurance
CREATE PROCEDURE InsertInsurance
    @Name nvarchar(45),
    @Fee float,
    @StartDate date,
    @Status nvarchar(45)
AS
BEGIN
    INSERT INTO Insurance (Name, Fee, StartDate, Status)
    VALUES (@Name, @Fee, @StartDate, @Status)
END

go



CREATE PROCEDURE GetInsuranceByID
    @InsuranceID int
AS
BEGIN
    SELECT * FROM Insurance
    WHERE InsuranceID = @InsuranceID
END
go

CREATE PROCEDURE GetAllInsurances
   
AS
BEGIN
    SELECT * FROM Insurance
  
END
go

CREATE PROCEDURE UpdateInsurance
    @InsuranceID int,
    @Name nvarchar(45),
    @Fee float,
    @StartDate date,
    @Status nvarchar(45)
AS
BEGIN
    UPDATE Insurance
    SET Name = @Name, Fee = @Fee, StartDate = @StartDate, Status = @Status
    WHERE InsuranceID = @InsuranceID
END


go

CREATE PROCEDURE DeleteInsurance
    @InsuranceID int
AS
BEGIN
    DELETE FROM Insurance
    WHERE InsuranceID = @InsuranceID
END


----Crud Combo
go
---Procedure thêm Combo mới (Create)
CREATE PROCEDURE AddCombo
@Name NVARCHAR(45),
@Cost NVARCHAR(45),
@ImageURL NTEXT,
@Description NTEXT,
@ComboID INT OUTPUT
AS
BEGIN
INSERT INTO Combo (Name, Cost, ImageURL, Description, status)
OUTPUT INSERTED.ComboID
VALUES (@Name, @Cost, @ImageURL, @Description, 1)
END
go

---Procedure thêm món ăn vào DetailCombo (Create)
CREATE PROCEDURE AddMenuToCombo
@MenuID INT,
@ComboID INT,
@Number int
AS
BEGIN
INSERT INTO DetailCombo (MenuID, Id,Number)
VALUES (@MenuID, @ComboID,@Number)
END
Go

---Procedure lấy danh sách các Combo (get)
CREATE PROCEDURE GetCombosByStatus
@status int
AS
BEGIN
SELECT * FROM Combo WHERE status = @status
END
Go
CREATE PROCEDURE GetCombos
AS
BEGIN
SELECT * FROM Combo 
END
Go
Create Procedure UpdateStatusOfCombo 
@Status int,
@id int
AS 
begin 
Update Combo
Set status = @status 
where Id = @id
end
go
---Procedure lấy danh sách các món ăn trong Combo (get)
CREATE PROCEDURE GetMenusInCombo
@ComboID INT
AS
BEGIN
SELECT Menu.* FROM Menu
INNER JOIN DetailCombo ON Menu.MenuID = DetailCombo.MenuID
WHERE DetailCombo.Id = @ComboID
END
Go
---Procedure cập nhật thông tin Combo (Update)
CREATE PROCEDURE UpdateCombo
@ComboID INT,
@Name NVARCHAR(45),
@Cost NVARCHAR(45),
@ImageURL NTEXT,
@Description NTEXT
AS
BEGIN
UPDATE Combo
SET Name = @Name, Cost = @Cost, ImageURL = @ImageURL, Description = @Description
WHERE Id = @ComboID
END
Go
----Procedure xóa Combo (Delete)
CREATE PROCEDURE DeleteCombo
@ComboID INT
AS
BEGIN
DELETE FROM Combo WHERE Id = @ComboID
END
Go
----Procedure xóa món ăn khỏi Combo (Delete)
CREATE PROCEDURE RemoveMenuFromCombo
@MenuID INT,
@ComboID INT
AS
BEGIN
DELETE FROM DetailCombo WHERE MenuID = @MenuID AND Id = @ComboID
END



----- CRUD Tembill
--- Mô tả : Đối với Status Temp Bill status bằng 0 nghĩa là chia được thanh toán 1 là đã thanh toán 
---Còn đối với TempBillDetails status bằng 0 nghĩa là đã xác nhận món xong 0 là chưa xác nhận món
---Procedure Thêm Chi tiết bill
CREATE PROCEDURE InsertTempBillDetails
    @TempBillId INT,
    @MenuID INT,
    @Number INT,
    @Price FLOAT,
    @Status BIT
AS
BEGIN
    INSERT INTO TempBillDetails (TempBillId, MenuID, Number, Price, Status)
    VALUES (@TempBillId, @MenuID, @Number, @Price, @Status)
END

Go
---Procedure Thêm TempBill
CREATE PROCEDURE InsertTempBill
    @CustomerId INT,
    @Status BIT,
    @Price FLOAT
AS
BEGIN
    INSERT INTO TempBill (CustomerId, Status, Price)
    VALUES (@CustomerId, @Status, @Price)
END
GO
---Update TempBill 
CREATE PROCEDURE UpdateTempBill
    @Id INT,
    @CustomerId INT,
    @Status BIT,
    @Price FLOAT
AS
BEGIN
    UPDATE TempBill
    SET CustomerId = @CustomerId,
        Status = @Status,
        Price = @Price
    WHERE Id = @Id
END

Go
----Update TempBillDetails
CREATE PROCEDURE UpdateTempBillDetails
    @TempBillId INT,
    @MenuID INT,
    @Number INT,
    @Price FLOAT,
    @Status BIT
AS
BEGIN
    UPDATE TempBillDetails
    SET Number = @Number,
        Price = @Price,
        Status = @Status
    WHERE TempBillId = @TempBillId AND MenuID = @MenuID
END
GO
---Delete TempBill
CREATE PROCEDURE DeleteTempBill
    @Id INT
AS
BEGIN
    DELETE FROM TempBill WHERE Id = @Id
END
GO
---Delete TempBillDetails
CREATE PROCEDURE DeleteTempBillDetails
    @TempBillId INT,
    @MenuID INT
AS
BEGIN
    DELETE FROM TempBillDetails WHERE TempBillId = @TempBillId AND MenuID = @MenuID
END
GO
---Get
Create Procedure GetTempBill
@Token varchar(45),
@CustomerID int 
AS 
	Begin 
		Select * from TempBill where Token = @Token and CustomerId = @CustomerId
	End

Go 
Create Procedure GetAllTempBillDetailsOfTempBill
@Id  int 
AS 
	Begin 
		Select * from TempBillDetails where TempBillId = @Id
	End
----PayRoll
GO

CREATE PROCEDURE InsertPayroll
(
@TimeHourW FLOAT,
@NDAYOFF INT,
@Bonus FLOAT,
@Overtime FLOAT,
@TotalSalary FLOAT,
@Tax FLOAT,
@SocialInsurance FLOAT,
@Unionfee FLOAT,
@Date DATE,
@NDAYW INT,
@StaffID INT,
@TimekeepingID INT
)
AS
BEGIN
INSERT INTO Payroll(TimeHourW, NDAYOFF, Bonus, Overtime, TotalSalary, Tax, SocialInsurance, Unionfee, Date, NDAYW, StaffID, TimekeepingID)
VALUES (@TimeHourW, @NDAYOFF, @Bonus, @Overtime, @TotalSalary, @Tax, @SocialInsurance, @Unionfee, @Date, @NDAYW, @StaffID, @TimekeepingID);
END
GO
CREATE PROCEDURE GetPayrollByID
(
@PayrollID INT
)
AS
BEGIN
SELECT * FROM Payroll WHERE PayrollID = @PayrollID;
END
Go
CREATE PROCEDURE GetPayroll

AS
BEGIN
SELECT * FROM Payroll 
END
Go
CREATE PROCEDURE UpdatePayroll
(
@PayrollID INT,
@TimeHourW FLOAT,
@NDAYOFF INT,
@Bonus FLOAT,
@Overtime FLOAT,
@TotalSalary FLOAT,
@Tax FLOAT,
@SocialInsurance FLOAT,
@Unionfee FLOAT,
@Date DATE,
@NDAYW INT,
@StaffID INT,
@TimekeepingID INT
)
AS
BEGIN
UPDATE Payroll
SET TimeHourW = @TimeHourW,
NDAYOFF = @NDAYOFF,
Bonus = @Bonus,
Overtime = @Overtime,
TotalSalary = @TotalSalary,
Tax = @Tax,
SocialInsurance = @SocialInsurance,
Unionfee = @Unionfee,
Date = @Date,
NDAYW = @NDAYW,
StaffID = @StaffID,
TimekeepingID = @TimekeepingID
WHERE PayrollID = @PayrollID;
END
GO
CREATE PROCEDURE DeletePayroll
(
@PayrollID INT
)
AS
BEGIN
DELETE FROM Payroll WHERE PayrollID = @PayrollID;
END
GO

---- SocialInsurance
CREATE PROCEDURE dbo.CreateSocialInsurance
@StartDateSI DATE,
@EndDateSI DATE,
@CodeSI INT,
@StartDateHI DATE,
@EndDateHI DATE,
@StaffID INT
AS
BEGIN
INSERT INTO SocialInsurance (StartDateSI, EndDateSI, CodeSI, StartDateHI, EndDateHI, StaffID)
VALUES (@StartDateSI, @EndDateSI, @CodeSI, @StartDateHI, @EndDateHI, @StaffID);
End

go
CREATE PROCEDURE dbo.getSocialInsuranceByID

@SocialInsuranceID INT
AS
BEGIN
SELECT * FROM SocialInsurance WHERE id = @SocialInsuranceID;
END
go

CREATE PROCEDURE dbo.getSocialInsurances

AS
BEGIN
SELECT * FROM SocialInsurance
END
go

CREATE PROCEDURE dbo.UpdateSocialInsurance
@SocialInsuranceID INT,
@StartDateSI DATE,
@EndDateSI DATE,
@CodeSI INT,
@StartDateHI DATE,
@EndDateHI DATE,
@StaffID INT
AS
BEGIN
UPDATE SocialInsurance
SET StartDateSI = @StartDateSI, EndDateSI = @EndDateSI, CodeSI = @CodeSI, StartDateHI = @StartDateHI, EndDateHI = @EndDateHI, StaffID = @StaffID
WHERE id = @SocialInsuranceID;
END
go


CREATE PROCEDURE dbo.DeleteSocialInsurance
@SocialInsuranceID INT
AS
BEGIN
DELETE FROM SocialInsurance WHERE id = @SocialInsuranceID;
END
go
----Promotion
CREATE PROCEDURE InsertPromotion
@Name nvarchar(50),
@Discount FLOAT,
@Description ntext,
@Starttime DATE,
@EndTime DATE
AS
BEGIN
INSERT INTO Promotion (Name, Discount, Description, Starttime, EndTime)
VALUES (@Name, @Discount, @Description, @Starttime, @EndTime);
END;


go
CREATE PROCEDURE UpdatePromotion
@PromotionID INT,
@Name nvarchar(50),
@Discount FLOAT,
@Description ntext,
@Starttime DATE,
@EndTime DATE
AS
BEGIN
UPDATE Promotion
SET Name = @Name, Discount = @Discount, Description = @Description, Starttime = @Starttime, EndTime = @EndTime
WHERE PromotionID = @PromotionID;
END;
go
CREATE PROCEDURE DeletePromotion
@PromotionID INT
AS
BEGIN
DELETE FROM Promotion
WHERE PromotionID = @PromotionID;
END;
go
CREATE PROCEDURE GetPromotionByID
@PromotionID INT
AS
BEGIN
SELECT *
FROM Promotion
WHERE PromotionID = @PromotionID;
END;
go
CREATE PROCEDURE GetAllPromotions
AS
BEGIN
SELECT *
FROM Promotion;
END;
go

----- PromotionForLevel 
CREATE PROCEDURE AddPromotionDetailForLevel
  @Description ntext,
  @LevelID INT,
  @PromotionID INT
AS
BEGIN
  INSERT INTO PromotionDetailForLevel (Description, LevelID, PromotionID)
  VALUES (@Description, @LevelID, @PromotionID);
END
go
CREATE PROCEDURE UpdatePromotionDetailForLevel
  @Description ntext,
  @LevelID INT,
  @PromotionID INT
AS
BEGIN
  UPDATE PromotionDetailForLevel
  SET Description = @Description
  WHERE LevelID = @LevelID AND PromotionID = @PromotionID;
END
go

CREATE PROCEDURE DeletePromotionDetailForLevel
  @LevelID INT,
  @PromotionID INT
AS
BEGIN
  DELETE FROM PromotionDetailForLevel
  WHERE LevelID = @LevelID AND PromotionID = @PromotionID;
END
go

CREATE PROCEDURE GetAllPromotionDetailForLevel
@id int
AS
BEGIN
  SELECT * FROM PromotionDetailForLevel where LevelID = @id;
END

go
---Request 
CREATE PROCEDURE AddRequest
    @Date DATE,
    @Description INT,
    @StaffID INT,
    @RequestTypeID INT,
    @Status INT
AS
BEGIN
    INSERT INTO Requets (Date, Description, StaffID, RequestTypeID, Status)
    VALUES (@Date, @Description, @StaffID, @RequestTypeID, @Status);
END
go
----
CREATE PROCEDURE UpdateRequest
    @RequestID INT,
    @Date DATE,
    @Description INT,
    @StaffID INT,
    @RequestTypeID INT,
    @Status INT
AS
BEGIN
    UPDATE Requets
    SET Date = @Date,
        Description = @Description,
        StaffID = @StaffID,
        RequestTypeID = @RequestTypeID,
        Status = @Status
    WHERE RequestID = @RequestID;
END
go

CREATE PROCEDURE DeleteRequest
    @RequestID INT
AS
BEGIN
    DELETE FROM Requets
    WHERE RequestID = @RequestID;
END

go
CREATE PROCEDURE GetAllRequests
AS
BEGIN
    SELECT * FROM Requets;
END
go
CREATE PROCEDURE GetRequestByID
@id int
AS
BEGIN
    SELECT * FROM Requets where RequestID = @id;
END
go
----RequestType
CREATE PROCEDURE CreateRequestType
  @Name NVARCHAR(50),
  @MaxNumber NVARCHAR(50),
  @Description NTEXT
AS
BEGIN
  INSERT INTO RequestType (Name, MaxNumber, Description)
  VALUES (@Name, @MaxNumber, @Description)
END
GO
CREATE PROCEDURE getRequestType
  @RequestTypeID INT
AS
BEGIN
  SELECT * FROM RequestType WHERE RequestTypeID = @RequestTypeID
END
GO
CREATE PROCEDURE getAllRequestType
  
AS
BEGIN
  SELECT * FROM RequestType 
END
GO
CREATE PROCEDURE UpdateRequestType
  @RequestTypeID INT,
  @Name NVARCHAR(50),
  @MaxNumber NVARCHAR(50),
  @Description NTEXT
AS
BEGIN
  UPDATE RequestType
  SET Name = @Name, MaxNumber = @MaxNumber, Description = @Description
  WHERE RequestTypeID = @RequestTypeID
END
GO
CREATE PROCEDURE DeleteRequestType
  @RequestTypeID INT
AS
BEGIN
  DELETE FROM RequestType WHERE RequestTypeID = @RequestTypeID
END
GO





---Timekeeping
CREATE PROCEDURE CreateTimekeepingSum
    @ActualWT FLOAT,
    @Date DATE,
    @TheCalendarWT FLOAT,
    @Deduction INT,
    @Locked INT,
    @DateLocked BIT,
    @OverTime FLOAT,
    @StaffID INT,
    @ArrangeShifts INT
AS
BEGIN
    INSERT INTO TimekeepingSum (ActualWT, Date, TheCalendarWT, Deduction, Locked, DateLocked, OverTime, StaffID, ArrangeShifts)
    VALUES (@ActualWT, @Date, @TheCalendarWT, @Deduction, @Locked, @DateLocked, @OverTime, @StaffID, @ArrangeShifts)
    SELECT SCOPE_IDENTITY() AS TimekeepingID
END



go
CREATE PROCEDURE UpdateTimekeepingSum
    @TimekeepingID INT,
    @ActualWT FLOAT,
    @Date DATE,
    @TheCalendarWT FLOAT,
    @Deduction INT,
    @Locked INT,
    @DateLocked BIT,
    @OverTime FLOAT,
    @StaffID INT,
    @ArrangeShifts INT
AS
BEGIN
    UPDATE TimekeepingSum
    SET ActualWT = @ActualWT,
        Date = @Date,
        TheCalendarWT = @TheCalendarWT,
        Deduction = @Deduction,
        Locked = @Locked,
        DateLocked = @DateLocked,
        OverTime = @OverTime,
        StaffID = @StaffID,
        ArrangeShifts = @ArrangeShifts
    WHERE TimekeepingID = @TimekeepingID
END

go
CREATE PROCEDURE DeleteTimekeepingSum
    @TimekeepingID INT
AS
BEGIN
    DELETE FROM TimekeepingSum WHERE TimekeepingID = @TimekeepingID
END

go
CREATE PROCEDURE GetTimekeepingSum
    @TimekeepingID INT
AS
BEGIN
    SELECT * FROM TimekeepingSum WHERE TimekeepingID = @TimekeepingID
END

go
CREATE PROCEDURE GetAllTimekeepings

AS
BEGIN
    SELECT * FROM TimekeepingSum 
END

go


------Search and getByName


---- Account 
Create Procedure searchAccount 
@key nvarchar(45)
AS 
Begin 
	Select * from Account where Username like @key 
End 

go 
Create Procedure getAccountByName 
@Username nvarchar(45)
AS 
Begin 
	Select * from Account where Username = @Username 
End 

go
---Combo 

Create procedure searchCombo 
@key nvarchar(45) 
AS 
begin 
	Select * from Combo where Name like  @key
end 
go
Create procedure getComboByName 
@name  nvarchar(45) 
AS 
begin 
	Select * from Combo where Name = @name
end 


go 

----Commodity 
Create procedure searchCommodity 
@key nvarchar(45) 
as 
	begin 
		Select * from Combo where Name like @key 
	end 
go
Create procedure getCommodityByName
@name nvarchar(45) 
as 
	begin 
		Select * from Combo where Name = @name
	end 
go 

Create procedure searchCustomer 
@key nvarchar(45) 
as 
	begin 
		Select * from Customers where Name like @key 
	end
go 

Create procedure getCustomerByName 
@name nvarchar(45)
as 
	begin 
		select * from Customers where Name = @name
	end
go
---Department
Create procedure getDepartmentByName 
@name nvarchar(45) 
as	
	begin 
		Select * from Department where Name = @name
	end 

go 
---KindFod
Create procedure getKindFoodByName 
@name nvarchar(45)
as 
	begin 
		Select * from KindFood where Name	= @name 
	end 
go
---Menu 

Create procedure searchMenu 
@key nvarchar(45) 
as 
	begin 
		Select * from Menu where Name like  @key 
	end 

go
Create procedure getMenuByName 
@name nvarchar(45) 
as 
	begin 
		Select * from Menu where Name  = @name 
	end 
go

----
create procedure searchImportCoupon 
@key nvarchar(45) 
as 
	begin 
		Select ImportCoupon.* from ImportCoupon inner join Staff on ImportCoupon.StaffID = Staff.StaffID
		where Staff.Name like @key
	end
go
create procedure searchImportOrder
@key nvarchar(45) 
as 
	begin 
		Select ImportOrders.* from ImportOrders inner join Staff on ImportOrders.StaffID = Staff.StaffID
		where Staff.Name like @key
	end
go
create procedure searchExportOrder
@key nvarchar(45) 
as 
	begin 
		Select ExportOrders.* from ExportOrders inner join Staff on ExportOrders.StaffID = Staff.StaffID
		where Staff.Name like @key
	end
go
---Promotion 

Create procedure SearchPromotion
 @key nvarchar(45)
 as
	begin 
		select * from Promotion where Name like @key
	end 
go
Create procedure GetPromotionByName
 @name nvarchar(45)
 as
	begin 
		select * from Promotion where Name =  @name
	end 
go
----Staff

Create procedure SearchStaff
@key nvarchar(45) 
as 
	begin 
		select * from Staff where Name like @key
	end
go
Create procedure getStaffByName
@name nvarchar(45) 
as 
	begin 
		select * from Staff where Name = @name
	end