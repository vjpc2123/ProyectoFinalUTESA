/*Procedimientos Almacenados Presentacion*/
create procedure INSERTAR_PRESENTACION
@idpresentacion int output,
@nombre varchar (50),
@descripcion varchar(150)
as Insert Into Presentacion values (@nombre,@descripcion)
go

alter proc MODIFICAR_PRESENTACION
@idpresentacion int,
@nombre varchar (50),
@descripcion varchar (150)
as update Presentacion set Nombre = @nombre, Descripcion = @descripcion
where @idpresentacion = idPresentacion
go

create proc ELIMINAR_PRESENTACION
@idpresentacion int output
as delete from Presentacion 
where @idpresentacion = idPresentacion
go

create proc MOSTRAR_TODOS_PRESENTACION
as select * from Presentacion
go

create proc MOSTRAR_NOMBRE_PRESENTACION
@nombre varchar (50)
as select * from Presentacion
where Nombre like @nombre + '%'
order by idPresentacion asc
go

create proc MOSTRAR_DESCRIPCION_PRESENTACION
@descripcion varchar (150)
as select * from Presentacion
where Descripcion like @descripcion + '%'
order by idPresentacion asc
go