import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { VeiculoService } from '../../services/veiculo.service';

@Component({
  selector: 'app-formulario',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.css']
})
export class FormVeiculoComponent implements OnInit {
  formVeiculos = new FormGroup({
    marca: new FormControl(),
    modelo: new FormControl(),
    ano: new FormControl(),
    valor: new FormControl(),
    combustivel: new FormControl(),
  })

  constructor(private service: VeiculoService, private route: ActivatedRoute, private router: Router) { }
  id!:any;
  ngOnInit() {
    //let id:any;
    this.route.queryParams.subscribe(params => {
      this.id = params['id'];
    })
    if(this.id){
      this.service.get(this.id).subscribe({
        next: (data)=>{
          this.formVeiculos.patchValue(data);
          return console.log(data);
        },
        error: (erro)=>{
          return console.log(erro);
        }
      })
    }
  }

  onSubmit() {
    //console.log(this.formVeiculos.value);
    //console.log(date);
    let date = new Date(this.formVeiculos.value.ano).toISOString();

    let data = {
      marca: this.formVeiculos.value.marca,
      modelo: this.formVeiculos.value.modelo,
      ano: date,
      valor: this.formVeiculos.value.valor,
      combustivel: this.formVeiculos.value.combustivel,
    }

    if(this.id){
      this.service.put(this.id, data).subscribe({
        next: ()=>{
          return;
        },
        error: (erro)=>{
          return console.log(erro);
        }
      })
      return;
    }else{
    //this.service.post(this.formVeiculos.value).subscribe({
        this.service.post(data).subscribe({
          next: ()=>{
            return;
          },
          error: (erro)=>{
            return console.log(erro);
          }
        })
      }
  }

}
