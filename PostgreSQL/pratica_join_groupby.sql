select * from administracao.tb_eventos;
select * from administracao.tb_inscricoes;
select * from administracao.tb_convidados;
/*
Prática:
1. Apresentar os eventos (descricao, responsavel, data) e seus participantes (nome, email).
2. Apresentar os eventos (descricao) e a quantidade de participantes por evento.
3. Apresentar os eventos (descricao) e o valor total arrecadado por evento.
4. Apresentar os eventos (descricao), a quantidade e o valor total arregadado.
5. Apresentar a lista de participantes (nome, email) e o valor que gastará em eventos.
*/

-- ex1:
select e.descricao, e.responsavel, e.data, c.nome, c.email
from administracao.tb_eventos e left join administracao.tb_inscricoes i on i.idevento = e.id 
		join administracao.tb_convidados c on i.idconvidado = c.id;

	-- correção: a ordem do from, vem primeiro a tabela q tem mais relação com outras. Inner pq é só os eventos com convidados
select e.descricao, e.responsavel, e.data, c.nome, c.email
from administracao.tb_inscricoes i 
	inner join administracao.tb_eventos e on i.idevento = e.id 
	inner join administracao.tb_convidados c on i.idconvidado = c.id;

-- ex2:
select e.descricao, count(*)
from administracao.tb_eventos e left join administracao.tb_inscricoes i on i.idevento = e.id
group by e.descricao;

-- ex3:
select e.descricao, e.preco * count(*) as "Valor arrecadado"
from administracao.tb_eventos e left join administracao.tb_inscricoes i on i.idevento = e.id
group by e.descricao, e.preco;

	-- correcao:
select e.descricao, sum(e.preco) as "Valor arrecadado"
from administracao.tb_eventos e left join administracao.tb_inscricoes i on i.idevento = e.id
group by e.descricao, e.preco;

--ex4:
select e.descricao, count(*) as "N° de convidados", e.preco * count(*) as "Valor arrecadado"
from administracao.tb_eventos e left join administracao.tb_inscricoes i on i.idevento = e.id
group by e.descricao, e.preco;

	-- correcao:
select e.descricao, count(*) as "N° de convidados", sum(e.preco) as "Valor arrecadado"
from administracao.tb_eventos e left join administracao.tb_inscricoes i on i.idevento = e.id
group by e.descricao, e.preco;

--ex5:
select c.nome, c.email, sum(e.preco)
from administracao.tb_convidados c left join administracao.tb_inscricoes i on i.idconvidado = c.id
		join administracao.tb_eventos e on i.idevento = e.id
group by c.nome, c.email
order by c.nome;
