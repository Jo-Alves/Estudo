select * from pedido
select * from Cliente
select * from Produtos

select
 pedido.id_pedido,
  cliente.nome_cliente,
  cliente.endereço,
  cliente.data_nascimento,
  produtos.Nome_produto,
  produtos.marca_Produto 
  from pedido join cliente on pedido.id_cliente=cliente.id_cliente
    join produtos on pedido.id_Produto=produtos.id_produto
     where nome_cliente='valdete lopes'
