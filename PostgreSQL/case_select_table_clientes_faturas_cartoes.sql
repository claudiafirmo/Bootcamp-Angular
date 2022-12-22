/*
unir tabelas tb_cartoes, tb_faturas, tb_clientes
*/

select cl.documento, cl.nome, ca.numcartao, ca.limite, f.valor, f.datavencto, 
case f.status
	when '1' then 'Pendente'
	when '2' then 'Pago'
	else 'Não informado'
end as status
from financeiro.tb_cartoes ca, financeiro.tb_faturas f, administracao.tb_clientes cl
where ca.id = f.idcartao and cl.id = f.idcliente;