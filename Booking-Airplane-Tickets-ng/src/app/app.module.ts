import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';

import { HomeComponent } from './components/home/home.component';
import { AirlineAComponent } from './components/airline-a/airline-a.component';
import { AirlineBComponent } from './components/airline-b/airline-b.component';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { AirlineAService } from './services/airline-a.service';
import { AirlineBService } from './services/airline-b.service';

import { ReactiveFormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';
import { MapUseLoyalMemberCreditsPipe } from './pipes/map-use-loyal-member-credits.pipe';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    AirlineAComponent,
    AirlineBComponent,
    FooterComponent,
    MapUseLoyalMemberCreditsPipe
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    ReactiveFormsModule,
    ModalModule.forRoot(),
  ],
  providers: [
    AirlineAService,
    AirlineBService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
