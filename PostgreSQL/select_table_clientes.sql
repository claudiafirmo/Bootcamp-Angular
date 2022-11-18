-- Tabela tb_clientes
-- 1.Buscar todos os clientes
select * from administracao.tb_clientes;

-- 2.Buscar somente as colunas documento, nome e telefone de todos os clientes
select documento, nome, telefone from administracao.tb_clientes;

-- 3.Buscar todos os campos do cliente com cpf = "75507760080"
select * from administracao.tb_clientes where documento = '75507760080';

-- 4. Todos os campos cujo o id esteja na faixa de 5 a 10 
select * from administracao.tb_clientes where id between 5 and 10;

-- 5. Todos os campos dos clientes que não sejam de SP
select * from administracao.tb_clientes where uf != 'SP'; -- ou <>

-- 6. Mesmo que o exercicio 5, mas em ordem de estado e em cada estado por ordem de nome 
select * from administracao.tb_clientes where uf != 'SP' order by uf, nome;

-- 7.Buscando os clientes que tenham o nome iniciando com a letra 'A'
select * from administracao.tb_clientes where nome like 'A%';

-- 8.Buscando os clientes que tenham a letra 'A' no nome
select * from administracao.tb_clientes where nome like '%a%';

-- 9. Buscando os clientes que tenham a letra 'A' no nome or começam com 'A'
select * from administracao.tb_clientes where nome like '%a%' or nome like 'A%';

-- 10. Selecionando os campos documento, nome e telefone a partir de um ALIAS para a tabela
select c.documento, c.nome, c.telefone from administracao.tb_clientes c;

-- 10. Selecionando os campos documento, nome e telefone a partir de um ALIAS para a tabela considerando apenas os nomes
-- iniciando com letra 'A' ou 'C'
select c.documento, c.nome, c.telefone from administracao.tb_clientes c
where c.nome like 'A%' or c.nome like 'C%';

-- 11. inserindo ALIAS para todos os campos
select c.documento as "CPF", c.nome as "Cliente", c.telefone as "Contato" from administracao.tb_clientes c
where c.nome like 'A%' or c.nome like 'C%';