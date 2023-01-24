import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {
  ngOnInit(): void {
    this.usuario_logado = this.storage.getItem("user_name");
  }

  storage: Storage = localStorage;
  usuario_logado!: string | null;
}
