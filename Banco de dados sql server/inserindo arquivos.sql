create table arquivos_auto_incremento
(
id int primary key identity(1,1) not null,
nome varchar(1000),
arquivo varbinary(max)
)

insert into arquivos_auto_incremento
select 'Transa��o', bulkcolumn from openrowset(bulk 'D:\Banco de dados sql server\Transa��o.sql',single_blob) as arquivo

select * from arquivos_auto_incremento