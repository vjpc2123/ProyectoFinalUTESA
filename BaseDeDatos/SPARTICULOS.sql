/*Procedimiento almacenado Articulo*/

alter proc INSERTAR_ARTICULO
@idarticulo int output,
@nombre varchar(50),
@descripcion varchar(150),
@imagen image,
@idcategoria int,
@idpresentacion int,
@idubicacion int,
@idmarca int
as
insert into Articulo(Nombre,Descripcion,Imagen,idCategoria,idPresentacion,idUbicacion,idMarca)
values (@nombre,@descripcion,@imagen,@idcategoria,@idpresentacion,@idubicacion,@idmarca)
SET @idarticulo = @@IDENTITY
GO


create proc MODIFICAR_ARTICULO
@idarticulo int ,
@nombre varchar(50),
@descripcion varchar(150),
@imagen image,
@idcategoria int,
@idpresentacion int,
@idubicacion int,
@idmarca int
as 
update Articulo set Nombre=@nombre,Descripcion=@descripcion,Imagen=@imagen,
idCategoria = @idcategoria,idPresentacion = @idpresentacion,idUbicacion = @idubicacion,idMarca = @idmarca
where @idarticulo = idArticulo
go

create proc ELIMINAR_ARTICULO
@idarticulo int 
as delete from Articulo 
where @idarticulo = idArticulo
go

alter proc MOSTRAR_TODOS_ARTICULOS
as
select idArticulo AS Codigo,Articulo.Nombre,Articulo.Descripcion,Imagen,Categoria.Nombre as Categoria,Presentacion.Nombre as Presentacion,Marca.Nombre as Marca,Ubicacion.Nombre as Ubicacion from Articulo
inner join Categoria on Articulo.idCategoria = Categoria.idCategoria inner join Presentacion on Articulo.idPresentacion = Presentacion.idPresentacion inner join Marca on Articulo.idMarca = Marca.idMarca inner join Ubicacion on Articulo.idUbicacion = Ubicacion.idUbicacion
go

create proc MOSTRAR_CODIGO_ARTICULO
@buscador int
as
select idArticulo AS Codigo,Articulo.Nombre,Articulo.Descripcion,Imagen,Categoria.Nombre as Categoria,Presentacion.Nombre as Presentacion,Marca.Nombre as Marca,Ubicacion.Nombre as Ubicacion from Articulo
inner join Categoria on Articulo.idCategoria = Categoria.idCategoria inner join Presentacion on Articulo.idPresentacion = Presentacion.idPresentacion inner join Marca on Articulo.idMarca = Marca.idMarca inner join Ubicacion on Articulo.idUbicacion = Ubicacion.idUbicacion
where idArticulo = @buscador
go

create proc MOSTRAR_NOMBRE_ARTICULO
@buscador varchar(50)
as
select idArticulo AS Codigo,Articulo.Nombre,Articulo.Descripcion,Imagen,Categoria.Nombre as Categoria,Presentacion.Nombre as Presentacion,Marca.Nombre as Marca,Ubicacion.Nombre as Ubicacion from Articulo
inner join Categoria on Articulo.idCategoria = Categoria.idCategoria inner join Presentacion on Articulo.idPresentacion = Presentacion.idPresentacion inner join Marca on Articulo.idMarca = Marca.idMarca inner join Ubicacion on Articulo.idUbicacion = Ubicacion.idUbicacion
where Articulo.Nombre like @buscador + '%'
go

create proc MOSTRAR_NOMBRE_ARTICULO_CATE
@buscador varchar(50)
as
select idArticulo AS Codigo,Articulo.Nombre,Articulo.Descripcion,Imagen,Categoria.Nombre as Categoria,Presentacion.Nombre as Presentacion,Marca.Nombre as Marca,Ubicacion.Nombre as Ubicacion from Articulo
inner join Categoria on Articulo.idCategoria = Categoria.idCategoria inner join Presentacion on Articulo.idPresentacion = Presentacion.idPresentacion inner join Marca on Articulo.idMarca = Marca.idMarca inner join Ubicacion on Articulo.idUbicacion = Ubicacion.idUbicacion
where Categoria.Nombre like @buscador + '%'
go

create proc MOSTRAR_NOMBRE_ARTICULO_PRESENT
@buscador varchar(50)
as
select idArticulo AS Codigo,Articulo.Nombre,Articulo.Descripcion,Imagen,Categoria.Nombre as Categoria,Presentacion.Nombre as Presentacion,Marca.Nombre as Marca,Ubicacion.Nombre as Ubicacion from Articulo
inner join Categoria on Articulo.idCategoria = Categoria.idCategoria inner join Presentacion on Articulo.idPresentacion = Presentacion.idPresentacion inner join Marca on Articulo.idMarca = Marca.idMarca inner join Ubicacion on Articulo.idUbicacion = Ubicacion.idUbicacion
where Presentacion.Nombre like @buscador + '%'
go

create proc MOSTRAR_NOMBRE_ARTICULO_MARCA
@buscador varchar(50)
as
select idArticulo AS Codigo,Articulo.Nombre,Articulo.Descripcion,Imagen,Categoria.Nombre as Categoria,Presentacion.Nombre as Presentacion,Marca.Nombre as Marca,Ubicacion.Nombre as Ubicacion from Articulo
inner join Categoria on Articulo.idCategoria = Categoria.idCategoria inner join Presentacion on Articulo.idPresentacion = Presentacion.idPresentacion inner join Marca on Articulo.idMarca = Marca.idMarca inner join Ubicacion on Articulo.idUbicacion = Ubicacion.idUbicacion
where Marca.Nombre like @buscador + '%'
go

create proc MOSTRAR_NOMBRE_ARTICULO_UBIC
@buscador varchar(50)
as
select idArticulo AS Codigo,Articulo.Nombre,Articulo.Descripcion,Imagen,Categoria.Nombre as Categoria,Presentacion.Nombre as Presentacion,Marca.Nombre as Marca,Ubicacion.Nombre as Ubicacion from Articulo
inner join Categoria on Articulo.idCategoria = Categoria.idCategoria inner join Presentacion on Articulo.idPresentacion = Presentacion.idPresentacion inner join Marca on Articulo.idMarca = Marca.idMarca inner join Ubicacion on Articulo.idUbicacion = Ubicacion.idUbicacion
where Ubicacion.Nombre like @buscador + '%'
go
