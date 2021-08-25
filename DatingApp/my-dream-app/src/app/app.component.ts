import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
// import { url } from 'inspector';

@Component({
  selector: 'app-boo',
  templateUrl: './app.component.html',
  // templateUrl: './app.component copy.html',

  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit  {
  // title = 'my-dream-app';
    title = 'Dating App';
  // create http Request 24/08/2021
    users:any;

  constructor(private http: HttpClient){}
        ngOnInit()   {
        this.getuser()
        }
        //#region  Create GetUser
        getuser(){
        this.http.get('https://localhost:5001/users').subscribe(Response =>{
        this.users =Response;
        },error=>{
        console.log(error);
        })

        }
        //#endregion
   
}
