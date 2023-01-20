import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Empresa } from '../interface/empresa';

@Injectable({
  providedIn: 'root'
})
export class EmpresaService {

  constructor(private http: HttpClient) { }

  baseUrl: string = "http://localhost:5062/api/empresas"

  public postEmpresa(empresa: Empresa): Observable<Empresa> {
    return this.http.post<Empresa>(this.baseUrl, empresa);
  }
}
