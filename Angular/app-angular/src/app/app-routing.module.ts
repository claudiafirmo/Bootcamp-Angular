import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AppComponent } from "./app.component";
import { ErroComponent } from "./components/erro/erro.component";
import { HomeComponent } from "./components/home/home.component";

// do mais geral ao menos específico
const routes: Routes = [
    { path: "", redirectTo: "home", pathMatch: "full" },
    { path: "home", component: HomeComponent },
    { path: "exemplos", component: AppComponent },
    { path: "**", component: ErroComponent }
]

@NgModule({
    imports: [
        RouterModule.forRoot(routes)
    ],
    exports: [
        RouterModule
    ]
})

// módulo de rota
export class AppRoutingModule { }