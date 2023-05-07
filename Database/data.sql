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

drop table TempBill
select * from TempBill