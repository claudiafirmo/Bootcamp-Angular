import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Cliente } from 'src/app/interfaces/cliente';
import { ClientesService } from 'src/app/services/clientes.service';

@Component({
  selector: 'app-cliente-remocao',
  templateUrl: './cliente-remocao.component.html',
  styleUrls: ['./cliente-remocao.component.css']
})
export class ClienteRemocaoComponent implements OnInit {

  constructor(
    private clienteService: ClientesService,
    private router: Router,
    private route: ActivatedRoute) { }

  cliente!: Cliente;
  id!: string;

  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get("id") as string;
    this.clienteService.getClienteApi(parseInt(this.id)).subscribe(resp => this.cliente = resp);
  }

  fechar(): void {
    this.router.navigate(["/clientes"]);
  }

  remover(): void {
    this.clienteService.deleteClienteApi(parseInt(this.id)).subscribe(() => this.fechar());
  }

}
