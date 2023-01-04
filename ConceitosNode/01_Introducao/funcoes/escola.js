let lista = require('./../listas/listaDados');

// o módulo representa uma função apenas, é um tipo de módulo
module.exports = function (descricao = 'Impacta') {
    console.log(`Nome da escola: ${descricao}`);
    console.log(lista.nomes);
}