create procedure INSERTAR_UBICACION
@idubicacion int output,
@nombre varchar(50),
@descripcion varchar (150)
as
insert into Ubicacion values (@nombre,@descripcion)
go

create procedure MODIFICAR_UBICACION
@idubicacion int,
@nombre varchar (50),
@descripcion varchar (150)
as
update Ubicacion set @nombre = Nombre, @descripcion = Descripcion
where @idubicacion = idUbicacion
go

create procedure ELIMINAR_UBICACION
@idubicacion int
as
delete from Ubicacion where
@idubicacion = idUbicacion
go

create procedure MOSTRAR_TODOS_UBICACION
as
select * from Ubicacion
go

create procedure MOSTRAR_NOMBRE_UBICACION
@nombre varchar (50)
as
select * from Ubicacion
where @nombre like Nombre +'%'
go 

create procedure MOSTRAR_DESCRIPCION_UBICACION
@descripcion varchar (50)
as
select * from Ubicacion
where @descripcion like Descripcion + '%'
go