-- SUBQUERY: realiza select dentro de um select, o retorno de 1 é usado de parâmetro para outro
-- lista de clientes que possuam alguma fatura
select  * 
from administracao.tb_clientes 
where id in (select distinct idcliente from financeiro.tb_faturas);
