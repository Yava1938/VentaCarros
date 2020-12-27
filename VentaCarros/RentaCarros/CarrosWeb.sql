create database CarrosWeb
go

use CarrosWeb

create table Carros
(
IdCarro        int primary key identity not null,
Nombre         varchar(100) not null,
Modelo         varchar(100) not null,
Marca          varchar(50) not null,
Matricula      varchar(50) not null,
Anio           int not null,
Precio         decimal(10,2) not null,
Disponibilidad bit not null,
UrlFoto        varchar(max) not null
)

create table Clientes
(
IdCliente         int primary key identity not null,
NombreCliente            varchar(100) not null,
Apellido_paterno  varchar(100) not null,
Apellido_materno  varchar(100) not null,
Correo            varchar (100) not null,
Telefono          varchar(100) not null,
Direccion         varchar(100) not null,
UrlFoto           varchar(max) not null
)

Create table Rentas
(
IdRenta        int primary key identity not null,
IdCarro        int not null,
IdCliente      int not null,
Duracion       int not null,
Fecha          datetime not null,
Estado         varchar(20) not null
constraint FK_Renta_IdCarro Foreign key (IdCarro) References Carros (IdCarro),
constraint FK_Renta_IdCliente Foreign key (IdCliente) References Clientes (IdCliente),
)