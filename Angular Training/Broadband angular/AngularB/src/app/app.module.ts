import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import{RouterModule, Routes} from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { LeadComponent } from './lead/lead.component';
import { EmployeeComponent } from './employee/employee.component';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { AddEditEmpComponent } from './employee/add-edit-emp/add-edit-emp.component';
import { ShowEmpComponent } from './employee/show-emp/show-emp.component';
import { ServiceService } from './service.service';
import { AddEditLeadComponent } from './Lead/add-edit-lead/add-edit-lead.component';
import { ShowLeadComponent } from './Lead/show-lead/show-lead.component';
import { Ng2SearchPipeModule } from 'ng2-search-filter';



@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomeComponent,
    LeadComponent,
    EmployeeComponent,
    AddEditEmpComponent,
    ShowEmpComponent,
    AddEditLeadComponent,
    ShowLeadComponent,
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule, 
    RouterModule,
    Ng2SearchPipeModule
  
 
  ],

  providers: [ServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
