import { Injectable } from '@angular/core';
import { Cliente } from '../interfaces/cliente';

@Injectable({
  providedIn: 'root'
})
export class ClientesService {

  constructor() { }

  public getClientes(): Cliente[] {
    return [
      {
        cpf: "12521521251",
        nome: "Elizabeth",
        email: "liz@mail.com",
        telefone: "11525285852"
      },
      {
        cpf: "85465469535",
        nome: "Thiago",
        email: "thiagao@mail.com",
        telefone: "11524632569"
      },
      {
        cpf: "45469449535",
        nome: "Arthur",
        email: "arthur@mail.com",
        telefone: "11557432569"
      }
    ]
  }
}
