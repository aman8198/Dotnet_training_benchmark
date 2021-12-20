import { Component, OnInit } from '@angular/core';
import { ServiceService } from 'src/app/service.service';

@Component({
  selector: 'app-show-dep',
  templateUrl: './show-dep.component.html',
  styleUrls: ['./show-dep.component.css']
})
export class ShowDepComponent implements OnInit {

  constructor(private service:ServiceService) { }

  DepartmentList:any=[];

   ModalTitle:string | undefined;
  
  ActivateAddEditDepComp:boolean=false;
  dep:any;


  ngOnInit(): void {
    this.refreshDepList();
  }

  addClick()
  {
    this.dep={
      DepartmentId:0,
      DepartmentName:""
    }
    this.ModalTitle="Add Department";
    this.ActivateAddEditDepComp=true;



  }
  editClick(item: any)
  {
    this.dep=item;
    this.ModalTitle="Edit Department";
    this.ActivateAddEditDepComp=true;
  }
  deleteClick(item:any)
  {
    if(confirm('Are You Sure?'))
    {
      this.service.deleteDepartment(item.DepartmentId).subscribe(data=>{
        alert(data.toString());
        this.refreshDepList();
      })
    }

  }

  closeClick()
  {
    this.ActivateAddEditDepComp=false;
    this.refreshDepList();
  }
   
  
  refreshDepList()
  {
    this.service.getDepList().subscribe(data=>{
        this.DepartmentList=data;
    });
  }
}
