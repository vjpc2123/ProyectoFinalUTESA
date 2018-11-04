create table Cliente
(
idCliente int primary key identity (1,1),
Estatus bit,
TipoCliente varchar(10),
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
)go

create procedure INSERTAR_CLIENTE(
@idcliente int output,
@estatus varchar(10),
@tipocliente varchar(10),
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
insert into Cliente values (@estatus,@tipocliente,@nombre,@apellido,
@telefono,@direccion,@ciudad,@sector,@contacto,@telefonocontacto,@tipoidentificacion,@identificacion,@correoelectronico)
go

create procedure MODIFICAR_CLIENTE
(
@idcliente int,
@estatus varchar(10),
@tipocliente varchar(10),
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
UPDATE Cliente set Estatus = @estatus,TipoCliente = @tipocliente, Nombre = @nombre, Apellido = @apellido,Telefono = @telefono, Direccion = @direccion,
Ciudad = @ciudad,Sector = @sector, Contacto = @contacto, TelefonoContacto = @telefonocontacto, tipoIdentificacion = @tipoidentificacion, Identificacion	= @identificacion,CorreoElectronico = @correoelectronico
where idCliente like @idcliente + '%'
go

create proc ELIMINAR_CLIENTE
@idcliente int 
as delete from Cliente 
where @idcliente = idCliente
go

alter procedure MOSTRAR_TODOS_CLIENTE
as
select * from Cliente
go

alter procedure MOSTRAR_NOMBRE_CLIENTE
@buscador varchar (50)
as
select * from Cliente
where @buscador like Nombre +'%'
go 

create procedure MOSTRAR_IDENTIFICIACION_CLIENTE
@buscador varchar (50)
as
select * from Cliente
where @buscador like Identificacion + '%'
go