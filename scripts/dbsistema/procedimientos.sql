USE [dbsistema]
GO
/****** Object:  StoredProcedure [dbo].[categoria_activar]    Script Date: 4/5/2022 6:07:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[categoria_activar]
@idcategoria int
as
update categoria set estado = 1
where idcategoria =@idcategoria
GO
/****** Object:  StoredProcedure [dbo].[categoria_actualizar]    Script Date: 4/5/2022 6:07:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[categoria_actualizar]
@idcategoria int,
@nombre varchar(50),
@descripcion varchar(255)
as
update categoria set nombre = @nombre,descripcion =@descripcion
where idcategoria = @idcategoria
GO
/****** Object:  StoredProcedure [dbo].[categoria_buscar]    Script Date: 4/5/2022 6:07:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[categoria_buscar]
@valor varchar(50)
as
select idcategoria as ID,nombre as Nombre, descripcion as Descripcion, estado as Estado
from categoria
where nombre like '%' + @valor + '%' or descripcion like '%' + @valor + '%'
order by nombre asc
GO
/****** Object:  StoredProcedure [dbo].[categoria_desactivar]    Script Date: 4/5/2022 6:07:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[categoria_desactivar]
@idcategoria int
as
update categoria set estado = 0
where idcategoria =@idcategoria
GO
/****** Object:  StoredProcedure [dbo].[categoria_eliminar]    Script Date: 4/5/2022 6:07:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[categoria_eliminar]
@idcategoria int
as
delete from categoria
where idcategoria=@idcategoria
GO
/****** Object:  StoredProcedure [dbo].[categoria_existe]    Script Date: 4/5/2022 6:07:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[categoria_existe]
@valor varchar(100),
@existe bit output
as
	if exists(select nombre from categoria where nombre = ltrim (rtrim(@valor)))
		begin
		set @existe=1
		end
	else
		begin
		set @existe=0
		end
GO
/****** Object:  StoredProcedure [dbo].[categoria_insertar]    Script Date: 4/5/2022 6:07:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[categoria_insertar]
@nombre varchar(50),
@descripcion varchar(255)
as
insert into categoria (nombre,descripcion) values (@nombre, @descripcion)
GO
/****** Object:  StoredProcedure [dbo].[categoria_listar]    Script Date: 4/5/2022 6:07:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[categoria_listar]
as
select idcategoria as ID,nombre as Nombre, descripcion as Descripcion, estado as Estado
from categoria 
order by idcategoria desc
GO
