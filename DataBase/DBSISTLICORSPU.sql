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

alter PROCEDURE spu_registrar_personas
	@apellidos	VARCHAR(30),
	@nombres		VARCHAR(30),
	@dni		CHAR(8),
	@telefono	CHAR(9)
AS BEGIN
	INSERT INTO Personas(apellidos, nombres, DNI, telefono) VALUES
		(@apellidos, @nombres, @dni, @telefono)
END
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

CREATE PROCEDURE spu_eliminar_persona
	@idpersona int
AS BEGIN
	UPDATE Personas	SET
	estado = 0
WHERE idpersona = @idpersona
END
GO

select * from Personas

CREATE PROCEDURE spu_activar_persona
	@idpersona int
AS BEGIN
	UPDATE Personas	SET
	estado = 1
WHERE idpersona = @idpersona
END
GO

exec spu_activar_persona 3
exec spu_activar_persona 4
exec spu_activar_persona 5
exec spu_activar_persona 6


CREATE PROCEDURE spu_registrar_empleado
	@idpersona		INT,
	@nombreusuario	VARCHAR(50),
	@claveacceso	VARCHAR(90)
AS BEGIN
	INSERT INTO Empleados (idpersona, nombreusuario, claveacceso) VALUES
				(@idpersona, @nombreusuario, @claveacceso)
END
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

alter PROCEDURE spu_modificar_Empleado
	@idmpleado			INT,
	@claveacceso		VARCHAR(90)
AS BEGIN
	UPDATE Empleados SET
		
		claveacceso = @claveacceso
WHERE idempleado = @idmpleado
END
GO

exec spu_modificar_Empleado '1256',3


CREATE PROCEDURE spu_eliminar_empleado
	@idempleado int
AS BEGIN
	UPDATE Empleados SET
	estado = 0
WHERE idempleado = @idempleado
END
GO

alter proc spu_listar_detalleempleado
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

exec spu_vista_persona 1

create proc spu_personas_activas
@estado bit
as begin
select 
		personas.idpersona,
		concat (Personas.apellidos,' ' ,Personas.nombres) as 'Persona'
		

		from Personas
		
		
		where Personas.estado = @estado
		order by idpersona desc
end
go

create proc spu_empleados_activos
@estado bit
as begin
select 
		empleados.idempleado,
		empleados.nombreusuario,
		empleados.claveacceso
		

		from empleados
		
		
		where empleados.estado = @estado
		order by idempleado desc
end
go


CREATE PROCEDURE spu_eliminar_empleado
	@idempleado int
AS BEGIN
	UPDATE Empleados SET
	estado = 0
WHERE idempleado = @idempleado
END
GO

CREATE PROCEDURE spu_listar_producto
	@estado		bit
as begin
	select idproducto,
	codigo,
	nombreCategoria,
	nombreMarca,
	nombreproducto,
	descripcion,
	precio,
	stock,
	caducidad

	from Productos
	inner join  categoria on Productos.idcategoria = categoria.idCategoria
	inner join marcas on Productos.idmarca = marcas.idMarca

	where Productos.estado = @estado
	ORDER BY idproducto DESC
end
go

insert INTO categorias(nombrecategoria) values
('CERVEZAS'),
('VINOS')


drop PROCEDURE spu_registrar_producto
	@idpersona		INT,
	@nombreusuario	VARCHAR(50),
	@claveacceso	VARCHAR(90)
AS BEGIN
	INSERT INTO Empleados (idpersona, nombreusuario, claveacceso) VALUES
				(@idpersona, @nombreusuario, @claveacceso)
END
GO

CREATE PROCEDURE spu_producto_eliminar
	@codigo int
AS BEGIN
	UPDATE Productos SET
	estado = 0
WHERE codigo = @codigo
END
GO

alter proc spu_editar_producto
	@idproducto		int,
	@idmarca		INT,
	@idcategoria	int,
	@nombreproducto	varchar(50),
	@descripcion varchar(100),
	@codigo varchar(30),
	@precio decimal (7,2),
	@stock int,
	@caducidad date
as begin
	UPDATE Productos SET
		idmarca = @idmarca,
		idcategoria = @idcategoria,
		nombreproducto= @nombreproducto,
		descripcion = @descripcion,
		codigo=@descripcion,
		precio = @precio,
		stock = @stock,
		caducidad = @caducidad
WHERE idproducto = @idproducto
end
GO