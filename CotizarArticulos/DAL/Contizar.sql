CREATE DATABASE CotizarDb
GO
USE CotizarDb
GO

CREATE TABLE Articulos
(
 ID int primary key identity,
 Descricion varchar (20),
 FechaDeVencimiento varchar(20),
 precio float,
 Exitencia int,
 Cantidad int
 )


