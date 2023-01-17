import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { EmpresaComponent } from './components/principal/empresa.component';
import { MenuGeralComponent } from './components/menu-geral/menu-geral.component';
import { MenuPrincipalComponent } from './components/principal/menu-principal/menu-principal.component';

@NgModule({
  declarations: [
    EmpresaComponent,
    MenuGeralComponent,
    MenuPrincipalComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [EmpresaComponent]
})
export class AppModule { }
