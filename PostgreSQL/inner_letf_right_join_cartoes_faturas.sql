-- Join tb_fatura e tb_cartao
select ca.numcartao, f.valor, f.datavencto
from financeiro.tb_cartoes ca right join financeiro.tb_faturas f on f.idcartao = ca.id;