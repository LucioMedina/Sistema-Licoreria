create  database sistema_licoreria
go

use sistema_licoreria
go

create table Personas
(
	idpersona		int identity(1,1)	primary key,
	apellidos		varchar(30)			not null,
	nombres			varchar(30)			not null,	
	DNI				char(8)		        not null,
	telefono		char(9)				not null,
	CONSTRAINT ck_DNI CHECK( DNI LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CONSTRAINT uk_DNI UNIQUE (DNI)
)
go

ALTER TABLE Personas ADD estado BIT NOT NULL DEFAULT 1



create table Empleados
(
	idempleado		int identity(1,1)	primary key,
	idpersona		int					not null, --FK
	nombreusuario	varchar(50)			not null,
	claveacceso		varchar(90)			not null,
	constraint fk_idpersona_empleados foreign key (idpersona) references Personas (idpersona),
	CONSTRAINT uk_nombreUsuario UNIQUE (nombreusuario),
	CONSTRAINT uk_idpersona UNIQUE (idpersona)
)
go

alter table Empleados add estado bit not null default 1



create table MediosPago
(
	idmediopago		int identity(1,1) primary key,
	mediopago		varchar(30)		not null
)
go
alter table MediosPago add CONSTRAINT uk_mediopago UNIQUE (mediopago)

create table Sedes
(
	idsede		int identity(1,1) primary key,
	ciudad		varchar(30)		not null,
	direccion	varchar(30)		not null,
	telefono	char(9)			not null,
	CONSTRAINT ck_telefono CHECK (telefono like '[9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
go


CREATE table Ventas 
(
	idventa			int identity(1,1) primary key,
	idmediopago		int			not null, --FK
	idsede			int			not null, --FK
	idcliente		int			not null, --FK
	idempleado		int			not null,  --FK
	fechahora		datetime	not null default getdate(),
	tipocomprovante	varchar(30)	not null,
	numcomprovante	char(7)	not null,
	constraint fk_idmediopago_ventas foreign key (idmediopago) references MediosPago (idmediopago),
	constraint fk_idsede_ventas foreign key (idsede) references Sedes (idsede),
	constraint fk_idcliente_ventas foreign key (idcliente) references Personas (idpersona),
	constraint fk_idempleado_ventas foreign key (idempleado) references Empleados (idempleado),
	constraint ck_tipocomprovante check (tipocomprovante in ('Boleta', 'Factura')),
	CONSTRAINT ck_numcomprovante CHECK (numcomprovante like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CONSTRAINT uk_numcomprovante UNIQUE (numcomprovante)
)
go


CREATE TABLE marcas
(
	idMarca			INT IDENTITY(1,1) PRIMARY KEY,
	nombreMarca		VARCHAR(50)		NOT NULL,
	CONSTRAINT uk_nombreMarca UNIQUE (nombreMarca)
)
GO

CREATE TABLE categoria
(
	idCategoria			INT IDENTITY(1,1) PRIMARY KEY,
	nombreCategoria		VARCHAR(50)		NOT NULL,
	CONSTRAINT uk_nombrecategoria UNIQUE (nombreCategoria)
)
GO

CREATE TABLE Productos
(
	idproducto			INT IDENTITY(1,1) PRIMARY KEY,
	idmarca				INT			 NOT NULL,
	idcategoria			INT			 NOT NULL,
	nombreproducto		VARCHAR(50)	 NOT NULL,
	descripcion			VARCHAR(100) NOT NULL,
	precio				DECIMAL(7,2) NOT NULL,
	stock				smallint	 NOT NULL,
	caducidad			DATE		 NOT NULL,
	CONSTRAINT R1_idmarca FOREIGN KEY (idmarca) REFERENCES marcas(idmarca),
	CONSTRAINT R2_idcategoria FOREIGN KEY (idcategoria) REFERENCES categoria(idcategoria),
	CONSTRAINT R4_precio CHECK (precio > 0),
	CONSTRAINT Re_stock CHECK (stock > 0)
)
GO
ALTER TABLE Productos ADD estado BIT NOT NULL DEFAULT 1

create table DetalleVenta
(
	iddetalleventa		int identity(1,1) primary key,
	idventa				int				not null,
	idproducto			int				not null,
	cantidad			smallint		not null,
	precioventa			decimal(7,2)	not null,
	constraint fk_idventas_detalleven foreign key (idventa) references Ventas (idventa),
	constraint fk_idproductos_detalleven foreign key (idproducto) references Productos (idproducto),
	CONSTRAINT R5_precioventa CHECK (precioventa > 0),
	CONSTRAINT ck_cantidad CHECK (cantidad > 0)
)
go

CREATE TABLE Proveedores
(
	idproveedor		INT IDENTITY(1,1) PRIMARY KEY,
	nombreprov		VARCHAR(50)		NOT NULL,
	direccion		VARCHAR(50)		NOT NULL,
	RUC				CHAR(11)		NOT NULL,
	telefono		CHAR(9)			NOT NULL,
	CONSTRAINT uk_Ruc UNIQUE (RUC),
	CONSTRAINT ck1_telefono CHECK (telefono like '[9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CONSTRAINT ck_RUC CHECK (RUC LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
GO

CREATE TABLE Compras 
(
	idcompras	INT IDENTITY(1,1) PRIMARY KEY,
	idproveedor	INT		NOT NULL,
	CONSTRAINT R6_idproveedor FOREIGN KEY (idproveedor) REFERENCES Proveedores(idproveedor)
)
GO

CREATE TABLE detalleCompra
(
	iddecompra		INT IDENTITY(1,1) PRIMARY KEY,
	idcompras		INT			 NOT NULL,
	idproductos		INT			 NOT NULL,
	cantidad		SMALLINT	 NOT NULL,
	preciocompra	DECIMAL(7,2) NOT NULL,
	CONSTRAINT r6_idcompras FOREIGN KEY (idcompras)	REFERENCES compras(idcompras),
	CONSTRAINT R7_idproducto FOREIGN KEY (idproductos) REFERENCES productos(idproducto),
	CONSTRAINT R8_cantidad CHECK (cantidad > 0),
	CONSTRAINT R9_preciocompra CHECK (precioCompra > 0)
)
GO