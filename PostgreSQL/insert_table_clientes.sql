-- incluindo todos os campos, menos campo id(Serial)
insert into administracao.tb_clientes (documento, nome, telefone, endereco, uf, status)
values('52848953047', 'Renata Glasc', '1568-9574', 'Av. Tunel Barato 1234', 'PE', TRUE);

-- incluindo vario registros simultaneamente
insert into administracao.tb_clientes (documento, nome, telefone, endereco, uf, status)
values('91931895082', 'Rell Pereira','1253-7567', 'Rua Fire, 157', 'SC', TRUE),
('57863653010', 'Violet Costa', '4585-9653', 'Av.Zaun, 987', 'SP', TRUE),
('36320325054', 'Caitlyn Garcia Moreira','6523-2626',  'Av. Piltover, 1225', 'SP', FALSE);

select * from administracao.tb_clientes;