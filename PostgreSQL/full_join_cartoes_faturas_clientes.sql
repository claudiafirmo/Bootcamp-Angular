-- join com todas as tabelas
select cl.nome, ca.numcartao, f.datavencto, f.valor
from financeiro.tb_faturas f inner join administracao.tb_clientes cl on f.idcliente = cl.id
	inner join financeiro.tb_cartoes ca on f.idcartao = ca.id; 
	
select cl.nome, ca.numcartao, f.datavencto, f.valor
from financeiro.tb_faturas f inner join administracao.tb_clientes cl on f.idcliente = cl.id
	right join financeiro.tb_cartoes ca on f.idcartao = ca.id; 
	
select cl.nome, ca.numcartao, f.datavencto, f.valor
from financeiro.tb_faturas f full join administracao.tb_clientes cl on f.idcliente = cl.id
	full join financeiro.tb_cartoes ca on f.idcartao = ca.id; 