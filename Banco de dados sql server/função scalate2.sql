USE [Sistema_Controle_Livros]
GO

/****** Object:  UserDefinedFunction [dbo].[ZeroEsquerda_Cod_Usuario]    Script Date: 26/02/2018 22:00:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[ZeroEsquerda_Cod_Usuario]
(
	@Tamanho int,
	@Valor varchar(max)
)
RETURNS varchar(max)
AS
BEGIN
		Declare @Retorno as varchar(max)
		if(LEN(@Valor) <= @Tamanho)
			set @Retorno = REPLICATE('0', @Tamanho - LEN(@Valor)) + @Valor
		else 
		set @Retorno = @Valor
	RETURN @Retorno
END
GO



