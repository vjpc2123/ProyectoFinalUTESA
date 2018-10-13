/*Procedimientos Almacenados Categoria*/
create procedure INSERTAR_CATEGORIA
@idcategoria int output,
@nombre varchar (50),
@descripcion varchar(150)
as Insert Into Categoria values (@nombre,@descripcion)
go

alter proc MODIFICAR_CATEGORIA
@idcategoria int,
@nombre varchar (50),
@descripcion varchar (150)
as update Categoria set Nombre = @nombre, Descripcion = @descripcion
where @idcategoria = idCategoria
go

create proc ELIMINAR_CATEGORIA
@idcategoria int output
as delete from Categoria 
where @idcategoria = idCategoria
go

create proc MOSTRAR_TODOS_CATEGORIA
as select * from Categoria
go

create proc MOSTRAR_NOMBRE_CATEGORIA
@nombre varchar (50)
as select * from Categoria
where Nombre like @nombre + '%'
order by idCategoria asc
go

create proc MOSTRAR_DESCRIPCION_CATEGORIA
@descripcion varchar (150)
as select * from Categoria
where Descripcion like @descripcion + '%'
order by idCategoria asc
go