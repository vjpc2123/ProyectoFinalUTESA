use Proyecto_Grado

create table Compra(
idCompra int primary key identity (1,1),
idProveedor int,
NumeroComprobante varchar (20),
TipoDocumento varchar (20),
FechaCompra date,

Constraint FK_PROVEEDOR_COMPRA
foreign key (idProveedor) references Suplidor(idSuplidor)
ON UPDATE CASCADE
ON DELETE CASCADE
)
go

create table detalleCompra(
idDetalleCompra int primary key identity (1,1),
idCompra int,
idArticulo int,
cantidad int,
costoUnitario decimal(18,4),
CompraBruto decimal (18,4),
Descuento decimal (18,4),
ITBIS decimal (18,4),
CompraNeto decimal (18,4),

Constraint FK_detalle_COMPRA
foreign key (idCompra) references Compra(idCompra)
ON UPDATE CASCADE
ON DELETE CASCADE,

Constraint FK_ARTICULO_COMPRAS
foreign key (idArticulo) references Articulo(idArticulo)
ON UPDATE CASCADE
ON DELETE CASCADE
)
go

create procedure INSERTAR_COMPRA
@idCompra int output,
@idProveedor int,
@NumeroComprobante varchar (20),
@TipoDocumento varchar (20),
@FechaCompra date
as
insert into Compra values (@idProveedor,@NumeroComprobante,@TipoDocumento,@FechaCompra)
go

create procedure MODIFICAR_COMPRA
@idCompra int,
@idProveedor int,
@NumeroComprobante varchar (20),
@TipoDocumento varchar (20),
@FechaCompra date
as 
update Compra set @idProveedor = idProveedor ,
@NumeroComprobante =  NumeroComprobante,
@TipoDocumento= TipoDocumento,
@FechaCompra = FechaCompra

go

create procedure INSERTAR_DETALLE_COMPRA
@idDetalleCompra int output,
@idCompra int,
@idArticulo int,
@cantidad int,
@costoUnitario decimal(18,4),
@CompraBruto decimal (18,4),
@Descuento decimal (18,4),
@ITBIS decimal (18,4),
@CompraNeto decimal (18,4)
as	
insert into detalleCompra values (@idCompra,@idArticulo,@cantidad,@costoUnitario,@CompraBruto,@Descuento,@ITBIS,@CompraNeto)
