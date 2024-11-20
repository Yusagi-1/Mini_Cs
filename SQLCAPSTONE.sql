CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(20) NOT NULL, -- Example roles: 'Manager', 'Staff'
    CreatedAt DATETIME DEFAULT GETDATE()
);
CREATE TABLE Clients (
    ClientID INT PRIMARY KEY IDENTITY(1,1),
    FamilyName NVARCHAR(100) NOT NULL, -- Family name instead of FullName
    ContactNumber NVARCHAR(15),
    Address NVARCHAR(255), -- Family's primary address
    DateOfBirth DATE, -- Optional field
    CreatedAt DATETIME DEFAULT GETDATE(),
    CreatedBy INT,
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID) ON DELETE SET NULL
);
CREATE TABLE Deceased (
    DeceasedID INT PRIMARY KEY IDENTITY(1,1),
    ClientID INT NOT NULL, -- Links to the family in the Clients table
    DeceasedName NVARCHAR(100) NOT NULL, -- Name of the deceased
    Age INT, -- Age of the deceased
    BirthDate DATE, -- Birthdate of the deceased
    DeathDate DATE NOT NULL, -- Day of death
    GraveAddress NVARCHAR(255), -- Address of the grave
    Notes NVARCHAR(MAX), -- Notes about family wishes, messages, etc.
    CreatedAt DATETIME DEFAULT GETDATE(),
    CreatedBy INT,
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID) ON DELETE CASCADE, -- Cascade delete deceased records with family
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID) ON DELETE SET NULL
);
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
CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    ClientID INT NOT NULL,
    ServiceID INT NOT NULL,
    TransactionDate DATE NOT NULL DEFAULT GETDATE(),
    Amount DECIMAL(10, 2) NOT NULL,
    Quantity INT NOT NULL DEFAULT 1, -- Added Quantity column
    Discount DECIMAL(10, 2) NOT NULL DEFAULT 0.00, -- Added Discount column
    Notes NVARCHAR(255),
    CreatedBy INT,
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID) ON DELETE CASCADE,
    FOREIGN KEY (ServiceID) REFERENCES Services(ServiceID) ON DELETE CASCADE,
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID) ON DELETE SET NULL
);
CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY IDENTITY(1,1),
    TransactionID INT NOT NULL,
    PaymentDate DATE NOT NULL DEFAULT GETDATE(),
    Amount DECIMAL(10, 2) NOT NULL,
    PaymentMethod NVARCHAR(50),
    Notes NVARCHAR(255),
    FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID) ON DELETE CASCADE
);
CREATE TABLE AuditLogs (
    LogID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NULL, -- UserID must be nullable to allow ON DELETE SET NULL
    Action NVARCHAR(100) NOT NULL,
    Timestamp DATETIME DEFAULT GETDATE(),
    Description NVARCHAR(255),
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE SET NULL
);
-- Indexes for optimization
CREATE INDEX IDX_ClientID ON Transactions(ClientID);
CREATE INDEX IDX_ServiceID ON Transactions(ServiceID);
CREATE INDEX IDX_TransactionID ON Payments(TransactionID);
CREATE INDEX IDX_UserID ON AuditLogs(UserID);
CREATE INDEX IDX_Clients_FamilyName ON Clients(FamilyName);
CREATE INDEX IDX_Deceased_Name ON Deceased(DeceasedName);
CREATE INDEX IDX_Deceased_DeathDate ON Deceased(DeathDate);
