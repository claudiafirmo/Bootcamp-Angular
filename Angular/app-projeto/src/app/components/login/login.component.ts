import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Usuario } from 'src/app/classes/usuario';
import { UsuariosService } from 'src/app/services/usuarios.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(
    private router: Router,
    private usuarioService: UsuariosService) { }

  user!: Usuario;
  erro!: string;
  // tipo de storage é Localstorage
  storage: Storage = localStorage;

  ngOnInit(): void {
    this.user = new Usuario();
    this.storage.removeItem('user_name');
  }

  fechar(): void {
    this.router.navigate(['/'])
  }

  validar(usuario: Usuario): void {
    this.usuarioService.postUsuarioApi(usuario).subscribe(res => {
      if (res) {
        this.storage.setItem("user_name", res.nome);
        this.fechar();
      } else {
        this.erro = "Usuário ou senha inválidos";
      }
    })

    // SEM API
    // let valida: boolean = this.usuarioService.usuarios.includes(usuario.nome);
    // if (valida && usuario.senha == 'admin') {
    //   this.storage.setItem("user_name", usuario.nome);
    //   this.fechar();
    // } else {
    //   this.erro = "Usuário ou senha inválidos"
    // }
  }
}
