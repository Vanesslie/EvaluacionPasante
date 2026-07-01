-- creacion de tablas
CREATE TABLE Category (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    NombreCategoria VARCHAR(50) NOT NULL, 
    EstadoCategoria BIT
);
GO

CREATE TABLE Product(
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    CodigoProducto VARCHAR(20) UNIQUE NOT NULL,
    NombreProducto VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Estado BIT,
    Stock INT NOT NULL,
    FechaCreacion DATETIME,

    CategoryID INT NOT NULL,

    FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
);
GO

CREATE TABLE TipoMovInv(
    TipoMovInvID INT IDENTITY(1,1) PRIMARY KEY,
    NombreMov VARCHAR(50) NOT NULL,
    -- Donde entrada es 1 y salida es 0
    TipoMov BIT 
);
GO

CREATE TABLE [User](
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario VARCHAR(30) UNIQUE NOT NULL,
    Nombre VARCHAR(20),
    Contrasena VARCHAR(20) NOT NULL,
    Correo VARCHAR(50),
    Estado BIT
);
GO

CREATE TABLE MovInv(
    MovInvID INT IDENTITY(1,1) PRIMARY KEY,
    Cantidad INT NOT NULL,
    FechaMov DATETIME,

    ProductID INT NOT NULL,
    UserID INT NOT NULL,
    TipoMovInvID INT NOT NULL,

    FOREIGN KEY(ProductID) REFERENCES Product(ProductID),
    FOREIGN KEY(UserID) REFERENCES [User](UserID),
    FOREIGN KEY(TipoMovInvID) REFERENCES TipoMovInv(TipoMovInvID)
);
GO