import { Component } from '@angular/core';
import { MenuPainelComponent } from '../menu-painel/menu-painel.component';

@Component({
  selector: 'app-painel-empresa',
  templateUrl: './painel-empresa.component.html',
  styleUrls: ['./painel-empresa.component.css']
})
export class PainelEmpresaComponent {
  obj: MenuPainelComponent = new MenuPainelComponent();
  mostrar = this.obj.mostrar;
}
