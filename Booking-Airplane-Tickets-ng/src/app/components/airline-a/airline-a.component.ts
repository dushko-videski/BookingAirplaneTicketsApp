import { Component, OnInit } from '@angular/core';
import { AirlineAService } from './../../services/airline-a.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-airline-a',
  templateUrl: './airline-a.component.html',
  styleUrls: ['./airline-a.component.css']
})
export class AirlineAComponent implements OnInit {

  constructor(
    private airlineAService: AirlineAService) { }
  

  ngOnInit(): void {
    this.addTicket()
 }

  addTicket(){
  let requestModel = {
      // AirLine : 2,
      // FirstName : "from Ng",
      // LastName : "from Ng",
      // DateOfBirth : "1988, 01, 22",
      // PassportNo : "B25645486",
      // LoyalMemberId : 123,
      // UseLoyalMemberCredits : true,
      // Origin : "Nis",
      // Destination : "Paris",
      // Departure : "2020, 07, 1",
      // Return : "2020, 05, 12",
      // FreeCarryOnBag : 1,
      // CheckedInBag : 2
      }
      this.airlineAService.addTicket(requestModel).subscribe({
        error: err => console.warn(err.error)
      })
  }





}
