-- exercicio: Inserindo 10 novos itens
insert into administracao.tb_clientes (documento, nome, telefone, endereco, uf, status)
values ('52137364085', 'Lena Blanc', '5163-3958', 'Rua Ploft, 928', 'RS', FALSE),
('80297787080', 'Tryndamer Fernandes', '8278-9298', 'Rodovia Blabla, km 15', 'MT', TRUE),
('60139019022', 'Victor Barros', '17823-7373', 'Rua California, 272', 'MA' ,TRUE),
('00000000001', 'Heimerdinger De Vermontes', '2922-2222', 'Rua Vermontes, 10', 'SC', FALSE),
('92862888087', 'Udyrmines Machado', '9339-8744', 'Rua Freyord, 5', 'RS', TRUE),
('91142767043', 'Akshan Gomes da Silva', '3939-3838', 'Rua Pulinhos, 203', 'SP', TRUE),
('91409128091', 'Yasuo Tosco', '8383-2822', 'Rua Viola, 38', 'SP', FALSE),
('70179862022', 'Yone Irmao do Tosco', '9829-3636', 'Rua Viola, 38', 'SP', TRUE),
('75507760080', 'Leona Cristiane Gimenes', '8833-3738', 'Rua Bacana, 12', 'SP', TRUE),
('51969156058', 'Diana Valentina Farias', '3838-3737', 'Rua Legal, 45', 'SP', TRUE);

select * from administracao.tb_clientes;