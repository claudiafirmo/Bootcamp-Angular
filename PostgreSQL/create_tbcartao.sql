-- criando uma tabela chamada tb_cartoes
create table administracao.tb_cartoes(
	id serial not null primary key,
	numcartao char(16) not null check(length(numcartao) = 16),
	limite decimal(12,2) not null check(limite >= 1000.0 and limite <= 5000.00) 
);