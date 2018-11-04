create table Suplidor
(
idSuplidor int primary key identity (1,1),
Estatus VARCHAR(10),
TipoSuplidor varchar(10),
Nombre varchar(50),
Apellido varchar (50),
Telefono varchar (20),
Direccion varchar(150),
Ciudad varchar (150),
Sector varchar (150),
Contacto varchar (50),
TelefonoContacto varchar (20),
tipoIdentificacion varchar (20),
Identificacion varchar(20),
CorreoElectronico varchar (150)
)
go

ALTER  procedure INSERTAR_SUPLIDOR(
@idsuplidor int output,
@estatus varchar(10),
@tiposuplidor varchar(10),
@nombre varchar(50),
@apellido varchar (50),
@telefono varchar (20),
@direccion varchar(150),
@ciudad varchar (150),
@sector varchar (150),
@contacto varchar (50),
@telefonocontacto varchar (20),
@tipoidentificacion varchar (20),
@identificacion varchar(20),
@correoelectronico varchar (150)
)
as 
insert into Suplidor values (@estatus,@tiposuplidor,@nombre,@apellido,
@telefono,@direccion,@ciudad,@sector,@contacto,@telefonocontacto,@tipoidentificacion,@identificacion,@correoelectronico)
go


create procedure MODIFICAR_SUPLIDOR
(
@idsuplidor int,
@estatus varchar(10),
@tiposuplidor varchar(10),
@nombre varchar(50),
@apellido varchar (50),
@telefono varchar (20),
@direccion varchar(150),
@ciudad varchar (150),
@sector varchar (150),
@contacto varchar (50),
@telefonocontacto varchar (20),
@tipoidentificacion varchar (20),
@identificacion varchar(20),
@correoelectronico varchar (150)
)as 
UPDATE Suplidor set Estatus = @estatus,TipoSuplidor = @tiposuplidor, Nombre = @nombre, Apellido = @apellido,Telefono = @telefono, Direccion = @direccion,
Ciudad = @ciudad,Sector = @sector, Contacto = @contacto, TelefonoContacto = @telefonocontacto, tipoIdentificacion = @tipoidentificacion, Identificacion	= @identificacion,CorreoElectronico = @correoelectronico
where idSuplidor = @idsuplidor
go

create proc ELIMINAR_SUPLIDOR
@idsuplidor int 
as delete from Suplidor 
where @idsuplidor = idSuplidor
go


create procedure MOSTRAR_TODOS_SUPLIDORES	
as
select * from Suplidor
go

Create procedure MOSTRAR_NOMBRE_SUPLIDORES
@buscador varchar (50)
as
select * from Suplidor
where @buscador like Nombre +'%'
go 

create procedure MOSTRAR_IDENTIFICIACION_SUPLIDORES
@buscador varchar (50)
as
select * from Suplidor
where @buscador like Identificacion + '%'
go