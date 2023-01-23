CREATE PROCEDURE SP_ActualizarCliente
@id int,
@cliente_cedula varchar(50),
@cliente_apellidos varchar(50),
@cliente_nombres varchar(50),
@cliente_telefono varchar(50),
@cliente_email varchar(50),
@cliente_direccion varchar(50)
AS
BEGIN
UPDATE [Cliente]
set [cliente_cedula] = @cliente_cedula,
[cliente_apellidos] = @cliente_apellidos,
[cliente_nombres] = @cliente_nombres,
[cliente_telefono] = @cliente_telefono,
[cliente_email] = @cliente_email,
[cliente_direccion] = @cliente_direccion
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE [id] = @id 
END
GO

CREATE PROCEDURE SP_ActualizarEmpleado
@id int,
@empleado_nombres nvarchar(50),
@empleado_apellidos nvarchar(50),
@empleado_telefono nvarchar(50),
@empleado_email nvarchar(50),
@empleado_direccion nvarchar(50),
@empleado_usuario int
AS
BEGIN
UPDATE [Empleado]
set empleado_nombres = @empleado_nombres,
empleado_apellidos = @empleado_apellidos,
empleado_telefono = @empleado_telefono,
empleado_email = @empleado_email,
empleado_direccion = @empleado_direccion,
empleado_usuario = @empleado_usuario
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE [id] = @id 
END
GO

CREATE PROCEDURE SP_ActualizarFactura
@id int,
@factura_cliente int,
@factura_funcion int,
@factura_metodo_pago varchar(25),
@factura_fecha_emision datetime,
@factura_estado varchar(25)
AS
BEGIN
UPDATE [Factura]
set factura_cliente = @factura_cliente,
factura_funcion = @factura_funcion,
factura_metodo_pago = @factura_metodo_pago,
factura_fecha_emision = @factura_fecha_emision,
factura_estado = @factura_estado
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE [id] = @id 
END
GO

CREATE PROCEDURE SP_ActualizarFuncion
@id int,
@funcion_pelicula int,
@funcion_sala int,
@funcion_fecha_evento date,
@funcion_horario int,
@funcion_estado nvarchar(25),
@funcion_precio_boleto decimal(18,0),
@funcion_fecha_creacion date,
@funcion_idioma int,
@funcion_asientos_disponibles int
AS 
BEGIN
UPDATE [Funcion]
set funcion_pelicula = @funcion_pelicula,
funcion_sala = @funcion_sala,
funcion_fecha_evento = @funcion_fecha_evento,
funcion_horario = @funcion_horario,
funcion_estado = @funcion_estado,
funcion_precio_boleto = @funcion_precio_boleto,
funcion_fecha_creacion = @funcion_fecha_creacion,
funcion_idioma = @funcion_idioma,
funcion_asientos_disponibles = @funcion_asientos_disponibles
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE [id] = @id 	
END
GO

CREATE PROCEDURE SP_ActualizarHorario
@id int,
@hora_inicio time(7),
@hora_fin time(7)
AS
BEGIN
UPDATE [Horarios]
set horario_inicio = @hora_inicio,
horario_fin = @hora_fin
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE [id] = @id 	
END
GO

CREATE PROCEDURE SP_ActualizarImagenPelicula
@id int,
@imagen image
AS
BEGIN
UPDATE Pelicula
SET pelicula_imagen = @imagen
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE id = @id
END
USE [cinedb]
GO

CREATE PROCEDURE SP_ActualizarPelicula
@id int,
@pelicula_titulo nvarchar(50),
@pelicula_titulo_original nvarchar(50),
@pelicula_duracion nvarchar(50),
@pelicula_tipo_censura nvarchar(50),
@pelicula_sinopsis nvarchar(255),
@pelicula_director nvarchar(50),
@pelicula_reparto nvarchar(255),
@pelicula_url_trailer nvarchar(255),
@pelicula_imagen image
AS
BEGIN
UPDATE [Pelicula]
set pelicula_titulo = @pelicula_titulo,
pelicula_titulo_original = @pelicula_titulo_original,
pelicula_duracion = @pelicula_duracion,
pelicula_tipo_censura = @pelicula_tipo_censura,
pelicula_sinopsis = @pelicula_sinopsis,
pelicula_director = @pelicula_director,
pelicula_reparto = @pelicula_reparto,
pelicula_url_trailer = @pelicula_url_trailer,
pelicula_imagen = @pelicula_imagen
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE [id] = @id 	
END
GO

CREATE PROCEDURE SP_ActualizarUsuario
@id int,
@usuario_username nvarchar(25),
@usuario_password nvarchar(25),
@usuario_perfil int
AS
BEGIN
UPDATE [Usuario]
set usuario_username = @usuario_username,
usuario_password = @usuario_password,
usuario_perfil = @usuario_perfil
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE [id] = @id 
END
GO

CREATE PROCEDURE SP_BancosActivos
AS
BEGIN
SELECT * FROM dbo.Banco
WHERE Banco.banco_estado = 1
END
GO

CREATE PROCEDURE SP_BoletosCliente
(
@idCliente int
)
AS
BEGIN
/* Selecciona un grupo de boletos */
SELECT [Boleto].* 
FROM [Boleto]
/* Cuando la factura del boleto, 
corresponda a las id de las facturas 
de un cliente x */
WHERE [Boleto].boleto_factura IN ( 
SELECT [Factura].id
FROM [Factura]
WHERE [Factura].factura_cliente = @idCliente
)
END
GO

CREATE PROCEDURE SP_BorrarClientes
@id int
AS
BEGIN
DELETE FROM Cliente 
OUTPUT 'ELIMINADO' AS 'RESPONSE'
WHERE  id = @id
END
GO

CREATE PROCEDURE SP_BorrarEmpleado
@id int
AS
BEGIN
DELETE FROM Empleado
OUTPUT 'ELIMINADO' AS 'RESPONSE'
WHERE  id = @id 
END
GO

CREATE PROCEDURE SP_BorrarFuncion
@id int
AS
BEGIN
DELETE FROM Funcion 
OUTPUT 'ELIMINADO' AS 'RESPONSE'
WHERE  id = @id
END
GO

CREATE PROCEDURE SP_BorrarPelicula
@id int
AS
BEGIN
DELETE FROM Pelicula 
OUTPUT 'ELIMINADO' AS 'RESPONSE'
WHERE  id = @id
END
GO

CREATE PROCEDURE SP_BorrarPeliculaCategoria
@idPelicula int
AS
BEGIN
DELETE FROM rel_Pelicula_Categoria
WHERE id_Pelicula = @idPelicula
END
GO

CREATE PROCEDURE SP_BorrarUsuario
@id int
AS
BEGIN
DELETE FROM Usuario 
OUTPUT 'ELIMINADO' AS 'RESPONSE'
WHERE  id = @id
END
GO

CREATE PROCEDURE SP_BuscarTarjetas
@idCliente int
AS
BEGIN
SET NOCOUNT ON;
SELECT * FROM [dbo].[Tarjetas]
WHERE @idCliente = [tarjeta_cliente]
END
GO

CREATE PROCEDURE SP_CategoriasPelicula
@id int
AS
BEGIN
/* Selecciona el nombre de la categoria seg�n la id de pelicula indicado */

SELECT 
Categoria.nombre_categoria AS nombre_cateogria
FROM [dbo].[rel_Pelicula_Categoria] relacion
INNER JOIN [dbo].[Categoria] categoria
ON categoria.id = relacion.id_Categoria
WHERE relacion.id_Pelicula = @id
END
GO

CREATE PROCEDURE SP_CrearBanco
(
@banco_nombre nvarchar(25)
)
AS
BEGIN
INSERT INTO [Banco] 
OUTPUT inserted.id
values (@banco_nombre,1)
END

CREATE PROCEDURE SP_CrearCliente
@cliente_cedula varchar(50),
@cliente_apellidos varchar(50),
@cliente_nombres varchar(50),
@cliente_telefono varchar(50),
@cliente_email varchar(50),
@cliente_direccion varchar(50),
@cliente_usuario int
AS
BEGIN
INSERT INTO [Cliente]
OUTPUT inserted.id
values (
@cliente_cedula,
@cliente_apellidos,
@cliente_nombres,
@cliente_telefono,
@cliente_email,
@cliente_direccion,
@cliente_usuario
)
END
GO

CREATE PROCEDURE SP_CrearEmpleado
@empleado_nombres nvarchar(50),
@empleado_cedula nvarchar(50),
@empleado_apellidos nvarchar(50),
@empleado_telefono nvarchar(50),
@empleado_email nvarchar(50),
@empleado_direccion nvarchar(50),
@empleado_usuario int
AS
BEGIN
INSERT INTO Empleado
(
empleado_nombres,
empleado_cedula,
empleado_apellidos,
empleado_telefono,
empleado_email,
empleado_direccion,
empleado_usuario
)
OUTPUT inserted.id
VALUES (
@empleado_nombres,
@empleado_cedula,
@empleado_apellidos,
@empleado_telefono,
@empleado_email,
@empleado_direccion,
@empleado_usuario
)
END
GO

CREATE PROCEDURE SP_CrearFactura
@factura_cliente int,
@factura_funcion int,
@factura_metodo_pago varchar(25),
@factura_fecha_emision datetime,
@factura_estado varchar(25)
AS
BEGIN

DECLARE @factura_numero as int;
SET @factura_numero = (SELECT COUNT(id) FROM Factura) + 1;

INSERT INTO Factura 
OUTPUT inserted.id
VALUES(@factura_cliente,@factura_funcion,@factura_numero,@factura_fecha_emision,@factura_metodo_pago,@factura_estado)
END
GO

CREATE PROCEDURE SP_CrearFuncion
(
@funcion_pelicula int,
@funcion_sala int,
@funcion_fecha_evento date,
@funcion_horario int,
@funcion_estado nvarchar(25),
@funcion_precio_boleto decimal(18,0),
@funcion_fecha_creacion date,
@funcion_idioma int,
@funcion_asientos_disponibles int
)
AS
BEGIN
INSERT INTO [Funcion]
VALUES(
@funcion_pelicula,
@funcion_sala,
@funcion_fecha_evento,
@funcion_horario,
@funcion_estado,
@funcion_precio_boleto,
@funcion_fecha_creacion,
@funcion_idioma,
@funcion_asientos_disponibles
)
END
GO

CREATE PROCEDURE SP_CrearHorario
@hora_inicio time(7),
@hora_fin time(7)
AS
BEGIN
INSERT INTO Horarios
OUTPUT inserted.id
values (
@hora_inicio,
@hora_fin
)
END
GO

CREATE PROCEDURE SP_CrearPelicula
@pelicula_titulo nvarchar(50),
@pelicula_titulo_original nvarchar(50),
@pelicula_duracion nvarchar(50),
@pelicula_tipo_censura nvarchar(50),
@pelicula_sinopsis nvarchar(255),
@pelicula_director nvarchar(50),
@pelicula_reparto nvarchar(255),
@pelicula_url_trailer nvarchar(255),
@pelicula_imagen image
AS
BEGIN
INSERT INTO [Pelicula]
(pelicula_titulo,
pelicula_titulo_original,
pelicula_duracion,
pelicula_tipo_censura,
pelicula_sinopsis,
pelicula_director,
pelicula_reparto,
pelicula_url_trailer,
pelicula_imagen)
OUTPUT inserted.id
VALUES (
@pelicula_titulo,
@pelicula_titulo_original,
@pelicula_duracion,
@pelicula_tipo_censura,
@pelicula_sinopsis,
@pelicula_director,
@pelicula_reparto,
@pelicula_url_trailer,
@pelicula_imagen
)	
END
GO

CREATE PROCEDURE SP_CrearPeliculaCategoria
@id_Pelicula int,
@id_Categoria int
AS
BEGIN
INSERT INTO rel_Pelicula_Categoria
VALUES (@id_Pelicula,@id_Categoria)	
END

CREATE PROCEDURE SP_CrearTarjeta
(
@tarjeta_cliente int,
@tarjeta_tipo nvarchar(25),
@tarjeta_banco int,
@tarjeta_numero nvarchar(50),
@tarjeta_ccv nvarchar(3),
@tarjeta_ano int, 
@tarjeta_mes nvarchar(50),
@tarjeta_propietario nvarchar(50)
)
AS
BEGIN
INSERT INTO [Tarjetas]
OUTPUT inserted.id
values (
@tarjeta_cliente,
@tarjeta_tipo,
@tarjeta_banco,
@tarjeta_numero,
@tarjeta_ccv,
@tarjeta_ano,
@tarjeta_mes,
@tarjeta_propietario
)
END
GO

CREATE PROCEDURE SP_CrearUsuario
@usuario_username varchar(25),
@usuario_password varchar(25),
@usuario_perfil int
AS
BEGIN
INSERT INTO [Usuario]
OUTPUT inserted.id
values (
@usuario_username,
@usuario_password,
@usuario_perfil
)
END
GO

CREATE PROCEDURE SP_BorrarTarjeta
@id int
AS
BEGIN
DELETE FROM [Tarjetas]
OUTPUT 'ELIMINADO' AS 'RESPONSE'
WHERE [Tarjetas].id = @id
END

CREATE PROCEDURE SP_FuncionesActivas
AS
BEGIN
SELECT * 
FROM [dbo].[Vista_Funciones]
WHERE funcion_estado = 'ACTIVO'
END
GO

CREATE PROCEDURE SP_GetBanco
@id int
AS
BEGIN
SELECT * FROM dbo.Banco
WHERE Banco.id = @id
END
GO

CREATE PROCEDURE SP_GetCategoria
@id int
AS
BEGIN
SELECT * FROM [dbo].Categoria
WHERE [dbo].Categoria.id = @id
END
GO

CREATE PROCEDURE SP_GetEmpleado
@id int
AS
BEGIN
SELECT * FROM dbo.Empleado
WHERE Empleado.id = @id
END
GO

CREATE PROCEDURE SP_GetEmpresa
@id int
AS
BEGIN
SELECT * FROM dbo.Empresa
WHERE Empresa.id = @id
END
GO

CREATE PROCEDURE SP_GetUsuario
@id int
AS
BEGIN
SELECT * FROM Usuario
WHERE id = @id
END
GO

CREATE PROCEDURE SP_IdiomasPelicula
@id int
AS
BEGIN
SELECT

/* Selecciona el listado de idiomas para la pelicula especificada */

idioma.idioma_abreviatura
FROM [dbo].[Funcion] funcion
INNER JOIN [dbo].[Idiomas] idioma
ON idioma.id = funcion.funcion_idioma
WHERE funcion.funcion_pelicula = @id
END
GO

CREATE PROCEDURE SP_IniciarSesion
@usuario_username varchar(25),
@usuario_password varchar(25)
AS
BEGIN
SELECT 
*
FROM 
[dbo].[Cliente] cliente

/*Subconsulta a tabla de usuarios*/
WHERE cliente.[cliente_usuario] = (
SELECT
[dbo].[Usuario].[id]
FROM
[dbo].[Usuario]
WHERE
[usuario_username] = @usuario_username AND [usuario_password] = @usuario_password
)
END
GO

CREATE PROCEDURE SP_ListarCategorias
AS
BEGIN
SELECT * FROM Categoria
END
GO

CREATE PROCEDURE SP_ListarCliente
AS
BEGIN
SELECT * FROM dbo.Cliente
END
GO

CREATE PROCEDURE SP_ListarEmpleado
AS
BEGIN
SELECT * FROM dbo.Empleado
END
GO

CREATE PROCEDURE SP_ListarIdiomas
AS
BEGIN
SELECT * FROM Idiomas
END
GO

CREATE PROCEDURE SP_ListarPeliculaCategoria
@idPelicula int
AS
BEGIN
SELECT * FROM rel_Pelicula_Categoria
WHERE id_Pelicula = @idPelicula
END
GO

CREATE PROCEDURE SP_ListarPeliculasP
AS
BEGIN
SELECT *
FROM V_PeliculaP
END
GO

CREATE PROCEDURE SP_ListarSala
AS
BEGIN
SELECT * FROM Sala_Cine
END
GO

CREATE PROCEDURE SP_ListarUsuario
AS
BEGIN
SELECT * FROM Usuario
END
GO

CREATE PROCEDURE SP_ListarUsuarios
AS
BEGIN
SELECT * FROM Usuario
END
GO

CREATE PROCEDURE SP_ObtenerBoletosFacturaGeneral
AS
BEGIN
DECLARE @cantBoletos int;
DECLARE @asientos varchar(MAX);

SET @cantBoletos = 
(
	SELECT COUNT(*) FROM Boleto AS B
)

SET @asientos = 
(
	SELECT STRING_AGG (B.boleto_asiento,', ')
	FROM Boleto AS B
)

SELECT 
@cantBoletos AS 'cantidad',
@asientos AS 'asientos',
('Boleto de tipo ' + Boleto.boleto_tipo_asiento + ', para la funcion de ' + Pelicula.pelicula_titulo) AS 'concepto', 
Funcion.funcion_precio_boleto AS 'precio_unitario',
(Funcion.funcion_precio_boleto * @cantBoletos) AS 'importe',
(Funcion.funcion_precio_boleto * @cantBoletos * 0.12) AS 'iva',
((Funcion.funcion_precio_boleto * @cantBoletos) + (Funcion.funcion_precio_boleto * @cantBoletos * 0.12)) AS 'total'

FROM Boleto 
INNER JOIN Factura ON Boleto.boleto_factura = Factura.id 
INNER JOIN Funcion ON Factura.factura_funcion = Funcion.id
INNER JOIN Pelicula ON Funcion.funcion_pelicula = Pelicula.id

GROUP BY 
Factura.id, 
Boleto.boleto_funcion, 
Boleto.boleto_tipo_asiento, 
Funcion.funcion_precio_boleto,
Pelicula.pelicula_titulo
END
GO

CREATE PROCEDURE SP_ObtenerFacturaDatosGeneral
AS
BEGIN
SELECT * FROM Vista_FacturaDatos 
END
GO

CREATE PROCEDURE SP_VistaFacturasCliente
@id as int
AS
BEGIN
SELECT F.*,
(SELECT COUNT(*) FROM Boleto B WHERE B.boleto_factura = F.id) AS 'numero_boletos'
FROM Vista_FacturaFuncion F
WHERE F.factura_cliente = @id
ORDER BY F.id DESC
END
GO

CREATE PROCEDURE SP_VistaFacturasClienteAdmin
AS
BEGIN
SELECT F.*,
(SELECT COUNT(*) FROM Boleto B WHERE B.boleto_factura = F.id) AS 'numero_boletos'
FROM Vista_FacturaAdmin F
ORDER BY F.factura_fecha_emision DESC
END
GO

CREATE PROCEDURE SP_VistaFunciones
AS
BEGIN
SELECT * FROM Vista_FuncionesActivas
END
GO