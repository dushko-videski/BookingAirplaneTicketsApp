import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})


export class AirlineAService {

  serverUrl = environment.apiServer

  constructor(private http: HttpClient) { }

  addTicket(request: any) : Observable<any>{
    let url = `${this.serverUrl}/ticket/new`;
    return this.http.post<any>(url, request)
  }
  
}
