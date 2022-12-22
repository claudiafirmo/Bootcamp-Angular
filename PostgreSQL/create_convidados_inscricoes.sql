alter table tb_eventos set schema administracao;

create table administracao.tb_convidados(
	id serial primary key not null,
	cpf char(11) not null,
	nome varchar(60) not null,
	email varchar(60) not null,
	constraint ck_cpf check (length(cpf) = 11),
	constraint uq_cpf unique(cpf)
);

create table administracao.tb_inscricoes(
	id serial primary key not null,
	idevento integer,
	idconvidado integer,
	dataInscricao date,
	constraint fk_idevento foreign key(idevento) references administracao.tb_eventos(id),
	constraint fk_idconvidado foreign key(idconvidado) references administracao.tb_convidados 
);