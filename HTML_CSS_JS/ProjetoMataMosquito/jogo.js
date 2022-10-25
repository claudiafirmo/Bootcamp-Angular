// Verifica dimensão da tela
var altura = 0;
var largura = 0;
var vidas = 1;

function ajustaTamanhoPalcoJogo(){
    altura = window.innerHeight;
    largura = window.innerWidth;
}

ajustaTamanhoPalcoJogo();

// Cria posições aleatórias para o objeto mosca

function posicaoRandomica(){

    //remove mosquito anterior(caso exista)
    var obj = document.getElementById('mosquito');

    if(obj){ // obj !== null gera True
  
        obj.remove();
        
        if(vidas > 3){
            alert('PARE')
            gameOver()
        }else{
            document.getElementById('v' + vidas).src =
            "img/coracao_vazio.png";
            vidas++;
        }
    };

    var posicaoX = 
    Math.floor(Math.random() * largura) - 50;

    var posicaoY = 
    Math.floor(Math.random() * altura) - 50;

    // caso o X ou Y saia da tela, o eixo é = 0
    if(posicaoX < 0){
        posicaoX = 0;
    };
    
    if(posicaoY < 0){
        posicaoY = 0;
    };
    
    // Criar novo elemento HTML
    var mosquito = 
    document.createElement('img');
    mosquito.src = 
    'img/mosca.png';
    mosquito.className = 
    tamanhoAleatorio() + ' ' + ladoAleatorio();
    mosquito.style.left = 
    posicaoX + 'px';
    mosquito.style.top = 
    posicaoY + 'px';
    mosquito.style.position = 
    'absolute';
    mosquito.id = 'mosquito';
    mosquito.onclick = function(){
        this.remove();
    };
    
    document.body.appendChild(mosquito);

}

function tamanhoAleatorio(){
    var classe = Math.floor(Math.random() * 3);

    switch(classe){
        case 0:
            return 'mosquito1';
        case 1:
            return 'mosquito2';
        case 2:
            return 'mosquito3';
    };
}

function ladoAleatorio(){
    var classe = Math.floor(Math.random() * 2);

    switch(classe){
        case 0:
            return 'ladoA';
        case 1:
            return 'ladoB';
    };
}

function gameOver(){
    var fimDeJogo = document.createElement('img');
    fimDeJogo.src = 'img/game_over.png';
    fimDeJogo.style.left = 
    (Math.floor(posicaoX / 2)) + 'px';
    fimDeJogo.style.top = 
    (Math.floor(posicaoY / 2)) + 'px';
    fimDeJogo.style.position = 'absolute';
}