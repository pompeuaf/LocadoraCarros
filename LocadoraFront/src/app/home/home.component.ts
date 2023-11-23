import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { VeiculoService } from '../services/veiculo.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})

export class HomeComponent implements OnInit {
  formHome = new FormGroup({
    marca: new FormControl(),
    modelo: new FormControl(),
    ano: new FormControl(),
    valor: new FormControl(),
    combustivel: new FormControl(),
  })

  constructor(private service: VeiculoService, private router: Router, private route: ActivatedRoute,) { }
  Veiculos:any
  ngOnInit() {
    this.service.get().subscribe(dados => this.Veiculos = dados);
  }

}
