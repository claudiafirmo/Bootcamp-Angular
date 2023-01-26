import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'validacelular'
})
export class ValidaCelularPipe implements PipeTransform {

  transform(numeroContato: string): string {
    return numeroContato.at(2) == "9" ? `${numeroContato} (Cel)` : numeroContato
  }
}
