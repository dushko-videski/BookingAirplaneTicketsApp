import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})

export class AirlineBService {

  serverUrl = environment.apiServer

  constructor(private http: HttpClient) { }






  
  getAllTickets(){
    let url = `${this.serverUrl}/tickets?airline=airline_b`;
    return this.http.get(url);
  }
  


}
