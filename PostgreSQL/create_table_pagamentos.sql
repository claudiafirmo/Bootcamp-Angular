create table if not exists administracao.tb_pagamentos(
	id serial not null primary key,
	idinscricao integer not null,
	datapagto date not null,
	valor decimal(12,2),
	foreign key (idinscricao) references administracao.tb_inscricoes(id)
);
