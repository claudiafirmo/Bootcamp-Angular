import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cliente } from '../interfaces/cliente';

@Injectable({
  providedIn: 'root'
})
export class ClientesService {

  constructor(private http: HttpClient) { }

  // public getClientes(): Cliente[] {
  //   return [
  //     {
  //       id: 1,
  //       cpf: "12521521251",
  //       nome: "Elizabeth",
  //       email: "liz@mail.com",
  //       telefone: "11525285852"
  //     },
  //     {
  //       id: 2,
  //       cpf: "85465469535",
  //       nome: "Thiago",
  //       email: "thiagao@mail.com",
  //       telefone: "11524632569"
  //     },
  //     {
  //       id: 3,
  //       cpf: "45469449535",
  //       nome: "Arthur",
  //       email: "arthur@mail.com",
  //       telefone: "11557432569"
  //     }
  //   ]
  // }

  baseUrl: string = "http://localhost:3000/apiclientes";

  // Lista todos os clientes
  public getClientesApi(): Observable<Cliente[]> {
    return this.http.get<Cliente[]>(this.baseUrl);
  }

  // Busca de um cliente pelo ID
  public getClienteApi(id: number): Observable<Cliente> {
    const url = `${this.baseUrl}/${id}`;
    return this.http.get<Cliente>(url);
  }

  // Inclui um novo cliente
  public postClienteApi(cliente: Cliente): Observable<Cliente> {
    return this.http.post<Cliente>(this.baseUrl, cliente);
  }

  // altera os dados do cliente 
  public putClienteApi(cliente: Cliente, id: number): Observable<Cliente> {
    const url = `${this.baseUrl}/${id}`;
    return this.http.put<Cliente>(url, cliente);
  }

  // remove cliente
  public deleteClienteApi(id: number): Observable<Cliente> {
    const url = `${this.baseUrl}/${id}`;
    return this.http.delete<Cliente>(url);
  }
}

