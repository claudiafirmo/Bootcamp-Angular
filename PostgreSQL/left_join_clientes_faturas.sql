-- LEFT join (tabela secundaria -> tabela primaria)
select c.documento,
		c.nome,
		f.valor,
		f.datavencto
from financeiro.tb_faturas f left join administracao.tb_clientes c on f.idcliente = c.id;

-- LEFT join (tabela primaria -> tabela secundaria)
select c.documento,
		c.nome,
		f.valor,
		f.datavencto
from administracao.tb_clientes c left join financeiro.tb_faturas f on f.idcliente = c.id;