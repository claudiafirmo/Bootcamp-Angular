-- RIGHT join (tabela secundaria -> tabela primaria)
select c.documento,
		c.nome,
		f.valor,
		f.datavencto
from financeiro.tb_faturas f RIGHT join administracao.tb_clientes c on f.idcliente = c.id;

-- RIGHT join (tabela primaria -> tabela secundaria)
select c.documento,
		c.nome,
		f.valor,
		f.datavencto
from administracao.tb_clientes c RIGHT join financeiro.tb_faturas f on f.idcliente = c.id;