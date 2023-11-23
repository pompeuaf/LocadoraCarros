import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { PessoaComponent } from './pessoa/pessoa.component';
import { FormPessoaComponent } from './pessoa/formulario/formulario.component';
import { HomeComponent } from './home/home.component';
import { NavbarComponent } from './navbar/navbar.component';
import { FooterComponent } from './footer/footer.component';
import { LoginComponent } from './login/login.component';
import { VeiculoComponent } from './veiculo/veiculo.component';
import { FormVeiculoComponent } from './veiculo/formulario/formulario.component';
import { FaturamentoComponent } from './faturamento/faturamento.component';
import { PedidoComponent } from './pedido/pedido.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    PessoaComponent,
    FormPessoaComponent,
    VeiculoComponent,
    FormVeiculoComponent,
    HomeComponent,
    NavbarComponent,
    FooterComponent,
    LoginComponent,
    VeiculoComponent,
    FaturamentoComponent,
    PedidoComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
