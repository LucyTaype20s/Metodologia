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
select * from tbl_Docente


insert into tbl_Docente values('Juan Manuel','Ventura','Rios','JoseManuel@gmail.com',2)
insert into tbl_Docente values('Maria Pilar','De los Angeles','Paz','MPilar21@gmail.com',4)
insert into tbl_Docente values('Alonso','Gutierres','Del Solar','Doc_Alonso@gmail.com',8)
insert into tbl_Docente values('Mateo','Mendez','Sarcos','MendezMateo12@gmail.com',12)
insert into tbl_Docente values('Benjamin','Morillo','Taborda','MorilloBT10@gmail.com',10)
insert into tbl_Docente values('Joaquin','Urdaneta','Garcia','JoaquinIberoInst@gmail.com',6)
insert into tbl_Docente values('Matias','Bravo','Peña','BravoPeña5@gmail.com',5)
insert into tbl_Docente values('Luciano','Nuñez','Quivera','Luciano.Inge@gmail.com',3)
insert into tbl_Docente values('Vicente','Piñero','Morales','Vicente2022@gmail.com',1)
insert into tbl_Docente values('Tomas','Lisboa','Romero','TomasLisboaInst@gmail.com',11)
insert into tbl_Docente values('Maribel','Del Aguila','Suarez','MaribelDAS@ibero.pe',4)

insert into tbl_Usuario values('FrankAdmi','FrankDeLaBarra@gmail.com','admi')

select * from tbl_Usuario







select d.nombre docente,c.nombre curso from tbl_Docente d inner join tbl_Curso c on d.id_curso=c.id_curso



select * from tbl_Curso

insert into tbl_Curso values('Ingles')
insert into tbl_Curso values('Robotica')
insert into tbl_Curso values('Nutricion')
insert into tbl_Curso values('Fisica')
insert into tbl_Curso values('Quimica')
insert into tbl_Curso values('Odontologia')
insert into tbl_Curso values('Finanzas')
insert into tbl_Curso values('Sistemas')
insert into tbl_Curso values('Geologia')
insert into tbl_Curso values('Humanidades')
insert into tbl_Curso values('Diseño grafico')
insert into tbl_Curso values('Administracion')



use BD_SGCIBero

insert into tbl_Espacio values('Laboratorio de Estructuras')
insert into tbl_Espacio values('Laboratorio de Fisica')
insert into tbl_Espacio values('Laboratorio de Geotecnia')
insert into tbl_Espacio values('Laboratorio de Ambiental')
insert into tbl_Espacio values('Laboratorio de Electromecanica')
insert into tbl_Espacio values('Laboratorio de Hidraulica e Hidrologia')
insert into tbl_Espacio values('Laboratorio de Materiales')
insert into tbl_Espacio values('Laboratorio de Pavimentos')
insert into tbl_Espacio values('Laboratorio de Quimica')
insert into tbl_Espacio values('Laboratorio de Simulacion de Proyectos')
insert into tbl_Espacio values('Laboratorio de Topografia y Geomàtica')




select * from tbl_Espacio
select * from tbl_Usuario
select * from tbl_Curso
select * from tbl_Docente

select * from tbl_Espacio
select * from tbl_Reserva



insert into tbl_Reserva values('Taller de Ambiental Facultad de Ambiental','Dirigido a los alumnos de todos los cilos de la carrera de Ingenieria Ambiental',1,4,'24/01/2022 08:00','24/01/2022 13:00',7)
insert into tbl_Reserva values('Taller Medioambiental','Alumnado en General',1,4,'24/01/2022 08:00','24/01/2022 13:00',7)
insert into tbl_Reserva values('Seminario por la semana Ambientalista','Dedicado a los ultimos ciclos',1,4,'25/01/2022 07:00','25/01/2022 09:00',7)
insert into tbl_Reserva values('Conferencia de Cuidado Geologico','Sin comentarios',1,4,'26/01/2022 10:00','26/01/2022 12:00',7)





