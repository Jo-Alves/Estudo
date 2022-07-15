select ip.id_pedido,nc.id_cliente, nc.nome_Cliente from pedido ip join cliente nc on ip.id_cliente=nc.id_cliente-- where nc.id_cliente=1

select ip.id_produto,ip.nome_produto,nc.id_cliente, nc.nome_Cliente from produtos ip join cliente nc on ip.id_produto=nc.id_cliente where id_cliente=2
