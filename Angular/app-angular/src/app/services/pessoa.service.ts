import { Injectable } from "@angular/core";
import { Pessoa } from "../classes/pessoa";

@Injectable()
export class PessoaService {
    listarPessoas(): Pessoa[] {
        return [
            { nome: "Pedro", idade: 32 },
            { nome: "Antonia", idade: 12 },
            { nome: "Julia", idade: 18 },
            { nome: "Lucas", idade: 19 },
            { nome: "Osvaldo", idade: 52 }
        ];
    }
}