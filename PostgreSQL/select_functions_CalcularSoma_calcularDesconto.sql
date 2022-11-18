select 
	id,
	descricao,
	responsavel,
	preco,
	administracao.CalcularDesconto(preco, 10) as "preco_pix",
	funcoes.CalcularSoma(preco, 10) as "Novo preço",
	data
from administracao.tb_eventos;