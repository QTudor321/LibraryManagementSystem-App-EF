SELECT TOP (1000) [userID]
      ,[username]
      ,[lastname]
      ,[firstname]
      ,[address]
      ,[password]
      ,[subscriptionstatus]
  FROM [LibraryDatabase].[dbo].[Users]
  INSERT INTO Users(username, lastname, firstname, address, password, subscriptionstatus)
  Values
  ('Johnny3','Doe','John','Str. Jamaican 3','Doe4',0),
  ('KevinO3','Laurent','Kevin','Str. Izvorului 23','KevDollar',0),
  ('Octa77','Ovidiu','Octavian','Str. Uzinei 998','MagicPass1234',0);
INSERT INTO Cards(userID, number, expiration, cvv, credit)
VALUES
(3,'7773884999231000','2027-02-11','123',2100.00),
(3,'9876123476543456','2025-11-08','432',0.00),
(3,'9089877653432734','2030-12-17','477',10000.00),
(4,'3434232354543434','2027-01-13','322',150.00),
(4,'3434234512432424','2029-11-29','452',300.00),
(5,'0983499234000002','2031-07-30','654',1.00),
(6,'6637777777223772','2050-12-23','233',200.00),
(6,'5234782459430009','2033-07-17','877',3000.00);
SELECT * From Cards;
USE LibraryDatabase;
INSERT INTO Books(theme, title, author, identifier, copies, price)
VALUES
('Fiction','Bufallo Hunter','Stephen Graham Jones','94853',1,70.00),
('Fiction','Dream Count','Chimamanda Ngozi Adichie','23453',1,30.00),
('Fiction','The Dream Hotel','Laila Lalami','33234',1,25.99),
('Fiction','This Book Will Bury Me','Ashley Winstead','46373',1,49.99),
('Horror','Collected Ghost Stories','M. R. James','94853',3,370.01),
('Horror','Frankenstein','Mary Shelley','33543',5,570.00),
('Horror','Gothic Tales','Elizabeth Gaskell','23421',1,170.00),
('Horror','The Fall Of The House of Usher','Edgar Allan Poe','77677',1,600.03),
('Action','Catching Fire','Suzanne Collins','09000',2,170.00),
('Action','One Wrong Step','Jennifer A. Nielsen','12312',1,135.00),
('Action','Splinter Effect','Andrew Ludington','00112',3,317.00),
('Action','What Wakes The Bells','Elle Tesch','83947',5,125.15);
SELECT * FROM Books;
SELECT * FROM Loans;
DELETE FROM Loans
Where loanID = 1;
DELETE FROM Users
Where subscriptionstatus = 1;
SELECT * From Users;
SELECT * From Cards;