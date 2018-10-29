import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
@Component({
  selector: 'app-left-bar',
  templateUrl: './left-bar.component.html',
  styleUrls: ['./left-bar.component.css']
})
export class LeftBarComponent  {
  fortsSymbols: any[];
  constructor(http: Http) {
    http.get('https://testtaskaionys.azurewebsites.net/api/ClientsApi').subscribe(response => {
      this.fortsSymbols = response.json();
     // console.log(this.fortsSymbols);
    })
  }
}