create table if not exists administracao.tb_usuarios(
	nome varchar(50), 
	senha varchar(32) not null,
	nivel integer not null,
	constraint pk_nome primary key (nome)
);

select * from administracao.tb_usuarios;
