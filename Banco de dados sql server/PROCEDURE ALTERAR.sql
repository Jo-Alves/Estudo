CREATE PROCEDURE ater_uspTBLPESSOAFISICA
		--PARAMETROS
		@id_Pessoa int,
		@NOME VARCHAR(100),
		@CPF CHAR(11)
		
		
AS
BEGIN
	UPDATE 
		tblpessoaFisica
	 set 
		Nome = @NOME,
		CPF = @CPF
	 where
		 id_Pessoa = @id_Pessoa
END