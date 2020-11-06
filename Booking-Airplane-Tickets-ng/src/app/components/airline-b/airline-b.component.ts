import { Component, OnInit, TemplateRef } from '@angular/core';
import { AirLines, TicketDtoModel } from 'src/app/models/ticket-model';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AirlineBService } from 'src/app/services/airline-b.service';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-airline-b',
  templateUrl: './airline-b.component.html',
  styleUrls: ['./airline-b.component.css']
})

export class AirlineBComponent implements OnInit {

  modalRef: BsModalRef

  tickets: any;

  requestForm = new FormGroup({
    airLine: new FormControl('', Validators.required),
    firstName: new FormControl('', Validators.required),
    lastName: new FormControl('', Validators.required),
    dateOfBirth: new FormControl('', Validators.required),
    passportNo: new FormControl('', Validators.required),
    loyalMemberId: new FormControl(''),
    useLoyalMemberCredits: new FormControl(''),
    origin: new FormControl('', Validators.required),
    destination: new FormControl('', Validators.required),
    departure: new FormControl('', Validators.required),
    return: new FormControl(''),
    freeCarryOnBag: new FormControl('', Validators.required),
    checkedInBag: new FormControl('', Validators.required),
  })

  constructor(private airlineBService: AirlineBService,
    private modalService: BsModalService) { }

  ngOnInit(): void {
  }

  addTicket() {
    let requestModel = new TicketDtoModel()

    requestModel.airLine = AirLines.airLine_B
    requestModel.firstName = this.requestForm.value.firstName
    requestModel.lastName = this.requestForm.value.lastName
    requestModel.dateOfBirth = this.requestForm.value.dateOfBirth
    requestModel.passportNo = this.requestForm.value.passportNo
    requestModel.loyalMemberId = this.requestForm.value.loyalMemberId
    requestModel.useLoyalMemberCredits = this.requestForm.value.useLoyalMemberCredits
    requestModel.origin = this.requestForm.value.origin
    requestModel.destination = this.requestForm.value.destination
    requestModel.departure = this.requestForm.value.departure
    requestModel.return = this.requestForm.value.return
    requestModel.freeCarryOnBag = this.requestForm.value.freeCarryOnBag
    requestModel.checkedInBag = this.requestForm.value.checkedInBag

    this.airlineBService.addTicket(requestModel).subscribe({
      error: err => console.error(err),
      complete: () => {
        this.closeModal()
        this.getAllTickets()
      }
    })
  }


  getAllTickets() {
    this.airlineBService.getAllTickets().subscribe({
      next: res => {
        this.tickets = res
      }
    })
  }


  deleteTicket(ticketId: number) {
    this.airlineBService.deleteTicket(ticketId).subscribe({
      error: err => console.error(err),
      complete: () => {
        this.getAllTickets()
      }
    })
  }

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template)
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