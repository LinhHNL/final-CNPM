INSERT INTO Room (Name, Description) VALUES ('Room 101', 'A deluxe room with a king-size bed and a balcony with a view of the sea');
INSERT INTO Room (Name, Description) VALUES ('Room 102', 'A standard room with two twin beds and a city view');

INSERT INTO KindFood (Name, Description) VALUES ('Appetizer', 'Small dishes served before the main course');
INSERT INTO KindFood (Name, Description) VALUES ('Entree', 'The main course of a meal');
INSERT INTO KindFood (Name, Description) VALUES ('Dessert', 'Sweet dishes served at the end of a meal');

INSERT INTO Level (Name, Description, condition)
VALUES ('Beginner', 'This level is designed for people who are new to the subject and have no prior experience.', 0.2),
('Intermediate', 'This level is designed for people who have some knowledge and experience in the subject.', 0.5),
('Advanced', 'This level is designed for people who have a deep understanding of the subject and extensive experience.', 0.8),
('Expert', 'This level is designed for people who are highly skilled and knowledgeable in the subject and can handle complex problems.', 0.9);

INSERT INTO Customers (Name, Phone, Address, Password, Point, LevelID)
VALUES ('John Doe', '01234567890', '123 Main St', 'password123', 100, 1);

INSERT INTO Customers (Name, Phone, Address, Password, Point, LevelID)
VALUES ('Jane Smith', '09876543210', '456 Oak Ave', 'mypassword', 200, 2);

INSERT INTO Customers (Name, Phone, Address, Password, Point, LevelID)
VALUES ('Bob Johnson', '03456789123', '789 Maple Dr', 'password456', 50, 1);

INSERT INTO Customers (Name, Phone, Address, Password, Point, LevelID)
VALUES ('Alice Lee', '07654321980', '321 Pine Rd', 'letmein', 300, 3);

INSERT INTO Customers (Name, Phone, Address, Password, Point, LevelID)
VALUES ('Tom Wilson', '09871234567', '654 Cedar Blvd', 'password789', 75, 1);


INSERT INTO Menu (Name, Price, Point, URLImage, KindFoodID, RoomID, status)
VALUES
('Burger', 5.99, 5, 'https://example.com/burger.jpg', 1, 1, 1),
('Pizza', 8.99, 7, 'https://example.com/pizza.jpg', 2, 2, 1),
('Spaghetti', 7.99, 6, 'https://example.com/spaghetti.jpg', 2, 1, 1),
('Sushi', 10.99, 8, 'https://example.com/sushi.jpg', 3, 2, 1),
('Fried Rice', 6.99, 5, 'https://example.com/friedrice.jpg', 1, 2, 1),
('Salmon', 12.99, 10, 'https://example.com/salmon.jpg', 3, 1, 1),
('Tacos', 7.99, 6, 'https://example.com/tacos.jpg', 2, 2, 1),
('Pho', 5.99, 5, 'https://example.com/pho.jpg', 1, 1, 1),
('Chicken Alfredo', 8.99, 7, 'https://example.com/chickenalfredo.jpg', 2, 2, 1),
('Steak', 13.99, 11, 'https://example.com/steak.jpg', 3, 1, 1);

INSERT INTO TempBill (CustomerId, status, Price,Token) VALUES (1, 0, 150000,423423);
INSERT INTO TempBill (CustomerId, status, Price,Token) VALUES (2, 0, 250000,754534);
INSERT INTO TempBill (CustomerId, status, Price,Token) VALUES (3, 1, 850000,423567456);

INSERT INTO TempBillDetails (TempBillId, MenuID, Number, Price, Status) VALUES (1,9, 2, 50000, 1);
INSERT INTO TempBillDetails (TempBillId, MenuID, Number, Price, Status) VALUES (1, 10, 1, 75000, 1);
INSERT INTO TempBillDetails (TempBillId, MenuID, Number, Price, Status) VALUES (2, 12, 1, 125000, 1);
INSERT INTO TempBillDetails (TempBillId, MenuID, Number, Price, Status) VALUES (2, 14, 2, 50000, 1);
INSERT INTO TempBillDetails (TempBillId, MenuID, Number, Price, Status) VALUES (2, 16, 1, 50000, 0);
INSERT INTO TempBillDetails (TempBillId, MenuID, Number, Price, Status) VALUES (3, 15, 4, 150000, 1);
INSERT INTO TempBillDetails (TempBillId, MenuID, Number, Price, Status) VALUES (3, 17, 1, 100000, 1);

INSERT INTO Unit(Name, Description) VALUES ('Pound', 'A unit of weight equal to 16 ounces.');
INSERT INTO Unit(Name, Description) VALUES ('Kilogram', 'A unit of mass equal to 1000 grams.');
INSERT INTO Unit(Name, Description) VALUES ('Liter', 'A unit of volume equal to 1000 milliliters.');
INSERT INTO Unit(Name, Description) VALUES ('Gallon', 'A unit of volume equal to 128 fluid ounces.');
INSERT INTO Unit(Name, Description) VALUES ('Dozen', 'A group of 12 items.');
INSERT INTO Commodity(Name, Number, Description, UnitID) VALUES ('Rice', 25.5, 'Long-grain white rice', 1);
INSERT INTO Commodity(Name, Number, Description, UnitID) VALUES ('Wheat', 18.2, 'Whole wheat flour', 2);
INSERT INTO Commodity(Name, Number, Description, UnitID) VALUES ('Corn', 13.8, 'Yellow cornmeal', 3);
INSERT INTO Commodity(Name, Number, Description, UnitID) VALUES ('Sugar', 10.0, 'Granulated sugar', 4);
INSERT INTO Commodity(Name, Number, Description, UnitID) VALUES ('Milk', 5.5, 'Whole milk', 5);
INSERT INTO Commodity(Name, Number, Description, UnitID) VALUES ('Eggs', 7.2, 'Large eggs', 5);
INSERT INTO Commodity(Name, Number, Description, UnitID) VALUES ('Chicken', 12.0, 'Boneless skinless chicken breasts', 4);
INSERT INTO Commodity(Name, Number, Description, UnitID) VALUES ('Beef', 15.5, 'Ground beef (80% lean, 20% fat)', 3);
INSERT INTO Commodity(Name, Number, Description, UnitID) VALUES ('Salmon', 23.3, 'Fresh salmon fillet', 2);
INSERT INTO Commodity(Name, Number, Description, UnitID) VALUES ('Broccoli', 4.5, 'Fresh broccoli florets', 1);


INSERT INTO ImportCoupon (Date, StaffID)
VALUES
('2023-05-01', 1),
('2023-05-02', 2),
('2023-05-03', 1),
('2023-05-04', 3),
('2023-05-05', 2),
('2023-05-06', 1),
('2023-05-07', 3),
('2023-05-08', 2),
('2023-05-09', 3),
('2023-05-10', 1)


INSERT INTO Shift (Name, StartTime, EndTime)
VALUES ('Morning', '08:00:00', '12:00:00'),
('Afternoon', '13:00:00', '17:00:00'),
('Evening', '18:00:00', '22:00:00'),
('Night', '23:00:00', '03:00:00'),
('Overtime', '19:00:00', '23:59:59')

INSERT INTO Department (Name, Description)
VALUES ('Sales', 'Department responsible for sales activities.'),
('Marketing', 'Department responsible for marketing activities.'),
('Human Resources', 'Department responsible for HR activities.'),
('Finance', 'Department responsible for financial management.'),
('IT', 'Department responsible for IT infrastructure and systems.');

INSERT INTO Position (Name, Description, DepartmentID)
VALUES ('Manager', 'Responsible', 1),
('Assistant Manager', 'Supports ', 1),
('Supervisor', 'Directly', 2),
('Senior Developer', 'Leads', 3),
('Junior Developer', 'Works ', 3),
('Human Resources Officer', 'Responsible', 1),
('Marketing Officer', 'Responsible', 4),
('Sales Officer', 'Responsible', 4),
('Accountant', 'Responsible', 5),
('Customer Service Officer', 'Responsible', 4);




INSERT INTO Staff (Name, Dateofbirth, Nationality, Phone, identityCard, DateIdentityCard, PlaceidentityCard, CurrentAddress, PermanentAddress, BankID, NameBank, Salary, Sex, Status, URLImage, PositionID, ShiftID)
VALUES
('John Doe', '1990-01-01', 'American', '1234567890', '123456789', '2010-01-01', 'New York', '123 Main St', '456 Oak Ave', '1234567890', 'Bank of America', 3000, 'Male', 'Active', 'https://example.com/john-doe.jpg', 1, 1),
('Jane Doe', '1995-05-05', 'British', '0987654321', '987654321', '2015-05-05', 'London', '789 Elm St', '321 Maple Ave', '0987654321', 'HSBC Bank', 3500, 'Female', 'Active', 'https://example.com/jane-doe.jpg', 2, 1),
('David Smith', '1992-03-15', 'Canadian', '5678901234', '567890123', '2012-03-15', 'Toronto', '246 Pine St', '135 Cedar Ave', '5678901234', 'Royal Bank of Canada', 3200, 'Male', 'Active', 'https://example.com/david-smith.jpg', 3, 2),
('Linda Johnson', '1998-09-20', 'Australian', '3456789012', '345678901', '2018-09-20', 'Sydney', '789 Oak St', '246 Pine Ave', '3456789012', 'Commonwealth Bank', 2800, 'Female', 'Active', 'https://example.com/linda-johnson.jpg', 1, 2)