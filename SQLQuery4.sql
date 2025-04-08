--Inserting the librarian
Use LibraryDatabase;
INSERT INTO Users(username, lastname, firstname, address, password, subscriptionstatus)
VALUES
('Greg123', 'Hector','Greg','Str. Vaslui 31','Librarianpass1234',1);
SELECT * FROM Users;
SELECT * FROM Cards;
SELECT * FROM Books;
SELECT * From Loans;