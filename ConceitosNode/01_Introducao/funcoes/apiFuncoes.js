// função que recebe 2 parametros numericos e retorna a soma

// função nomeada
function calcularSoma(valor1, valor2) {
    if (typeof (valor1) != 'number' || typeof (valor2) != 'number') {
        throw new Error("Os parâmetros devem ser numéricos");
    }
    return valor1 + valor2;
}

exports.somar = calcularSoma; // passa o endereco de memória

// neste exemplo a função recebe 2 parâmetros numéricos e retorna o maior deles

// função anônima
exports.buscarMaior = function (a, b = 0) {
    if (typeof (a) != 'number' || typeof (b) != 'number') {
        throw new Error("Os parâmetros devem ser numéricos");
    }
    return a > b ? a : b;
}
