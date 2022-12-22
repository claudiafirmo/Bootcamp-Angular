/*
 * uso da função COALESCE(campo, valor) - Apresentar o valor do primeiro parametro,
 *  se ele for null ou inválido, o segundo parametro é retornado para o dado 
*/

select id, idinscricao, datapagto , coalesce(valor, 0) as valor
from administracao.tb_pagamentos tp 

-- Tornar idinscricao único
alter table administracao.tb_pagamentos add constraint uq_idinscricao unique(idinscricao)