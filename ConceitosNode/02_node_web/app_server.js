let http = require('http');
let fs = require('fs');
let url = require('url');

let server = http.createServer(function (request, response) {

    let url_params = url.parse(request.url);
    let caminho = url_params.pathname; // retorna a informação apos o localhost:3000

    if(caminho == '/'){
        caminho = '/index.html';
    }

    console.log(caminho);

    fs.readFile(__dirname + caminho, function (erro, conteudo) {
        if (erro) {
            response.writeHead(404, { 'Content-Type': 'text/html' });
            response.write('<h1>Page Not Found</h1>');
        } else {
            response.writeHead(200, { 'Content-Type': 'text/html' });
            response.write(conteudo);
        }
        response.end();
    });
});

server.listen(3000, function () {
    // __dirname retorna a pasta que esta a aplicação atual
    console.log(__dirname);
    console.log('Servidor em execução');
    console.log('Clique ctrl + c para parar');
});