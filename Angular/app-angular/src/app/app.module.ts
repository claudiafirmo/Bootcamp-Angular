import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { PrincipalComponent } from './components/principal.component';
import { PessoaService } from './services/pessoa.service';
import { MenuComponent } from './components/menu/menu.component';
import { HomeComponent } from './components/home/home.component';
import { ErroComponent } from './components/erro/erro.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    PrincipalComponent,
    MenuComponent,
    HomeComponent,
    ErroComponent
  ],
  imports: [
    BrowserModule, AppRoutingModule
  ],
  providers: [
    PessoaService
  ],
  bootstrap: [PrincipalComponent]
})
export class AppModule { }