import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { TicketDtoModel } from './../models/ticket-model';

@Injectable({
  providedIn: 'root'
})

export class AirlineBService {

  serverUrl = environment.apiServer

  constructor(private http: HttpClient) { }


  addTicket(request: TicketDtoModel) : Observable<any>{
    let url = `${this.serverUrl}/ticket/new`
    return this.http.post<any>(url, request)
  }


  getAllTickets(){
    let url = `${this.serverUrl}/tickets?airline=airline_b`;
    return this.http.get(url);
  }

  
  deleteTicket(ticketId: number){
    let url = `${this.serverUrl}/ticket/delete?ticketId=${ticketId}`
    return this.http.delete(url)
  }
  
}
