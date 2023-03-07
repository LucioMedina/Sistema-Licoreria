use sistema_licoreria
go

--insertando registros "Personas"

INSERT INTO Personas (apellidos, nombres, DNI, telefono) VALUES
			('Farfan Torres', 'Angelo', '72564289', '953221053'),
			('Cartagena Salazar','Jimena','89735243','983751837'),
			('Mateo Quispe', 'Jean', '64827405','918268376'),
			('Medina Llanos', 'Lucio', '87263549', '918265348')
GO

SELECT * FROM Personas
GO


INSERT INTO Empleados (idpersona, nombreusuario, claveacceso) VALUES
			(1, 'Angelo', 'farfan123'),
			(4, 'lucio', 'medina123')
GO

SELECT * FROM Empleados
GO

INSERT INTO MediosPago (mediopago) VALUES
				('Tarjeta'),
				('Efectivo'),
				('Yape'),
				('Plin')
GO

SELECT * FROM MediosPago
GO 

INSERT INTO Sedes (ciudad, direccion, telefono) VALUES
				('Chincha Alta', 'Av. benavides #255', '928475629'),
				('Pueblo Nuevo', 'Jr. Arica # 506', '918724938'),
				('Tambo de Mora', 'Vilma Leon #320', '972653854')
GO

SELECT * FROM Sedes
GO

INSERT INTO Ventas (idsede, idempleado, idcliente, idmediopago, tipocomprovante, numcomprovante, fechahora) VALUES
					(2, 1, 2, 3, 'Boleta', '0000142', ''),
					(3, 2, 3, 2, 'Factura', '0000465', '')
GO

SELECT * FROM Ventas
GO

insert into marcas (nombreMarca) values ('Viña vieja')
insert into marcas (nombreMarca) values ('Tabernero')
go

select * from marcas
go

insert into categoria (nombreCategoria) values ('Vinos')
insert into categoria (nombreCategoria) values ('Cervezas')
go


select * from categoria
go

insert into Productos (idmarca, idcategoria, nombreproducto, descripcion, precio, stock, caducidad) values 
	(1, 2, 'Gran borgoña', 'Semi Seco Botella 750ml', 16.0, 10, '01-03-2024')
go

SELECT * FROM Empleados
SELECT * FROM Personas
SELECT * FROM Ventas
SELECT * FROM Compras
SELECT * FROM Productos
GO


insert into DetalleVenta (idventa, idproducto, cantidad, precioventa) values 
	(3, 4, 2, 32.0)
go

select * from detalleCompra
go

insert into Proveedores (nombreprov, direccion, RUC, telefono) values 
	('El Pozito', 'Lima av. Victoria #120', 45367876776, 987654376)
go
DELETE FROM Proveedores
GO

select * from Proveedores
go

insert into Compras (idproveedor) values 
	(1)
go

select * from compras
go

insert into detalleCompra (idcompras, idproductos, cantidad, preciocompra) values
	(2, 4, 2, 32.0)
go

select * from detalleCompra
go