import { Component, OnInit } from '@angular/core';
import { Pessoa } from "./classes/pessoa";
import { PessoaService } from './services/pessoa.service';

@Component({
  selector: 'exemplos',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  constructor(private pessoaService: PessoaService) { }

  // implementação da interface
  ngOnInit(): void {
    this.gerarNumero();
    this.listar();
  }

  // Exemplo 01 - Property Binding (componente -> view)
  // <variavel>! - aceita valor indefinido
  rnd!: number; // retorna um valor entre 0 e 1

  gerarNumero(): void {
    this.rnd = Math.random() * 100;
  }

  // Exemplo 02 - produzindo uma lista de pessoas
  pessoas!: Pessoa[];

  listar(): void {
    this.pessoas = this.pessoaService.listarPessoas();
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
