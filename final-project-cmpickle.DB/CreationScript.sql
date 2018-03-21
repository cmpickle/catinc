-- Database Creation Script 
-- Cameron Pickle 3/20/2018
-- This creates the Cat Inc database
-- Uses MySQL database

DROP DATABASE IF EXISTS Cat_Inc;

CREATE DATABASE Cat_Inc;

-- With the CatInc database now created, switch to it and begin creating the individual 
-- tables for the database

USE Cat_Inc;

CREATE TABLE Users
(
    UserID          INT             NOT NULL  AUTO_INCREMENT, 
    Username        VARCHAR(30)     NOT NULL, 
    UserHash        VARCHAR(30)     NOT NULL, 
    Salt            VARCHAR(20)     NOT NULL, 
    UserDeleted     BIT             NOT NULL,
    PRIMARY KEY(UserID)
);

CREATE TABLE Permission
(
    PermissionID        INT         NOT NULL AUTO_INCREMENT,
    UserID              INT         NOT NULL,
    PermissionLevel     SMALLINT    NOT NULL,
    PRIMARY KEY(PermissionID)
);

CREATE TABLE Loyalty
(
    LoyaltyID       INT     NOT NULL  AUTO_INCREMENT,
    UserID          INT     NOT NULL,
    LoyaltyPoints   INT     NOT NULL,
    PRIMARY KEY(LoyaltyID)
);

CREATE TABLE Orders
(
    OrderID         INT         NOT NULL  AUTO_INCREMENT,
    OrderTimestamp  DATETIME    NOT NULL, 
    DiscountID      INT         NOT NULL,
    PRIMARY KEY(OrderID)
);

CREATE TABLE ProductOrder
(
    ProductOrderID      INT    NOT NULL  AUTO_INCREMENT,
    OrderID             INT    NOT NULL,
    ProductID           INT    NOT NULL,
    Quantity            INT    NOT NULL,
    PRIMARY KEY(ProductOrderID)
);

CREATE TABLE Product
(
    ProductID               INT             NOT NULL  AUTO_INCREMENT,
    ProductSKU              VARCHAR(15)     NULL,
    ProductName             VARCHAR(30)     NOT NULL,
    ProductPrice            DECIMAL(10, 2)  NOT NULL,
    ProductInventory        INT             NOT NULL,
    ProductExpirationDate   DATETIME        NULL,  
    ProductDeleted          BIT             NOT NULL,
    PRIMARY KEY(ProductID)
);

CREATE TABLE Discount
(
    DiscountID          INT         NOT NULL AUTO_INCREMENT,
    DiscountStart       DATETIME    NOT NULL,
    DiscoundEnd         DATETIME    NOT NULL,
    DiscountDeleted     BIT         NOT NULL,
    PRIMARY KEY(DiscountID)
);

CREATE TABLE Patron
(
    PatronID            INT             NOT NULL  AUTO_INCREMENT,
    PatronFirst         VARCHAR(30)     NULL,
    PatronLast          VARCHAR(30)     NULL,
    PatronAddress       VARCHAR(50)     NULL,
    PatronEmail         VARCHAR(50)     NULL,
    PatronTelephoneNo   VARCHAR(15)     NULL,
    PatronSuspended     BIT             NOT NULL,
    PatronDeleted       BIT             NOT NULL,
    UserID              INT             NOT NULL,
    PRIMARY KEY(PatronID)
);

CREATE TABLE PatronCreditcard
(
    PatronCreditcardID  INT     NOT NULL  AUTO_INCREMENT,
    PatronID            INT     NOT NULL,
    CreditcardID        INT     NOT NULL,
    PRIMARY KEY(PatronCreditcardID)
);

CREATE TABLE Creditcard
(
    CreditcardID        INT     NOT NULL AUTO_INCREMENT,
    CreditcardNo        INT     NOT NULL,
    ExpirationDate      DATE    NOT NULL,
    CCV                 TINYINT NOT NULL,
    PRIMARY KEY(CreditcardID)
);

CREATE TABLE Log
(
    LogID           INT             NOT NULL AUTO_INCREMENT,
    UserID          INT             NOT NULL,
    LogTimestamp    DATETIME        NOT NULL,
    LogLevel        INT             NOT NULL,
    LogMessage      VARCHAR(300)    NOT NULL,
    PRIMARY KEY(LogID)
);

CREATE TABLE VendorUser
(
    VendorUserID    INT     NOT NULL AUTO_INCREMENT,
    VendorID        INT     NOT NULL, 
    UserID          INT     NOT NULL,
    PRIMARY KEY(VendorUserID)
);

CREATE TABLE Vendor
(
    VendorID                INT             NOT NULL AUTO_INCREMENT,
    VendorName              VARCHAR(50)     NOT NULL,
    VendorAddress           VARCHAR(100)    NOT NULL,
    VendorTelephoneNo       VARCHAR(15)     NULL,
    VendorEmail             VARCHAR(50)     NULL,
    VendorPaymentAmount     DECIMAL(10,2)   NOT NULL,
    VendorCreditcardNo      INT             NOT NULL,
    VendorActive            BIT             NOT NULL,
    VendorSuspended         BIT             NOT NULL,
    VendorDeleted           BIT             NOT NULL,
    PRIMARY KEY(VendorID)
);

-- Alter tables to set up foreign keys 
ALTER TABLE Permission
  ADD CONSTRAINT fk_permission_user_id
    FOREIGN KEY (UserID) REFERENCES User(UserID)
    ON DELETE CASCADE
    ON UPDATE CASCADE;
    
ALTER TABLE Loyalty
    ADD CONSTRAINT fk_loyalty_user_id
    FOREIGN KEY (UserID) REFERENCES User(UserID)
    ON DELETE CASCADE
    ON UPDATE CASCADE;

ALTER TABLE Orders
  ADD CONSTRAINT fk_order_discount_id
    FOREIGN KEY (DiscountID) REFERENCES Discount(DiscountID)
    ON DELETE CASCADE
    ON UPDATE CASCADE;
    
ALTER TABLE ProductOrder
  ADD CONSTRAINT fk_productorder_order_id
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
    ON DELETE CASCADE
    ON UPDATE CASCADE,

    ADD CONSTRAINT fk_productorder_product_id
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
    ON DELETE CASCADE
    ON UPDATE CASCADE;
    
ALTER TABLE Patron
  ADD CONSTRAINT fk_patron_user_id
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
    ON DELETE CASCADE
    ON UPDATE CASCADE;
    
ALTER TABLE PatronCreditcard
  ADD CONSTRAINT fk_patroncreditcard_patron_id
    FOREIGN KEY (PatronID) REFERENCES Patron(PatronID)
    ON DELETE CASCADE
    ON UPDATE CASCADE,

    ADD CONSTRAINT fk_patroncreditcard_creditcard_id
    FOREIGN KEY (CreditcardID) REFERENCES Creditcard(CreditcardID)
    ON DELETE CASCADE
    ON UPDATE CASCADE;

ALTER TABLE VendorUser
  ADD CONSTRAINT fk_vendoruser_vendor_id
    FOREIGN KEY (VendorID) REFERENCES Vendor(VendorID)
    ON DELETE CASCADE
    ON UPDATE CASCADE,

    ADD CONSTRAINT fk_vendoruser_user_id
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
    ON DELETE CASCADE
    ON UPDATE CASCADE;