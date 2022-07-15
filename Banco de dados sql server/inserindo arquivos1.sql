--Cria a tabela de dados

use inserindo_arquivos

create table arquivos
(
id int primary key not null,
nome varchar(1000),
arquivo varbinary(max)
)

insert into arquivos
select 3,'inserção de arquivos', bulkcolumn from openrowset(bulk 'D:\Imagens\Imagem\Família\IMG-20170129-WA0008.jpg',single_blob) as arquivo

select * from arquivos