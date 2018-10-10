/*Procedimiento Almacenados Marca*/
create procedure INSERTAR_MARCA
@idmarca int output,
@nombre varchar (50),
@descripcion varchar(150)
as Insert Into Marca values (@nombre,@descripcion)
go



create proc MODIFICAR_MARCA
@idmarca int,
@nombre varchar (50),
@descripcion varchar (150)
as update Marca set Nombre = @nombre, Descripcion = @descripcion
where @idmarca = idMarca
go

create proc ELIMINAR_MARCA
@idmarca int 
as delete from Marca 
where @idmarca = idMarca
go

create proc MOSTRAR_TODOS_MARCA
as select * from Marca
go

create proc MOSTRAR_NOMBRE_MARCA
@nombre varchar (50)
as select * from Marca
where Nombre like @nombre + '%'
order by idMarca asc
go

create proc MOSTRAR_DESCRIPCION_MARCA
@descripcion varchar (150)
as select * from Marca
where Descripcion like @descripcion + '%'
order by idMarca asc
go