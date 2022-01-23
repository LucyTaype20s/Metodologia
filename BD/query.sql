create database BD_SGCIBero
use BD_SGCIBero

drop table tbl_Usuario
create table tbl_Usuario(
id_usuario int not null identity primary key,
users varchar(10)not null,
email varchar(50) not null,
contrasena varchar(20)not null
)
drop table tbl_Asignacion
create table tbl_Asignacion(
id_asignacion int not null identity primary key,
novedades varchar(200),
id_reserva int not null,
)
alter table tbl_Asignacion add foreign key(id_reserva)references tbl_Reserva(id_reserva)

drop table tbl_Reserva
create table tbl_Reserva(
id_reserva int not null identity primary key,
titulo_evento varchar(200)not null,
descripcion varchar(300)not null,
id_usuario int not null,
id_espacio int not null,
fecha_inicio DateTime,
fecha_fin DateTime
)
alter table tbl_Reserva add id_docente int not null

alter table tbl_Reserva add foreign key(id_docente)references tbl_Docente(id_docente)
alter table tbl_Reserva add foreign key (id_usuario) references tbl_Usuario(id_usuario)
alter table tbl_Reserva add foreign key (id_espacio)references tbl_Espacio(id_espacio)


drop table tbl_Espacio
create table tbl_Espacio(
id_espacio int not null identity primary key,
nombre varchar(50) not null,
)

drop table tbl_Docente
create table tbl_Docente(
id_docente int not null identity primary key,
nombre varchar(30) not null,
apellido_p varchar(30)not null,
apellido_m varchar(30)not null,
correo varchar(30)not null,
id_curso int not null,
)
drop table tbl_Curso
create table tbl_Curso(
id_curso int not null identity primary key,
nombre varchar(30)not null
)













