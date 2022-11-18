select c.documento, c.nome,ca.numcartao, sum(f.valor) as "total", count(f.id) as "Quantidade de faturas"
from financeiro.tb_faturas f inner join administracao.tb_clientes c on f.idcliente = c.id
	inner join financeiro.tb_cartoes ca on f.idcartao = ca.id
group by c.documento, c.nome, ca.numcartao
order by c.nome;