import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClienteAlteracaoComponent } from './components/cliente-alteracao/cliente-alteracao.component';
import { ClienteNovoComponent } from './components/cliente-novo/cliente-novo.component';
import { ClienteRemocaoComponent } from './components/cliente-remocao/cliente-remocao.component';
import { ClientesComponent } from './components/clientes/clientes.component';
import { ErroComponent } from './components/erro/erro.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { AuthGuardGuard } from './guards/auth-guard.guard';

const routes: Routes = [
  { path: "", redirectTo: "home", pathMatch: 'full' },
  { path: "home", component: HomeComponent },
  { path: "clientes", component: ClientesComponent },
  { path: "clientes/novo", component: ClienteNovoComponent /*, canActivate: [AuthGuardGuard*/ },
  { path: "clientes/alterar/:id", component: ClienteAlteracaoComponent },
  { path: "clientes/remover/:id", component: ClienteRemocaoComponent },
  { path: "login", component: LoginComponent },
  { path: "**", component: ErroComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
