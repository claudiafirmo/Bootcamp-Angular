import { Pipe, PipeTransform } from '@angular/core';
import { Cliente } from '../interfaces/cliente';

@Pipe({
  name: 'sublista'
})
export class SubListaPipe implements PipeTransform {

  // o primeiro parametro de transform é o elemento sobre o qual o pipe irá atuar
  transform(clientes: Cliente[], input: string): Cliente[] {
    if (!input) {
      return clientes;
    } else {
      return clientes.filter(
        c => c.nome.toLowerCase().includes(input.toLowerCase())
      );
    }
  }

}
