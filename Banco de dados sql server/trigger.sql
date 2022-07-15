
create database teste
use teste

--trigger de inserção
create trigger trg_onInsertValue on tbl_usuario
for insert 
as
		if(select count(*) from inserted)=1
		print 'O registro foi inserido com sucesso!'
		
--trigger para delete
create trigger tgr_onDeletedvalue On tbl_usuario
for delete
as
	if(select count(*) from deleted)=1
	begin 
		raiserror(
		'usuarios não podem ser excluidos!',
		16,
		1)
		rollback transaction
End

--trigger para update
alter trigger trg_UpdateValue On tbl_usuario
for update
as  
		if(select count (*) from deleted)<>0
			print 'alteramos o trigger para exibir a mensagem'