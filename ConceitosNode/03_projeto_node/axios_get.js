let axios = require("axios");

function mostrar(s) {
    console.log(s);
    console.log('------- Fim do programa -------');
}

// usando o recurso de Promises

// consome api - então retorna a resposta (assincrono)
axios.get('http://localhost:3200/produtos/').then(resposta => {
    resultado = resposta.data;
    mostrar(resultado);
    console.log('------- Fim da consulta -------');
});
