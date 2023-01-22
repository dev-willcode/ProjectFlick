USE [master]
GO
CREATE DATABASE [cinedb]
GO
ALTER DATABASE [cinedb] SET COMPATIBILITY_LEVEL = 140
GO
ALTER DATABASE [cinedb] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [cinedb] SET ANSI_NULLS OFF
GO
ALTER DATABASE [cinedb] SET ANSI_PADDING OFF
GO
ALTER DATABASE [cinedb] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [cinedb] SET ARITHABORT OFF
GO
ALTER DATABASE [cinedb] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [cinedb] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [cinedb] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [cinedb] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [cinedb] SET CURSOR_DEFAULT GLOBAL
GO
ALTER DATABASE [cinedb] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [cinedb] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [cinedb] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [cinedb] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [cinedb] SET DISABLE_BROKER
GO
ALTER DATABASE [cinedb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [cinedb] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [cinedb] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [cinedb] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [cinedb] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [cinedb] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [cinedb] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [cinedb] SET RECOVERY FULL
GO
ALTER DATABASE [cinedb] SET MULTI_USER
GO
ALTER DATABASE [cinedb] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [cinedb] SET DB_CHAINING OFF
GO
ALTER DATABASE [cinedb] SET FILESTREAM ( NON_TRANSACTED_ACCESS = OFF )
GO
ALTER DATABASE [cinedb] SET TARGET_RECOVERY_TIME = 60 SECONDS
GO
ALTER DATABASE [cinedb] SET DELAYED_DURABILITY = DISABLED
GO
ALTER DATABASE [cinedb] SET QUERY_STORE = OFF
GO
USE [cinedb]
GO
/****** Object:  Table [dbo].[Funcion]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcion]
(
    [id]                           [int] IDENTITY (1,1) NOT NULL,
    [funcion_pelicula]             [int]                NOT NULL,
    [funcion_sala]                 [int]                NOT NULL,
    [funcion_fecha_evento]         [date]               NOT NULL,
    [funcion_horario]              [int]                NOT NULL,
    [funcion_estado]               [nvarchar](25)       NOT NULL,
    [funcion_precio_boleto]        [decimal](18, 0)     NOT NULL,
    [funcion_fecha_creacion]       [date]               NOT NULL,
    [funcion_idioma]               [int]                NULL,
    [funcion_asientos_disponibles] [int]                NULL,
    CONSTRAINT [PK_Funcion] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pelicula]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pelicula]
(
    [id]                       [int] IDENTITY (1,1) NOT NULL,
    [pelicula_titulo]          [nvarchar](50)       NOT NULL,
    [pelicula_titulo_original] [nvarchar](50)       NOT NULL,
    [pelicula_duracion]        [nvarchar](50)       NOT NULL,
    [pelicula_tipo_censura]    [nvarchar](50)       NOT NULL,
    [pelicula_sinopsis]        [nvarchar](255)      NOT NULL,
    [pelicula_director]        [nvarchar](50)       NOT NULL,
    [pelicula_reparto]         [nvarchar](255)      NOT NULL,
    [pelicula_url_trailer]     [nvarchar](255)      NOT NULL,
    [pelicula_imagen]          [image]              NULL,
    CONSTRAINT [PK_Pelicula] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[Vista_Funciones]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_Funciones]
AS
SELECT dbo.Pelicula.id AS id_pelicula,
       dbo.Pelicula.pelicula_titulo,
       dbo.Pelicula.pelicula_titulo_original,
       dbo.Pelicula.pelicula_tipo_censura,
       dbo.Pelicula.pelicula_duracion,
       dbo.Pelicula.pelicula_url_trailer,
       dbo.Funcion.funcion_estado
FROM dbo.Funcion
         INNER JOIN
     dbo.Pelicula ON dbo.Funcion.funcion_pelicula = dbo.Pelicula.id
GROUP BY dbo.Pelicula.id, dbo.Pelicula.pelicula_titulo, dbo.Pelicula.pelicula_titulo_original,
         dbo.Pelicula.pelicula_tipo_censura, dbo.Pelicula.pelicula_duracion, dbo.Pelicula.pelicula_url_trailer,
         dbo.Funcion.funcion_estado
GO
/****** Object:  Table [dbo].[Boleto]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boleto]
(
    [id]                  [int] IDENTITY (1,1) NOT NULL,
    [boleto_factura]      [int]                NOT NULL,
    [boleto_funcion]      [int]                NOT NULL,
    [boleto_asiento]      [nchar](5)           NOT NULL,
    [boleto_tipo_asiento] [nvarchar](25)       NOT NULL,
    [boleto_medio_compra] [nvarchar](25)       NOT NULL,
    [boleto_descuento]    [decimal](18, 0)     NOT NULL,
    CONSTRAINT [PK_Boleto] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria]
(
    [id]               [int] IDENTITY (1,1) NOT NULL,
    [nombre_categoria] [nvarchar](25)       NULL,
    CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente]
(
    [id]                [int] IDENTITY (1,1) NOT NULL,
    [cliente_cedula]    [nvarchar](50)       NULL,
    [cliente_apellidos] [nvarchar](50)       NULL,
    [cliente_nombres]   [nvarchar](50)       NULL,
    [cliente_telefono]  [nvarchar](50)       NULL,
    [cliente_email]     [nvarchar](50)       NULL,
    [cliente_direccion] [nvarchar](50)       NULL,
    [cliente_usuario]   [int]                NOT NULL,
    CONSTRAINT [PK_tb_cliente] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado]
(
    [id]                 [int] IDENTITY (1,1) NOT NULL,
    [empleado_nombres]   [nvarchar](50)       NULL,
    [empleado_cedula]    [nvarchar](50)       NULL,
    [empleado_apellidos] [nvarchar](50)       NULL,
    [empleado_telefono]  [nvarchar](50)       NULL,
    [empleado_email]     [nvarchar](50)       NULL,
    [empleado_direccion] [nvarchar](50)       NULL,
    [empleado_usuario]   [int]                NOT NULL,
    CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa]
(
    [id]                           [int] IDENTITY (1,1) NOT NULL,
    [empresa_razon_social]         [nvarchar](50)       NOT NULL,
    [empresa_numero_contribuyente] [nvarchar](25)       NOT NULL,
    [empresa_numero_autorizacion]  [nvarchar](25)       NOT NULL,
    [empresa_direccion]            [nvarchar](25)       NOT NULL,
    [empresa_telefono]             [nvarchar](25)       NOT NULL,
    [empresa_email]                [nvarchar](25)       NOT NULL,
    [empresa_website]              [nvarchar](25)       NOT NULL,
    [empresa_ambiente]             [nvarchar](25)       NOT NULL,
    [empresa_contabilidad]         [bit]                NOT NULL,
    CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura]
(
    [id]                    [int] IDENTITY (1,1) NOT NULL,
    [factura_cliente]       [int]                NULL,
    [factura_funcion]       [int]                NULL,
    [factura_numero]        [varchar](50)        NULL,
    [factura_estado]        [varchar](50)        NULL,
    [factura_metodo_pago]   [varchar](25)        NULL,
    [factura_fecha_emision] [date]               NULL,
    CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Horarios]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horarios]
(
    [id]             [int] IDENTITY (1,1) NOT NULL,
    [horario_inicio] [time](7)            NOT NULL,
    [horario_fin]    [time](7)            NOT NULL,
    CONSTRAINT [PK_Horario_Sala] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idiomas]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idiomas]
(
    [id]                 [int] IDENTITY (1,1) NOT NULL,
    [idioma_descripcion] [nvarchar](25)       NOT NULL,
    [idioma_abreviatura] [nvarchar](25)       NOT NULL,
    CONSTRAINT [PK_Idiomas] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil_Usuario]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil_Usuario]
(
    [id]                    [int] IDENTITY (1,1) NOT NULL,
    [perfil_usuario_nombre] [nvarchar](25)       NULL,
    CONSTRAINT [PK_Perfil_Usuario] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos]
(
    [id]                  [int] IDENTITY (1,1) NOT NULL,
    [permiso_nombre]      [nvarchar](25)       NOT NULL,
    [permiso_descripcion] [nvarchar](25)       NULL,
    CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rel_Pelicula_Categoria]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rel_Pelicula_Categoria]
(
    [id_Pelicula]  [int] NULL,
    [id_Categoria] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rel_perfil_permisos]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rel_perfil_permisos]
(
    [id_perfil]  [int] NOT NULL,
    [id_permiso] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sala_Cine]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala_Cine]
(
    [id]                    [int] IDENTITY (1,1) NOT NULL,
    [sala_nombre]           [nvarchar](10)       NOT NULL,
    [sala_capacidad_maxima] [int]                NOT NULL,
    CONSTRAINT [PK_Sala_cine] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarjetas]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarjetas]
(
    [id]                  [int] IDENTITY (1,1) NOT NULL,
    [tarjeta_cliente]     [int]                NOT NULL,
    [tarjeta_tipo]        [nvarchar](50)       NOT NULL,
    [tarjeta_banco]       [nvarchar](50)       NOT NULL,
    [tarjeta_numero]      [nchar](16)          NOT NULL,
    [tarjeta_ccv]         [nvarchar](50)       NOT NULL,
    [tarjeta_ano]         [int]                NOT NULL,
    [tarjeta_mes]         [int]                NOT NULL,
    [tarjeta_dia]         [int]                NOT NULL,
    [tarjeta_propietario] [nvarchar](50)       NOT NULL,
    CONSTRAINT [PK_Tarjetas] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 17/01/2020 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario]
(
    [id]               [int] IDENTITY (1,1) NOT NULL,
    [usuario_username] [nvarchar](25)       NOT NULL,
    [usuario_password] [nvarchar](25)       NOT NULL,
    [usuario_perfil]   [int]                NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED
        (
         [id] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Banco]
(
    [id]           [int] IDENTITY (1,1) NOT NULL,
    [banco_nombre] [nvarchar](25)       NOT NULL,
    [banco_estado] [bit]                NULL,
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Boleto]
    WITH CHECK ADD CONSTRAINT [FK_Boleto_Factura] FOREIGN KEY ([boleto_factura])
        REFERENCES [dbo].[Factura] ([id])
GO
ALTER TABLE [dbo].[Boleto]
    CHECK CONSTRAINT [FK_Boleto_Factura]
GO
ALTER TABLE [dbo].[Cliente]
    WITH CHECK ADD CONSTRAINT [FK_Cliente_Usuario] FOREIGN KEY ([cliente_usuario])
        REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[Cliente]
    CHECK CONSTRAINT [FK_Cliente_Usuario]
GO
ALTER TABLE [dbo].[Empleado]
    WITH CHECK ADD CONSTRAINT [FK_Empleado_Usuario] FOREIGN KEY ([empleado_usuario])
        REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[Empleado]
    CHECK CONSTRAINT [FK_Empleado_Usuario]
GO
ALTER TABLE [dbo].[Factura]
    WITH CHECK ADD CONSTRAINT [FK_Factura_Cliente] FOREIGN KEY ([factura_cliente])
        REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Factura]
    CHECK CONSTRAINT [FK_Factura_Cliente]
GO
ALTER TABLE [dbo].[Factura]
    WITH CHECK ADD CONSTRAINT [FK_Factura_Funcion] FOREIGN KEY ([factura_funcion])
        REFERENCES [dbo].[Funcion] ([id])
GO
ALTER TABLE [dbo].[Factura]
    CHECK CONSTRAINT [FK_Factura_Funcion]
GO
ALTER TABLE [dbo].[Funcion]
    WITH CHECK ADD CONSTRAINT [FK_Funcion_Horarios] FOREIGN KEY ([funcion_horario])
        REFERENCES [dbo].[Horarios] ([id])
GO
ALTER TABLE [dbo].[Funcion]
    CHECK CONSTRAINT [FK_Funcion_Horarios]
GO
ALTER TABLE [dbo].[Funcion]
    WITH CHECK ADD CONSTRAINT [FK_Funcion_Idiomas] FOREIGN KEY ([funcion_idioma])
        REFERENCES [dbo].[Idiomas] ([id])
GO
ALTER TABLE [dbo].[Funcion]
    CHECK CONSTRAINT [FK_Funcion_Idiomas]
GO
ALTER TABLE [dbo].[Funcion]
    WITH CHECK ADD CONSTRAINT [FK_Funcion_Pelicula] FOREIGN KEY ([funcion_pelicula])
        REFERENCES [dbo].[Pelicula] ([id])
GO
ALTER TABLE [dbo].[Funcion]
    CHECK CONSTRAINT [FK_Funcion_Pelicula]
GO
ALTER TABLE [dbo].[Funcion]
    WITH CHECK ADD CONSTRAINT [FK_Funcion_Sala_Cine] FOREIGN KEY ([funcion_sala])
        REFERENCES [dbo].[Sala_Cine] ([id])
GO
ALTER TABLE [dbo].[Funcion]
    CHECK CONSTRAINT [FK_Funcion_Sala_Cine]
GO
ALTER TABLE [dbo].[rel_Pelicula_Categoria]
    WITH CHECK ADD CONSTRAINT [FK_rel_Pelicula_Categoria_Categoria] FOREIGN KEY ([id_Categoria])
        REFERENCES [dbo].[Categoria] ([id])
GO
ALTER TABLE [dbo].[rel_Pelicula_Categoria]
    CHECK CONSTRAINT [FK_rel_Pelicula_Categoria_Categoria]
GO
ALTER TABLE [dbo].[rel_Pelicula_Categoria]
    WITH CHECK ADD CONSTRAINT [FK_rel_Pelicula_Categoria_Pelicula] FOREIGN KEY ([id_Pelicula])
        REFERENCES [dbo].[Pelicula] ([id])
GO
ALTER TABLE [dbo].[rel_Pelicula_Categoria]
    CHECK CONSTRAINT [FK_rel_Pelicula_Categoria_Pelicula]
GO
ALTER TABLE [dbo].[rel_perfil_permisos]
    WITH CHECK ADD CONSTRAINT [FK_rel_perfil_permisos_Perfil_Usuario] FOREIGN KEY ([id_perfil])
        REFERENCES [dbo].[Perfil_Usuario] ([id])
GO
ALTER TABLE [dbo].[rel_perfil_permisos]
    CHECK CONSTRAINT [FK_rel_perfil_permisos_Perfil_Usuario]
GO
ALTER TABLE [dbo].[rel_perfil_permisos]
    WITH CHECK ADD CONSTRAINT [FK_rel_perfil_permisos_Permisos] FOREIGN KEY ([id_permiso])
        REFERENCES [dbo].[Permisos] ([id])
GO
ALTER TABLE [dbo].[rel_perfil_permisos]
    CHECK CONSTRAINT [FK_rel_perfil_permisos_Permisos]
GO
ALTER TABLE [dbo].[Tarjetas]
    WITH CHECK ADD CONSTRAINT [FK_Tarjetas_Cliente] FOREIGN KEY ([tarjeta_cliente])
        REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Tarjetas]
    CHECK CONSTRAINT [FK_Tarjetas_Cliente]
GO
ALTER TABLE [dbo].[Usuario]
    WITH CHECK ADD CONSTRAINT [FK_Usuario_Perfil_Usuario] FOREIGN KEY ([usuario_perfil])
        REFERENCES [dbo].[Perfil_Usuario] ([id])
GO
ALTER TABLE [dbo].[Usuario]
    CHECK CONSTRAINT [FK_Usuario_Perfil_Usuario]
GO

CREATE VIEW Vista_FuncionesActivas
AS
SELECT dbo.Funcion.id,
       dbo.Funcion.funcion_pelicula,
       dbo.Pelicula.pelicula_titulo,
       dbo.Pelicula.pelicula_titulo_original,
       dbo.Pelicula.pelicula_duracion,
       dbo.Pelicula.pelicula_tipo_censura,
       dbo.Pelicula.pelicula_imagen,
       dbo.Pelicula.pelicula_url_trailer,
       dbo.Pelicula.pelicula_sinopsis,
       dbo.Pelicula.pelicula_director,
       dbo.Pelicula.pelicula_reparto,
       dbo.Funcion.funcion_fecha_evento,
       dbo.Funcion.funcion_estado,
       dbo.Funcion.funcion_precio_boleto,
       dbo.Funcion.funcion_asientos_disponibles,
       dbo.Funcion.funcion_fecha_creacion,
       dbo.Sala_Cine.sala_nombre,
       dbo.Idiomas.idioma_abreviatura,
       dbo.Idiomas.idioma_descripcion,
       dbo.Horarios.horario_inicio
FROM dbo.Funcion
         INNER JOIN dbo.Pelicula ON dbo.Funcion.funcion_pelicula = dbo.Pelicula.id
         INNER JOIN dbo.Idiomas ON dbo.Funcion.funcion_idioma = dbo.Idiomas.id
         INNER JOIN dbo.Sala_Cine ON dbo.Funcion.funcion_sala = dbo.Sala_Cine.id
         INNER JOIN dbo.Horarios ON dbo.Funcion.funcion_horario = dbo.Horarios.id
GROUP BY dbo.Funcion.id, dbo.Funcion.funcion_pelicula, dbo.Pelicula.pelicula_titulo,
         dbo.Pelicula.pelicula_titulo_original, dbo.Pelicula.pelicula_duracion, dbo.Pelicula.pelicula_tipo_censura,
         dbo.Pelicula.pelicula_url_trailer, dbo.Pelicula.pelicula_sinopsis, dbo.Pelicula.pelicula_director,
         dbo.Pelicula.pelicula_reparto, dbo.Funcion.funcion_fecha_evento, dbo.Funcion.funcion_estado,
         dbo.Funcion.funcion_precio_boleto, dbo.Funcion.funcion_asientos_disponibles,
         dbo.Funcion.funcion_fecha_creacion, dbo.Sala_Cine.sala_nombre, dbo.Idiomas.idioma_abreviatura,
         dbo.Idiomas.idioma_descripcion, dbo.Horarios.horario_inicio;
GO

CREATE VIEW Vista_FacturaDatos
AS
SELECT dbo.Factura.id,
       dbo.Cliente.cliente_cedula,
       dbo.Cliente.cliente_apellidos,
       dbo.Cliente.cliente_nombres,
       dbo.Cliente.cliente_telefono,
       dbo.Cliente.cliente_email,
       dbo.Cliente.cliente_direccion,
       dbo.Factura.factura_numero,
       dbo.Factura.factura_fecha_emision,
       dbo.Factura.factura_metodo_pago,
       dbo.Funcion.funcion_fecha_evento,
       dbo.Funcion.funcion_precio_boleto,
       dbo.Sala_Cine.sala_nombre,
       dbo.Horarios.horario_inicio,
       dbo.Idiomas.idioma_abreviatura,
       dbo.Pelicula.pelicula_titulo,
       dbo.Pelicula.pelicula_tipo_censura,
       dbo.Pelicula.pelicula_duracion
FROM dbo.Factura
         INNER JOIN dbo.Cliente ON dbo.Factura.factura_cliente = dbo.Cliente.id
         INNER JOIN dbo.Funcion ON dbo.Factura.factura_funcion = dbo.Funcion.id
         INNER JOIN dbo.Pelicula ON dbo.Funcion.funcion_pelicula = dbo.Pelicula.id
         INNER JOIN dbo.Idiomas ON dbo.Funcion.funcion_idioma = dbo.Idiomas.id
         INNER JOIN dbo.Sala_Cine ON dbo.Funcion.funcion_sala = dbo.Sala_Cine.id
         INNER JOIN dbo.Horarios ON dbo.Funcion.funcion_horario = dbo.Horarios.id;

GO

CREATE VIEW Vista_FacturaFuncion
AS
SELECT dbo.Factura.id,
       dbo.Factura.factura_funcion,
       dbo.Factura.factura_cliente,
       dbo.Factura.factura_numero,
       dbo.Factura.factura_fecha_emision,
       dbo.Funcion.funcion_precio_boleto,
       dbo.Funcion.funcion_fecha_evento,
       dbo.Pelicula.pelicula_titulo,
       dbo.Idiomas.idioma_abreviatura,
       dbo.Horarios.horario_inicio
FROM dbo.Factura
         INNER JOIN dbo.Cliente ON dbo.Factura.factura_cliente = dbo.Cliente.id
         INNER JOIN dbo.Funcion ON dbo.Factura.factura_funcion = dbo.Funcion.id
         INNER JOIN dbo.Pelicula ON dbo.Funcion.funcion_pelicula = dbo.Pelicula.id
         INNER JOIN dbo.Idiomas ON dbo.Funcion.funcion_idioma = dbo.Idiomas.id
         INNER JOIN dbo.Sala_Cine ON dbo.Funcion.funcion_sala = dbo.Sala_Cine.id
         INNER JOIN dbo.Horarios ON dbo.Funcion.funcion_horario = dbo.Horarios.id;
GO

CREATE VIEW Vista_FacturaAdmin
AS
SELECT dbo.Factura.id,
       dbo.Factura.factura_numero,
       dbo.Factura.factura_fecha_emision,
       dbo.Factura.factura_estado,
       dbo.Cliente.cliente_nombres,
       dbo.Cliente.cliente_apellidos,
       dbo.Funcion.funcion_precio_boleto,
       dbo.Pelicula.pelicula_titulo
FROM dbo.Factura
         INNER JOIN dbo.Cliente ON dbo.Factura.factura_cliente = dbo.Cliente.id
         INNER JOIN dbo.Funcion ON dbo.Factura.factura_funcion = dbo.Funcion.id
         INNER JOIN dbo.Pelicula ON dbo.Funcion.funcion_pelicula = dbo.Pelicula.id
;

CREATE VIEW V_PeliculaP
AS
SELECT dbo.Pelicula.id,
       dbo.Pelicula.pelicula_titulo,
       dbo.Pelicula.pelicula_titulo_original,
       dbo.Pelicula.pelicula_duracion,
       dbo.Pelicula.pelicula_tipo_censura,
       dbo.Pelicula.pelicula_director
FROM [dbo].[Pelicula];

CREATE PROCEDURE SP_ActualizarCliente @id int,
                                      @cliente_cedula varchar(50),
                                      @cliente_apellidos varchar(50),
                                      @cliente_nombres varchar(50),
                                      @cliente_telefono varchar(50),
                                      @cliente_email varchar(50),
                                      @cliente_direccion varchar(50)
AS
BEGIN
    UPDATE [Cliente]
    set [cliente_cedula]    = @cliente_cedula,
        [cliente_apellidos] = @cliente_apellidos,
        [cliente_nombres]   = @cliente_nombres,
        [cliente_telefono]  = @cliente_telefono,
        [cliente_email]     = @cliente_email,
        [cliente_direccion] = @cliente_direccion
    OUTPUT 'CORRECTO' AS 'RESPONSE'
    WHERE [id] = @id
END
GO

CREATE PROCEDURE SP_ListarPeliculas
AS
BEGIN
    SELECT *
    FROM [dbo].[Pelicula]
END
GO

CREATE PROCEDURE SP_ListarHorarios 
AS
BEGIN
    SELECT *
    FROM [dbo].[Horarios]
END
GO

CREATE PROCEDURE SP_ActualizarEmpleado @id int,
                                       @empleado_nombres nvarchar(50),
                                       @empleado_cedula nvarchar(50),
                                       @empleado_apellidos nvarchar(50),
                                       @empleado_telefono nvarchar(50),
                                       @empleado_email nvarchar(50),
                                       @empleado_direccion nvarchar(50),
                                       @empleado_usuario int
AS
BEGIN
    UPDATE [Empleado]
    set empleado_nombres   = @empleado_nombres,
        empleado_apellidos = @empleado_apellidos,
        empleado_cedula    = @empleado_cedula,
        empleado_telefono  = @empleado_telefono,
        empleado_email     = @empleado_email,
        empleado_direccion = @empleado_direccion,
        empleado_usuario   = @empleado_usuario
    OUTPUT 'CORRECTO' AS 'RESPONSE'
    WHERE [id] = @id
END
GO

CREATE PROCEDURE SP_ActualizarFactura @id int,
                                      @factura_cliente int,
                                      @factura_funcion int,
                                      @factura_metodo_pago varchar(25),
                                      @factura_fecha_emision datetime,
                                      @factura_estado varchar(25)
AS
BEGIN
    UPDATE [Factura]
    set factura_cliente       = @factura_cliente,
        factura_funcion       = @factura_funcion,
        factura_metodo_pago   = @factura_metodo_pago,
        factura_fecha_emision = @factura_fecha_emision,
        factura_estado        = @factura_estado
    OUTPUT 'CORRECTO' AS 'RESPONSE'
    WHERE [id] = @id
END
GO

CREATE PROCEDURE SP_ActualizarFuncion @id int,
                                      @funcion_pelicula int,
                                      @funcion_sala int,
                                      @funcion_fecha_evento date,
                                      @funcion_horario int,
                                      @funcion_estado nvarchar(25),
                                      @funcion_precio_boleto decimal(18, 0),
                                      @funcion_fecha_creacion date,
                                      @funcion_idioma int,
                                      @funcion_asientos_disponibles int
AS
BEGIN
    UPDATE [Funcion]
    set funcion_pelicula             = @funcion_pelicula,
        funcion_sala                 = @funcion_sala,
        funcion_fecha_evento         = @funcion_fecha_evento,
        funcion_horario              = @funcion_horario,
        funcion_estado               = @funcion_estado,
        funcion_precio_boleto        = @funcion_precio_boleto,
        funcion_fecha_creacion       = @funcion_fecha_creacion,
        funcion_idioma               = @funcion_idioma,
        funcion_asientos_disponibles = @funcion_asientos_disponibles
    OUTPUT 'CORRECTO' AS 'RESPONSE'
    WHERE [id] = @id
END
GO

CREATE PROCEDURE SP_ActualizarHorario @id int,
                                      @hora_inicio time(7),
                                      @hora_fin time(7)
AS
BEGIN
    UPDATE [Horarios]
    set horario_inicio = @hora_inicio,
        horario_fin    = @hora_fin
    OUTPUT 'CORRECTO' AS 'RESPONSE'
    WHERE [id] = @id
END
GO

CREATE PROCEDURE SP_ActualizarImagenPelicula @id int,
                                             @imagen image
AS
BEGIN
    UPDATE Pelicula
    SET pelicula_imagen = @imagen
    OUTPUT 'CORRECTO' AS 'RESPONSE'
    WHERE id = @id
END
GO

CREATE PROCEDURE SP_ActualizarPelicula @id int,
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
    set pelicula_titulo          = @pelicula_titulo,
        pelicula_titulo_original = @pelicula_titulo_original,
        pelicula_duracion        = @pelicula_duracion,
        pelicula_tipo_censura    = @pelicula_tipo_censura,
        pelicula_sinopsis        = @pelicula_sinopsis,
        pelicula_director        = @pelicula_director,
        pelicula_reparto         = @pelicula_reparto,
        pelicula_url_trailer     = @pelicula_url_trailer,
        pelicula_imagen          = @pelicula_imagen
    OUTPUT 'CORRECTO' AS 'RESPONSE'
    WHERE [id] = @id
END
GO

CREATE PROCEDURE SP_ActualizarUsuario @id int,
                                      @usuario_username nvarchar(25),
                                      @usuario_password nvarchar(25),
                                      @usuario_perfil int
AS
BEGIN
    UPDATE [Usuario]
    set usuario_username = @usuario_username,
        usuario_password = @usuario_password,
        usuario_perfil   = @usuario_perfil
    OUTPUT 'CORRECTO' AS 'RESPONSE'
    WHERE [id] = @id
END
GO

CREATE PROCEDURE SP_BancosActivos
AS
BEGIN
    SELECT *
    FROM dbo.Banco
    WHERE Banco.banco_estado = 1
END
GO

CREATE PROCEDURE SP_BoletosCliente(
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
    WHERE [Boleto].boleto_factura IN (SELECT [Factura].id
                                      FROM [Factura]
                                      WHERE [Factura].factura_cliente = @idCliente)
END
GO

CREATE PROCEDURE SP_BorrarClientes @id int
AS
BEGIN
    DELETE
    FROM Cliente
    OUTPUT 'ELIMINADO' AS 'RESPONSE'
    WHERE id = @id
END
GO

CREATE PROCEDURE SP_BorrarEmpleado @id int
AS
BEGIN
    DELETE
    FROM Empleado
    OUTPUT 'ELIMINADO' AS 'RESPONSE'
    WHERE id = @id
END
GO

CREATE PROCEDURE SP_BorrarFuncion @id int
AS
BEGIN
    DELETE
    FROM Funcion
    OUTPUT 'ELIMINADO' AS 'RESPONSE'
    WHERE id = @id
END
GO

CREATE PROCEDURE SP_BorrarPelicula @id int
AS
BEGIN
    DELETE
    FROM Pelicula
    OUTPUT 'ELIMINADO' AS 'RESPONSE'
    WHERE id = @id
END
GO

CREATE PROCEDURE SP_BorrarPeliculaCategoria @idPelicula int
AS
BEGIN
    DELETE
    FROM rel_Pelicula_Categoria
    WHERE id_Pelicula = @idPelicula
END
GO

CREATE PROCEDURE SP_BorrarUsuario @id int
AS
BEGIN
    DELETE
    FROM Usuario
    OUTPUT 'ELIMINADO' AS 'RESPONSE'
    WHERE id = @id
END
GO

CREATE PROCEDURE SP_BuscarTarjetas @idCliente int
AS
BEGIN
    SET NOCOUNT ON;
    SELECT *
    FROM [dbo].[Tarjetas]
    WHERE @idCliente = [tarjeta_cliente]
END
GO
CREATE PROCEDURE SP_CategoriasPelicula @id int
AS
BEGIN
    /* Selecciona el nombre de la categoria seg�n la id de pelicula indicado */

    SELECT relacion.id_Categoria as id, Categoria.nombre_categoria AS nombre_categoria
    FROM [dbo].[rel_Pelicula_Categoria] relacion
             INNER JOIN [dbo].[Categoria] categoria
                        ON categoria.id = relacion.id_Categoria
    WHERE relacion.id_Pelicula = @id
END
GO

CREATE PROCEDURE SP_CrearBanco(
    @banco_nombre nvarchar(25)
)
AS
BEGIN
    INSERT INTO [Banco]
    OUTPUT inserted.id
    values (@banco_nombre, 1)
END
GO

CREATE PROCEDURE SP_CrearCliente @cliente_cedula varchar(50),
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
    values (@cliente_cedula,
            @cliente_apellidos,
            @cliente_nombres,
            @cliente_telefono,
            @cliente_email,
            @cliente_direccion,
            @cliente_usuario)
END
GO

CREATE PROCEDURE SP_CrearEmpleado @empleado_nombres nvarchar(50),
                                  @empleado_cedula nvarchar(50),
                                  @empleado_apellidos nvarchar(50),
                                  @empleado_telefono nvarchar(50),
                                  @empleado_email nvarchar(50),
                                  @empleado_direccion nvarchar(50),
                                  @empleado_usuario int
AS
BEGIN
    INSERT INTO Empleado
    (empleado_nombres,
     empleado_cedula,
     empleado_apellidos,
     empleado_telefono,
     empleado_email,
     empleado_direccion,
     empleado_usuario)
    OUTPUT inserted.id
    VALUES (@empleado_nombres,
            @empleado_cedula,
            @empleado_apellidos,
            @empleado_telefono,
            @empleado_email,
            @empleado_direccion,
            @empleado_usuario)
END
GO

CREATE PROCEDURE SP_CrearFactura @factura_cliente int,
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
    VALUES (@factura_cliente, @factura_funcion, @factura_numero, @factura_fecha_emision, @factura_metodo_pago,
            @factura_estado)
END
GO

CREATE PROCEDURE SP_CrearFuncion(
    @funcion_pelicula int,
    @funcion_sala int,
    @funcion_fecha_evento date,
    @funcion_horario int,
    @funcion_estado nvarchar(25),
    @funcion_precio_boleto decimal(18, 0),
    @funcion_fecha_creacion date,
    @funcion_idioma int,
    @funcion_asientos_disponibles int
)
AS
BEGIN
    INSERT INTO [Funcion]
    VALUES (@funcion_pelicula,
            @funcion_sala,
            @funcion_fecha_evento,
            @funcion_horario,
            @funcion_estado,
            @funcion_precio_boleto,
            @funcion_fecha_creacion,
            @funcion_idioma,
            @funcion_asientos_disponibles)
END
GO

CREATE PROCEDURE SP_CrearHorario @hora_inicio time(7),
                                 @hora_fin time(7)
AS
BEGIN
    INSERT INTO Horarios
    OUTPUT inserted.id
    values (@hora_inicio,
            @hora_fin)
END
GO

CREATE PROCEDURE SP_CrearPelicula @pelicula_titulo nvarchar(50),
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
    VALUES (@pelicula_titulo,
            @pelicula_titulo_original,
            @pelicula_duracion,
            @pelicula_tipo_censura,
            @pelicula_sinopsis,
            @pelicula_director,
            @pelicula_reparto,
            @pelicula_url_trailer,
            @pelicula_imagen)
END
GO

CREATE PROCEDURE SP_CrearPeliculaCategoria @id_Pelicula int,
                                           @id_Categoria int
AS
BEGIN
    INSERT INTO rel_Pelicula_Categoria
    VALUES (@id_Pelicula, @id_Categoria)
END
GO

CREATE PROCEDURE SP_CrearTarjeta(
    @tarjeta_cliente int,
    @tarjeta_tipo nvarchar(25),
    @tarjeta_banco int,
    @tarjeta_numero nvarchar(50),
    @tarjeta_ccv nvarchar(3),
    @tarjeta_ano int,
    @tarjeta_mes nvarchar(50),
    @tarjeta_dia nvarchar(50),
    @tarjeta_propietario nvarchar(50)
)
AS
BEGIN
    INSERT INTO [Tarjetas]
    (tarjeta_cliente,
     tarjeta_tipo,
     tarjeta_banco,
     tarjeta_numero,
     tarjeta_ccv,
     tarjeta_ano,
     tarjeta_mes,
     tarjeta_dia,
     tarjeta_propietario)
    OUTPUT inserted.id
    values (@tarjeta_cliente,
            @tarjeta_tipo,
            @tarjeta_banco,
            @tarjeta_numero,
            @tarjeta_ccv,
            @tarjeta_ano,
            @tarjeta_mes,
            @tarjeta_dia,
            @tarjeta_propietario)
END
GO

CREATE PROCEDURE SP_CrearUsuario @usuario_username varchar(25),
                                 @usuario_password varchar(25),
                                 @usuario_perfil int
AS
BEGIN
    INSERT INTO [Usuario]
    OUTPUT inserted.id
    values (@usuario_username,
            @usuario_password,
            @usuario_perfil)
END
GO

CREATE PROCEDURE SP_BorrarTarjeta @id int
AS
BEGIN
    DELETE
    FROM [Tarjetas]
    OUTPUT 'ELIMINADO' AS 'RESPONSE'
    WHERE [Tarjetas].id = @id
END
GO

CREATE PROCEDURE SP_FuncionesActivas
AS
BEGIN
    SELECT *
    FROM [dbo].[Vista_FuncionesActivas]
    WHERE funcion_estado = 'ACTIVO'
END
GO

CREATE PROCEDURE SP_GetBanco @id int
AS
BEGIN
    SELECT *
    FROM dbo.Banco
    WHERE Banco.id = @id
END
GO

CREATE PROCEDURE SP_GetCategoria @id int
AS
BEGIN
    SELECT *
    FROM [dbo].Categoria
    WHERE [dbo].Categoria.id = @id
END
GO

CREATE PROCEDURE SP_GetEmpleado @id int
AS
BEGIN
    SELECT *
    FROM dbo.Empleado
    WHERE Empleado.id = @id
END
GO

CREATE PROCEDURE SP_GetEmpresa @id int
AS
BEGIN
    SELECT *
    FROM dbo.Empresa
    WHERE Empresa.id = @id
END
GO

CREATE PROCEDURE SP_GetUsuario @id int
AS
BEGIN
    SELECT *
    FROM Usuario
    WHERE id = @id
END
GO

CREATE PROCEDURE SP_IdiomasPelicula @id int
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

CREATE PROCEDURE SP_IniciarSesionCliente @usuario_username varchar(25),
                                  @usuario_password varchar(25)
AS
BEGIN
    SELECT *
    FROM [dbo].[Cliente] cliente

/*Subconsulta a tabla de usuarios*/
    WHERE cliente.[cliente_usuario] = (SELECT [dbo].[Usuario].[id]
                                       FROM [dbo].[Usuario]
                                       WHERE [usuario_username] = @usuario_username
                                         AND [usuario_password] = @usuario_password)
END
GO

CREATE PROCEDURE SP_IniciarSesionEmpleado @usuario_username varchar(25),
                                  @usuario_password varchar(25)
AS
BEGIN
    SELECT *
    FROM [dbo].[Empleado] empleado

/*Subconsulta a tabla de usuarios*/
    WHERE empleado.[empleado_usuario] = (SELECT [dbo].[Usuario].[id]
                                       FROM [dbo].[Usuario]
                                       WHERE [usuario_username] = @usuario_username
                                         AND [usuario_password] = @usuario_password)
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

CREATE PROCEDURE SP_ListarPeliculaCategoria @idPelicula int
AS
BEGIN
    SELECT *
    FROM rel_Pelicula_Categoria
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

CREATE PROCEDURE SP_BoletosFuncion
    AS
    DECLARE @id int;
    BEGIN
    SELECT * FROM dbo.Boletos
    WHERE id
        END
    GO

CREATE PROCEDURE SP_ObtenerBoletosFacturaGeneral
AS
BEGIN
    DECLARE @cantBoletos int;
    DECLARE @asientos varchar(MAX);

    SET @cantBoletos =
            (SELECT COUNT(*)
             FROM Boleto AS B)

    SET @asientos =
            (SELECT STRING_AGG(B.boleto_asiento, ', ')
             FROM Boleto AS B)

    SELECT @cantBoletos                                            AS 'cantidad',
           @asientos                                               AS 'asientos',
           ('Boleto de tipo ' + Boleto.boleto_tipo_asiento + ', para la funcion de ' +
            Pelicula.pelicula_titulo)                              AS 'concepto',
           Funcion.funcion_precio_boleto                           AS 'precio_unitario',
           (Funcion.funcion_precio_boleto * @cantBoletos)          AS 'importe',
           (Funcion.funcion_precio_boleto * @cantBoletos * 0.12)   AS 'iva',
           ((Funcion.funcion_precio_boleto * @cantBoletos) +
            (Funcion.funcion_precio_boleto * @cantBoletos * 0.12)) AS 'total'

    FROM Boleto
             INNER JOIN Factura ON Boleto.boleto_factura = Factura.id
             INNER JOIN Funcion ON Factura.factura_funcion = Funcion.id
             INNER JOIN Pelicula ON Funcion.funcion_pelicula = Pelicula.id

    GROUP BY Factura.id,
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

CREATE PROCEDURE SP_VistaFacturasCliente @id as int
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