-- Exercicio:
-- 1. Criar um novo schema chamado financeiro;
-- 2. Mover a tabela tb_cartoes para este novo schema

create schema financeiro;
alter table administracao.tb_cartoes set schema financeiro;
