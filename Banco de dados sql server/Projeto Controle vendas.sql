CREATE TABLE Cliente (
Id_cliente int not null identity(1,1) PRIMARY KEY,
Nome varchar(100),
Endereço varchar(50),
Data_Nascimento Varchar(10)
)

CREATE TABLE Produtos 
(
Id_Produto int not null PRIMARY KEY,
Nome_Produto varchar(50),
Quantidade_Estoque int,
Marca_Produto varchar(50)
)

CREATE TABLE Pedido (
Id_Pedido Int identity (1,1) PRIMARY KEY,
Quantidade int,
Valor_Pedido int,
Id_cliente int,
Id_Produto int,
FOREIGN KEY(Id_cliente) REFERENCES Cliente (Id_cliente),
FOREIGN KEY(Id_Produto) REFERENCES Produtos (Id_Produto)
)
	sp_rename 'cliente.[nome]','nome_Cliente','column'	
 insert into Pedido values (3, 1000, 1, 1)
insert into cliente (nome_cliente) values ('Edilene')
insert into produtos values (2,'Tablet',2,'Samsung')
select * from cliente

