-- Inner join (tabela primaria -> tabela secundaria)
select c.documento,
		c.nome,
		f.valor,
		f.datavencto
from financeiro.tb_faturas f inner join administracao.tb_clientes c on f.idcliente = c.id;

-- Inner join (tabela secundaria -> tabela primaria) = TANTO FAZ A ORDEM COM INNER JOIN
select c.documento,
		c.nome,
		f.valor,
		f.datavencto
from administracao.tb_clientes c inner join financeiro.tb_faturas f on f.idcliente = c.id;

