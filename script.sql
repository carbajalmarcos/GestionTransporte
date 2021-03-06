USE [master]
GO
/****** Object:  Database [gestiontransporte]    Script Date: 10/3/2017 02:29:58 ******/
CREATE DATABASE [gestiontransporte]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gestiontransporte', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\gestiontransporte.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'gestiontransporte_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\gestiontransporte_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [gestiontransporte] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gestiontransporte].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gestiontransporte] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gestiontransporte] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gestiontransporte] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gestiontransporte] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gestiontransporte] SET ARITHABORT OFF 
GO
ALTER DATABASE [gestiontransporte] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gestiontransporte] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gestiontransporte] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gestiontransporte] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gestiontransporte] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gestiontransporte] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gestiontransporte] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gestiontransporte] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gestiontransporte] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gestiontransporte] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gestiontransporte] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gestiontransporte] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gestiontransporte] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gestiontransporte] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gestiontransporte] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gestiontransporte] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gestiontransporte] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gestiontransporte] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [gestiontransporte] SET  MULTI_USER 
GO
ALTER DATABASE [gestiontransporte] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gestiontransporte] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gestiontransporte] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gestiontransporte] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [gestiontransporte] SET DELAYED_DURABILITY = DISABLED 
GO
USE [gestiontransporte]
GO
/****** Object:  DatabaseRole [funciones_principales]    Script Date: 10/3/2017 02:29:59 ******/
CREATE ROLE [funciones_principales]
GO
/****** Object:  Table [dbo].[acoplado]    Script Date: 10/3/2017 02:29:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[acoplado](
	[id_acoplado] [int] IDENTITY(1,1) NOT NULL,
	[dominio] [nvarchar](20) NOT NULL,
	[marca] [nvarchar](50) NOT NULL,
	[modelo] [nvarchar](20) NOT NULL,
	[año] [int] NULL,
	[tara] [float] NOT NULL,
	[tipo] [int] NULL,
	[alt_total] [float] NOT NULL,
	[nro_chasis] [nvarchar](20) NOT NULL,
	[ancho_interior] [float] NOT NULL,
	[ancho_exterior] [float] NOT NULL,
	[long_plataforma] [float] NOT NULL,
	[capacidad_carga] [float] NOT NULL,
	[cant_ejes] [int] NOT NULL,
	[estado] [nvarchar](30) NOT NULL,
	[observaciones] [nvarchar](300) NULL,
	[fecha_alta] [date] NULL,
	[fecha_baja] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_acoplado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_acoplado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[dominio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nro_chasis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[auditoria]    Script Date: 10/3/2017 02:29:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[auditoria](
	[fecha_hr] [nvarchar](50) NOT NULL,
	[usuario] [nvarchar](50) NOT NULL,
	[accion] [nvarchar](200) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[camion]    Script Date: 10/3/2017 02:29:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[camion](
	[id_camion] [int] IDENTITY(1,1) NOT NULL,
	[dominio] [nvarchar](10) NOT NULL,
	[marca] [int] NOT NULL,
	[tara] [nvarchar](20) NOT NULL,
	[modelo] [nvarchar](20) NOT NULL,
	[año] [int] NULL,
	[tipo] [int] NULL,
	[nro_chasis] [nvarchar](20) NOT NULL,
	[nro_motor] [nvarchar](20) NOT NULL,
	[alt_total] [float] NULL,
	[ancho_total] [float] NULL,
	[long_total] [float] NULL,
	[estado] [nvarchar](30) NULL,
	[observaciones] [nchar](300) NULL,
	[fecha_alta] [date] NULL,
	[fecha_baja] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_camion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[dominio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nro_chasis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_camion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nro_motor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[camion_acoplado]    Script Date: 10/3/2017 02:29:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[camion_acoplado](
	[id_camion] [int] NOT NULL,
	[id_acoplado] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[cliente]    Script Date: 10/3/2017 02:29:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[legajo] [int] IDENTITY(1,1) NOT NULL,
	[denominacion] [nvarchar](200) NOT NULL,
	[telefono1] [nvarchar](30) NOT NULL,
	[telefono2] [nvarchar](30) NULL,
	[correo_electronico] [nvarchar](100) NULL,
	[descripcion] [nvarchar](500) NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[empleados]    Script Date: 10/3/2017 02:29:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[num_legajo] [int] NOT NULL,
	[nombre] [nvarchar](20) NOT NULL,
	[num_cedula] [nvarchar](20) NOT NULL,
	[direccion] [nvarchar](20) NOT NULL,
	[telefono1] [nvarchar](30) NOT NULL,
	[telefono2] [nvarchar](30) NULL,
	[estado] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_empleados] PRIMARY KEY CLUSTERED 
(
	[num_legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[login]    Script Date: 10/3/2017 02:29:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[usuario] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[num_legajo] [int] NOT NULL,
	[tipo_usuario] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[marca]    Script Date: 10/3/2017 02:29:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marca](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[marca] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_marca] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [ak_marca] UNIQUE NONCLUSTERED 
(
	[marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[mecanico]    Script Date: 10/3/2017 02:29:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mecanico](
	[num_legajo] [int] NOT NULL,
	[telefono1] [nvarchar](20) NOT NULL,
	[telefono2] [nvarchar](20) NULL,
	[estado] [nvarchar](30) NOT NULL,
	[direccion] [nvarchar](30) NOT NULL,
	[apellido] [nvarchar](20) NOT NULL,
	[nombre] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[num_legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[num_legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[pedido]    Script Date: 10/3/2017 02:29:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedido](
	[id_pedido] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[fecha_pedido] [datetime] NULL,
	[destino] [nvarchar](300) NULL,
	[fecha_sal_aprox] [datetime] NULL,
	[fecha_reg_aprox] [datetime] NULL,
	[peso_carga_aprox] [float] NULL,
	[cambios] [nvarchar](500) NULL,
	[observaciones] [nvarchar](500) NULL,
	[estado] [nvarchar](50) NULL,
 CONSTRAINT [PK_pedido] PRIMARY KEY CLUSTERED 
(
	[id_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[reparacion]    Script Date: 10/3/2017 02:29:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reparacion](
	[id_camion] [int] NOT NULL,
	[num_legajo] [int] NOT NULL,
	[entrada_taller] [datetime] NOT NULL,
	[salida_aprox] [datetime] NOT NULL,
	[salida] [datetime] NULL,
	[observaciones] [nchar](300) NULL,
 CONSTRAINT [PK_reparacion] PRIMARY KEY CLUSTERED 
(
	[num_legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_acoplado]    Script Date: 10/3/2017 02:29:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_acoplado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tipo_acoplado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [ak_tipo_acoplado] UNIQUE NONCLUSTERED 
(
	[tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_camion]    Script Date: 10/3/2017 02:29:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_camion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tipo_camion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [ak_tipo_camion] UNIQUE NONCLUSTERED 
(
	[tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[viaje]    Script Date: 10/3/2017 02:29:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[viaje](
	[id_viaje] [int] IDENTITY(1,1) NOT NULL,
	[id_pedido] [int] NOT NULL,
	[id_camion] [int] NOT NULL,
	[id_chofer] [int] NULL,
	[fecha_sal] [datetime] NULL,
	[fecha_regre] [datetime] NULL,
	[kms_realizados] [float] NULL,
	[kms_antes_de_viajar] [float] NULL,
	[cambios] [nvarchar](500) NULL,
	[observaciones] [nvarchar](500) NULL,
	[estado] [nvarchar](20) NULL,
 CONSTRAINT [PK_viaje] PRIMARY KEY CLUSTERED 
(
	[id_viaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Index [IX_camion_acoplado]    Script Date: 10/3/2017 02:29:59 ******/
CREATE NONCLUSTERED INDEX [IX_camion_acoplado] ON [dbo].[camion_acoplado]
(
	[id_camion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[acoplado]  WITH CHECK ADD  CONSTRAINT [fk_tipo_acoplado] FOREIGN KEY([tipo])
REFERENCES [dbo].[tipo_acoplado] ([id])
GO
ALTER TABLE [dbo].[acoplado] CHECK CONSTRAINT [fk_tipo_acoplado]
GO
ALTER TABLE [dbo].[auditoria]  WITH CHECK ADD  CONSTRAINT [fk_usuario] FOREIGN KEY([usuario])
REFERENCES [dbo].[login] ([usuario])
GO
ALTER TABLE [dbo].[auditoria] CHECK CONSTRAINT [fk_usuario]
GO
ALTER TABLE [dbo].[camion]  WITH CHECK ADD  CONSTRAINT [fk_marca] FOREIGN KEY([marca])
REFERENCES [dbo].[marca] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[camion] CHECK CONSTRAINT [fk_marca]
GO
ALTER TABLE [dbo].[camion]  WITH CHECK ADD  CONSTRAINT [fk_tipo_camion] FOREIGN KEY([tipo])
REFERENCES [dbo].[tipo_camion] ([id])
GO
ALTER TABLE [dbo].[camion] CHECK CONSTRAINT [fk_tipo_camion]
GO
ALTER TABLE [dbo].[camion_acoplado]  WITH CHECK ADD  CONSTRAINT [FK_camion_acoplado_acoplado] FOREIGN KEY([id_acoplado])
REFERENCES [dbo].[acoplado] ([id_acoplado])
GO
ALTER TABLE [dbo].[camion_acoplado] CHECK CONSTRAINT [FK_camion_acoplado_acoplado]
GO
ALTER TABLE [dbo].[camion_acoplado]  WITH CHECK ADD  CONSTRAINT [FK_camion_acoplado_camion] FOREIGN KEY([id_camion])
REFERENCES [dbo].[camion] ([id_camion])
GO
ALTER TABLE [dbo].[camion_acoplado] CHECK CONSTRAINT [FK_camion_acoplado_camion]
GO
ALTER TABLE [dbo].[login]  WITH CHECK ADD  CONSTRAINT [FK_login_empleados] FOREIGN KEY([num_legajo])
REFERENCES [dbo].[empleados] ([num_legajo])
GO
ALTER TABLE [dbo].[login] CHECK CONSTRAINT [FK_login_empleados]
GO
ALTER TABLE [dbo].[reparacion]  WITH CHECK ADD  CONSTRAINT [FK_reparacion_camion] FOREIGN KEY([id_camion])
REFERENCES [dbo].[camion] ([id_camion])
GO
ALTER TABLE [dbo].[reparacion] CHECK CONSTRAINT [FK_reparacion_camion]
GO
ALTER TABLE [dbo].[viaje]  WITH CHECK ADD  CONSTRAINT [FK_viaje_camion] FOREIGN KEY([id_camion])
REFERENCES [dbo].[camion] ([id_camion])
GO
ALTER TABLE [dbo].[viaje] CHECK CONSTRAINT [FK_viaje_camion]
GO
ALTER TABLE [dbo].[viaje]  WITH NOCHECK ADD  CONSTRAINT [FK_viaje_empleados] FOREIGN KEY([id_chofer])
REFERENCES [dbo].[empleados] ([num_legajo])
GO
ALTER TABLE [dbo].[viaje] CHECK CONSTRAINT [FK_viaje_empleados]
GO
ALTER TABLE [dbo].[viaje]  WITH CHECK ADD  CONSTRAINT [FK_viaje_pedido] FOREIGN KEY([id_pedido])
REFERENCES [dbo].[pedido] ([id_pedido])
GO
ALTER TABLE [dbo].[viaje] CHECK CONSTRAINT [FK_viaje_pedido]
GO
USE [master]
GO
ALTER DATABASE [gestiontransporte] SET  READ_WRITE 
GO
