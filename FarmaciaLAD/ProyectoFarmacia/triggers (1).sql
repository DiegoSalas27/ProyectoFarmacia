USE [dbFarmacia]
GO
/****** Object:  Trigger [dbo].[ActualizarStock]    Script Date: 4/29/2018 9:36:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[ActualizarStock] ON [dbo].[Ingreso]
for insert
as

begin
declare @id_producto int
declare @cantidad int

select @id_producto = Codigo_producto, @cantidad = Cantidad from inserted

update Producto
set Stock = Stock + @cantidad
where Codigo_Producto = @id_producto
end

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[DeleteIngreso] ON [dbo].[Ingreso]
for delete
as

begin
declare @id_producto int
declare @cantidad int

select @id_producto = Codigo_producto, @cantidad = Cantidad from deleted

update Producto
set Stock = Stock - @cantidad
where Codigo_Producto = @id_producto
end

GO
/****** Object:  Trigger [dbo].[ActualizarStock2]    Script Date: 4/29/2018 9:36:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*igual sucede al eliminar presentacion, categoria y laboratorio*/
/*se elimina del listado de productos a aquellos cuya categoria, marca, presentacion o laboratorios dejan de existir*/
create trigger [dbo].[ActualizarStock2] on [dbo].[Marca] 
for delete
as

begin
declare @id_marca int

select @id_marca = Codigo_Marca from deleted

delete from Producto where Marca = @id_marca
end

create trigger DeleteProducto on Categoria
for delete
as

begin
declare @id_categoria int

select @id_categoria = Codigo_Categoria from deleted

delete from Producto where Categoria = @id_categoria
end

create trigger DeleteProducto2 on Laboratorio
for delete
as
begin
declare @id_laboratorio int

select @id_laboratorio = Codigo_Laboratorio from deleted

delete from Producto where Laboratorio = @id_laboratorio
end

create trigger DeleteProducto3 on Presentacion
for delete
as
begin
declare @id_presentacion int

select @id_presentacion = Codigo_Presentacion from deleted

delete from Producto where Presentacion = @id_presentacion
end
