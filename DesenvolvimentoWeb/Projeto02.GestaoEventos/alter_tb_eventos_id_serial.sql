SELECT MAX(id)+1 FROM administracao.tb_eventos te ;
CREATE SEQUENCE administracao.event_id_seq MINVALUE 6;
ALTER TABLE administracao.tb_eventos ALTER id SET DEFAULT nextval('administracao.event_id_seq');
ALTER SEQUENCE administracao.event_id_seq OWNED BY administracao.tb_eventos.id