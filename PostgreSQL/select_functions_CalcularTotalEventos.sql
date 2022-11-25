select * from administracao.tb_convidados tc;

select administracao.CalcularTotalEventos(10)

select cv.id, cv.nome, coalesce(administracao.CalcularTotalEventos(18), 0) as total
from administracao.tb_convidados cv where cv.id = 18;