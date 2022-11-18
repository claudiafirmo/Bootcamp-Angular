create table tb_eventos
(
	id integer primary key,
	descricao varchar(50) not null,
	responsavel varchar(50) not null,
	preco numeric not null,
	data date not null
);
