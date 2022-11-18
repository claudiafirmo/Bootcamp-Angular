select * from administracao.tb_clientes;
select * from financeiro.tb_cartoes;
select * from financeiro.tb_faturas;

-- inserindo faturas
insert into financeiro.tb_faturas (idcliente, idcartao, valor, datavencto, status)
values (1,23,780.25,'2022-11-10', '1');

insert into financeiro.tb_faturas (idcliente, idcartao, valor, datavencto, status)
values (3,24,1250.00,'2022-11-11', '1');

insert into financeiro.tb_faturas (idcliente, idcartao, valor, datavencto, status)
values (4,24,1650.00,'2022-11-15', '1');

insert into financeiro.tb_faturas (idcliente, idcartao, valor, datavencto, status)
values (5,25,4250.00,'2022-11-14', '1');

insert into financeiro.tb_faturas (idcliente, idcartao, valor, datavencto, status)
values (6,27,1250.00,'2022-10-17', '1');