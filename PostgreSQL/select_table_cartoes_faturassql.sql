-- tb_cartoes e tb_faturas

select c.numcartao, c.limite,f.valor, f.datavencto,
from financeiro.tb_faturas f, financeiro.tb_cartoes c
where f.idcartao = c.id

select c.numcartao, c.limite,f.valor, (c.limite - f.valor) as "Saldo", f.datavencto
from financeiro.tb_faturas f, financeiro.tb_cartoes c
where f.idcartao = c.id;