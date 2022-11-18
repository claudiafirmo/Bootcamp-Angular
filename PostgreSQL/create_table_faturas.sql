create table financeiro.tb_faturas(
	id serial not null primary key,
	idCliente integer not null,
	idCartao integer not null,
	numCartao char(16) not null check(length(numCartao) = 16),
	valor decimal(12,2) not null check(valor > 0),
	dataVencto timestamp not null,
	status char(1) not null check(status = '1' or status = '2'), -- 1: pendente / 2: pago
	
	foreign key(idCliente) references administracao.tb_clientes(id),
	foreign key(idCartao) references financeiro.tb_cartoes(id)
);