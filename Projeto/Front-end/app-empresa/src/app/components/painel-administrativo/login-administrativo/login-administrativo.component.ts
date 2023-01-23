import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login-administrativo',
  templateUrl: './login-administrativo.component.html',
  styleUrls: ['./login-administrativo.component.css']
})
export class LoginAdministrativoComponent {
  constructor(private router: Router) { }

  entrar(): void {
    this.router.navigate(['painelAdministrativo'])
  }
}
