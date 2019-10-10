use dbWS
go
create table db_table
(
	Id int identity primary key,
	[Имя] nvarchar(max) not null,
	[Фамилия] nvarchar(max) not null,
	[Пол] nvarchar(max) not null,
	[Телефон] nvarchar(max) not null,
	[instagram] nvarchar(max) not null,
	[Группа] nvarchar(max) not null
);

select * from db_table