-- PROCEDIMIENTOS ALMACENADOS
use sistema_licoreria
go

-- TABLA PERSONAS

CREATE PROCEDURE spu_registrar_personas
	@apellido	VARCHAR(30),
	@nombre		VARCHAR(30),
	@dni		CHAR(8),
	@telefono	CHAR(9)
AS BEGIN
	INSERT INTO Personas(apellidos, nombres, DNI, telefono) VALUES
		(@apellido, @nombre, @dni, @telefono)
END
GO

EXEC spu_registrar_personas 'casillas', 'aurelio', '68793745', '987654321'
GO

CREATE PROCEDURE spu_listar_personas
	@estado		BIT
AS BEGIN
	SELECT	idpersona,
	apellidos,
	nombres,
	dni,
	telefono FROM Personas 
WHERE estado = @estado

ORDER BY idpersona DESC
END
GO

EXEC spu_listar_personas 1
GO

CREATE PROCEDURE spu_modificar_personas
	@idpersona		INT,
	@apellidos		VARCHAR(30),
	@nombres		VARCHAR(30),
	@dni			CHAR(8),
	@telefono		CHAR(9)
AS BEGIN
	UPDATE Personas SET
		apellidos = @apellidos,
		nombres = @nombres,
		DNI = @dni,
		telefono = @telefono
WHERE idpersona = @idpersona
END
GO

EXEC spu_modificar_personas 10, 'Casillas Torres', 'aurelio', '68793745', '987654321'
GO

CREATE PROCEDURE spu_eliminar_presonas
	@idpersona int
AS BEGIN
	UPDATE Personas	SET
	estado = 0
WHERE idpersona = @idpersona
END
GO

EXEC spu_eliminar_presonas 10
GO

CREATE PROCEDURE spu_buscar_personas
@dni CHAR(8)
AS BEGIN
	SELECT
		Personas.idpersona,
		Personas.apellidos,
		Personas.nombres,
		Personas.DNI,
		Personas.telefono,
		Personas.estado
		FROM Personas
		WHERE Personas.estado = '1' AND Personas.DNI = @dni;
END
GO

EXEC spu_buscar_personas '89735243'
GO
	

-- TABLA EMPLEADOS

CREATE PROCEDURE spu_registrar_empleado
	@idpersona		INT,
	@nombreusuario	VARCHAR(50),
	@claveacceso	VARCHAR(90)
AS BEGIN
	INSERT INTO Empleados (idpersona, nombreusuario, claveacceso) VALUES
				(@idpersona, @nombreusuario, @claveacceso)
END
GO

EXEC spu_registrar_empleado 8, 'Jean', 'mateo123'
GO

CREATE PROCEDURE spu_listar_empleado
	@estado BIT
AS BEGIN
	SELECT 
	idpersona,
	nombreusuario,
	claveacceso 
	FROM Empleados 
	WHERE estado = @estado
ORDER BY idempleado DESC
END
GO

EXEC spu_listar_empleado 1
GO

CREATE PROCEDURE spu_modificar_Empleado
	@idpersona			INT,
	@claveacceso		VARCHAR(90)
AS BEGIN
	UPDATE Empleados SET
		idpersona = @idpersona,
		claveacceso = @claveacceso
WHERE idpersona = @idpersona
END
GO

EXEC spu_modificar_Empleado 8, '123456'
GO

CREATE PROCEDURE spu_eliminar_empleado
	@idempleado int
AS BEGIN
	UPDATE Empleados SET
	estado = 0
WHERE idempleado = @idempleado
END
GO

CREATE PROCEDURE spu_buscar_empleado
@idempleado INT
AS BEGIN
	SELECT 
		nombreusuario,
		claveacceso
		FROM Empleados
		WHERE Empleados.estado = '1' AND Empleados.idempleado = @idempleado;
END
GO

EXEC spu_buscar_empleado 2
GO

-- TABLA PRODUCTOS
CREATE PROCEDURE spu_registrar_producto
	@idmarca		INT,
	@idcategoria	INT,
	@nombreproducto	VARCHAR(50),
	@descripcion	VARCHAR(100),
	@precio			DECIMAL(7,2),
	@stock			SMALLINT,
	@caducidad		DATE
AS BEGIN
	INSERT INTO Productos(idmarca, idcategoria, nombreproducto, descripcion, precio, stock, caducidad) VALUES
				(@idmarca, @idcategoria, @nombreproducto, @descripcion, @precio, @stock, @caducidad)
END
GO

EXEC spu_registrar_producto '2', '1', 'Borgoña', 'Vino Tinto 1L', '30', '5', '02-03-2024'
GO

SELECT * FROM categoria
GO

CREATE PROCEDURE spu_listar_producto
    @estado        bit
as begin
    select idproducto,
    nombreCategoria,
    nombreproducto,
    nombreMarca,
    descripcion,
    precio,
    stock,
    caducidad     from Productos
    inner join  categoria on Productos.idcategoria = categoria.idCategoria
    inner join marcas on Productos.idmarca = marcas.idMarca     
	where Productos.estado = @estado
    ORDER BY idproducto DESC
end
go 

exec spu_listar_producto 1
go

CREATE PROCEDURE spu_modificar_producto
	@idproducto		 INT,
	@idMarca		 INT,
	@idCategoria	 INT,
	@nombreproducto  VARCHAR(50),
	@descripcion	 VARCHAR(100),
	@precio			 DECIMAL(7,2),
	@stock			 SMALLINT,
	@caducidad		 DATE
AS BEGIN
	UPDATE Productos SET
	idmarca = @idMarca,
	idcategoria = @idCategoria,
	nombreproducto	= @nombreproducto,
	descripcion = @descripcion,
	precio	= @precio,
	stock	= @stock,
	caducidad = @caducidad		
WHERE idproducto = @idproducto
END
GO

EXEC spu_modificar_producto 4, 2, 1, 'Borgoña', 'Vino seco 1L', '30', '10', '02-03-2024'
GO

DELETE FROM Productos
GO

SELECT * FROM Productos
GO

CREATE PROCEDURE spu_buscar_producto
    @idproducto        INT
as begin
    select idproducto,
    nombreCategoria,
    nombreproducto,
    nombreMarca,
    descripcion,
    precio,
    stock,
    caducidad     from Productos
    inner join  categoria on Productos.idcategoria = categoria.idCategoria
    inner join marcas on Productos.idmarca = marcas.idMarca     
	where Productos.idproducto = @idproducto
    ORDER BY idproducto DESC
end
go

EXEC spu_buscar_producto 3
GO

SELECT * FROM Compras
GO

CREATE PROCEDURE spu_eliminar_productos
	@idproducto int
AS BEGIN
	UPDATE Productos	SET
	estado = 0
WHERE idproducto = @idproducto
END
GO

EXEC spu_eliminar_productos 3
GO

CREATE PROCEDURE spu_activar_productos
	@idproducto int
AS BEGIN
	UPDATE Productos	SET
	estado = 1
WHERE idproducto = @idproducto
END
GO

EXEC spu_activar_productos 3
GO

SELECT * FROM Productos
GO

--TABLA VENTA

CREATE PROCEDURE spu_registrar_venta
	@idmediopago	 INT,
	@idsede			 INT,
	@idcliente  	 INT,
	@idempleado		 INT,
	@tipocomprovante VARCHAR(30),
	@numcomprovante	 VARCHAR(7)
AS BEGIN
	INSERT INTO Ventas(idmediopago, idsede, idcliente, idempleado, tipocomprovante, numcomprovante) VALUES
				(@idmediopago, @idsede, @idcliente, @idempleado, @tipocomprovante, @numcomprovante)
END
GO

EXEC spu_registrar_venta '3','2','2','3','Boleta','0000951'
GO

SELECT * FROM Empleados
SELECT * FROM Personas
SELECT * FROM detalleventa
select * from Ventas
SELECT * FROM Compras
SELECT * FROM Productos
GO

select  DetalleVenta.iddetalleventa,
		DetalleVenta.idproducto,
		DetalleVenta.cantidad,
		DetalleVenta.precioventa,
		DetalleVenta.cantidad * DetalleVenta.precioventa'Importe'
    from DetalleVenta
    INNER JOIN Productos on DetalleVenta.idproducto = Productos.idproducto
    INNER JOIN Ventas on DetalleVenta.idventa = Ventas.idventa
where DetalleVenta.idventa = 3
go

SELECT 
	DetalleVenta.iddetalleventa,
	Productos.nombreproducto,
	Productos.precio,
	DetalleVenta.cantidad,
	DetalleVenta.cantidad * DetalleVenta.precioventa 'Total'
    from DetalleVenta
    INNER JOIN Productos on DetalleVenta.idproducto = Productos.idproducto
    INNER JOIN Ventas on DetalleVenta.idventa = Ventas.idventa
go

select * from DetalleVenta
go

--TABLA DETALLECOMPRA
SELECT * FROM detalleCompra
GO

CREATE PROCEDURE spu_registrar_detallecompra
	@idcompras		INT,
	@idproductos	INT,
	@cantidad		SMALLINT,
	@preciocompra	DECIMAL(7,2)
AS BEGIN
	INSERT INTO detalleCompra(idcompras,idproductos,cantidad,preciocompra) VALUES
		(@idcompras,@idproductos,@cantidad,@preciocompra)
END
GO

EXEC spu_registrar_detallecompra '2','3','2','30'
GO

CREATE PROCEDURE spu_modificar_detallecompra
	@iddecompra		INT,
	@idcompras		INT,
	@idproductos	INT,
	@cantidad		SMALLINT,
	@preciocompra	DECIMAL(7,2)
AS BEGIN
	UPDATE detalleCompra SET
	idcompras = @idcompras,
	idproductos = @idproductos,
	cantidad	= @cantidad,
	preciocompra = @preciocompra
WHERE iddecompra = @iddecompra
END

EXEC spu_modificar_detallecompra '1005','2','3','2','60'
GO

SELECT * FROM detalleCompra
GO

SELECT * FROM DetalleVenta
GO 

--TABLA DETALLEVENTA
CREATE PROCEDURE spu_registrar_detalleventa
	@idventa		INT,
	@idproducto		INT,
	@cantidad		SMALLINT,
	@precioventa	DECIMAL(7,2)
AS BEGIN
	INSERT INTO DetalleVenta (idventa,idproducto,cantidad,precioventa) VALUES
		(@idventa,@idproducto,@cantidad,@precioventa)
END

EXEC spu_registrar_detalleventa '4','4','2','32'
GO