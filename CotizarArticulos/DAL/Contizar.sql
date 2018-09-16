CREATE DATABASE CotizarDb
GO
USE CotizarDb
GO

CREATE TABLE Articulos
(
 ID int primary key identity,
 Descripcion varchar (20),
 FechaDeVencimiento datetime,
 precio decimal,
 Exitencia int,
 Cantidad int
 )


