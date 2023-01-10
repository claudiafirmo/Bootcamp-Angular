-- Script do banco de dados do Projeto final - Recursos Humanos

CREATE database dbrecursoshumanos;

create table if not EXISTS tb_modalidade(
	id serial,
  	descricao varchar(11) not NULL,
  	CONSTRAINT pk_modalidade PRIMARY KEY(id)
);
create table if not EXISTS tb_turno(
	id serial,
  	descricao varchar(8) not NULL,
  	CONSTRAINT pk_turno PRIMARY KEY(id)
);
create table if not EXISTS tb_beneficios(
	id serial,
  	descricao varchar(30) not NULL,
  	CONSTRAINT pk_beneficios PRIMARY KEY(id)
);
create table if not EXISTS tb_escolaridade(
	id serial,
  	descricao varchar(30) not NULL,
  	CONSTRAINT pk_escolaridade PRIMARY KEY(id)
);
create table if not EXISTS tb_endereco(
	id serial,
  	logradouro varchar(60) not null,
	cep char(8) not null,
	cidade varchar(30) not null,
	estado char(2) not null,
	numero integer not NULL,
	CONSTRAINT pk_endereco PRIMARY KEY(id),
	CONSTRAINT ck_cep check(LENGTH(cep) = 8),
	CONSTRAINT ck_estado CHECK (LENGTH(estado) = 2)
);
create table if not exists tb_empresa(
	id serial,
	idendereco int NOT null,
	nome varchar(50) NOT null,
	razaosocial varchar(50) NOT null,
	cnpj char(14) NOT NULL,
	telefone varchar(11),
	site varchar(100),
	CONSTRAINT pk_empresa PRIMARY KEY(id),
	CONSTRAINT fk_idendereco_tbempresa FOREIGN KEY (idendereco) REFERENCES (tb_endereco),
	CONSTRAINT ck_cnpj check (length(cnpj) = 14),
	CONSTRAINT uq_cnpj unique(cnpj),
	CONSTRAINT ck_telefone check (length(telefone) = 11 or length(telefone) = 10)
);
create table if not exists tb_candidato(
	id serial,
	idendereco int not null,
	idescolaridade int not null,
	nome varchar(50) not null,
	cpf char(11) not null,
	telefone varchar(11),
	email varchar(60),
	CONSTRAINT pk_candidato PRIMARY KEY(id),
	CONSTRAINT fk_idendereco_tbcandidato FOREIGN KEY (idendereco) REFERENCES (tb_endereco),
	CONSTRAINT fk_idescolaridade_tbcandidato FOREIGN KEY (idescolaridade) REFERENCES (tb_escolaridade),
	CONSTRAINT ck_cpf check (length(cpf) = 11),
	CONSTRAINT uq_cpf unique(cpf),
	CONSTRAINT ck_telefone check (length(telefone) = 11 or length(telefone) = 10),
	CONSTRAINT ck_email check(email like '.@.')
);
