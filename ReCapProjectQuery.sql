CREATE TABLE Cars(
	CarID INT IDENTITY(1,1) PRIMARY KEY,
	BrandID SMALLINT,
	ModelYear INT,
	DailyPrice DECIMAL,
	Description VARCHAR(255)
);

INSERT INTO Cars
VALUES 
	(1, 2015, 152, 'Nissan Leaf 2.0'),
	(2, 2018, 369, 'Jaguar I-Pace'),
	(3, 2021, 245, 'Tesla Model 3'),
	(4, 2017, 741, 'Volkswagen e-Golf'),
	(3, 2021, 152, 'Tesla Model S'),
	(2, 2021, 578, 'Jaguar XE'),
	(5, 2012, 98, 'Toyota Camry'),
	(7, 2014, 152, 'BMW 3'),
	(4, 2015, 613, 'Volkswagen Tiguan Allspace'),
	(6, 2012, 152, 'Chevrolet Malibu');

CREATE TABLE Brands(
	BrandID INT IDENTITY(1,1) PRIMARY KEY,
	BrandName VARCHAR(255)
);

INSERT INTO Brands
VALUES 
	('Nissan'),
	('Jaguar'),
	('Tesla'),
	('Volkswagen'),
	('Toyota'),
	('Chevrolet'),
	('BMW');

CREATE TABLE Colors(
	ColorID INT IDENTITY(1,1) PRIMARY KEY,
	ColorName VARCHAR(255)
);

INSERT INTO Colors
VALUES 
	('Black'),
	('White'),
	('Yellow'),
	('Blue'),
	('Green'),
	('Red'),
	('Gray');