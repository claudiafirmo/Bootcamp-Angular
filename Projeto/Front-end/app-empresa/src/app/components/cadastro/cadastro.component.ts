import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Empresa } from 'src/app/interface/empresa';
import { Endereco } from 'src/app/interface/endereco';
import { EmpresaService } from 'src/app/services/empresa.service';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.css']
})
export class CadastroComponent implements OnInit {
  constructor(private router: Router, private empresaService: EmpresaService) { }

  ngOnInit(): void {
    this.endereco = { logradouro: '', cep: '', cidade: '', uf: '', numero: undefined };

    this.empresa = { nome: '', razaoSocial: '', cnpj: '', telefone: '', site: '' };
  }

  empresa!: Empresa;
  endereco!: Endereco

  incluir(empresa: Empresa): void {
    empresa.enderecoInfo = this.endereco;
    this.empresaService.postEmpresa(empresa).subscribe(() => this.router.navigate(['home']))
  }
}
