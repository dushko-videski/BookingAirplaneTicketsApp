import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AirlineAComponent } from './components/airline-a/airline-a.component';
import { AirlineBComponent } from './components/airline-b/airline-b.component';
import { HomeComponent } from './components/home/home.component';

const routes: Routes = [
    { path:'', redirectTo:'/home', pathMatch:'full' },
    { path:'home', component: HomeComponent },
    { path:'airline-a', component: AirlineAComponent },
    { path:'airline-b', component: AirlineBComponent },
]

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }