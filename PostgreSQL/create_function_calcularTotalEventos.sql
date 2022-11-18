create or replace function administracao.CalcularTotalEventos(idconv integer) returns decimal(12,2) as
$$
declare
	valorTotal decimal(12,2);
	id integer;
begin
	select  
		c.id, sum(e.preco) as "valor total pago"
	into
		id, valorTotal
	from 
		administracao.tb_convidados c 
		inner join administracao.tb_inscricoes i on i.idconvidado = c.id
		inner join administracao.tb_eventos e on i.idevento = e.id
	group by c.id;
	
	return valorTotal;
end
$$
language plpgsql;

select  c.id, administracao.CalcularTotalEventos(c.id) as "valor total pago"
from administracao.tb_convidados c inner join administracao.tb_inscricoes i on i.idconvidado = c.id
		join administracao.tb_eventos e on i.idevento = e.id
group by c.id
order by c.id;