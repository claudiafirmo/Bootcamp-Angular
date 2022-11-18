-- Buscar todos os clientes que não possuem fatura
select * from  administracao.tb_clientes
where id not in (select distinct idcliente from financeiro.tb_faturas);
-- deletar clientes sem fatura
delete from administracao.tb_clientes 
where id not in (select distinct idcliente from financeiro.tb_faturas);

-- causa ERRO! pois esse registro é usado na tabela faturas
delete from administracao.tb_clientes where id = 1;