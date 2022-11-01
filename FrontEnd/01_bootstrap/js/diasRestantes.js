/*
    No formulário, o usuário fornecerá três informações:
    dia, mês e ano.
    Com base nas informações, determinar quantos dias restam para terminar o ano.
*/
/*
    Outro jeito de fazer função: 
    let calcularDias = function(){} -> caracteristicas do let não afeta ela em nada.
    A função não tem nome, mas ela tem uma variável que representa ela
 */
let calcularDias = function (dia, mes, ano) {

    // valida mes
    if(mes < 1 || mes > 12){
        throw TypeError('Mês inválido, deve ser um valor entre 1 e 12.');
    }

    // determinando números de dias de cada mes
    let meses = [31, ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0 ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

    // valida dia
    if(dia < 1 || dia > meses[mes - 1]){
            throw TypeError('Dia inválido para o mês informado.');
    }

    // determinando o número de dias para terminar o mes informado
    let dias = meses[mes - 1] - dia;

    for (let i = mes; i < meses.length; i++) {
        dias += meses[i];
    }

    return dias;
}
