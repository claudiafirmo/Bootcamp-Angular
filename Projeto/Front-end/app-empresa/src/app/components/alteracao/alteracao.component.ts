import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { throwError } from 'rxjs';
import { Empresa } from 'src/app/interface/EmpresaApi/empresa';
import { Endereco } from 'src/app/interface/EmpresaApi/endereco';
import { Municipio } from 'src/app/interface/LocalidadesApi/Cidades/municipio';
import { Uf } from 'src/app/interface/LocalidadesApi/Estados/uf';
import { EmpresaService } from 'src/app/services/empresa.service';
import { LocalidadesService } from 'src/app/services/localidades.service';
import { ViacepService } from 'src/app/services/viacep.service';

@Component({
  selector: 'app-alteracao',
  templateUrl: './alteracao.component.html',
  styleUrls: ['./alteracao.component.css']
})
export class AlteracaoComponent {
  constructor(private router: Router, private empresaService: EmpresaService, private viacep: ViacepService, private localidades: LocalidadesService) { }

  storage: Storage = localStorage;
  empresa!: Empresa;
  endereco!: Endereco;
  estados!: Uf[];
  cidades!: Municipio[];

  ngOnInit(): void {
    let userLogado = this.storage.getItem("user_name") as string;
    this.empresaService.getEmpresaPorCnpj(userLogado).subscribe(
      resp => {
        this.empresa = resp;
        this.endereco = this.empresa.enderecoInfo as Endereco;
      }
    );
    this.listarEstados();
  }

  Alterar(empresa: Empresa): void {
    this.empresaService.putEmpresa(empresa).subscribe(() => this.router.navigate(["/painelEmpresa"]), error => this.router.navigate(["/erro"]));
  }

  preencherEnderecoPorCep(cep: string): void {
    this.viacep.getEnderecoPorCep(cep).subscribe(resposta => {
      this.endereco = {
        logradouro: resposta.logradouro, cidade: resposta.localidade, uf: resposta.uf, cep: this.endereco.cep, numero: this.endereco.numero
      };
      this.listarMunicipiosPorUf(this.endereco.uf);
    });
  }

  listarEstados(): void {
    this.localidades.getEstados().subscribe(resposta => this.estados = resposta);
  }

  listarMunicipiosPorUf(uf: string): void {
    this.localidades.getMunicipiosPorUf(uf).subscribe(resposta => this.cidades = resposta);
  }
}
