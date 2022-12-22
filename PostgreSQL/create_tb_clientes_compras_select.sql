-- Salvando o resultado do select em uma tabela chamada administracao.tb_clientes_compras
create table if not exists administracao.tb_clientes_compras as 
	select c.documento, c.nome, sum(f.valor) as "total", count(f.id) as "Quantidade de faturas"
	from financeiro.tb_faturas f inner join administracao.tb_clientes c on f.idcliente = c.id
	group by c.documento, c.nome
	order by c.nome;