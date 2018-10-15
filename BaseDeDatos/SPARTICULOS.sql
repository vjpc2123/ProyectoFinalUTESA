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

create proc MOSTRAR_TODOS_ARTICULOS
as
select idArticulo AS Codigo,Articulo.Nombre,Articulo.Descripcion,Imagen,Categoria.Nombre as Categoria,Presentacion.Nombre as Presentacion from Articulo
inner join Categoria on Articulo.idCategoria = Categoria.idCategoria inner join Presentacion on Articulo.idPresentacion = Presentacion.idPresentacion
go

create proc MOSTRAR_CODIGO_ARTICULO
@idarticulo int
as
select idArticulo AS Codigo,Articulo.Nombre,Articulo.Descripcion,Imagen,Categoria.Nombre as Categoria,Presentacion.Nombre as Presentacion from Articulo
inner join Categoria on Articulo.idCategoria = Categoria.idCategoria inner join Presentacion on Articulo.idPresentacion = Presentacion.idPresentacion
where idArticulo = @idarticulo
go

create proc MOSTRAR_NOMBRE_ARTICULO
@nombre varchar(50)
as
select idArticulo AS Codigo,Articulo.Nombre,Articulo.Descripcion,Imagen,Categoria.Nombre as Categoria,Presentacion.Nombre as Presentacion from Articulo
inner join Categoria on Articulo.idCategoria = Categoria.idCategoria inner join Presentacion on Articulo.idPresentacion = Presentacion.idPresentacion
where Articulo.Nombre like @nombre + '%'
go

create proc MOSTRAR_NOMBRE_ARTICULO_CATE
@categoria varchar(50)
as
select idArticulo AS Codigo,Articulo.Nombre,Articulo.Descripcion,Imagen,Categoria.Nombre as Categoria,Presentacion.Nombre as Presentacion from Articulo
inner join Categoria on Articulo.idCategoria = Categoria.idCategoria inner join Presentacion on Articulo.idPresentacion = Presentacion.idPresentacion
where Categoria.Nombre like @categoria + '%'
go

create proc MOSTRAR_NOMBRE_ARTICULO_PRESENT
@presentacion varchar(50)
as
select idArticulo AS Codigo,Articulo.Nombre,Articulo.Descripcion,Imagen,Categoria.Nombre as Categoria,Presentacion.Nombre as Presentacion from Articulo
inner join Categoria on Articulo.idCategoria = Categoria.idCategoria inner join Presentacion on Articulo.idPresentacion = Presentacion.idPresentacion
where Presentacion.Nombre like @presentacion + '%'
go