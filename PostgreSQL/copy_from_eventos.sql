-- Copiando conteudo do aquivo CSV - convidados.txt - para tabela tb_convidados
copy administracao.tb_convidados(cpf, nome, email)
from 'D:/DEV MANDA/Bootcamp-Angular/PostgreSQL/convidados.csv' 
using delimiters ';';

copy administracao.tb_eventos(id, descricao, responsavel, preco, data)
from 'D:/DEV MANDA/Bootcamp-Angular/PostgreSQL/eventos.csv'
using delimiters ';';
