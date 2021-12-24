import { Component, Input, OnInit } from '@angular/core';
import { ServiceService } from 'src/app/service.service';

@Component({
  selector: 'app-add-edit-lead',
  templateUrl: './add-edit-lead.component.html',
  styleUrls: ['./add-edit-lead.component.css']
})
export class AddEditLeadComponent implements OnInit {

  constructor(private service:ServiceService) { }

  @Input() lead:any;
  LeadId:string|undefined;
  Name:string|undefined;
  City:string|undefined;
  State:string|undefined;
  Gender:string|undefined;
  PhoneNo:string|undefined;
  Remark:string|undefined;
  CreatedBy:string|undefined;
  Status:string|undefined;

  ngOnInit(): void {
    this.LeadId=this.lead.LeadId;
    this.Name=this.lead.Name;
    this.City=this.lead.City;
    this.State=this.lead.State;
    this.Gender=this.lead.Gender;
    this.PhoneNo=this.lead.PhoneNo;
    this.Remark=this.lead.Remark;
    this.CreatedBy=this.lead.CreatedBy;
    this.Status=this.lead.Status;
  }

  addLead()
  {
    var val={
      LeadId:this.LeadId,
      Name:this.Name,
      City:this.City,
      State:this.State,
      Gender:this.Gender,
      PhoneNo:this.PhoneNo,
      Remark:this.Remark,
      CreatedBy:this.CreatedBy,
      Status:this.Status

    };
    this.service.addLead(val).subscribe(res=>{alert(res.toString());});

  }

  updateLead()
  {
    var val={
      LeadId:this.LeadId,
      Name:this.Name,
      City:this.City,
      State:this.State,
      Gender:this.Gender,
      PhoneNo:this.PhoneNo,
      Remark:this.Remark,
      CreatedBy:this.CreatedBy,
      Status:this.Status

    };
    this.service.updateLead(val).subscribe(res=>{alert(res.toString());});
  }

}

