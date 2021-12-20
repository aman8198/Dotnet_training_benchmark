import { Component, Input, OnInit } from '@angular/core';
import { ServiceService } from 'src/app/service.service';

@Component({
  selector: 'app-add-edit-dep',
  templateUrl: './add-edit-dep.component.html',
  styleUrls: ['./add-edit-dep.component.css']
})
export class AddEditDepComponent implements OnInit {

  constructor(private service:ServiceService) { }
  @Input() dep:any;
  DepartmentId:string | undefined;
  DepartmentName:string | undefined;

  
  

  ngOnInit(): void {
    this.DepartmentId=this.dep.DepartmentId;
    this.DepartmentName=this.dep.DepartmentName;
  }

  addDepartment()
  {
    var val = {DepartmentId:this.DepartmentId,
               DepartmentName:this.DepartmentName};
   this.service.addDepartment(val).subscribe(res=>{alert(res.toString());});

  }

  updateDepartment()
  {  var val = {DepartmentId:this.DepartmentId,
    DepartmentName:this.DepartmentName};
this.service.updateDepartment(val).subscribe(res=>{alert(res.toString());});


  }

}
