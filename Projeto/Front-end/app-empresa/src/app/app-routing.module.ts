import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastroComponent } from './components/cadastro/cadastro.component';
import { HomeEmpresaComponent } from './components/home/home-empresa/home-empresa.component';
import { LoginComponent } from './components/login/login.component';
import { DadosUsuarioComponent } from './components/Painel/dados-usuario/dados-usuario.component';
import { PainelEmpresaComponent } from './components/Painel/painel-empresa/painel-empresa.component';
import { SuasVagasComponent } from './components/Painel/suas-vagas/suas-vagas.component';

const routes: Routes = [
  { path: "", redirectTo: "home", pathMatch: 'full' },
  { path: "home", component: HomeEmpresaComponent },
  { path: "cadastro", component: CadastroComponent },
  { path: "login", component: LoginComponent },
  { path: "painelEmpresa", component: PainelEmpresaComponent },
  { path: "suasVagas", component: SuasVagasComponent },
  { path: "dadosUsuario", component: DadosUsuarioComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
