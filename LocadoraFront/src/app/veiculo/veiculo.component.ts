import { Component, OnInit } from '@angular/core';
import { VeiculoService } from '../services/veiculo.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-veiculo',
  templateUrl: './veiculo.component.html',
  styleUrls: ['./veiculo.component.css']
})
export class VeiculoComponent implements OnInit {

  constructor(private service: VeiculoService, private router: Router, private route: ActivatedRoute,) { }
  Veiculos:any
  ngOnInit() {
    this.service.get().subscribe(dados => this.Veiculos = dados);
  }

  editar(id:number){
    this.router.navigate(['/veiculo/formulario'], {relativeTo: this.route, queryParams: {id: id}});
  }
  excluir(id:number){
    this.service.delete(id).subscribe();
    window.location.reload();
  }

}
