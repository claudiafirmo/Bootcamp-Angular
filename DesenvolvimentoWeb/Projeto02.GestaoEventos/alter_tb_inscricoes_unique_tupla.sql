-- A junção (tupla) desses ids tem q ser unica 
alter table administracao.tb_inscricoes add constraint unq_inscricao unique(idevento, idconvidado) 