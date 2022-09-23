import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public enventos: any = [
    {
      tema: 'angular',
      local: 'Belo Horizonte'
    },
    {
      tema: 'react',
      local: 'Fortaleza'
    },
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
