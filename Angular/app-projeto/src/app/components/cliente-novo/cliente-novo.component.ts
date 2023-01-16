import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Cliente } from 'src/app/interfaces/cliente';
import { ClientesService } from 'src/app/services/clientes.service';

@Component({
  selector: 'app-cliente-novo',
  templateUrl: './cliente-novo.component.html',
  styleUrls: ['./cliente-novo.component.css']
})
export class ClienteNovoComponent implements OnInit {

  constructor(private router: Router, private clienteService: ClientesService) { }

  ngOnInit(): void {
    this.cliente = { cpf: '', nome: '', email: '', telefone: '' };
  }

  cliente!: Cliente


  fechar(): void {
    this.router.navigate(["clientes"])
  }

  incluir(cliente: Cliente): void {
    this.clienteService.postClienteApi(cliente).subscribe(() => this.router.navigate(['clientes']));
  }
}
