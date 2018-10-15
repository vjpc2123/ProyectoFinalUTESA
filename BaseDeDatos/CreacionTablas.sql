

create table Articulo
(
idArticulo int primary key identity (1,1),
Nombre varchar (50) not null,
Descripcion varchar (50) not null,
Imagen image,
idCategoria int,
idPresentacion int,

CONSTRAINT FK_CATEGORIA_ARTICULO
Foreign Key (idCategoria) References Categoria(idCategoria)
ON UPDATE CASCADE
ON DELETE CASCADE,

CONSTRAINT FK_PRESETACION_ARTICULO
Foreign Key (idPresentacion) References Presentacion(idPresentacion)
ON UPDATE CASCADE
ON DELETE CASCADE

) 




alter table Articulo
add idUbicacion int, idMarca int,
Constraint FK_UBICACION_ARTICULO
Foreign key (idUbicacion) references Ubicacion(idUbicacion)
on update cascade
on delete cascade,
constraint FK_MARCA_ARTICULO
foreign key (idMarca) references Marca(idMarca)
on update cascade
on delete cascade
go

create table Ubicacion(
idUbicacion int primary key identity(1,1),
Nombre varchar(50),
Descripcion varchar (150)
)

create table Marca(
idMarca int primary key identity (1,1),
Nombre varchar (50),
Descripcion varchar (150)
)


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
)GO

