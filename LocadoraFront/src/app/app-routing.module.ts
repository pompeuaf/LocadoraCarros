import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PessoaComponent } from './pessoa/pessoa.component';
import { FormPessoaComponent} from './pessoa/formulario/formulario.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { FormVeiculoComponent } from './veiculo/formulario/formulario.component';
import { VeiculoComponent } from './veiculo/veiculo.component';
import { FaturamentoComponent } from './faturamento/faturamento.component';
import { PedidoComponent } from './pedido/pedido.component';

const routes: Routes = [
  {
    path: 'pessoa',
    component: PessoaComponent,
  },
  {
  path: 'pessoa/formulario',
      component: FormPessoaComponent,
    },
  {
    path: 'veiculo',
    component: VeiculoComponent,
  },
  {
    path: 'veiculo/formulario',
    component: FormVeiculoComponent,
  },
  {
    path: 'pedido',
    component: PedidoComponent,
  },
  {
    path: 'faturamento',
    component: FaturamentoComponent,
  },
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: '',
    redirectTo: '/login',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
