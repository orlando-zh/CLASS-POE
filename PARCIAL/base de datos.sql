CREATE DATABASE CarSalesBusiness
USE CarSalesBusiness;

CREATE TABLE Car (
    CarID INT PRIMARY KEY IDENTITY(1,1), 
    Model VARCHAR(100) NOT NULL,          
    Price DECIMAL(10, 2) NOT NULL         
);

CREATE TABLE Sale (
    SaleID INT PRIMARY KEY IDENTITY(1,1), 
    SaleDate DATE NOT NULL,               
    Quantity INT NOT NULL,               
    TotalAmount DECIMAL(10, 2) NOT NULL,  
    CarID INT,                            
    FOREIGN KEY (CarID) REFERENCES Car(CarID) 
);