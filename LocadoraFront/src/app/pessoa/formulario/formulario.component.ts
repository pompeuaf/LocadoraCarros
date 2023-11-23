import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { ActivatedRoute, Router } from '@angular/router';
import { PessoaService } from 'src/app/services/pessoa.service';

@Component({
  selector: 'app-formulario',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.css']
})
export class FormPessoaComponent implements OnInit {
  formPessoas = new FormGroup({
    id: new FormControl(''),
    pessoa: new FormControl('', Validators.required),
    email: new FormControl('', Validators.email),
    telefone: new FormControl('', Validators.required),
    cpfcnpj: new FormControl('', Validators.maxLength(11)),
  })

  constructor(private service: PessoaService, private route: ActivatedRoute, private router: Router) { }
  id!:any;
  ngOnInit() {
    //let id:any;
    this.route.queryParams.subscribe(params => {
      this.id = params['id'];
    })
    if(this.id){
      this.service.get(this.id).subscribe({
        next: (data)=>{
          this.formPessoas.patchValue(data);
          return console.log(data);
        },
        error: (erro)=>{
          return console.log(erro);
        }
      })
    }else{
      this.id = 0;
      this.formPessoas.controls['id'].patchValue(this.id);
    }
  }

  onSubmit() {
    //console.log(this.formVeiculos.value);
    //console.log(date);
    //let date = new Date(this.formPessoas.value.ano).toISOString();

    let data = {
      id: this.formPessoas.value.id,
      pessoa: this.formPessoas.value.pessoa,
      email: this.formPessoas.value.email,
      telefone: this.formPessoas.value.telefone,
      cpfcnpj: this.formPessoas.value.cpfcnpj,
    }

    if(this.id){
      this.service.post(data).subscribe({
        next: ()=>{
          this.router.navigate(['/pessoa'])
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
            this.router.navigate(['/pessoa'])
            return;
          },
          error: (erro)=>{
            return console.log(erro);
          }
        })
      }
  }
}
