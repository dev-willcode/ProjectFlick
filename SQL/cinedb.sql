USE [master]
GO
/****** Object:  Database [cinedb]    Script Date: 17/01/2020 16:59:51 ******/
CREATE DATABASE [cinedb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cinedb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\cinedb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cinedb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\cinedb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [cinedb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cinedb].[dbo].[sp_fulltext_database] @action = 'enable'
end
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
ALTER DATABASE [cinedb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cinedb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cinedb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cinedb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cinedb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cinedb] SET  DISABLE_BROKER 
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
ALTER DATABASE [cinedb] SET  MULTI_USER 
GO
ALTER DATABASE [cinedb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cinedb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cinedb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cinedb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cinedb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'cinedb', N'ON'
GO
ALTER DATABASE [cinedb] SET QUERY_STORE = OFF
GO
USE [cinedb]
GO
/****** Object:  Table [dbo].[Boleto]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boleto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[boleto_factura] [int] NOT NULL,
	[boleto_funcion] [int] NOT NULL,
	[boleto_asiento] [nchar](5) NOT NULL,
	[boleto_tipo_asiento] [nvarchar](25) NOT NULL,
	[boleto_medio_compra] [nvarchar](25) NOT NULL,
	[boleto_descuento] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Boleto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[categoria_nombre] [nvarchar](25) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cliente_cedula] [nvarchar](50) NULL,
	[cliente_apellidos] [nvarchar](50) NULL,
	[cliente_nombres] [nvarchar](50) NULL,
	[cliente_telefono] [nvarchar](50) NULL,
	[cliente_email] [nvarchar](50) NULL,
	[cliente_direccion] [nvarchar](50) NULL,
	[cliente_usuario] [int] NOT NULL,
 CONSTRAINT [PK_tb_cliente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[empleado_nombres] [nvarchar](50) NULL,
	[empleado_apellidos] [nvarchar](50) NULL,
	[empleado_telefono] [nvarchar](50) NULL,
	[empleado_email] [nvarchar](50) NULL,
	[empleado_direccion] [nvarchar](50) NULL,
	[empleado_usuario] [int] NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[empresa_razon_social] [nvarchar](50) NOT NULL,
	[empresa_numero_contribuyente] [nvarchar](25) NOT NULL,
	[empresa_numero_autorizacion] [nvarchar](25) NOT NULL,
	[empresa_direccion] [nvarchar](25) NOT NULL,
	[empresa_telefono] [nvarchar](25) NOT NULL,
	[empresa_email] [nvarchar](25) NOT NULL,
	[empresa_website] [nvarchar](25) NOT NULL,
	[empresa_ambiente] [nvarchar](25) NOT NULL,
	[empresa_contabilidad] [bit] NOT NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[factura_cliente] [int] NULL,
	[factura_funcion] [int] NULL,
	[factura_numero] [varchar](50) NULL,
	[factura_metodo_pago] [varchar](25) NULL,
	[factura_fecha_emision] [date] NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcion]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[funcion_pelicula] [int] NOT NULL,
	[funcion_sala] [int] NOT NULL,
	[funcion_fecha_evento] [date] NOT NULL,
	[funcion_horario] [int] NOT NULL,
	[funcion_estado] [nvarchar](25) NOT NULL,
	[funcion_precio_boleto] [decimal](18, 0) NOT NULL,
	[funcion_fecha_creacion] [date] NOT NULL,
	[funcion_idioma] [int] NULL,
 CONSTRAINT [PK_Funcion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Horarios]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[horario_inicio] [time](7) NOT NULL,
	[horario_fin] [time](7) NOT NULL,
 CONSTRAINT [PK_Horario_Sala] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idiomas]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idiomas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idioma_descripcion] [nvarchar](25) NOT NULL,
	[idioma_abreviatura] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Idiomas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pelicula]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pelicula](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pelicula_titulo] [nvarchar](50) NOT NULL,
	[pelicula_titulo_original] [nvarchar](50) NOT NULL,
	[pelicula_duracion] [nvarchar](50) NOT NULL,
	[pelicula_tipo_censura] [nvarchar](50) NOT NULL,
	[pelicula_sinopsis] [nvarchar](255) NOT NULL,
	[pelicula_director] [nvarchar](50) NOT NULL,
	[pelicula_reparto] [nvarchar](255) NOT NULL,
	[pelicula_url_trailer] [nvarchar](255) NOT NULL,
	[pelicula_imagen] [image] NULL,
 CONSTRAINT [PK_Pelicula] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil_Usuario]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil_Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[perfil_usuario_nombre] [nvarchar](25) NULL,
 CONSTRAINT [PK_Perfil_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[permiso_nombre] [nvarchar](25) NOT NULL,
	[permiso_descripcion] [nvarchar](25) NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rel_Pelicula_Categoria]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rel_Pelicula_Categoria](
	[id_Pelicula] [int] NULL,
	[id_Categoria] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rel_perfil_permisos]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rel_perfil_permisos](
	[id_perfil] [int] NOT NULL,
	[id_permiso] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sala_Cine]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala_Cine](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sala_nombre] [nvarchar](10) NOT NULL,
	[sala_capacidad_maxima] [int] NOT NULL,
 CONSTRAINT [PK_Sala_cine] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarjetas]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarjetas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tarjeta_cliente] [int] NOT NULL,
	[tarjeta_nombre_banco] [nvarchar](50) NOT NULL,
	[tarjeta_numero] [nchar](16) NOT NULL,
	[tarjeta_ano] [int] NOT NULL,
	[tarjeta_mes] [int] NOT NULL,
	[tarjeta_dia] [int] NOT NULL,
	[tarjeta_propietario] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tarjetas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_username] [nvarchar](25) NOT NULL,
	[usuario_password] [nvarchar](25) NOT NULL,
	[usuario_perfil] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Boleto]  WITH CHECK ADD  CONSTRAINT [FK_Boleto_Factura] FOREIGN KEY([boleto_factura])
REFERENCES [dbo].[Factura] ([id])
GO
ALTER TABLE [dbo].[Boleto] CHECK CONSTRAINT [FK_Boleto_Factura]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Usuario] FOREIGN KEY([cliente_usuario])
REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Usuario]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Usuario] FOREIGN KEY([empleado_usuario])
REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Usuario]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Cliente] FOREIGN KEY([factura_cliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Cliente]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Funcion] FOREIGN KEY([factura_funcion])
REFERENCES [dbo].[Funcion] ([id])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Funcion]
GO
ALTER TABLE [dbo].[Funcion]  WITH CHECK ADD  CONSTRAINT [FK_Funcion_Horarios] FOREIGN KEY([funcion_horario])
REFERENCES [dbo].[Horarios] ([id])
GO
ALTER TABLE [dbo].[Funcion] CHECK CONSTRAINT [FK_Funcion_Horarios]
GO
ALTER TABLE [dbo].[Funcion]  WITH CHECK ADD  CONSTRAINT [FK_Funcion_Idiomas] FOREIGN KEY([funcion_idioma])
REFERENCES [dbo].[Idiomas] ([id])
GO
ALTER TABLE [dbo].[Funcion] CHECK CONSTRAINT [FK_Funcion_Idiomas]
GO
ALTER TABLE [dbo].[Funcion]  WITH CHECK ADD  CONSTRAINT [FK_Funcion_Pelicula] FOREIGN KEY([funcion_pelicula])
REFERENCES [dbo].[Pelicula] ([id])
GO
ALTER TABLE [dbo].[Funcion] CHECK CONSTRAINT [FK_Funcion_Pelicula]
GO
ALTER TABLE [dbo].[Funcion]  WITH CHECK ADD  CONSTRAINT [FK_Funcion_Sala_Cine] FOREIGN KEY([funcion_sala])
REFERENCES [dbo].[Sala_Cine] ([id])
GO
ALTER TABLE [dbo].[Funcion] CHECK CONSTRAINT [FK_Funcion_Sala_Cine]
GO
ALTER TABLE [dbo].[rel_Pelicula_Categoria]  WITH CHECK ADD  CONSTRAINT [FK_rel_Pelicula_Categoria_Categoria] FOREIGN KEY([id_Categoria])
REFERENCES [dbo].[Categoria] ([id])
GO
ALTER TABLE [dbo].[rel_Pelicula_Categoria] CHECK CONSTRAINT [FK_rel_Pelicula_Categoria_Categoria]
GO
ALTER TABLE [dbo].[rel_Pelicula_Categoria]  WITH CHECK ADD  CONSTRAINT [FK_rel_Pelicula_Categoria_Pelicula] FOREIGN KEY([id_Pelicula])
REFERENCES [dbo].[Pelicula] ([id])
GO
ALTER TABLE [dbo].[rel_Pelicula_Categoria] CHECK CONSTRAINT [FK_rel_Pelicula_Categoria_Pelicula]
GO
ALTER TABLE [dbo].[rel_perfil_permisos]  WITH CHECK ADD  CONSTRAINT [FK_rel_perfil_permisos_Perfil_Usuario] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfil_Usuario] ([id])
GO
ALTER TABLE [dbo].[rel_perfil_permisos] CHECK CONSTRAINT [FK_rel_perfil_permisos_Perfil_Usuario]
GO
ALTER TABLE [dbo].[rel_perfil_permisos]  WITH CHECK ADD  CONSTRAINT [FK_rel_perfil_permisos_Permisos] FOREIGN KEY([id_permiso])
REFERENCES [dbo].[Permisos] ([id])
GO
ALTER TABLE [dbo].[rel_perfil_permisos] CHECK CONSTRAINT [FK_rel_perfil_permisos_Permisos]
GO
ALTER TABLE [dbo].[Tarjetas]  WITH CHECK ADD  CONSTRAINT [FK_Tarjetas_Cliente] FOREIGN KEY([tarjeta_cliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Tarjetas] CHECK CONSTRAINT [FK_Tarjetas_Cliente]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Perfil_Usuario] FOREIGN KEY([usuario_perfil])
REFERENCES [dbo].[Perfil_Usuario] ([id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Perfil_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[SP_CrearCliente]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CrearCliente]
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
/****** Object:  StoredProcedure [dbo].[SP_CrearUsuario]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CrearUsuario]
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
/****** Object:  StoredProcedure [dbo].[SP_IniciarSesion]    Script Date: 17/01/2020 16:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IniciarSesion]
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
USE [master]
GO
ALTER DATABASE [cinedb] SET  READ_WRITE 
GO
