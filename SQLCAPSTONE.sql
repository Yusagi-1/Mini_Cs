-- Users Table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(20) NOT NULL, -- Example roles: 'Manager', 'Staff'
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Clients Table
CREATE TABLE Clients (
    ClientID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    ContactNumber NVARCHAR(15),
    Address NVARCHAR(255),
    DateOfBirth DATE,
    CreatedAt DATETIME DEFAULT GETDATE(),
    CreatedBy INT,
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID) ON DELETE SET NULL
);

-- Services Table
CREATE TABLE Services (
    ServiceID INT PRIMARY KEY IDENTITY(1,1),
    ServiceName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    Price DECIMAL(10, 2) NOT NULL,
    DurationDays INT,
    CreatedAt DATETIME DEFAULT GETDATE(),
    CreatedBy INT,
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID) ON DELETE SET NULL
);

-- Transactions Table
CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    ClientID INT NOT NULL,
    ServiceID INT NOT NULL,
    TransactionDate DATE NOT NULL DEFAULT GETDATE(),
    Amount DECIMAL(10, 2) NOT NULL,
    Notes NVARCHAR(255),
    CreatedBy INT,
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID) ON DELETE CASCADE,
    FOREIGN KEY (ServiceID) REFERENCES Services(ServiceID) ON DELETE CASCADE,
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID) ON DELETE SET NULL
);

-- Payments Table
CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY IDENTITY(1,1),
    TransactionID INT NOT NULL,
    PaymentDate DATE NOT NULL DEFAULT GETDATE(),
    Amount DECIMAL(10, 2) NOT NULL,
    PaymentMethod NVARCHAR(50),
    Notes NVARCHAR(255),
    FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID) ON DELETE CASCADE
);

-- Audit Logs Table with Nullable UserID
CREATE TABLE AuditLogs (
    LogID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NULL, -- UserID must be nullable to allow ON DELETE SET NULL
    Action NVARCHAR(100) NOT NULL,
    Timestamp DATETIME DEFAULT GETDATE(),
    Description NVARCHAR(255),
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE SET NULL
);

-- Indexing for optimization
CREATE INDEX IDX_ClientID ON Transactions(ClientID);
CREATE INDEX IDX_ServiceID ON Transactions(ServiceID);
CREATE INDEX IDX_TransactionID ON Payments(TransactionID);
CREATE INDEX IDX_UserID ON AuditLogs(UserID);


ALTER TABLE Transactions
ADD Quantity INT NOT NULL DEFAULT 1;  -- Default to 1 if not specified
ALTER TABLE Transactions
ADD Discount DECIMAL(10, 2) NOT NULL DEFAULT 0.00;  -- Percentage discount or flat amount