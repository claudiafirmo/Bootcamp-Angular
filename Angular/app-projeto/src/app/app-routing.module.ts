import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClienteNovoComponent } from './components/cliente-novo/cliente-novo.component';
import { ClientesComponent } from './components/clientes/clientes.component';
import { ErroComponent } from './components/erro/erro.component';
import { HomeComponent } from './components/home/home.component';

const routes: Routes = [
  { path: "", redirectTo: "home", pathMatch: 'full' },
  { path: "home", component: HomeComponent },
  { path: "clientes", component: ClientesComponent },
  { path: "clientes/novo", component: ClienteNovoComponent },
  { path: "**", component: ErroComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
