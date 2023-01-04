// instancia o módulo listaDados e armazena em 'funcoes'
let funcoes = require('./funcoes/apiFuncoes');

// acessa os recursos do módulo instanciado
console.log(funcoes.buscarMaior(1, 2));
console.log(funcoes.buscarMaior(2));
console.log(funcoes.somar(10, 10));