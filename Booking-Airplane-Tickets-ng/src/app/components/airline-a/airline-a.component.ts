import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { AirLines, TicketDtoModel } from './../../models/ticket-model';
import { AirlineAService } from './../../services/airline-a.service';

@Component({
  selector: 'app-airline-a',
  templateUrl: './airline-a.component.html',
  styleUrls: ['./airline-a.component.css']
})

export class AirlineAComponent implements OnInit {

  modalRef: BsModalRef;

  tickets: any;

  requestForm = new FormGroup({
    airLine: new FormControl('', Validators.required),
    firstName: new FormControl('', Validators.required),
    lastName: new FormControl('', Validators.required),
    dateOfBirth: new FormControl('', Validators.required),
    passportNo: new FormControl('', Validators.required),
    origin: new FormControl('', Validators.required),
    destination: new FormControl('', Validators.required),
    departure: new FormControl('', Validators.required),
    return: new FormControl(''),
    freeCarryOnBag: new FormControl('', Validators.required),
    trolleyBag: new FormControl('', Validators.required),
    checkedInBag: new FormControl('', Validators.required),
  })


  constructor(private airlineAService: AirlineAService,
    private modalService: BsModalService) { }

  ngOnInit(): void {
  }

  addTicket() {
    let requestModel = new TicketDtoModel();

    requestModel.airLine = AirLines.airLine_A
    requestModel.firstName = this.requestForm.value.firstName
    requestModel.lastName = this.requestForm.value.lastName
    requestModel.dateOfBirth = this.requestForm.value.dateOfBirth
    requestModel.passportNo = this.requestForm.value.passportNo
    requestModel.origin = this.requestForm.value.origin
    requestModel.destination = this.requestForm.value.destination
    requestModel.departure = this.requestForm.value.departure
    requestModel.return = this.requestForm.value.return
    requestModel.freeCarryOnBag = this.requestForm.value.freeCarryOnBag
    requestModel.trolleyBag = this.requestForm.value.trolleyBag
    requestModel.checkedInBag = this.requestForm.value.checkedInBag

    this.airlineAService.addTicket(requestModel).subscribe({
      error: err => console.warn(err.error),
      complete: () => {
        this.closeModal()
        this.getAllTickets()
      }
    })
  }


  getAllTickets() {
    this.airlineAService.getAllTickets().subscribe({
      next: res => {
        this.tickets = res
      }
    })
  }


  deleteTicket(ticketId: number) {
    this.airlineAService.deleteTicket(ticketId).subscribe({
      error: err => console.warn(err.error),
      complete: () => {
        this.getAllTickets()
      }
    })
  }


  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  closeModal() {
    this.modalService._hideModal()
    this.modalService._hideBackdrop()
    this.requestForm.reset()
  }

  resetForm() {
    this.requestForm.reset()
  }


}
