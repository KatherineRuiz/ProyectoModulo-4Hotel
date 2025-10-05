Create database HotelEvaluacion
go
use HotelEvaluacion
go

--Tablas independientes

Create table Rol (
    idRol int identity(1,1) primary key,
    nombreRol varchar(25) not null
);
go

Create table EstadoReserva (
    idEstadoReserva int identity(1,1) primary key,
    nombreEstadoReserva varchar(25) not null
);
go

Create table EstadoHabitacion (
    idEstadoHabitacion int identity(1,1) primary key,
    nombreEstadoHabitacion varchar(25) not null
);
go

Create table Servicio (
    idServicio int identity(1,1) primary key,
    nombreServicio varchar(30) not null
);
go

Create table Cliente (
    idCliente int identity(1,1) primary key,
    nombreCliente varchar(35) not null,
    apellidoCliente varchar(35) not null,
    correoCliente varchar(60) not null,
);
go
 

--Tablas dependientes

Create table Usuario (
    idUsuario int identity(1,1) primary key,
    correoUsuario varchar(60) not null,
    clave varchar(100) not null,
    id_Rol int not null,
    constraint fk_idRol foreign key (id_Rol) references Rol(idRol) on delete cascade
);
go

Create table Reservacion (
    idReserva int identity(1,1) primary key,
    fechaReserva date not null,
    fechaInicio datetime not null,
    fechaFinal datetime not null,
    checkIn datetime,
    checkOut datetime,
    id_Cliente int not null,
    id_EstadoReserva int not null,
    constraint fk_idCliente foreign key (id_Cliente) references Cliente(idCliente) on delete cascade,
    constraint fk_idEstadoReserva foreign key (id_EstadoReserva) references EstadoReserva(idEstadoReserva) on delete cascade
);
go

Create table Habitacion (
    idHabitacion int identity(1,1) primary key,
    nombreHabitacion varchar(5) not null,
    numCamas varchar(1) not null,
    ubicacion varchar(40) not null,
    precioHabitacion decimal(8,2) not null,
    id_EstadoHabitacion int not null,
    constraint fk_idEstadoHabitacion foreign key (id_EstadoHabitacion) references EstadoHabitacion(idEstadoHabitacion) on delete cascade
);
go

--Tablas intermedias

Create table HabitacionReserva (
    idHabitacionReserva int identity(1,1) primary key,
    id_Reserva int not null,
    id_Habitacion int not null,
    constraint fk_idReserva foreign key (id_Reserva) references Reservacion(idReserva) on delete cascade,
    constraint fk_idHabitacion foreign key (id_Habitacion) references Habitacion(idHabitacion) on delete cascade
);
go

Create table ServicioReserva (
    idServicioReserva int identity(1,1) primary key,
    id_HabitacionReserva int not null,
    id_Servicio int not null,
    precioServicio decimal (8,2) not null,
    fechaServicio datetime not null,
    constraint fk_idHabitacionReserva foreign key (id_HabitacionReserva) references HabitacionReserva(idHabitacionReserva) on delete cascade,
    constraint fk_idServicio foreign key (id_Servicio) references Servicio(idServicio) on delete cascade
);
go

--Insersiones a las tablas necesarias

Insert into EstadoReserva values ('ACTIVA'), ('CANCELADA'), ('EN CURSO'),('FINALIZADA');


insert into Rol values 
('Administrador'),
('Recepcionista'),
('Gerente');

Insert into EstadoHabitacion (nombreEstadoHabitacion) values
('Disponible'),
('Ocupada'),
('Reservada'),
('Inactiva');

--Insersiones extra


Insert into Habitacion (nombreHabitacion, numCamas, ubicacion, precioHabitacion, id_EstadoHabitacion) values
('H01','2','Piso 1',75.00,1),
('H02','1','Piso 1',60.00,1),
('H03','3','Piso 2',90.00,2),
('H04','2','Piso 2',80.00,3),
('H05','1','Piso 3',55.00,1),
('H06','2','Piso 3',70.00,4),
('H07','1','Piso 4',65.00,1),
('H08','3','Piso 4',95.00,3),
('H09','2','Piso 5',88.00,2),
('H10','1','Piso 5',50.00,1);

Insert into Servicio (nombreServicio) values
('WiFi'),
('Desayuno'),
('Lavandería'),
('Spa'),
('Piscina'),
('Gimnasio'),
('Transporte'),
('Mini Bar'),
('Servicio al cuarto'),
('Cine');

Insert into Cliente (nombreCliente, apellidoCliente, correoCliente) values
('Paola','Cruz','paola@hotel.com'),
('Carlos','Martínez','carlos@hotel.com'),
('Ana','Santos','ana@hotel.com'),
('Jorge','García','jorge@hotel.com'),
('Elena','Torres','elena@hotel.com'),
('Luis','Flores','luis@hotel.com'),
('Sofía','Domínguez','sofia@hotel.com'),
('Ricardo','Valdez','ricardo@hotel.com'),
('María','Rivera','maria@hotel.com'),
('Andrés','López','andres@hotel.com');


Insert into Reservacion (fechaReserva, fechaInicio, fechaFinal, checkIn, checkOut, id_Cliente, id_EstadoReserva) values
('2025-10-01','2025-10-05','2025-10-07',null,null,1,1),
('2025-10-02','2025-10-06','2025-10-09',null,null,2,3),
('2025-10-03','2025-10-10','2025-10-15',null,null,3,4),
('2025-10-04','2025-10-05','2025-10-08',null,null,4,2),
('2025-10-05','2025-10-06','2025-10-10',null,null,5,1),
('2025-10-06','2025-10-12','2025-10-14',null,null,6,3),
('2025-10-07','2025-10-08','2025-10-11',null,null,7,1),
('2025-10-08','2025-10-09','2025-10-13',null,null,8,2),
('2025-10-09','2025-10-10','2025-10-12',null,null,9,4),
('2025-10-10','2025-10-11','2025-10-14',null,null,10,1);

Insert into HabitacionReserva (id_Reserva, id_Habitacion) values
(2,1),
(5,2),
(2,3),
(3,4),
(3,5),
(4,6),
(5,7),
(6,8),
(7,9),
(8,10);


Insert into ServicioReserva (id_HabitacionReserva, id_Servicio, precioServicio, fechaServicio) values
(4,1,5.00,'2025-10-05 08:00'),
(6,2,10.00,'2025-10-05 09:00'),
(1,4,20.00,'2025-10-06 11:00'),
(3,5,15.00,'2025-10-07 10:30'),
(4,3,8.00,'2025-10-08 14:00'),
(5,7,12.00,'2025-10-09 12:00'),
(6,9,9.00,'2025-10-10 13:00'),
(7,6,6.00,'2025-10-11 08:30'),
(8,8,11.00,'2025-10-12 15:00'),
(9,10,7.00,'2025-10-13 17:00');


--Selecciones join

Select*from EstadoReserva

--Seleccion para mostrar las reservaciones
Select R.idReserva As [N°], R.fechaReserva As [Fecha de Registro], C.nombreCliente As [Nombre], C.ApellidoCliente [Apellido], C.correoCliente As Correo, 
R.fechaInicio As [Inicio], R.fechaFinal As [Final], R.checkIn As CheckIn, R.checkOut As CheckOut, ES.nombreEstadoReserva As Estado, STRING_AGG(H.nombreHabitacion, ', ') As [Habitaciones],
SUM(H.precioHabitacion) As [Total Habitaciones],  SUM(ISNULL(SR.precioServicio, 0)) As [Total Servicios]
from Reservacion R
Inner join
Cliente C On R.id_Cliente = C.idCliente
Inner join 
EstadoReserva ES on R.id_EstadoReserva = ES.idEstadoReserva
Left join 
HabitacionReserva HR On R.idReserva = HR.id_Reserva
Left join 
Habitacion H On HR.id_Habitacion = H.idHabitacion
Left join 
ServicioReserva SR On HR.idHabitacionReserva = SR.id_HabitacionReserva
Group by 
R.idReserva, R.fechaReserva, C.nombreCliente, C.apellidoCliente, C.correoCliente,
R.fechaInicio, R.fechaFinal, R.checkIn, R.checkOut, ES.nombreEstadoReserva
Order by 
R.idReserva;

--Seleccion para mostrar los clientes
Select idCliente As [N°], nombreCliente As Nombre, apellidoCliente As Apellido, correoCliente As Correo from Cliente

