CREATE DATABASE VENTAS_LICOR
GO

USE VENTAS_LICOR
GO

-- **** CREACIÓN DE TABLAS ****

CREATE TABLE Personas
(
	idpersona		INT		IDENTITY(1,1) PRIMARY KEY,
	apellidos		VARCHAR(30)	NOT NULL,
	nombres			VARCHAR(30)	NOT NULL,
	dni				CHAR(8)		NOT NULL,
	CONSTRAINT uk_dni_per UNIQUE (dni),
	CONSTRAINT ck_DNI CHECK( DNI LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
GO

INSERT INTO personas (apellidos, nombres, dni) VALUES
	('SOZA PRADA','Angelica','21457896'),
	('TUESTA OCHOA','Fernando','32659874'),
	('ATUCAR MAGALLANES','Dina','89562314'),
	('QUISPE ORMEÑO', 'Xiomara', '74859612'),
	('SANTAMARIA SUAREZ', 'Julia', '95867421'),
	('CHAVEZ TRELLES', 'Raul', '32674852'),
	('JOYA MORENO', 'Susana', '24596874')
GO

CREATE TABLE Usuarios
(
	idusuario	int identity(1,1) primary key,
	idpersona	int not null,
	usuario		varchar(30) not null,
	clave		varchar(90) not null,
	fecharegistro	datetime  null default getdate(),
	estado		bit  null default 1
	constraint fk_idpersona_persona foreign key(idpersona) references personas(idpersona),
	CONSTRAINT uk_nombreUsuario UNIQUE (usuario),
	CONSTRAINT uk_idpersona UNIQUE (idpersona)
)
go

INSERT INTO Usuarios(idpersona, usuario, clave) VALUES
	(1,'angelita@','123456')


CREATE TABLE Categorias
(
	idcategoria	int identity(1,1) primary key,
	categoria	varchar(30) not null,
	estado				bit		not null default 1,
	CONSTRAINT uk_categoria UNIQUE (categoria)
)
go

--INSERTAMOS REGISTROS
insert into categorias (categoria) values 
	('Vinos'),
	('Cervezas'),
	('Whiskys'),
	('Ron'),
	('Piscos'),
	('Aguas'),
	('Energizantes')
go

select * from Categorias
select * from marcas
--CREACIÓN DE LA TABLA MARCAS
CREATE TABLE Marcas
(
	idMarca			INT IDENTITY(1,1) PRIMARY KEY,
	marca			VARCHAR(50)		NOT NULL,
	estado			bit		null default 1,
	CONSTRAINT uk_nombreMarca UNIQUE (marca)
)
GO

--INSERTAMOS REGISTROS
insert into marcas (marca) values 
	('Viña vieja'),
	('Tabernero'),
	('Pilsen'),
	('Cristal'),
	('Corona'),
	('Cusqueña'),
	('Red Bull')
go

CREATE TABLE Productos 
(
	idproducto		INT IDENTITY (1,1) PRIMARY KEY,
	codigo			VARCHAR(30)		NOT NULL,
	idcategoria		int		not null,
	idmarca			int 	NOT NULL, -- Debería ser FK
	nombre			VARCHAR(70)		NOT NULL,
	stock			INT				NOT NULL,
	precio			DECIMAL(7,2)	NOT NULL,
	CONSTRAINT R1_idmarca FOREIGN KEY (idmarca) REFERENCES marcas(idmarca),
	CONSTRAINT R2_idcategoria FOREIGN KEY (idcategoria) REFERENCES categorias(idcategoria),
	CONSTRAINT ck_stock_prd CHECK (stock >= 0),
	CONSTRAINT ck_precio_prd CHECK (precio > 0),
	constraint uk_codigo unique(codigo),
)
GO

INSERT INTO productos (codigo, idcategoria, idmarca, nombre, stock, precio) VALUES 
	('A001', 1, 1, 'Gran rose 650ml', 50, 20),
	('A002', 2, 3, 'Pilsen callao 750ml', 48,6),
	('A003', 2, 4, 'Cristal 750ml', 96, 5),
	('A004', 7, 7, 'Red primun 350ml', 20, 10),
	('A005', 5, 2, 'Quebranta 650ml', 10, 25)
	
GO

CREATE TABLE ventas
(
	idventa			INT IDENTITY(1,1) PRIMARY KEY,
	tipocomprobante	CHAR(1)		NOT NULL DEFAULT 'B',
	numcomprobante	INT			NOT NULL, 
	idpersona		INT			NULL, 
	fechaventa		DATETIME	NOT NULL DEFAULT GETDATE(),
	tipopago		VARCHAR(10) NOT NULL DEFAULT 'efectivo',
	CONSTRAINT ck_tipocomprobante_vnt CHECK (tipocomprobante IN ('B','F')),
	CONSTRAINT fk_idcliente_vnt FOREIGN KEY (idpersona) REFERENCES personas(idpersona),
	CONSTRAINT ck_tipopago_vnt CHECK (tipopago IN ('efectivo','yape','plin','visa','depósito'))
)
GO

CREATE TABLE detventa
(
	iddetventa		INT IDENTITY (1,1) PRIMARY KEY,
	idventa			INT			NOT NULL,
	idproducto		INT			NOT NULL,
	cantidad		SMALLINT	NOT NULL,
	precioventa		DECIMAL(7,2)NOT NULL,
	CONSTRAINT fk_idventa_dvt FOREIGN KEY (idventa) REFERENCES ventas (idventa),
	CONSTRAINT fk_idproducto_dvt FOREIGN KEY (idproducto) REFERENCES productos (idproducto),
	CONSTRAINT ck_cantidad_dvt CHECK (cantidad > 0),
	CONSTRAINT ck_precioventa_dvt CHECK (precioventa > 0)
)
GO



CREATE PROCEDURE spu_clientes_listar_todos
AS BEGIN
	SELECT * 
		FROM Personas
		ORDER BY apellidos, nombres
END
GO

create PROCEDURE spu_productos_listar_todos
AS BEGIN
	SELECT	idproducto,
			CONCAT(marca, ' ', nombre) 'descripcion',
			stock,
			precio
		FROM productos
		INNER JOIN Marcas ON Productos.idmarca = Marcas.idmarca
		WHERE stock > 0
		ORDER BY 2
END
GO

CREATE PROCEDURE spu_productos_buscar_codigo
@codigo	VARCHAR(30)
AS BEGIN
	SELECT	idproducto,
			CONCAT(marca, ' ', nombre) 'descripcion',
			stock,
			precio
		FROM productos
		INNER JOIN Marcas ON Productos.idmarca = Marcas.idMarca
		WHERE stock > 0 AND codigo = @codigo
END
GO

CREATE PROCEDURE spu_venta_registrar
	@idventa			INT OUTPUT,
	@tipocomprobante	CHAR(1),
	@numcomprobante		INT,
	@idcliente			INT,
	@tipopago			VARCHAR(10)
AS BEGIN
	
	IF @idcliente = -1 SET @idcliente = NULL

	INSERT INTO ventas (tipocomprobante, numcomprobante, idpersona, tipopago) 
		VALUES (@tipocomprobante, @numcomprobante, @idcliente, @tipopago)

	
	SET @idventa = @@IDENTITY
END
GO


CREATE PROCEDURE spu_detventa_registrar
	@idventa		INT,
	@idproducto		INT,
	@cantidad		SMALLINT,
	@precioventa	DECIMAL(7,2)
AS BEGIN
	INSERT INTO detventa (idventa, idproducto, cantidad, precioventa) VALUES
		(@idventa, @idproducto, @cantidad, @precioventa)

	UPDATE productos SET stock = stock - @cantidad WHERE idproducto = @idproducto
END
GO

select * from detventa
select * from ventas

select * from usuarios