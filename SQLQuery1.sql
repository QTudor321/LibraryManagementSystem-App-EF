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
	loanstatus VARCHAR(20) NOT NULL DEFAULT 'Act	ive'
);
