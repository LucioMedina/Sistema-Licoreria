CREATE DATABASE VENTAS_LICOR
GO

USE VENTAS_LICOR
GO



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


--PROCEDIMIENTOS ALMACENADOS

--LISTAR PERSONA
CREATE PROCEDURE spu_listar_personas

AS BEGIN
	SELECT	idpersona,
	apellidos,
	nombres,
	dni,
	telefono FROM Personas 


ORDER BY idpersona DESC
END
GO
--REGISTRAR PERSONA
CREATE PROCEDURE spu_registrar_personas
	@apellidos	VARCHAR(30),
	@nombres		VARCHAR(30),
	@dni		CHAR(8)
	
AS BEGIN
	INSERT INTO Personas(apellidos, nombres, DNI) VALUES
		(@apellidos, @nombres, @dni)
END
GO
--EDITAR PERSONA
CREATE PROCEDURE spu_modificar_personas
	@idpersona		INT,
	@apellidos		VARCHAR(30),
	@nombres		VARCHAR(30),
	@dni			CHAR(8)
	
AS BEGIN
	UPDATE Personas SET
		apellidos = @apellidos,
		nombres = @nombres,
		DNI = @dni
		
WHERE idpersona = @idpersona
END
GO
--ELIMINAR
CREATE PROCEDURE spu_eliminar_persona
	@idpersona int
AS BEGIN
	UPDATE Personas	SET
	estado = 0
WHERE idpersona = @idpersona
END
GO

-- SPU DE EMPLEADOS
---CREATE
CREATE PROCEDURE spu_registrar_empleado
	@idpersona		INT,
	@nombreusuario	VARCHAR(50),
	@claveacceso	VARCHAR(90)
AS BEGIN
	INSERT INTO Empleados (idpersona, nombreusuario, claveacceso) VALUES
				(@idpersona, @nombreusuario, @claveacceso)
END
GO
--LISTAR
CREATE PROCEDURE spu_listar_empleado
	@estado BIT
AS BEGIN
	SELECT 
	idpersona,
	idempleado,
	nombreusuario,
	claveacceso 
	FROM Empleados 
	WHERE estado = @estado
ORDER BY idempleado DESC
END
GO
--MODIFICAR
CREATE PROCEDURE spu_modificar_Empleado
	@idmpleado			INT,
	@claveacceso		VARCHAR(90)
AS BEGIN
	UPDATE Empleados SET
		claveacceso = @claveacceso
WHERE idempleado = @idmpleado
END
GO
--ELIMINAR
CREATE PROCEDURE spu_eliminar_empleado
	@idempleado int
AS BEGIN
	UPDATE Empleados SET
	estado = 0
WHERE idempleado = @idempleado
END
GO
--SPU
CREATE proc spu_listar_detalleempleado
@estado bit
as begin
select empleados.idempleado,
		personas.idpersona,
		concat (Personas.apellidos,' ' ,Personas.nombres) as 'Persona',
		empleados.nombreusuario, empleados.claveacceso

		from empleados
		inner join Personas on empleados.idpersona = Personas.idpersona
		
		where empleados.estado = @estado
		order by idempleado desc
end
go
		
create proc spu_vista_persona
@estado bit
as begin
select 
		personas.idpersona,
		concat (Personas.apellidos,' ' ,Personas.nombres) as 'Persona',
		empleados.nombreusuario, empleados.claveacceso

		from Personas
		inner join empleados on empleados.idpersona = Personas.idpersona
		
		where Personas.estado = @estado
		order by idpersona desc
end
go	

--PROCEDIMIENTO DE PRODUCTOS

--LISTAR PRODUCTO
CREATE PROCEDURE spu_listar_producto
	@estado		bit
as begin
	select idproducto 'Id',
	codigo 'Código',
	nombreCategoria 'Categoria',
	nombreMarca 'Marca',
	nombreproducto 'Producto',
	descripcion 'Descripción',
	precio 'Precio',
	stock 'Stock',
	caducidad 'Caducidad'

	from Productos
	inner join  Categorias on Productos.idcategoria = Categorias.idCategoria
	inner join marcas on Productos.idmarca = marcas.idMarca

	where Productos.estado = @estado
	ORDER BY idproducto DESC
end
go

--REGISTRAR PRODUCTO
CREATE proc spu_registrar_producto
	@codigo			varchar(30),
	@idmarca		INT,
	@idcategoria	int,
	@nombre	varchar(70),
	@precio decimal (7,2),
	@stock int

as begin
	insert into Productos (codigo,idcategoria,idmarca,nombre,precio,stock)values
		 (@codigo,@idcategoria,@idmarca,@nombre,@precio,@stock)
end
GO
--EDITAR PRODUCTO
CREATE proc spu_editar_producto
	@idproducto		int,
	@idmarca		INT,
	@idcategoria	int,
	@nombre	varchar(70),
	@codigo varchar(30),
	@precio decimal (7,2),
	@stock int
	
as begin
	UPDATE Productos SET
		codigo=@codigo,
		idcategoria = @idcategoria,
		idmarca = @idmarca,
		nombre= @nombre,
		precio = @precio,
		stock = @stock
WHERE idproducto = @idproducto
end
GO
--ELIMINAR
CREATE PROCEDURE spu_producto_eliminar
	@codigo varchar(30)
AS BEGIN
	UPDATE Productos SET
	estado = 0
WHERE codigo = @codigo
end
GO

SELECT * FROM Productos

create PROCEDURE spu_listar_persona
	@estado		BIT
AS BEGIN
	SELECT	
	dni,
	apellidos,
	nombres,
	telefono,
	idpersona FROM Personas 
	
WHERE estado = @estado
end
go

create PROCEDURE spu_listar_productomodi
	
as begin
	select 
	idproducto,
	codigo 'Código',
	categoria 'Categoria',
	marca 'Marca',
	nombre 'Producto',
	stock 'Stock',
	precio 'Precio'
	from Productos
	inner join  Categorias on Productos.idcategoria = Categorias.idCategoria
	inner join marcas on Productos.idmarca = marcas.idMarca
	ORDER BY idproducto DESC
end
go


CREATE PROCEDURE spu_login_usuario
@usuario VARCHAR(30)
AS
BEGIN
SELECT Usuarios.idusuario,
	usuario,clave
	FROM Usuarios
	INNER JOIN personas ON Personas.idpersona =Usuarios.idpersona
	WHERE usuario = @usuario 
		
		
END
GO


--spu proveedores

--listar
create proc spu_listar_proveedor
@estado bit
as begin
select idproveedor,nombreprov,direccion,ruc,telefono
from proveedores where estado = @estado
ORDER BY idproveedor DESC

end 
go

--registrar
CREATE proc spu_registrar_proveedor
	@nombreprov		varchar(50),
	@direccion		varchar(50),
	@ruc			char(11),
	@telefono		varchar(9)
	
as begin
	insert into Proveedores(nombreprov,direccion,ruc,telefono)values
		 (@nombreprov,@direccion,@ruc,@telefono)
end
GO
--editar

CREATE proc spu_editar_proveedor
	@nombreprov		varchar(50),
	@direccion		varchar(50),
	@ruc			char(11),
	@telefono		varchar(9),
	@idproveedor  int
	
as begin
	UPDATE Proveedores SET
		nombreprov=@nombreprov,
		direccion= @direccion,
		ruc = @ruc,
		telefono= @telefono
		
WHERE idproveedor= @idproveedor
end
GO
--eliminar
CREATE PROCEDURE spu_proveedor_eliminar
	@idproveedor int
AS BEGIN
	UPDATE Proveedores SET
	estado = 0
WHERE idproveedor = @idproveedor
end
GO
--spu_registrar_categoria

--listar
create proc spu_listar_categoria

as begin
select idcategoria,categoria
from Categorias 
ORDER BY idcategoria DESC

end 
go
--registrar
CREATE proc spu_registrar_categoria
	@categoria	varchar(50)
as begin
	insert into Categorias(categoria)values
		 (@categoria)
end
GO
--editar
CREATE proc spu_editar_categoria
	@nombrecategoria		varchar(50),
	@idcategoria int
as begin
	update Categorias set 
	nombrecategoria = @nombrecategoria
		
WHERE idcategoria= @idcategoria
end
GO

--eliminar
CREATE PROCEDURE spu_eliminar_categoria
	@idcategoria int
AS BEGIN
	UPDATE Categorias SET
	estado = 0
WHERE idcategoria = @idcategoria
end
GO


--spu marcas

--listar
create proc spu_listar_marca
as begin
select idmarca,marca
from Marcas 
ORDER BY idmarca DESC

end 
go
--registrar
CREATE proc spu_registrar_marca
	@marca	varchar(50)
as begin
	insert into Marcas(marca)values
		 (@marca)
end
GO
--editar
CREATE proc spu_editar_marca
	@marca		varchar(50),
	@idmarca int
as begin
	update Marcas set 
	marca = @marca
		
WHERE idmarca= @idmarca
end
GO

--eliminar
CREATE PROCEDURE spu_eliminar_marca
	@idmarca int
AS BEGIN
	UPDATE marcas SET
	estado = 0
WHERE idmarca = @idmarca
end
GO
select * from Proveedores



CREATE PROCEDURE spu_clientes_listar_todos
AS BEGIN
	SELECT * 
		FROM Personas
		ORDER BY apellidos, nombres
END
GO

ALTER PROCEDURE spu_productos_listar_todos
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



CREATE PROCEDURE spu_compra_registrar
	@idcompra			INT OUTPUT,
	@tipocomprobante	CHAR(1),
	@numcomprobante		INT,
	@idproveedor			INT,
	@tipopago			VARCHAR(10)
AS BEGIN
	
	IF @idproveedor = -1 SET @idproveedor = NULL

	INSERT INTO compras (tipocomprobante, numcomprobante, idproveedor, tipopago) 
		VALUES (@tipocomprobante, @numcomprobante, @idproveedor, @tipopago)

	
	SET @idcompra = @@IDENTITY
END
GO



create procedure spu_proveedor_registrar

	@nombreprov			varchar(50),
	@ruc				char(11),
	@direccion			varchar(50),
	@telefono			char(9)
AS BEGIN
	INSERT INTO proveedores (nombreprov, direccion, ruc,telefono) VALUES
		(@nombreprov, @ruc, @direccion, @telefono)

END
GO

create procedure spu_proveedor_editar
	@idproveedor		int,
	@nombreprov			varchar(50),
	@ruc				char(11),
	@direccion			varchar(50),
	@telefono			char(9)
as begin
	update Proveedores set 
	nombreprov = @nombreprov,
	ruc =@ruc,
	direccion = @direccion,
	telefono = @telefono
	where idproveedor = @idproveedor
end
go


create proc spu_proveedor_listar

as begin
select idproveedor,nombreprov,direccion,ruc,telefono
from proveedores 
ORDER BY idproveedor DESC

end 
go

CREATE PROCEDURE spu_detcompra_registrar
	@idcompra		INT,
	@idproducto		INT,
	@cantidad		SMALLINT,
	@precioventa	DECIMAL(7,2),
	@preciocompra	decimal(7,2)
AS BEGIN
	INSERT INTO detallecompra (idcompra, idproducto, cantidad, precioventa,preciocompra) VALUES
		(@idcompra, @idproducto, @cantidad, @precioventa,@preciocompra)

	UPDATE productos SET stock = stock + @cantidad WHERE idproducto = @idproducto
END
GO

