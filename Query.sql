--Create Database ProyectoFinalPropietaria
--GO

--Use ProyectoFinalPropietaria
--Go

--CREATE TABLE Art�culos(
--	ID int IDENTITY(1,1) not null, 
--	Descripci�n varchar(max), 
--	Costo_unitario int, 
--	Precio_unitario int, 
--	Estado bit,
--	Primary Key(ID)
--	);


--CREATE TABLE Clientes(
--	ID int IDENTITY(1,1) not null, 
--	Raz�n_social_nombre varchar(100), 
--	RNC_C�dula varchar(15), 
--	Cuenta_contable varchar(20),
--	Estado bit,
--	Primary Key(ID)
--	);



--CREATE TABLE Vendedor(
--	ID int IDENTITY (1,1) not null, 
--	Nombre varchar(50), 
--	Porciento_comisi�n int, 
--	Estado bit,
--	Primary Key(ID)
--	);


--CREATE TABLE Condiciones_Pago(
--	ID int IDENTITY(1,1) not null,
--	Descripci�n varchar(max),
--	Cantidad_dias int,
--	Estado bit,
--	Primary Key(ID),
--	);


--CREATE TABLE Factura(
--	ID int IDENTITY(1,1) not null,
--	Forma_pago int,
--	ID_vendedor int,
--	ID_cliente int,
--	Fecha datetime,
--	Comentario varchar(max),
--	ID_art�culo int,
--	Primary Key(ID),
--	Foreign Key(ID_vendedor) References Vendedor(ID),
--	Foreign Key(ID_cliente) References Clientes(ID),
--	Foreign Key(ID_art�culo) References Art�culos(ID),
--	Foreign Key(Forma_pago) References Condiciones_Pago(ID)
--	);

--CREATE TABLE Cantidad(
--	ID_Art�culos int,
--	ID_Factura int,
--	Cantidad int,
--	Primary Key(Cantidad),
--	Foreign Key(ID_Art�culos) References Art�culos(ID),
--	Foreign Key(ID_Factura) References Factura(ID)
--	);

--CREATE TABLE Acceso(
--	ID_vendedor int,
--	Username varchar(50),
--	Contrase�a varchar(15),
--	Primary Key (ID_vendedor),
--	Foreign Key(ID_vendedor) References Vendedor(ID)
--	);

--CREATE TABLE Reportes(
--	ID int IDENTITY(1,1) not null,
--	ID_factura int,
--	ID_cliente int,
--	Fecha datetime,
--	Primary key(ID),
--	Foreign Key(ID_factura) References Factura(ID),
--	Foreign Key(ID_cliente) References Clientes(ID)
--	);


