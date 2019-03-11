import { Component } from '@angular/core';
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})


import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
@NgModule({
...
imports: [BrowserAnimationsModule],
...
})


export class AppComponent {
  title = 'NYTimesApi';
  

  value = {};

  constructor(){}

  ngOnInit(){

  }

  getValues(){

    this.http.get('http://localhost:4200/api/values').subscribe
                 ( response => this.value = response.json());
  }


  public NYTimes{

      get{

          return NYTimes.Current;
      }
  }




}
