select * from administracao.tb_eventos;
select * from administracao.tb_inscricoes;
select * from administracao.tb_convidados;

-- efetuando inscriçoes de convidados no evento
insert into administracao.tb_inscricoes(idevento, idconvidado, datainscricao)
values (1, 1, current_date),(1, 2, current_date),(1, 3, current_date),(1, 4, current_date),
		(2, 5, current_date),(2, 6, current_date),(2, 7, current_date),(2, 8, current_date),(2, 10, current_date),
		(3, 9, current_date),(3, 10, current_date), (3, 12, current_date),
		(4, 14, current_date),(4, 15, current_date),(4, 16, current_date),
		(5, 17, current_date), (5, 1, current_date);