SELECT * FROM Usuario

insert into Usuario values ('Noelly','Ferreira Carvalho','Elly')
delete from usuario where Nome='noelly'
begin tran

insert into Usuario values ('MARIA CECÍLIA','Ferreira Carvalho','Elly')
COMMIT TRAN
go
rollback transaction 
go
select * from Produto where Id_Produto=4

Update Produto set EstoqueAtual = 7 where Id_Produto = 4