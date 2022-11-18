-- lista de cartoes que estejam em  alguma fatura
select * from financeiro.tb_cartoes
where id in (select distinct idcartao from financeiro.tb_faturas where valor > 1000.00);