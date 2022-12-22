function somar(){
    var a = document.getElementById("a").value;
    var b = document.getElementById("b").value;
    a = parseInt(a)
    b = parseInt(b)
    var soma = a + b
    var resposta = document.getElementById("resposta")
    resposta.innerHTML = "<h2>Resultado: " + soma + "</h2>";
}