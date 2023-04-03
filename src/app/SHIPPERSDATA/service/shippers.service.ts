import { HttpClient,HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { shipper } from '../model/shipper.interface';

@Injectable({
  providedIn: 'root'
})
export class ShippersService {
  private endpoint = 'api/Values'
  constructor(private htpp: HttpClient) {}

  listarShippers() : Observable<shipper[]>{
    const headers = { 'Content-Type': 'application/json' };
  return this.htpp.get<shipper[]>(environment.Shippers + this.endpoint,{headers})    
  }
 
  insertarShipper(ship: shipper): Observable<shipper>{
    const headers = { 'Content-Type': 'application/json' };
   return this.htpp.post<shipper>(environment.Shippers + this.endpoint,ship,{headers});
  }

  updateshipper(ship: shipper): Observable<shipper>{
    const headers = { 'Content-Type': 'application/json' };
   return this.htpp.put<shipper>(environment.Shippers + this.endpoint,ship,{headers});
  }

  deleteshipper(s:shipper): Observable<{}>{
    const opciones = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Access-Control-Allow-Origin': '*'
      })
    };
   return this.htpp.delete(environment.Shippers + this.endpoint+'/'+s.ShippersID,opciones);
  }

}


