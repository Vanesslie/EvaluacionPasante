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

--insercion de datos
INSERT INTO Category (NombreCategoria, EstadoCategoria) VALUES 
('Bebidas', 1),
('Snacks', 1),
('dulces', 1);

INSERT INTO Product (CodigoProducto, NombreProducto, Precio, Estado, FechaCreacion, CategoryID) VALUES 
('B001', 'Coca-Cola 500ml', 30.00, 1, GETDATE(), 1),
('B002', 'Coca-Cola zero lata 354ml', 35.00, 1, GETDATE(), 1),
('B003', 'Agua Fuente pura 1L', 35.00, 1, GETDATE(), 1),
('B004', 'Agua Alpina 1L', 32.00, 1, GETDATE(), 1),
('S001', 'Quesitos Diana 125g', 50.45, 1, GETDATE(), 2),
('S002', 'Centavitos Diana 93g', 45.30, 1, GETDATE(), 2),
('S003', 'Jalapeno Diana 150g', 50.60, 1, GETDATE(), 2),
('D001', 'Chocolate m&ms 47.9g', 100.30, 1, GETDATE(), 3),
('D002', 'Chocolate Snickers 52.7g', 100.45, 1, GETDATE(), 3),
('D003', 'Galleta principe limon 85g', 40.30, 1, GETDATE(), 3);

INSERT INTO [User] (NombreUsuario, Nombre, Contrasena, Correo, Estado) VALUES 
('admin', 'Administrador', '123', 'admin@ejemplo.com', 1),
('VEscobar', 'Vanessllie Escobar', '456', 'vanesslie@ejemplo.com', 1);

INSERT INTO TipoMovInv (NombreMov, TipoMov) VALUES 
('Compra a Proveedor', 1),
('Venta a Cliente', 0),
('Producto danado', 0); 

INSERT INTO MovInv (Cantidad, FechaMov, ProductID, UserID, TipoMovInvID) VALUES 
(50, GETDATE(), 1, 2, 1), 
(50, GETDATE(), 2, 2, 1), 
(50, GETDATE(), 3, 1, 1), 
(50, GETDATE(), 4, 1, 1), 
(50, GETDATE(), 5, 1, 1), 
(50, GETDATE(), 6, 2, 1), 
(50, GETDATE(), 7, 1, 1), 
(50, GETDATE(), 8, 2, 1), 
(50, GETDATE(), 9, 2, 1), 
(50, GETDATE(), 10, 2, 1), 
(20, GETDATE(), 1, 1, 2),  
(12, GETDATE(), 3, 1, 2),  
(15, GETDATE(), 6, 2, 2),  
(30, GETDATE(), 9, 2, 2),  
(25, GETDATE(), 10, 1, 2); 
GO