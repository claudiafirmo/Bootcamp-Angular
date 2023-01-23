import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastroComponent } from './components/cadastro/cadastro.component';
import { HomeEmpresaComponent } from './components/home/home-empresa/home-empresa.component';
import { LoginComponent } from './components/login/login.component';
import { LoginAdministrativoComponent } from './components/painel-administrativo/login-administrativo/login-administrativo.component';
import { PainelAdministrativoComponent } from './components/painel-administrativo/painel-administrativo/painel-administrativo.component';
import { DadosUsuarioComponent } from './components/painel-empresa/dados-usuario/dados-usuario.component';
import { PainelEmpresaComponent } from './components/painel-empresa/painel-empresa/painel-empresa.component';
import { SuasVagasComponent } from './components/painel-empresa/suas-vagas/suas-vagas.component';

const routes: Routes = [
  { path: "", redirectTo: "home", pathMatch: 'full' },
  { path: "home", component: HomeEmpresaComponent },
  { path: "cadastro", component: CadastroComponent },
  { path: "login", component: LoginComponent },
  { path: "painelEmpresa", component: PainelEmpresaComponent },
  { path: "suasVagas", component: SuasVagasComponent },
  { path: "dadosUsuario", component: DadosUsuarioComponent },
  { path: "loginAdministrativo", component: LoginAdministrativoComponent },
  { path: "painelAdministrativo", component: PainelAdministrativoComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
