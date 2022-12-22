select * from administracao.tb_convidados
select * from administracao.tb_clientes;

--Objetivo: adicionar os clientes na tabela tb_convidados
insert into administracao.tb_convidados(cpf, nome, email)
	-- insere registros de outra tabela
	select cli.documento, cli.nome, cli.telefone from administracao.tb_clientes cli
	-- p/ tirar cpf repetidos
	where cli.documento not in (select cpf from administracao.tb_convidados);