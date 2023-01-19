import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastroComponent } from './components/cadastro/cadastro.component';
import { HomeEmpresaComponent } from './components/home/home-empresa/home-empresa.component';

const routes: Routes = [
  { path: "", redirectTo: "home", pathMatch: 'full' },
  { path: "home", component: HomeEmpresaComponent },
  { path: "cadastro", component: CadastroComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
