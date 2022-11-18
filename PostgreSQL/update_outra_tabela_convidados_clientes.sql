select cli.documento, cli.nome, cnv.nome
from administracao.tb_clientes cli inner join administracao.tb_convidados cnv on cnv.cpf = cli.documento;

-- as tabelas possuem registros com o mesmo cpf, mas com nomes diferentes. 
update administracao.tb_convidados
set nome = cli.nome
from administracao.tb_clientes cli
where cli.documento = cpf;