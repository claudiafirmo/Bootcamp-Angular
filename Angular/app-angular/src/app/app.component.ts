import { Component, OnInit } from '@angular/core';
import { Pessoa } from "./classes/pessoa";

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
    this.listar();
  }

  // Exemplo 01 - Property Binding (componente -> view)
  // <variavel>! - aceita valor indefinido
  rnd!: number; // retorna um valor entre 0 e 1

  gerarNumero(): void {
    this.rnd = Math.random();
  }

  // Exemplo 02 - produzindo uma lista de pessoas
  pessoas!: Pessoa[];

  listar(): void {
    this.pessoas = [
      { nome: "Pedro", idade: 32 },
      { nome: "Antonia", idade: 12 },
      { nome: "Julia", idade: 18 },
      { nome: "Lucas", idade: 19 },
      { nome: "Osvaldo", idade: 52 }
    ];
  }

  nomePessoa!: string;
  mostrar(nome: string): void {
    this.nomePessoa = nome;
  }

  // Exemplo 03
  filtrar(input: string): void {
    this.listar();
    this.pessoas = this.pessoas.filter(p => p.nome.toLowerCase().includes(input.toLowerCase()));
  }
}
