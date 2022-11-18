-- inserindo pagamento dos eventos de 1 convidado na tb_pagamentos
insert into administracao.tb_pagamentos (idinscricao, datapagto, valor)
	select i.id as "idinscricao", current_date ,e.preco
	from administracao.tb_eventos e 
		inner join administracao.tb_inscricoes i on i.idevento = e.id 
		inner join administracao.tb_convidados c on i.idconvidado = c.id
	where c.id = 10;

-- inserindo pagamento dos eventos de outro convidado sem adicionar valor
insert into administracao.tb_pagamentos (idinscricao, datapagto)
	select i.id as "idinscricao", current_date
	from administracao.tb_eventos e 
		inner join administracao.tb_inscricoes i on i.idevento = e.id 
		inner join administracao.tb_convidados c on i.idconvidado = c.id
	where c.id = 4;
	
select * from administracao.tb_pagamentos tp 