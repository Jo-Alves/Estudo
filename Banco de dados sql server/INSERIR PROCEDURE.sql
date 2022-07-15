--PARA ALTERAR É SÓ TROCAR CREATE POR ALTER E ALTERAR O QUE PRECISAR
CREATE PROCEDURE uspInserirTelefoneTipo
        @id_TelefoneTipo int,
        @Descricao varchar (50)
AS
BEGIN
--SP INSERIR
INSERT INTO tblTelefoneTipo
(
id_TelefoneTipo,
descricao
)
VALUES
(
@id_TelefoneTipo,
@Descricao
)
END