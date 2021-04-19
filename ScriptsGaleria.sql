
--CREACION DE TABLAS

CREATE TABLE Tbl_DocumentoIdentidad(
    Id_DocumentoIdentidad INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    TipoDocumento VARCHAR(30) NOT NULL,
    NumeroDocumento VARCHAR(20) NOT NULL
)


CREATE TABLE Tbl_Persona(
    Id_Persona INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Id_DocumentoIdentidad INT FOREIGN KEY REFERENCES Tbl_DocumentoIdentidad(Id_DocumentoIdentidad) NOT NULL,
    Correo VARCHAR(40) NOT NULL,
    Nombre VARCHAR(40) NOT NULL,
    Telefono VARCHAR(20) NOT NULL,
    Direccion VARCHAR(100) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Nacionalidad VARCHAR(40) NOT NULL
)

CREATE TABLE Tbl_Pintor(
    Id_Pintor INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Id_Persona INT FOREIGN KEY REFERENCES Tbl_Persona(Id_Persona) NOT NULL
)

CREATE TABLE Tbl_Dueno(
    Id_Dueno INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Id_Persona INT FOREIGN KEY REFERENCES Tbl_Persona(Id_Persona) NOT NULL
)


CREATE TABLE Tbl_Pintura(
    Id_Pintura INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Id_Pintor INT FOREIGN KEY REFERENCES Tbl_Pintor(Id_Pintor),
    Id_Dueno   INT FOREIGN KEY REFERENCES Tbl_Dueno(Id_Dueno) NOT NULL, 
    NombrePintura VARCHAR(40) NOT NULL,
    Tamano VARCHAR(40) NOT NULL,
    FechaCreacion DATE ,
    FechaIngreso datetime,
    FechaSalida datetime,
    Valor decimal(10,2),
	Estado VARCHAR(15) NOT NULL
)

CREATE TABLE Tbl_Genero(
    Id_Genero INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    NombreGenero VARCHAR(30) NOT NULL
)


CREATE TABLE Tbl_PinturaGenero(
    Id_PinturaGenero INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Id_Pintura INT FOREIGN KEY REFERENCES Tbl_Pintura(Id_Pintura) NOT NULL,
    Id_Genero INT FOREIGN KEY REFERENCES Tbl_Genero(Id_Genero) NOT NULL
)

--CREACION STORED PROCEDURES
--PERSONA
GO
CREATE PROCEDURE InsertPersona(@TipoDocumento varchar(30), 
								@NumeroDocumento varchar(20), 
								@Correo varchar(40), 
								@Nombre varchar(40),
								@Telefono varchar(20),
								@Direccion varchar(100),
								@FechaNacimiento date,
								@Nacionalidad varchar(40))
AS  
	BEGIN
		BEGIN
			INSERT INTO Tbl_DocumentoIdentidad
						(TipoDocumento,
						 NumeroDocumento)
			VALUES	(@TipoDocumento,
					@NumeroDocumento)
		END

		BEGIN
			INSERT INTO Tbl_Persona
						(Correo,
						 Nombre,
						 Telefono,
						 Direccion,
						 FechaNacimiento,
						 Nacionalidad)

			VALUES	(@Correo,
					@Nombre,
					@Telefono,
					@Direccion,
					@FechaNacimiento,
					@Nacionalidad)
		END
END
GO

--Documento de identidad
CREATE PROCEDURE InsertDocId(@TipoDocumento varchar(30), 
								@NumeroDocumento varchar(20))
AS  
	BEGIN
			INSERT INTO Tbl_DocumentoIdentidad
						(TipoDocumento,
						 NumeroDocumento)
			VALUES	(@TipoDocumento,
					@NumeroDocumento)
END



--GENERO
CREATE PROCEDURE InsertGenero(@NombreGenero varchar(40))
AS  
	BEGIN
		INSERT INTO Tbl_Genero
					(NombreGenero)
		VALUES	(@NombreGenero)
END
--DUENO
GO
CREATE PROCEDURE [dbo].[InsertDueno](@Id_Persona INT)
AS  
	BEGIN
		INSERT INTO Tbl_Dueno
					(Id_Persona)
		VALUES	(@Id_Persona)
END
--PINTOR
GO
CREATE PROCEDURE [dbo].[InsertPintor](@Id_Persona INT)
AS  
	BEGIN
		INSERT INTO Tbl_Pintor
					(Id_Persona)
		VALUES	(@Id_Persona)
END

--PINTURA
GO
CREATE PROCEDURE [dbo].[InsertPintura](
                 @Id_Pintura int,
                 @Id_Pintor int,
                 @Id_dueno   int,
                 @NombrePintura varchar(40),
                 @Tamano varchar(40),
                 @FechaCreacion date,
                 @FechaIngreso datetime,
                 @FechaSalida  datetime,
                 @Valor decimal(10,2),
                 @Estado varchar(15))



AS
BEGIN
      INSERT INTO Tbl_Pintura (Id_Pintura, Id_Pintor, Id_dueno, NombrePintura, Tamano, FechaCreacion, FechaIngreso, FechaSalida,Valor, Estado)
	  VALUES
	  (@id_Pintura,@Id_Pintor, @id_dueno, @NombrePintura, @Tamano, @FechaCreacion, @FechaIngreso, @FechaSalida, @Valor, @Estado)
END

---STORED PROCEDURE DELETE

--Dueno
GO
CREATE PROCEDURE DeleteDueno
@Id_Dueno int

AS
BEGIN

DELETE FROM Tbl_Dueno where Id_Dueno= @Id_Dueno

END

--Genero
GO
CREATE PROCEDURE DeleteGenero
@Id_Genero int

AS
BEGIN

DELETE FROM Tbl_Genero where Id_Genero= @Id_Genero

END

-- Persona
GO
CREATE PROCEDURE DeletePersona
@Id_Persona int

AS
BEGIN

DELETE FROM Tbl_Persona where Id_Persona= @Id_Persona

END

-- Pintor
GO
CREATE PROCEDURE DeletePintor
@Id_Pintor int

AS
BEGIN

DELETE FROM Tbl_Pintor where Id_Pintor= @Id_Pintor

END

--Pintura
GO
CREATE PROCEDURE DeletePintura
@Id_Pintura int

AS
BEGIN

DELETE FROM Tbl_Pintura where Id_Pintura= @Id_Pintura

END

--INSERTANDO DATOS DE PRUEBA
GO
INSERT INTO Tbl_DocumentoIdentidad
						(TipoDocumento,
						 NumeroDocumento)
			VALUES	('Cedula',
					'40200000000')

GO
INSERT INTO Tbl_Persona
            (   Id_DocumentoIdentidad,
                Correo,
                Nombre,
                Telefono,
                Direccion,
                FechaNacimiento,
                Nacionalidad)

VALUES	(1,
        'Juan@gmail.com',
        'Juan',
        '809000000',
        'Av. Principal #40, Central, San Juan',
        '2008-11-11',
        'Dominicana')

GO
INSERT INTO Tbl_DocumentoIdentidad
						(TipoDocumento,
						 NumeroDocumento)
			VALUES	('Cedula',
					'40200000001')
GO
INSERT INTO Tbl_Persona
            (   Id_DocumentoIdentidad,
                Correo,
                Nombre,
                Telefono,
                Direccion,
                FechaNacimiento,
                Nacionalidad)

VALUES	(2,
        'Pedro@gmail.com',
        'Pedro',
        '809000001',
        'Av. Principal #40, Central, San Juan',
        '2008-11-11',
        'Dominicana')
GO
INSERT INTO Tbl_Genero
            (NombreGenero)
VALUES	('Retrato')

GO
INSERT INTO Tbl_Dueno
            (Id_Persona)
VALUES	(1)
GO
INSERT INTO Tbl_Pintor
            (Id_Persona)
VALUES	(1)


INSERT INTO Tbl_Pintura (Id_Pintor, Id_dueno, NombrePintura, Tamano, FechaCreacion, FechaIngreso, FechaSalida,Valor, Estado)
VALUES (1, 1, 'Retrato Abuelos', '15x15','2020-11-11' , '2020-11-11', NULL, 3000.00, 'Normal')


INSERT INTO Tbl_PinturaGenero(Id_Pintura, Id_Genero)
VALUES (1,1)

