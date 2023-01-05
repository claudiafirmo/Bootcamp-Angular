let axios = require('axios');

// obtendo os dados do produto                                           Index   0      1       2     3
let descricao = process.argv[2]; // valor do argumento informado no terminal  - node <arquivo> <arg> <arg>
let preco = parseFloat(process.argv[3]);

// definindo o obj produto
let produto = {
    "descricao" : descricao,
    "preco" : preco
}

// adicionando o produto

axios.post("http://localhost:3200/produtos/", produto).then(resposta => {
    console.log(resposta.data);
    console.log("Produto incluido com sucesso");
});