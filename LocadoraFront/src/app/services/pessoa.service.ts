import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PessoaService {

  apiUrl:string = 'http://localhost/api/pessoas';
  constructor(private http: HttpClient) {}

  get (id?:number): Observable<any>{
    if(id){
      return this.http.get(`${this.apiUrl}/${id}`);
    }
    return this.http.get(this.apiUrl);
  }
  post (Pessoas:any): Observable<any>{
    return this.http.post(this.apiUrl, Pessoas);
  }
  put (id:number, Pessoas:any): Observable<any>{
    return this.http.put(`${this.apiUrl}/${id}`, Pessoas);
  }
  delete (id:any): Observable<any>{
    return this.http.delete(`${this.apiUrl}/${id}`);
  }

}
