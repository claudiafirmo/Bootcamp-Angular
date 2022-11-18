select * from financeiro.tb_faturas f;
-- funções de agregação:

-- COUNT(coluna ou * -> todos os registros) : return n° de registros na tabela(sem null) ou registros na tabela
select count(*)
from financeiro.tb_faturas f;

-- sum(coluna): return soma dos registros
select sum(valor)
from financeiro.tb_faturas f;


-- avg(coluna): return media dos registros
select avg(valor)
from financeiro.tb_faturas f;

-- max(coluna): return maior valor dos registros
select max(valor)
from financeiro.tb_faturas f;

-- min(coluna): return menor valor dos registros
select min(valor)
from financeiro.tb_faturas f;
