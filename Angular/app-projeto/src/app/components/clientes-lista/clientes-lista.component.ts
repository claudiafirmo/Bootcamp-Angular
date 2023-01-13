import { Component, OnInit } from '@angular/core';
import { Cliente } from 'src/app/interfaces/cliente';
import { ClientesService } from 'src/app/services/clientes.service';

@Component({
  selector: 'app-clientes-lista',
  templateUrl: './clientes-lista.component.html',
  styleUrls: ['./clientes-lista.component.css']
})
export class ClientesListaComponent implements OnInit {

  constructor(private clientesService: ClientesService) { }

  ngOnInit(): void {
    this.clientes = this.clientesService.getClientes();
  }

  clientes: Cliente[] = [];
}
