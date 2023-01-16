import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { EmpresaComponent } from './components/principal/empresa.component';
import { MenuComponent } from './components/menu/menu.component';

@NgModule({
  declarations: [
    EmpresaComponent,
    MenuComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [EmpresaComponent]
})
export class AppModule { }
