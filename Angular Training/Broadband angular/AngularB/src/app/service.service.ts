import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable, observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ServiceService {
  readonly APIUrl="https://localhost:44327/api";
  readonly PhotoUrl="https://localhost:44327/Photos/";

  constructor(private http:HttpClient) { }

  getEmpList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Employee');
  }
  addEmployee(val:any)
  {
    return this.http.post(this.APIUrl+'/Employee',val);
  }
  updateEmployee(val:any)
  {
    return this.http.put(this.APIUrl+'/Employee',val);
  }
  deleteEmployee(val:any)
  {
    return this.http.delete(this.APIUrl+'/Employee/'+val);
  }
  getLeadList():Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Lead');
  }
  addLead(val:any)
  {
    return this.http.post(this.APIUrl+'/Lead',val);
  }
  updateLead(val:any)
  {
    return this.http.put(this.APIUrl+'/Lead',val);
  }
  deleteLead(val:any)
  {
    return this.http.delete(this.APIUrl+'/Lead/'+val);
  }
  UploadPhoto(val:any)
  {
    return this.http.post(this.APIUrl+'/Employee/SaveFile',val);
  }
}
