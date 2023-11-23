import { Component, OnInit } from '@angular/core';
import { PessoaService } from '../services/pessoa.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-pessoa',
  templateUrl: './pessoa.component.html',
  styleUrls: ['./pessoa.component.css']
})
export class PessoaComponent implements OnInit {

  constructor(private service: PessoaService, private router: Router, private route: ActivatedRoute,) { }
  Pessoas:any
  ngOnInit() {
    this.service.get().subscribe(dados => this.Pessoas = dados);
  }

  editar(id:number){
    this.router.navigate(['/pessoa/formulario'], {relativeTo: this.route, queryParams: {id: id}});
  }
  excluir(id:number){
    this.service.delete(id).subscribe();
    window.location.reload();
  }



}
