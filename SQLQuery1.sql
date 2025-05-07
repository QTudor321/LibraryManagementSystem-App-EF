CREATE Database LibraryDatabase;
USE LibraryDatabase;
CREATE Table Users(
	userID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	username VARCHAR(50) NOT NULL,
	lastname VARCHAR(50) NOT NULL,
	firstname VARCHAR(50) NOT NULL,
	address VARCHAR(50) NOT NULL,
	password VARCHAR(50) NOT NULL,
	subscriptionstatus TINYINT NOT NULL DEFAULT 0
);
CREATE Table Books(
	bookID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	theme VARCHAR(50) NOT NULL,
	title VARCHAR(50) NOT NULL,
	author VARCHAR(50) NOT NULL,
	identifier VARCHAR(30) NOT NULL,
	copies INT NOT NULL,
	price MONEY NOT NULL
);
CREATE Table Cards(
	cardID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	userID INT FOREIGN KEY REFERENCES Users(userID) ON DELETE CASCADE,
	number VARCHAR(20) NOT NULL,
	expiration DATETIME NOT NULL,
	cvv VARCHAR(3) NOT NULL,
	credit DECIMAL NOT NULL
);
CREATE Table Loans(
	loanID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	userID INT FOREIGN KEY REFERENCES Users(userID) ON DELETE CASCADE,
	bookID INT FOREIGN KEY REFERENCES Books(bookID) ON DELETE CASCADE,
	loandate DATETIME NOT NULL,
	duedate DATETIME NOT NULL,
	returndate DATETIME NULL,
	loanstatus VARCHAR(20) NOT NULL DEFAULT 'Active'
);
--parolele si numerele de card trebuie hashuite inainte sa fie inserate in baza de date, deci fara instructiuni insert in afara de carti
ALTER TABLE Users
ADD isLibrarian TINYINT NOT NULL DEFAULT 0;
ALTER TABLE Users ALTER COLUMN password VARCHAR(255);
ALTER TABLE Cards ALTER COLUMN number VARCHAR(255);
UPDATE Users
SET isLibrarian = 1
WHERE username = 'Greg123';
UPDATE Users
SET subscriptionstatus = 1
WHERE username = 'Greg123';
SELECT * From Cards;
SELECT * From Users;
SELECT * From Loans;
SELECT * From Books;