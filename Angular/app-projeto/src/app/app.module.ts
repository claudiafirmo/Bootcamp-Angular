import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuComponent } from './components/menu/menu.component';
import { HomeComponent } from './components/home/home.component';
import { ClientesComponent } from './components/clientes/clientes.component';
import { ErroComponent } from './components/erro/erro.component';
import { ClientesListaComponent } from './components/clientes-lista/clientes-lista.component';
import { ClienteNovoComponent } from './components/cliente-novo/cliente-novo.component';
import { FormsModule } from '@angular/forms';
// Consumo de API - Qualquer API
import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './components/login/login.component';
import { ClienteAlteracaoComponent } from './components/cliente-alteracao/cliente-alteracao.component';
import { ClienteRemocaoComponent } from './components/cliente-remocao/cliente-remocao.component';
import { SubListaPipe } from './pipes/sub-lista.pipe';
import { ValidaCelularPipe } from './pipes/valida-celular.pipe';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    HomeComponent,
    ClientesComponent,
    ErroComponent,
    ClientesListaComponent,
    ClienteNovoComponent,
    LoginComponent,
    ClienteAlteracaoComponent,
    ClienteRemocaoComponent,
    SubListaPipe,
    ValidaCelularPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
