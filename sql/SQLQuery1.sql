use dbWS
go
create table db_table
(
	Id int identity primary key,
	[���] nvarchar(max) not null,
	[�������] nvarchar(max) not null,
	[���] nvarchar(max) not null,
	[�������] nvarchar(max) not null,
	[instagram] nvarchar(max) not null,
	[������] nvarchar(max) not null
);

select * from db_table