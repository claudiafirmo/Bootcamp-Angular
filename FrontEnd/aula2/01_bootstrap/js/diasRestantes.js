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
let calcularDias = function () {
    let dia = parseInt(document.getElementById("dia").value);
    let mes = parseInt(document.getElementById("mes").value);
    let ano = parseInt(document.getElementById("ano").value);

    // determinando números de dias de cada mes
    let meses = [31, ano % 4 == 0 ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

    // determinando o número de dias para terminar o mes informado
    let dias = meses[mes - 1] - dia;

    for (let i = mes; i < meses.length; i++) {
        dias += meses[i];
    }

    return dias;
}

//executando evento click no botao
document.getElementById('btnCalcular').addEventListener('click', function () { });
