create table tb_funcionarios
(
	documento char(14) not null primary key,
	nome varchar(100) not null,
	idade integer not null,
	sexo char(1) not null check(sexo = '0' or sexo = '1' or sexo = '2'),
	cargo varchar(50) not null,
	salario decimal(12,2) not null
);

create table tb_enderecos
(
	id serial not null primary key,
	documento char(14) not null, 
	unique(documento),
	foreign key(documento) references tb_funcionarios(documento),
	logradouro varchar(100) not null,
	numero integer not null,
	cidade varchar(50) not null,
	cep char(8) not null check(length(cep) = 8)
);