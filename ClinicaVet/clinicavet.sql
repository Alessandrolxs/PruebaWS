create database clinicavet
go

use clinicavet
use master
go

/*-------------------------------------------*/

create table propietarios(
id int identity (1,1) primary key not null,
nombre varchar(20) not null,
apellido varchar(20) not null,
telefono int not null,
direccion varchar(50) not null,
email varchar(20) not null
);
go

insert into propietarios values ('Alessandro','Legua',987654321,'Gambeta Alta - Callao','legua@gmail.com')

create table mascotas(
id int identity (1,1) primary key not null,
id_propietario int not null,
nombre varchar(20) not null,
raza varchar(20) not null,
color varchar(20) not null,
animal varchar(20) not null,
edad int
);
go

create table recepcionistas(
id int identity (1,1) primary key not null,
nombre varchar(20) not null,
apellido varchar(20) not null,
telefono int not null,
edad int not null,
usuario varchar(20) not null,
contraseña varchar(20) not null
);
go

insert into recepcionistas values ('Julia','Chavez',987654321,21,'julia21','123456')
select * from recepcionistas

create table veterinarios(
id int identity (1,1) primary key not null,
nombre varchar(20) not null,
apellido varchar(20) not null,
telefono int not null,
direccion varchar(50) not null,
email varchar(20) not null,
usuario varchar(20) not null,
contraseña varchar(20) not null
);
go

create table citas(
id int identity (1,1) primary key not null,
id_propietario int not null,
id_mascota int not null,
id_veterinario int not null,
fecha date not null,
hora date not null,
direccion_vet varchar(50) not null,
sig_cita date
);
go

create table servicios(
id int identity (1,1) primary key not null,
id_veterinario int not null,
id_mascota int not null,
id_tratamiento int not null
);
go

create table tratamientos(
id int identity (1,1) primary key not null,
tipo varchar(20) not null,
precio int not null,
dias varchar(10) not null
);
go

/*-----------------------------------------------*/

create proc mostrarpro
as
select * from propietarios
go

create proc mostrarmas
as
select * from mascotas
go

create proc mostrarcit
as
select * from citas
go

create proc mostrartrat
as
select * from tratamientos
go

create proc mostrarvet
as
select * from veterinarios
go

/*-------------------------------------*/

create proc buscarcit
@id int
as
select * from citas where id=@id
go

create proc buscartrat
@id int
as
select * from tratamientos where id=@id
go

create proc buscarvet
@id int
as
select * from veterianrios where id=@id
go


create proc insertpro
@nombre varchar(20),
@apellido varchar(20),
@telefono int,
@direccion varchar(50),
@email varchar(20)
as
begin
insert into propietarios(nombre,apellido,telefono,direccion,email) values(@nombre,@apellido,@telefono,@direccion,@email)
end
go

create proc modifpro
@nombre varchar(20),
@apellido varchar(20),
@telefono int,
@direccion varchar(50),
@email varchar(20),
@id int
as
begin
update propietarios set nombre=@nombre,apellido=@apellido,telefono=@telefono,direccion=@direccion,email=@email where id=@id
end
go

create proc elimpro
@id int
as
begin
delete from propietarios where id=@id
end
go

create proc buscarpro
@id int
as
select * from propietarios where id=@id
go

/*-----------------------------------------*/

create proc mostrarmas
as
select * from mascotas
go

create proc insertmas
@id_propietario int,
@nombre varchar(20),
@raza varchar(20),
@color varchar(20),
@animal varchar(20),
@edad int
as
begin
insert into mascotas(id_propietario,nombre,raza,color,animal,edad) values(@id_propietario,@nombre,@raza,@color,@animal,@edad)
end
go

create proc modifmas
@id_propietario int,
@nombre varchar(20),
@raza varchar(20),
@color varchar(20),
@animal varchar(20),
@edad int,
@id int
as
begin
update mascotas set id_propietario=@id_propietario,nombre=@nombre,raza=@raza,color=@color,animal=@animal,edad=@edad where id=@id
end
go

create proc elimmas
@id int
as
begin
delete from mascotas where id=@id
end
go

create proc buscarmas
@id int
as
select * from mascotas where id=@id
go

/*-----------------------------------------------------------------------------*/

create proc sp_Login
@usuario varchar(20),
@contraseña varchar(20)
as
select * from recepcionistas where usuario=@usuario and contraseña=@contraseña
go

/*-----------------------------------------------------------------------------*/

alter table mascotas
    add constraint Fk_idprom foreign key(id_propietario) references propietarios(id)
go

alter table citas
    add constraint Fk_idproc foreign key (id_propietario) references propietarios(id)
go

alter table citas
    add constraint Fk_mascc foreign key(id_mascota) references mascotas(id)
go

alter table citas
    add constraint Fk_veterc foreign key(id_veterinario) references veterinarios(id)
go

alter table servicios
    add constraint Fk_veters foreign key(id_veterinario) references veterinarios(id)
go

alter table servicios
	add constraint Fk_mascos foreign key(id_mascota) references mascotas(id)
go

alter table servicios
	add constraint Fk_idtratamientos foreign key(id_tratamiento) references tratamientos(id)
go