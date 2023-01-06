import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  constructor() { }

  // implementação da interface
  ngOnInit(): void {
    this.gerarNumero();
  }

  // Exemplo 01 - Property Binding (componente -> view)
  // <variavel>! - aceita valor indefinido
  rnd!: number; // retorna um valor entre 0 e 1

  gerarNumero(): void {
    this.rnd = Math.random();
  }
}
