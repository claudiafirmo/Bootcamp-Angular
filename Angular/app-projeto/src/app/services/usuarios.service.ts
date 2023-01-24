import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Usuario } from '../classes/usuario';

@Injectable({
  providedIn: 'root'
})
export class UsuariosService {

  constructor(private http: HttpClient) { }

  baseUrl: string = "http://localhost:5192/api/user";

  public postUsuarioApi(usuario: Usuario): Observable<Usuario> {
    return this.http.post<Usuario>(this.baseUrl, usuario);
  }

  public get usuarios(): string[] {
    return [
      "admin", "scania", "convidado"
    ]
  }
}
