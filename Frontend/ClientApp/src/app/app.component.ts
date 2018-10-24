import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  fortsSymbols: any[];
  constructor(http: Http) {
    http.get('https://jsonplaceholder.typicode.com/posts').subscribe(response => {
      this.fortsSymbols = response.json();
      console.log(this.fortsSymbols);
    })
   
  }
  title = 'ClientApp';
}
