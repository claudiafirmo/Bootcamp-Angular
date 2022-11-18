-- criando a tabela tb_clientes no schema administracao
create table administracao.tb_clientes(
	documento char(14) not null,
	nome varchar(100) not null,
	telefone char(12) not null,
	endereco varchar(100) not null,
	uf char(2) default 'SP',
	status boolean default TRUE
);

-- movendo de schema
alter table tb_clientes set schema 'admnistracao';
-- adiciona constraint primary key
alter table administracao.tb_clientes add column id serial not null primary key;
-- o documento deve ter ou 11 ou 14 dígitos - check
alter table administracao.tb_clientes 
add constraint chk_tamanho_documento check(length(trim(documento)) = 11 or length(trim(documento)) = 14);
-- o documento deve ser exclusivo
alter table administracao.tb_clientes add constraint unq_documento_exclusivo unique(documento);