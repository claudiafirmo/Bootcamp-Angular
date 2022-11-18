/*
unir tabelas tb_cartoes, tb_faturas, tb_clientes
*/

select cl.documento, cl.nome, ca.numcartao, ca.limite, f.valor, f.datavencto
from financeiro.tb_cartoes ca, financeiro.tb_faturas f, administracao.tb_clientes cl
where ca.id = f.idcartao and cl.id = f.idcliente;