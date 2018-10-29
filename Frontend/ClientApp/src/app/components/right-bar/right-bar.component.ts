import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { HttpClient } from 'selenium-webdriver/http';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
@Component({
  selector: 'app-right-bar',
  templateUrl: './right-bar.component.html',
  styleUrls: ['./right-bar.component.css']
})
export class RightBarComponent {

  Cities: any[];
  ClientName :any[];
  TaskClient :any[]= new Array();
 


constructor(private http: Http){
  this.http.get('https://testtaskaionys.azurewebsites.net/api/ClientTasksApi').subscribe(response => {

       this.Cities = response.json();
       this.TaskClient=response.json();
      });
  http.get('https://testtaskaionys.azurewebsites.net/api/ClientsApi').subscribe(response => {
        this.ClientName = response.json();
       
        
});
}


selectChangeHandlerCities(cities:any){
  this.TaskClient=new Array();
  for (let task of this.Cities) {
    if(task.clientAddress==cities.target.value){
    console.log(task);
    this.TaskClient.push(task);
    }
}
}

selectChangeHandlerName(name:any){
  this.TaskClient=new Array();
  for (let client of this.ClientName) {
    if(client.firstName==name.target.value){
      for (let task of this.Cities) {
    if(task.clientsId==client.id){
    console.log(task);
    this.TaskClient.push(task);
    }
    }
  }
}
}

//показать список задач клиетов 
  Show(){
    this.http.get('https://testtaskaionys.azurewebsites.net/api/ClientTasksApi').subscribe(response => {
       this.TaskClient = response.json();
    
     })}

  
DeleteTask(id){
	this.http.delete("https://testtaskaionys.azurewebsites.net/api/ClientTasksApi/"+(id)).subscribe(response => {
    console.log("Delete");
    this.Show();
  })}

}


