SELECT MAX(id) FROM administracao.tb_convidados;
SELECT * FROM administracao.tb_convidados WHERE id = (SELECT MAX(id) FROM administracao.tb_convidados);