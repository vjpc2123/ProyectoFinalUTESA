create database Proyecto_Grado
use Proyecto_Grado

create table Cliente
(idCliente int primary key identity(1,1),
Estatus bit,
tipoCliente bit,
Nombre varchar (150) not null,
Apellido varchar(150),
Telefono varchar(20), 
Direccion varchar (150) not null,
Ciudad varchar(150),
Sector varchar(150),
Contacto varchar (50),
TipoIdentificacion varchar (25),
Identificacion varchar (20) not null,
CorreoElectronico varchar(150)
)

create table Articulo
(
idArticulo int primary key identity (1,1),
Nombre varchar (50) not null,
Descripcion varchar (50) not null,
Imagen image,
idCategora int,
idPresentacion int
)
alter table Articulo
add PrecioVenta money

create table Categoria
(
idCategoria int primary key identity (1,1),
Nombre varchar(50) not null,
Descripcion varchar (150)
)

create table Presentacion 
(
idPresentacion int primary key identity (1,1),
Nombre varchar(60) not null,
Descripcion varchar (150)
)

create table Almacen
(
idAlmacen int primary key identity (1,1),
Nombre Varchar (50) not null,
Descripcion varchar (150) not null,
Direccion varchar (100),
Telefono varchar (20)
)

create table detalle_venta
(
idDetalleVenta int primary key identity (1,1),
idVenta int not null,
cantidad int,
precioVenta money,
Descuento decimal(18,4),
ITBIS money,
Subtotal money,
Total money
)

create table Factura
(
idVenta int primary key identity (1,1),
idCliente int,
fecha date,
Estado varchar(20),
DocumentoFiscal varchar(20),
)