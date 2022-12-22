select * from administracao.tb_eventos;

-- escolher 2 eventos atribuir preco 0
update administracao.tb_eventos set preco = 0 where id in (2, 4);

-- reajustar valor em 10%
update administracao.tb_eventos set preco = preco * 1.1 where preco <> 0;

-- atribuir valor de R$100 para eventos gratuitos
update administracao.tb_eventos set preco = 100 where preco = 0;

-- eventos que o responsavel tenha menos que 6 caracteres, acrescentar sobrenome 'Silva' -> concat() ou ||
update administracao.tb_eventos set responsavel = concat(responsavel,' Silva') where length(responsavel) < 6;
