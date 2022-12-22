-- mostra os clientes, cada um, com TODOS os catoes!
select * from financeiro.tb_faturas,  administracao.tb_clientes;

-- Apresentando todos os clientes que possuam alguma fatura
select c.documento, c.nome, f.valor, f.datavencto
from financeiro.tb_faturas f join administracao.tb_clientes c on f.idcliente = c.id;

-- juntando as tabelas sem join
select c.documento as CPF, c.nome as Cliente, f.valor, f.datavencto as Vencimento
from financeiro.tb_faturas f, administracao.tb_clientes c
where f.idcliente = c.id;

-- determinando um campo calculado: desconto 10% para pagamento antecipado
select c.documento as CPF, c.nome as Cliente, f.valor,f.valor * 0.9 as "Antecipado", f.datavencto as Vencimento
from financeiro.tb_faturas f, administracao.tb_clientes c
where f.idcliente = c.id;
