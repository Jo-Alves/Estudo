create table T_datas
(
Data Datetime,
Data1 smalldatetime
)
insert into t_datas values('01/01/01','01/01/01')

select * from t_datas

INSERT INTO T_DATAS VALUES('01/12/2001','01/12/2001')

INSERT INTO T_DATAS VALUES('01/01/1901 10:10:01','12/31/01 22:10:01')

/*
Mostra a data atual no formato padrão */

SELECT
GETDATE()

/*
Converte a data atual para caracter e mostra no formato MM/DD/AAAA
*/

SELECT
CONVERT(CHAR,GETDATE(),101 )

/*
Converte a data atual para caracter e mostra no formato AAAA.MM.DD
*/

SELECT
CONVERT(CHAR,GETDATE(),102 )

/*
Converte a data atual para caracter e mostra no formato DD/MM/AAAA
*/

SELECT
CONVERT(CHAR,GETDATE(),103 )

/*
Converte a data atual para caracter e mostra no formato MM/DD/AA
*/

SELECT
CONVERT(CHAR,GETDATE(),1 )

/*
Converte a data atual para caracter e mostra no formato AA.MM.DD

Somente
os dois últimos dígitos do ano */

SELECT
CONVERT(CHAR,GETDATE(),2 )

/*
Diferença entre datas. Mostra quantos dias se passaram deste
o começo do ano 2001 até a data atual*/

SELECT
DATEDIFF(DAY,'01/01/1990',GETDATE())

/*
Retorna somente o mês da data atual */

SELECT
DATEPART(MONTH,GETDATE())


