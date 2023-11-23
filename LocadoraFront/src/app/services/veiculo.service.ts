import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class VeiculoService {

  apiUrl:string = 'http://localhost/api/veiculos';
  constructor(private http: HttpClient) {}

  get (id?:number): Observable<any>{
    if(id){
      return this.http.get(`${this.apiUrl}/${id}`);
    }
    return this.http.get(this.apiUrl);
  }
  post (Veiculos:any): Observable<any>{
    return this.http.post(this.apiUrl, Veiculos);
  }
  put (id:number, Veiculos:any): Observable<any>{
    return this.http.put(`${this.apiUrl}/${id}`, Veiculos);
  }
  delete (id:any): Observable<any>{
    return this.http.delete(`${this.apiUrl}/${id}`);
  }

}
