/*
 * Views - condensar retorno de consultas em um objeto
 */ 
create or replace view financeiro.view_faturas as
select c.documento, c.nome, sum(f.valor) as "total", count(f.id) as "Quantidade de faturas"
from financeiro.tb_faturas f inner join administracao.tb_clientes c on f.idcliente = c.id
group by c.documento, c.nome
having count(f.id) > 1
order by c.nome;

select * from financeiro.view_faturas vf;