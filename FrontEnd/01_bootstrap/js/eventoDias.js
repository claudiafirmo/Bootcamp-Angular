// arquivo dependente do HTML

//executando evento click no botao
document.getElementById('btnCalcular').addEventListener('click', function () {

    try {
        let d = parseInt(document.getElementById("dia").value);
        let m = parseInt(document.getElementById("mes").value);
        let a = parseInt(document.getElementById("ano").value);
    
        document.getElementById("resposta").innerHTML = "<p> Restam <strong>" + calcularDias(dia=d, mes=m, ano=a) + "</strong> dias para acabar o ano</p>";
    }catch(error){ // error -> é uma variável que contem o tipo de erro, poderia ser outro nome
        //alert('Erro: ' + error);
        document.getElementById('resposta').innerHTML = error.message;
    }

});