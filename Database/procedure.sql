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
    IF NOT EXISTS (SELECT * FROM Customers WHERE phone = @phone)
    BEGIN
        INSERT INTO Customers (name, phone, address, password, point, levelid)
        VALUES (@name, @phone, @address, @password, 0, 1)
        SELECT *, '1' as Result
        FROM Customers 
        WHERE Phone = @phone
    END
    ELSE
    BEGIN
        SELECT '0' AS Result
    END
END


GO
EXEC AddCustomer N'Nguyễn Văn A', '0854512355', '123 Street, HCM City', '123456'

EXEC CheckLogin '0854512355', '123456'
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
drop PROCEDURE room_delete
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
EXEC Room_Insert N'Phòng Lẩu', N'Phòng có chức năng chính là phục vụ các món lẩu'
EXEC Room_Insert N'Phòng Hải Sản', N'Phòng có chức năng chính là phục vụ các món hải sản'
EXEC Room_Insert N'Phòng Ăn Vặt', N'Phòng có chức năng chính là phục vụ các món ăn vặt và làm đồ ăn cho nhân viên'
EXEC Room_Insert N'Phòng Chuyên Dụng', N'Phòng có chức năng chính là phục vụ các món nước ép và fill gia vị'
EXEC Room_Insert N'Phòng Nước', N'Phòng có chức năng chính là phục vụ các món nước đóng chai rượu bia các thứ'
EXEC Room_Insert N'Phòng Lên món', N'Phòng có chức năng chính là phục vụ các món chính trong nhà hàng'
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
EXEC KindFood_Insert N'ĂN Vặt', N'Các món ăn vặt'
EXEC KindFood_Insert N'Món Thịt', N'Các món thịt'
EXEC KindFood_Insert N'Lẩu', N'Các món lẩu'
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
EXEC Level_Insert N'Cấp độ bạc', N'Đạt số tiền từ 0 - 10000000', 0
EXEC Level_Insert N'Cấp độ vàng', N'Đạt số tiền từ 10000000 - 30000000', 10000000




--crud monan
CREATE PROCEDURE sp_add_menu
    @name NVARCHAR(50),
    @price INT,
    @point INT,
    @url_image VARCHAR(MAX),
    @kind_food_id INT,
    @room_id INT,
    @status int
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM KindFood WHERE KindFoodid = @kind_food_id)
    BEGIN
        RAISERROR('Kind food does not exist.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM room WHERE roomid = @room_id)
    BEGIN
        RAISERROR('Room does not exist.', 16, 1);
        RETURN;
    END

    INSERT INTO Menu(name, price, point, urlimage, kindfoodid, roomid,status)
    VALUES (@name, @price, @point, @url_image, @kind_food_id, @room_id, @status);
END
EXEC change_status 1,0;
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
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT * FROM Menu WHERE Menuid = @id)
    BEGIN
        RAISERROR('Food does not exist.', 16, 1);
        RETURN;
    END

    IF EXISTS (SELECT * FROM detailcombo WHERE MenuID = @id)
    BEGIN
        RAISERROR('Cannot delete this food item as it is used in a combo.', 16, 1);
        RETURN;
    END
	 IF EXISTS (SELECT * FROM MaterialsDetails WHERE MenuID = @id)
    BEGIN
        RAISERROR('Cannot delete this food item as it is used in a combo.', 16, 1);
        RETURN;
    END

    DELETE FROM Menu WHERE MenuID = @id;
END
GO
Create proc sp_getAll_Menu
as 
begin
	Select * from Menu
end
GO
EXEC sp_getAll_Menu
GO
CREATE PROCEDURE sp_getMenuByID
	@ID INT
AS
BEGIN
	Select * from Menu where @ID=MenuID
END
GO
EXEC sp_getMenuByID 1
--Thay đổi trạng thái món ăn
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
EXEC change_status 1,0
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
CREATE PROCEDURE [dbo].[GetDepartments]
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
EXEC CreateDepartment @Name = 'HR', @Description = 'Human Resources Department'

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

EXEC InsertPosition 'Manager', 'Quản lý phòng kinh doanh', 1

---crud shift
CREATE PROCEDURE sp_CreateShift
  @Name nvarchar(45),
  @StartTime DATE,
  @EndTime DATE
AS
BEGIN
  INSERT INTO Shift(Name, StartTime, EndTime)
  VALUES(@Name, @StartTime, @EndTime);
END
go
CREATE PROCEDURE sp_GetShift
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
  IF EXISTS(SELECT * FROM Shift WHERE ShiftID = @ShiftID)
  BEGIN
    IF NOT EXISTS(SELECT * FROM Staff WHERE ShiftID = @ShiftID)
    BEGIN
      UPDATE Shift
      SET Name = @Name, StartTime = @StartTime, EndTime = @EndTime
      WHERE ShiftID = @ShiftID;
    END
    ELSE
    BEGIN
      RAISERROR ('Cannot update this shift because there are still staffs assigned to it.', 16, 1);
    END
  END
  ELSE
  BEGIN
    RAISERROR ('ShiftID not found.', 16, 1);
  END
END
go
CREATE PROCEDURE sp_DeleteShift
  @ShiftID INT
AS
BEGIN
  IF EXISTS(SELECT * FROM Shift WHERE ShiftID = @ShiftID)
  BEGIN
    IF NOT EXISTS(SELECT * FROM Staff WHERE ShiftID = @ShiftID)
    BEGIN
      DELETE FROM Shift
      WHERE ShiftID = @ShiftID;
    END
    ELSE
    BEGIN
      RAISERROR ('Cannot delete this shift because there are still staffs assigned to it.', 16, 1);
    END
  END
  ELSE
  BEGIN
    RAISERROR ('ShiftID not found.', 16, 1);
  END
END
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
    -- Check if the position and shift exist
    IF NOT EXISTS (SELECT * FROM Position WHERE PositionID = @PositionID)
        BEGIN
            RAISERROR ('Invalid position ID.', 16, 1);
            RETURN;
        END
    IF NOT EXISTS (SELECT * FROM Shift WHERE ShiftID = @ShiftID)
        BEGIN
            RAISERROR ('Invalid shift ID.', 16, 1);
            RETURN;
        END
        
 
    IF EXISTS (SELECT * FROM Staff WHERE Name = @Name AND DateOfBirth = @DateOfBirth)
        BEGIN
            RAISERROR ('A staff member with this name and date of birth already exists.', 16, 1);
            RETURN;
        END
    
  
    INSERT INTO Staff (Name, DateOfBirth, Nationality, Phone, IdentityCard, DateIdentityCard, PlaceIdentityCard,
        CurrentAddress, PermanentAddress, BankID, NameBank, Salary, Sex, Status, URLImage, PositionID, ShiftID)
    VALUES (@Name, @DateOfBirth, @Nationality, @Phone, @IdentityCard, @DateIdentityCard, @PlaceIdentityCard,
        @CurrentAddress, @PermanentAddress, @BankID, @NameBank, @Salary, @Sex, @Status, @URLImage, @PositionID, @ShiftID);
    
    SELECT @@IDENTITY as StaffID;
END

EXEC InsertStaff 
	@Name = 'John Doe',
	@Dateofbirth = '1990-01-01',
	@Nationality = 'American',
	@Phone = '1234567890',
	@identityCard = 'ABC123',
	@DateIdentityCard = '2010-01-01',
	@PlaceidentityCard = 'New York',
	@CurrentAddress = '123 Main St',
	@PermanentAddress = '123 Elm St',
	@BankID = '1234567890',
	@NameBank = 'Bank of America',
	@Salary = 5000,
	@Sex = 'Male',
	@Status = 'Active',
	@URLImage = 'https://example.com/image.png',
	@PositionID = 1,
	@ShiftID = 1;


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
    IF NOT EXISTS (SELECT * FROM Staff WHERE StaffID = @StaffID)
    BEGIN
        RAISERROR('The StaffID does not exist.', 16, 1)
        RETURN
    END

    IF NOT EXISTS (SELECT * FROM Position WHERE PositionID = @PositionID)
    BEGIN
        RAISERROR('The PositionID does not exist.', 16, 1)
        RETURN
    END

    IF NOT EXISTS (SELECT * FROM Shift WHERE ShiftID = @ShiftID)
    BEGIN
        RAISERROR('The ShiftID does not exist.', 16, 1)
        RETURN
    END

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
--lưu thông tin lịch sử giao dịch
CREATE PROCEDURE insert_transaction
    @TotalPrice FLOAT,
    @Date DATE,
    @CustormerID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem khóa ngoại CustormerID đã tồn tại trong bảng Customers hay chưa
    IF NOT EXISTS (SELECT 1 FROM Customers WHERE CustormerID = @CustormerID)
    BEGIN
        RAISERROR('Khóa ngoại CustormerID không hợp lệ', 16, 1)
        RETURN
    END
    
    -- Kiểm tra xem giá trị TotalPrice có lớn hơn 0 hay không
    IF @TotalPrice <= 0
    BEGIN
        RAISERROR('Giá trị TotalPrice không hợp lệ', 16, 1)
        RETURN
    END
    
    -- Thêm bản ghi vào bảng Transactions
    INSERT INTO Transactions (TotalPrice, Date, CustormerID)
    VALUES (@TotalPrice, @Date, @CustormerID)
END
go

--lưu thông tin chi tiết lịch sử giao dịch

CREATE PROCEDURE sp_InsertTransactionDetail
(
  @Number INT,
  @Price FLOAT,
  @TransactionID INT,
  @MenuID INT
)
AS
BEGIN
  -- Kiểm tra khóa ngoại
  IF NOT EXISTS(SELECT 1 FROM Transactions WHERE TransactionID = @TransactionID)
  BEGIN
    RAISERROR('Invalid TransactionID', 16, 1)
    RETURN
  END

  IF NOT EXISTS(SELECT 1 FROM Menu WHERE MenuID = @MenuID)
  BEGIN
    RAISERROR('Invalid MenuID', 16, 1)
    RETURN
  END

  -- Thực hiện insert
  INSERT INTO TransactionDetail (Number, Price, TransactionID, MenuID)
  VALUES (@Number, @Price, @TransactionID, @MenuID)
END

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
CREATE PROCEDURE read_unit
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

CREATE PROCEDURE CreateCommodity
    @Name NVARCHAR(45),
    @Number FLOAT,
    @Description NTEXT,
    @UnitID INT
AS
BEGIN


    IF NOT EXISTS (SELECT * FROM Unit WHERE UnitID = @UnitID)
    BEGIN
        RAISERROR('Unit does not exist', 16, 1);
        RETURN;
    END

    INSERT INTO Commodity (Name, Number, Description, UnitID)
    VALUES (@Name, @Number, @Description, @UnitID);

    SELECT SCOPE_IDENTITY() AS CommodityID;
END
go
CREATE PROCEDURE ReadCommodity
    @CommodityID INT
AS
BEGIN
    

    SELECT c.ComodityID, c.Name, c.Number, c.Description, u.Name AS UnitName
    FROM Commodity c
    INNER JOIN Unit u ON c.UnitID = u.UnitID
    WHERE c.ComodityID = @CommodityID;
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
   

    IF NOT EXISTS (SELECT * FROM Unit WHERE UnitID = @UnitID)
    BEGIN
        RAISERROR('Unit does not exist', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM Commodity WHERE ComodityID = @CommodityID)
    BEGIN
        RAISERROR('Commodity does not exist', 16, 1);
        RETURN;
    END

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
  -- Kiểm tra tính hợp lệ của dữ liệu trước khi thêm
  IF EXISTS (SELECT * FROM Menu WHERE MenuID = @MenuID)
  AND EXISTS (SELECT * FROM Commodity WHERE ComodityID = @ComodityID)
  BEGIN
    INSERT INTO MaterialsDetails(Number, MenuID, ComodityID) 
    VALUES (@Number, @MenuID, @ComodityID)
  END
  else
  begin
    RAISERROR('error', 16, 1);
	end
END
go
CREATE PROCEDURE GetMaterialsDetails
AS
BEGIN
  SELECT * FROM MaterialsDetails
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
  -- Kiểm tra tính hợp lệ của dữ liệu trước khi cập nhật
  IF EXISTS (SELECT * FROM Menu WHERE MenuID = @MenuID)
  AND EXISTS (SELECT * FROM Commodity WHERE ComodityID = @ComodityID)
  BEGIN
    UPDATE MaterialsDetails 
    SET Number = @Number
    WHERE MenuID = @MenuID AND ComodityID = @ComodityID
  END
   else
  begin
    RAISERROR('error', 16, 1);
	end
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


--Cru lập phiếu nhập hàng
CREATE PROCEDURE ImportCoupon_Insert
(
  @Date DATE,
  @StaffID INT
)
AS
BEGIN
  IF NOT EXISTS (SELECT * FROM Staff WHERE StaffID = @StaffID)
  BEGIN
  
    RAISERROR('error', 16, 1);
	
  END

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
  IF NOT EXISTS (SELECT * FROM ImportCoupon WHERE IDCoupon = @IDCoupon)
  BEGIN
       RAISERROR('error', 16, 1);

  END

  IF NOT EXISTS (SELECT * FROM Staff WHERE StaffID = @StaffID)
  BEGIN
       RAISERROR('error', 16, 1);

  END

  UPDATE ImportCoupon
  SET Date = @Date, StaffID = @StaffID
  WHERE IDCoupon = @IDCoupon
END
go
CREATE PROCEDURE sp_ImportCoupon_GetAll
AS
BEGIN
  SELECT IDCoupon, Date, StaffID
  FROM ImportCoupon
END
go

--Cru chi tiết phiếu nhập hàng 
CREATE PROCEDURE sp_CouponDetail_Insert
(
  @Number INT,
  @ComodityID INT,
  @IDCoupon INT
)
AS
BEGIN
  IF NOT EXISTS (SELECT * FROM Commodity WHERE ComodityID = @ComodityID)
  BEGIN
          RAISERROR('error', 16, 1);

  END

  IF NOT EXISTS (SELECT * FROM ImportCoupon WHERE IDCoupon = @IDCoupon)
  BEGIN
         RAISERROR('error', 16, 1);

  END

  INSERT INTO CouponDetail (Number, ComodityID, IDCoupon)
  VALUES (@Number, @ComodityID, @IDCoupon)
END
CREATE PROCEDURE sp_CouponDetail_Update
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
CREATE PROCEDURE sp_CouponDetail_GetAll
AS
BEGIN
  SELECT Number, ComodityID, IDCoupon
  FROM CouponDetail
END
--cru xuất hàng 
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
--cru nhập hàng
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
EXEC GetImportOrderAll;
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
CREATE PROCEDURE GetExportOrderDetail
    @CommodityID int,
    @ExportOrderID int
AS
BEGIN
    SELECT *
    FROM ExportOrdersDetails
    WHERE ComodityID = @CommodityID AND ExportOrderID = @ExportOrderID
END

--crud chi tiết xuất hàng
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
CREATE PROCEDURE GetExportOrderDetail
    @CommodityID int,
    @ExportOrderID int
AS
BEGIN
    SELECT *
    FROM ExportOrdersDetails
    WHERE ComodityID = @CommodityID AND ExportOrderID = @ExportOrderID
END
GO
CREATE PROCEDURE GetExportOrderAll
AS
BEGIN
    SELECT *
    FROM ExportOrders
END
go
