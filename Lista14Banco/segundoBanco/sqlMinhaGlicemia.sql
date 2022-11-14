create database glicemia_db

use glicemia_db

create table paciente(
	idPaciente int not null identity primary key,
	nomePaciente varchar(50) not null 
);

create table valores(
	idGlicemia int not null identity primary key,
	idPaciente int not null references paciente,
	valorGlicemia int  not null,
	dataMedida date not null
);

insert into paciente(nomePaciente) 
values('Alexandre Zamberlan');
--insert inicial pre populado

insert into valores(idPaciente,valorGlicemia,dataMedida)
values(1,150,'2022/10/10')
--insert inicial pre populado




select * from valores

--delete from paciente
--where idPaciente >= 1

select * from paciente



--insert into paciente(nomePaciente)
--values ('Alex Zamberlan'),
--		('beto albuquerque'),
--		('elton saldanha'),
--		('marcio antonio'),
--		('varlei etnos')


--insert into valores(idPaciente,valorGlicemia,dataMedida)
--values (4,100,'2022-11-11'),
--		(5,200,'2020-10-10'),
--		(6,300,'2009-10-02'),
--		(7,150,'1990-08-08'),
--		(8,160,'2021-07-08')




select paciente.idPaciente, paciente.nomePaciente, valores.idGlicemia, valores.valorGlicemia, valores.dataMedida
from paciente
inner join valores
on paciente.idPaciente = valores.idPaciente



