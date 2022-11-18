create schema funcoes; -- schema para funções de propósito geral

-- criando functions
create function funcoes.CalcularSoma(real, real)
returns real as -- define tipo do retorno
$$ -- bloco da função
begin -- bloco do return
	return $1 + $2; -- é a soma do parametro 1 com o parametro 2
end
$$
language plpgsql; --indica linguagem (sql do Postgree)


select funcoes.calcularsoma(2.0,2.0)
