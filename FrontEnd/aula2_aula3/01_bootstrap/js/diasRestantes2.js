// determinando o ano atual
let data = new Date();  // objeto captura data do sistema
let ano = data.getFullYear();

// listas de objetos contendo o mes e o número de dias do mes
let mesesLista = [
    {mes: 'Janeiro',    dias: 31},
    {mes: 'Fevereiro',  dias: ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0 ? 29 : 28},
    {mes: 'Março',      dias: 31},
    {mes: 'Abril',      dias: 30},
    {mes: 'Maio',       dias: 31},
    {mes: 'Junho',      dias: 30},
    {mes: 'Julho',      dias: 31},
    {mes: 'Agosto',     dias: 31},
    {mes: 'Setembro',   dias: 30},
    {mes: 'Outubro',    dias: 31},
    {mes: 'Novembro',   dias: 30},
    {mes: 'Dezembro',   dias: 31}
];

// referenciando o elemento select
let elementoMeses = document.getElementById('meses');

function listarMeses(){
    for(let i = 0; i < mesesLista.length; i++){
        let option = document.createElement('option');
        option.textContent = mesesLista[i].mes;
        option.setAttribute('value', i)
        elementoMeses.appendChild(option)
    }
}

listarMeses()

let calcularDias = function (dia, mes) {

    // valida dia
    if(dia < 1 || dia > mesesLista[mes].dias){
            throw TypeError('Dia inválido para o mês informado.');
    }
    // determinando o número de dias para terminar o mes informado
    let dias = mesesLista[mes].dias - dia;

    // calcula dias restantes(dos meses seguintes)
    for (let i = mes + 1; i < mesesLista.length; i++) {
        dias += mesesLista[i].dias;
    }

    return dias;
}

//Evento Click do botão para determinar o número de dias restantes

document.getElementById('btnCalcular').addEventListener('click', function(){
    try{
        let d = parseInt(document.getElementById("dia").value);
        let m = parseInt(document.getElementById("meses").value);
    
        document.getElementById('resposta').innerHTML = 'Restam <strong>' + calcularDias(d, m) + '</strong> dias';
    }catch(error){
        document.getElementById('resposta').innerHTML = error.message; 
    }
})
