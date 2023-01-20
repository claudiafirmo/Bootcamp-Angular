import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { EmpresaComponent } from './components/empresa.component';
import { MenuGeralComponent } from './components/menu-geral/menu-geral.component';
import { MenuHomeComponent } from './components/home/menu-home/menu-home.component';
import { HomeEmpresaComponent } from './components/home/home-empresa/home-empresa.component';
import { CadastroComponent } from './components/cadastro/cadastro.component';
import { HttpClientModule } from "@angular/common/http";
import { FormsModule } from "@angular/forms";

@NgModule({
  declarations: [
    EmpresaComponent,
    MenuGeralComponent,
    MenuHomeComponent,
    HomeEmpresaComponent,
    CadastroComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [EmpresaComponent]
})
export class AppModule { }
