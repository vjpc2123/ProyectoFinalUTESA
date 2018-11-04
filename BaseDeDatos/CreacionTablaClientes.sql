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
@estatus bit,
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
@idcliente int output,
@estatus bit,
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
