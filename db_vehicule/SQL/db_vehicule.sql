create database db_vehicule
go
use db_vehicule
go
create table cars(
	id bigint primary key identity(1,1) not null,
	model varchar(250),
	mark varchar(250),
	ref_number varchar(250)

)

create table motorcycle(
	id bigint primary key identity(1,1) not null,
	model varchar(250),
	mark varchar(250),
	roll_number varchar(250)	
)

select * from cars

select * from motorcycle