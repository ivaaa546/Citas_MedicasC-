USE [master]
GO
/****** Object:  Database [citasMedicas_IvanIco]    Script Date: 21/05/2024 14:38:06 ******/
CREATE DATABASE [citasMedicas_IvanIco]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'citasMedicas_IvanIco', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\citasMedicas_IvanIco.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'citasMedicas_IvanIco_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\citasMedicas_IvanIco_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [citasMedicas_IvanIco] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [citasMedicas_IvanIco].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [citasMedicas_IvanIco] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET ARITHABORT OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET  ENABLE_BROKER 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET RECOVERY FULL 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET  MULTI_USER 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [citasMedicas_IvanIco] SET DB_CHAINING OFF 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [citasMedicas_IvanIco] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'citasMedicas_IvanIco', N'ON'
GO
ALTER DATABASE [citasMedicas_IvanIco] SET QUERY_STORE = ON
GO
ALTER DATABASE [citasMedicas_IvanIco] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [citasMedicas_IvanIco]
GO
/****** Object:  User [usuario_]    Script Date: 21/05/2024 14:38:06 ******/
CREATE USER [usuario_] FOR LOGIN [usuario_] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [usuario]    Script Date: 21/05/2024 14:38:06 ******/
CREATE USER [usuario] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [sa1]    Script Date: 21/05/2024 14:38:06 ******/
CREATE USER [sa1] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [sa_2]    Script Date: 21/05/2024 14:38:06 ******/
CREATE USER [sa_2] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [sa_1]    Script Date: 21/05/2024 14:38:06 ******/
CREATE USER [sa_1] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [sa_]    Script Date: 21/05/2024 14:38:06 ******/
CREATE USER [sa_] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[datosPaciente]    Script Date: 21/05/2024 14:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datosPaciente](
	[Id_Paciente] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Nombres] [varchar](70) NOT NULL,
	[Apellidos] [varchar](70) NOT NULL,
	[Direccion] [varchar](100) NULL,
	[Telefono] [varchar](70) NOT NULL,
	[DPI] [varchar](70) NOT NULL,
	[Edad] [varchar](50) NULL,
	[PA] [varchar](50) NULL,
	[Temp] [varchar](20) NULL,
	[Peso] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examenes]    Script Date: 21/05/2024 14:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examenes](
	[Id_examenes] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Datos_postivos] [varchar](70) NOT NULL,
	[Examenes_Complementarios] [varchar](70) NOT NULL,
	[Impresion_Clinica] [varchar](70) NULL,
	[Tratamiento] [varchar](70) NULL,
	[Id_paciente] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_examenes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[datosPaciente] ON 

INSERT [dbo].[datosPaciente] ([Id_Paciente], [Fecha], [Nombres], [Apellidos], [Direccion], [Telefono], [DPI], [Edad], [PA], [Temp], [Peso]) VALUES (1, CAST(N'2023-05-10T00:00:00.000' AS DateTime), N'Juanito', N'Alcachofa', N'Chile', N'55669876', N'65464532131', N'18', N'110/80', N'37 grados', N'145 lb')
INSERT [dbo].[datosPaciente] ([Id_Paciente], [Fecha], [Nombres], [Apellidos], [Direccion], [Telefono], [DPI], [Edad], [PA], [Temp], [Peso]) VALUES (19, CAST(N'2024-05-14T08:43:30.563' AS DateTime), N'Marcos', N'Marcos', N'654', N'5656', N'654654', N'56', N'23', N'5', N'2 libras')
INSERT [dbo].[datosPaciente] ([Id_Paciente], [Fecha], [Nombres], [Apellidos], [Direccion], [Telefono], [DPI], [Edad], [PA], [Temp], [Peso]) VALUES (20, CAST(N'2024-05-14T09:24:31.830' AS DateTime), N'Ivan', N'Alexander', N'Chamelco', N'4546456', N'6546546', N'100', N'115/23', N'28', N'565 libras')
INSERT [dbo].[datosPaciente] ([Id_Paciente], [Fecha], [Nombres], [Apellidos], [Direccion], [Telefono], [DPI], [Edad], [PA], [Temp], [Peso]) VALUES (27, CAST(N'2024-05-19T22:27:28.423' AS DateTime), N'Hola', N'Hola', N'ss', N'dd', N'd', N'', N'', N'', N'')
INSERT [dbo].[datosPaciente] ([Id_Paciente], [Fecha], [Nombres], [Apellidos], [Direccion], [Telefono], [DPI], [Edad], [PA], [Temp], [Peso]) VALUES (29, CAST(N'2024-05-21T12:39:30.600' AS DateTime), N'Nan', N'Nan', N'Carcha', N'3664556', N'465464564', N'99', N'178/5', N'30', N'160')
INSERT [dbo].[datosPaciente] ([Id_Paciente], [Fecha], [Nombres], [Apellidos], [Direccion], [Telefono], [DPI], [Edad], [PA], [Temp], [Peso]) VALUES (30, CAST(N'2024-05-21T14:06:48.253' AS DateTime), N'sdf', N'sdf', N'', N'sdf', N'sd', N'', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[datosPaciente] OFF
GO
SET IDENTITY_INSERT [dbo].[Examenes] ON 

INSERT [dbo].[Examenes] ([Id_examenes], [Fecha], [Datos_postivos], [Examenes_Complementarios], [Impresion_Clinica], [Tratamiento], [Id_paciente]) VALUES (19, CAST(N'2024-05-15T08:38:24.580' AS DateTime), N'rsd3', N'fvt', N'fbt', N'fnt', 19)
INSERT [dbo].[Examenes] ([Id_examenes], [Fecha], [Datos_postivos], [Examenes_Complementarios], [Impresion_Clinica], [Tratamiento], [Id_paciente]) VALUES (27, CAST(N'2024-05-14T15:20:33.577' AS DateTime), N'dfsdf', N'sadf', N'asdf', N'asdf', 1)
INSERT [dbo].[Examenes] ([Id_examenes], [Fecha], [Datos_postivos], [Examenes_Complementarios], [Impresion_Clinica], [Tratamiento], [Id_paciente]) VALUES (28, CAST(N'2024-05-15T11:40:06.577' AS DateTime), N'ee', N'ee', N'f', N'f', 1)
INSERT [dbo].[Examenes] ([Id_examenes], [Fecha], [Datos_postivos], [Examenes_Complementarios], [Impresion_Clinica], [Tratamiento], [Id_paciente]) VALUES (30, CAST(N'2024-05-15T11:13:02.793' AS DateTime), N'dffss', N'df_', N'df', N'df', 20)
INSERT [dbo].[Examenes] ([Id_examenes], [Fecha], [Datos_postivos], [Examenes_Complementarios], [Impresion_Clinica], [Tratamiento], [Id_paciente]) VALUES (32, CAST(N'2024-05-20T22:27:58.250' AS DateTime), N's', N'sd', N'', N'', 20)
INSERT [dbo].[Examenes] ([Id_examenes], [Fecha], [Datos_postivos], [Examenes_Complementarios], [Impresion_Clinica], [Tratamiento], [Id_paciente]) VALUES (42, CAST(N'2024-05-18T08:00:51.983' AS DateTime), N'khkj', N'llj', N'ljkl', N'ljlk', 20)
INSERT [dbo].[Examenes] ([Id_examenes], [Fecha], [Datos_postivos], [Examenes_Complementarios], [Impresion_Clinica], [Tratamiento], [Id_paciente]) VALUES (46, CAST(N'2024-05-20T22:26:02.853' AS DateTime), N'hola', N'hola', N'hola', N'hola', 19)
INSERT [dbo].[Examenes] ([Id_examenes], [Fecha], [Datos_postivos], [Examenes_Complementarios], [Impresion_Clinica], [Tratamiento], [Id_paciente]) VALUES (47, CAST(N'2024-05-21T12:40:53.017' AS DateTime), N'p', N'p', N'', N'', 29)
SET IDENTITY_INSERT [dbo].[Examenes] OFF
GO
ALTER TABLE [dbo].[Examenes]  WITH CHECK ADD  CONSTRAINT [fk_Paciente] FOREIGN KEY([Id_paciente])
REFERENCES [dbo].[datosPaciente] ([Id_Paciente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Examenes] CHECK CONSTRAINT [fk_Paciente]
GO
/****** Object:  StoredProcedure [dbo].[buscar_examenes_por_nombre_apellido]    Script Date: 21/05/2024 14:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscar_examenes_por_nombre_apellido]
    @valor varchar(70)
AS
BEGIN
    SELECT 
        dp.Id_Paciente,
		dp.Fecha AS Fecha,
        dp.Nombres,
        dp.Apellidos,
        dp.Direccion,
        dp.Telefono,
        dp.DPI,
        dp.Edad,
        dp.PA,
        dp.Temp,
        dp.Peso,
        e.Id_examenes,
        e.Fecha AS Fecha,
        e.Datos_postivos,
        e.Examenes_Complementarios,
        e.Impresion_Clinica,
        e.Tratamiento
    FROM 
        datosPaciente dp
    INNER JOIN 
        Examenes e
    ON 
        dp.Id_Paciente = e.Id_paciente
    WHERE 
        dp.Nombres LIKE '%' + @valor + '%' OR dp.Apellidos LIKE '%' + @valor + '%'
    ORDER BY 
        dp.Id_Paciente, e.Id_examenes;
END;
GO
/****** Object:  StoredProcedure [dbo].[buscarxamanes_fechaNombre]    Script Date: 21/05/2024 14:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarxamanes_fechaNombre]
    @nombre_apellido varchar(70),
    @fecha datetime
AS
BEGIN
    SELECT 
        dp.Id_Paciente,
        dp.Fecha AS Fecha,
        dp.Nombres,
        dp.Apellidos,
        dp.Direccion,
        dp.Telefono,
        dp.DPI,
        dp.Edad,
        dp.PA,
        dp.Temp,
        dp.Peso,
        e.Id_examenes,
        e.Fecha AS Fecha,
        e.Datos_postivos,
        e.Examenes_Complementarios,
        e.Impresion_Clinica,
        e.Tratamiento
    FROM 
        datosPaciente dp
    INNER JOIN 
        Examenes e
    ON 
        dp.Id_Paciente = e.Id_paciente
    WHERE 
        (dp.Nombres + ' ' + dp.Apellidos) LIKE '%' + @nombre_apellido + '%' -- Buscar por nombre y apellido
        AND CONVERT(date, e.Fecha) = CONVERT(date, @fecha) -- Filtrar por fecha específica
    ORDER BY 
        dp.Id_Paciente, e.Fecha;
END;
GO
/****** Object:  StoredProcedure [dbo].[eliminar_paciente]    Script Date: 21/05/2024 14:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_paciente]
	@Id_paciente int
	as
	delete from datosPaciente
	where Id_Paciente = @Id_paciente
GO
/****** Object:  StoredProcedure [dbo].[examenes_actualizar]    Script Date: 21/05/2024 14:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[examenes_actualizar]
	@Id_examenes int,
	@Fecha datetime,
    @Datos_postivos varchar(50),
    @Examenes_Complementarios varchar(250),
    @Impresion_Clinica varchar(250),
    @Tratamiento varchar(250),
    @Id_paciente int
as
	update Examenes
	set Fecha = @Fecha,
    Datos_postivos = @Datos_postivos,
    Examenes_Complementarios = @Examenes_Complementarios,
    Impresion_Clinica = @Impresion_Clinica,
    Tratamiento = @Tratamiento,
	Id_paciente = @Id_paciente
	 WHERE Id_examenes = @Id_examenes
GO
/****** Object:  StoredProcedure [dbo].[examenes_buscar]    Script Date: 21/05/2024 14:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[examenes_buscar]
@idPaciente int
as
	select * from Examenes where id_paciente = @idPaciente
	order by id_examenes asc 
GO
/****** Object:  StoredProcedure [dbo].[examenes_eliminar]    Script Date: 21/05/2024 14:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[examenes_eliminar] 
	@Id_examenes  int
as
	delete from Examenes
	where Id_examenes =  @Id_examenes
GO
/****** Object:  StoredProcedure [dbo].[examenes_insertar]    Script Date: 21/05/2024 14:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[examenes_insertar]
    @Fecha datetime,
    @Datos_postivos varchar(50),
    @Examenes_Complementarios varchar(250),
    @Impresion_Clinica varchar(250),
    @Tratamiento varchar(250),
    @Id_paciente int
as
	insert into Examenes (Fecha, Datos_postivos, Examenes_Complementarios, Impresion_Clinica, Tratamiento, Id_paciente)
	values (@Fecha, @Datos_postivos, @Examenes_Complementarios, @Impresion_Clinica, @Tratamiento, @Id_paciente)
GO
/****** Object:  StoredProcedure [dbo].[examenes_listar]    Script Date: 21/05/2024 14:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[examenes_listar]
as
	select  Id_examenes ,Fecha, Datos_postivos, Examenes_Complementarios,Impresion_Clinica, Tratamiento, Id_paciente from Examenes
	order by Id_examenes desc
GO
/****** Object:  StoredProcedure [dbo].[paciente_actualizar]    Script Date: 21/05/2024 14:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--4. procedimiento para actualizar 
CREATE proc [dbo].[paciente_actualizar]	
	@Id_paciente int,
	@Fecha datetime,
	@Nombres varchar(70),
	@Apellidos varchar(70),
	@Direccion varchar(70),
	@telefono varchar(70),
	@DPI varchar(70),
	@Edad varchar(50), 
	@PA varchar (30),
	@Temp varchar (20),
	@Peso varchar (20)
as

	update	datosPaciente 
	set Fecha = @Fecha, 
	Nombres=@Nombres, 
	Apellidos=@Apellidos, 
	Direccion=@Direccion,
	Telefono=@telefono, 
	DPI =@DPI, 
	Edad =@Edad, 
	Pa = @PA, 
	Temp = @Temp, 
	Peso = @Peso
	where  Id_Paciente = @Id_paciente
GO
/****** Object:  StoredProcedure [dbo].[paciente_buscar]    Script Date: 21/05/2024 14:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[paciente_buscar]
@valor varchar(50)
as
	select  Id_paciente ,
	Fecha, Nombres, Apellidos, Direccion,Telefono, DPI, Edad, PA, temp, Peso from datosPaciente
	where	Nombres like '%' + @valor + '%' 
	or Apellidos like '%' + @valor + '%'
	order by Id_Paciente asc
GO
/****** Object:  StoredProcedure [dbo].[paciente_insertar]    Script Date: 21/05/2024 14:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--3. procedimientos para insertar
create proc [dbo].[paciente_insertar]	
	@Fecha datetime,
	@Nombres varchar(70),
	@Apellidos varchar(70),
	@Direccion varchar(70),
	@telefono varchar(70),
	@DPI varchar(70),
	@Edad varchar(50), 
	@PA varchar (30),
	@Temp varchar (20),
	@Peso varchar (20)
as
	insert into datosPaciente ( Fecha, Nombres, Apellidos, Direccion, Telefono, DPI, Edad, PA, Temp, Peso) values (@Fecha, @Nombres,@Apellidos, @Direccion, @telefono,@DPI,@Edad, @PA, @Temp,@Peso )
GO
/****** Object:  StoredProcedure [dbo].[paciente_listar]    Script Date: 21/05/2024 14:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[paciente_listar]
as
	select  Id_paciente ,Fecha, Nombres, Apellidos, Direccion,Telefono, DPI, Edad, PA, temp, Peso from datosPaciente
	order by Id_Paciente desc
GO
USE [master]
GO
ALTER DATABASE [citasMedicas_IvanIco] SET  READ_WRITE 
GO
