/*
	UNION: Permite a consulta conjunta de varias tabelas que tenham correspondencia entre as colunas (mesma qtd e mesmo tipo)
*/

-- unindo tabelas em 1 só:
select documento, nome, telefone from administracao.tb_clientes
union
select cpf, nome, email from administracao.tb_convidados;