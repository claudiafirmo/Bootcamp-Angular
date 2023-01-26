import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Cliente } from 'src/app/interfaces/cliente';
import { ClientesService } from 'src/app/services/clientes.service';

@Component({
  selector: 'app-cliente-alteracao',
  templateUrl: './cliente-alteracao.component.html',
  styleUrls: ['./cliente-alteracao.component.css']
})
export class ClienteAlteracaoComponent implements OnInit {

  constructor(
    // Lê parametro da query string
    private route: ActivatedRoute,
    private router: Router,
    private clienteService: ClientesService) { }

  cliente!: Cliente;
  id!: string;

  ngOnInit(): void {
    // retorna string ou null             deve retornar string
    this.id = this.route.snapshot.paramMap.get("id") as string;
    this.clienteService.getClienteApi(parseInt(this.id)).subscribe(res => this.cliente = res);
  }

  alterar(cliente: Cliente): void {
    this.clienteService.putClienteApi(cliente, parseInt(this.id)).subscribe(() => this.fechar());
  }

  fechar(): void {
    this.router.navigate(['/clientes']);
  }

}
