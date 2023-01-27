import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EmpresaService } from 'src/app/services/empresa.service';

@Component({
  selector: 'app-exclusao',
  templateUrl: './exclusao.component.html',
  styleUrls: ['./exclusao.component.css']
})
export class ExclusaoComponent implements OnInit {
  constructor(
    private route: ActivatedRoute,
    private empresaService: EmpresaService,
    private router: Router
  ) { }

  id!: string;

  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get("id") as string;
  }

  excluir(id: string): void {
    this.empresaService.deleteEmpresa(id).subscribe(resposta => {
      if (resposta) {
        this.router.navigate(["/home"]);
      } else {
        this.router.navigate(["/erro"]);
      }
    })
  }
}
