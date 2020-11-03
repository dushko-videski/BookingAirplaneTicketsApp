import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  btnClickA= function () {
    this.router.navigateByUrl('airline-a');
  };

  btnClickB= function () {
    this.router.navigateByUrl('airline-b');
  };
}
