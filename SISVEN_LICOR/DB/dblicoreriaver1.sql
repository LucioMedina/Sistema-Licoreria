-- CREACIÓN DE LA BD
create  database LICORERIA
go

--USAMOS LA BD
use LICORERIA
go

--CREACIÓN DE LA TABLA PERSONAS
create table Personas
(
	idpersona		int identity(1,1)	primary key,
	apellidos		varchar(30)			not null,
	nombres			varchar(30)			not null,	
	DNI				char(8)		        not null,
	telefono		char(9)				not null,
	estado			bit					not null default 1,
	CONSTRAINT ck_DNI CHECK( DNI LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CONSTRAINT uk_DNI UNIQUE (DNI)
)
go

--INSERTAMOS REGISTROS

INSERT INTO Personas (apellidos, nombres, DNI, telefono) VALUES
			('Farfan Torres', 'Angelo', '72564289', '953221053'),
			('Cartagena Salazar','Jimena','89735243','983751837'),
			('Mateo Quispe', 'Jean', '64827405','918268376'),
			('Medina Llanos', 'Lucio', '87263549', '918265348')
GO



--CREACIÓN DE LA TABLA EMPLEADOS
create table Empleados
(
	idempleado		int identity(1,1)	primary key,
	idpersona		int					not null, --FK
	nombreusuario	varchar(50)			not null,
	claveacceso		varchar(90)			not null,
	estado			bit					not null default 1,
	constraint fk_idpersona_empleados foreign key (idpersona) references Personas (idpersona),
	CONSTRAINT uk_nombreUsuario UNIQUE (nombreusuario),
	CONSTRAINT uk_idpersona UNIQUE (idpersona)
)
go

--INSERTAMOS REGISTROS
INSERT INTO Empleados (idpersona, nombreusuario, claveacceso) VALUES
			(1, 'Angelo', 'farfan123'),
			(4, 'lucio', 'medina123')
GO

--CREACIÓN DE LA TABLA MARCAS
CREATE TABLE Marcas
(
	idMarca			INT IDENTITY(1,1) PRIMARY KEY,
	nombreMarca		VARCHAR(50)		NOT NULL,
	estado			bit		null default 1,
	CONSTRAINT uk_nombreMarca UNIQUE (nombreMarca)
)
GO

--INSERTAMOS REGISTROS
insert into marcas (nombreMarca) values 
	('Viña vieja'),
	('Tabernero'),
	('Pilsen'),
	('Cristal'),
	('Corona'),
	('Cusqueña'),
	('Red Bull')
go

--CREACIÓN DE LA TABLA CATEGORIAS
CREATE TABLE Categorias
(
	idCategoria			INT IDENTITY(1,1) PRIMARY KEY,
	nombreCategoria		VARCHAR(50)		NOT NULL,
	estado				bit		not null default 1,
	CONSTRAINT uk_nombrecategoria UNIQUE (nombreCategoria)
)
GO

--INSERTAMOS REGISTROS
insert into categorias (nombreCategoria) values 
	('Vinos'),
	('Cervezas'),
	('Whiskys'),
	('Ron'),
	('Piscos'),
	('Aguas'),
	('Energizantes')
go

-- CREACIÓN DE LA TABLA PRODUCTOS
CREATE TABLE Productos
(
	idproducto			INT IDENTITY(1,1) PRIMARY KEY,
	idmarca				INT			 NOT NULL,
	idcategoria			INT			 NOT NULL,
	nombreproducto		VARCHAR(50)	 NOT NULL,
	descripcion			VARCHAR(100) NOT NULL,
	codigo				varchar(30)	NOT NULL,
	precio				DECIMAL(7,2) NOT NULL,
	stock				int	 NOT NULL,
	caducidad			DATE		 NOT NULL,
	estado			bit					not null default 1,
	CONSTRAINT R1_idmarca FOREIGN KEY (idmarca) REFERENCES marcas(idmarca),
	CONSTRAINT R2_idcategoria FOREIGN KEY (idcategoria) REFERENCES categorias(idcategoria),
	CONSTRAINT R4_precio CHECK (precio > 0),
	CONSTRAINT Re_stock CHECK (stock > 0),
	constraint uk_codigo unique(codigo)
)
GO

--INSERTAMOS REGISTROS

insert into Productos (codigo,idmarca, idcategoria, nombreproducto, descripcion, precio, stock, caducidad) values 
	('P01',1, 1, 'Gran Rose', 'Botella 750ml', 16.0, 10, '01-03-2024'),
	('P2',2, 1, 'Gran Blanco', ' Botella 750ml', 18.0, 10, '01-03-2024')
go


create table Ventas 
(
	idventa			int identity(1,1) primary key,
	idcliente			int		null,
	comprobante		char (1)	not null default 'B',
	numcomprobante	int 		not null,
	fechahora		datetime	not null default getdate(),
	constraint fk_idcliente_ventas foreign key (idcliente) references Personas (idpersona),
	--constraint fk_idempleado_ventas foreign key (idempleado) references Empleados (idempleado),
	constraint fk_comprobante check (comprobante in ('B','F')),
)
go

--Insertamos datos

insert into Ventas (idcliente,comprobante,numcomprobante) values
	(2,'B',0000001),
	(3,'F',0000002)
go


--CREACIÓN DE LA TABLA DETALLEVENTA
create table DetalleVenta
(
	iddetalleventa		int identity(1,1) primary key,
	idventa				int				not null,
	idproducto			int				not null,
	cantidad			smallint		not null,
	precioventa			decimal(7,2)	not null,
	estado				bit  not null default 1,
	constraint fk_idventa_ventas foreign key(idventa) references ventas(idventa),
	constraint fk_idproductos_detalleven foreign key (idproducto) references Productos (idproducto),
	CONSTRAINT R5_precioventa CHECK (precioventa > 0),
	CONSTRAINT ck_cantidad CHECK (cantidad > 0)
)
go

insert into DetalleVenta(idventa,idproducto,cantidad,precioventa) values
	(1,2,2,16),
	(2,2,5,16)
	--(3,3,7,6.50)
go
select * from Productos
--CREACIÓN DE TABLA PROVEEDORES
create TABLE Proveedores
(
	idproveedor		INT IDENTITY(1,1) PRIMARY KEY,
	nombreprov		VARCHAR(50)		NOT NULL,
	direccion		VARCHAR(50)		NOT NULL,
	RUC				CHAR(11)		NOT NULL,
	telefono		CHAR(9)			NOT NULL,
	estado				bit  not null default 1,
	CONSTRAINT uk_Ruc UNIQUE (RUC),
	CONSTRAINT ck1_telefono CHECK (telefono like '[9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CONSTRAINT ck_RUC CHECK (RUC LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
GO

--INSERTAMOS REGISTROS
insert into Proveedores (nombreprov, direccion, RUC, telefono) values 
	('El Pozito', 'Lima av. Victoria #120', 45367828776, 987654376),
	('Don Lucho', 'Chincha Pam.Sur 192km', 94563332125, 984233463),
	('Backus', 'Lima La victoria 156', 20459631248, 984234863)
go


--CREACIÓN DE TABLA COMPRAS
create TABLE Compras 
(
	idcompra		INT IDENTITY(1,1) PRIMARY KEY,
	idproveedor		INT		NOT NULL,
	tipocomprobante	CHAR(1)		NOT NULL DEFAULT 'B',
	numcomprobante	INT			NOT NULL, 
	fechaventa		DATETIME	NOT NULL DEFAULT GETDATE(),
	tipopago		VARCHAR(10) NOT NULL DEFAULT 'efectivo',
	CONSTRAINT R6_idproveedor FOREIGN KEY (idproveedor) REFERENCES Proveedores(idproveedor),
)
GO
select * from Compras
--INSERTAMOS REGISTROS
insert into Compras (idproveedor) values 
	(1),
	(2)
go



--CREACIÓN DE TABLA DETALLECOMPRA
create TABLE detalleCompra
(
	iddecompra		INT IDENTITY(1,1) PRIMARY KEY,
	idcompra		INT			 NOT NULL,
	idproducto		INT			 NOT NULL,
	cantidad		SMALLINT	 NOT NULL,
	preciocompra	decimal (7,2)	not null,
	precioventa		decimal (7,2) not null,
	fecharegistro	datetime	default getdate(),
	estado				bit  not null default 1,
	CONSTRAINT r6_idcompra FOREIGN KEY (idcompra)	REFERENCES compras(idcompra),
	CONSTRAINT R7_idproducto FOREIGN KEY (idproducto) REFERENCES productos(idproducto),
	CONSTRAINT R8_cantidad CHECK (cantidad > 0),
	CONSTRAINT R9_preciocompra CHECK (precioCompra > 0),
	CONSTRAINT R1_preciovompra CHECK (precioVenta > 0)
)
GO


insert into detalleCompra (idcompra,idproducto,cantidad,preciocompra,precioventa) values
	(1,1,10,10,16)
	