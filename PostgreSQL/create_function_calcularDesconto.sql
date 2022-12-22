create function administracao.CalcularDesconto(valor real, taxa real)
returns real as
$$
	begin
		return valor - valor * (taxa / 100);
	end
$$
language plpgsql;