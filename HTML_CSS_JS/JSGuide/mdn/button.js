const botoes = document.querySelectorAll('button');
for(var i = 0; i < botoes.length ; i++) {
  botoes[i].addEventListener('click', createParagraph);
}

function createParagraph() {
    const para = document.createElement('p');
    para.textContent = 'You clicked the button!';
    document.body.appendChild(para);
    
}
