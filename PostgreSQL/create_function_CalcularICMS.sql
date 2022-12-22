-- Função de propósito geral, determina valor do ICMS de um produto
-- create or replace = ou cria ou atualiza function
create or replace function funcoes.CalcularICMS(preco decimal(12,2)) returns decimal(12,2) as 
$$
-- declarando
declare 
	icms decimal(12,2);
	valorImposto decimal(12,2);
begin 
	-- atribuicao -> :=
	icms := 18;
	valorImposto := preco * icms / 100;
	return valorImposto;
end
$$
language plpgsql;