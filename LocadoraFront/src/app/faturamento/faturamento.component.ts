import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-faturamento',
  templateUrl: './faturamento.component.html',
  styleUrls: ['./faturamento.component.css']
})
export class FaturamentoComponent {
  formFaturamento = new FormGroup({
    nome: new FormControl('', Validators.required),
    veiculo: new FormControl(''),
    datalocacao: new FormControl('', Validators.required),
    dataretirada: new FormControl('', Validators.maxLength(11)),
    datadevolucao: new FormControl('', Validators.maxLength(11)),
    formapagamento: new FormControl('', Validators.maxLength(11)),
    valor: new FormControl('', Validators.maxLength(11)),
  })

  constructor() { }


  ngOnInit() {
  }

  onSubmit() {
    console.log(this.formFaturamento.value);
  }

}
