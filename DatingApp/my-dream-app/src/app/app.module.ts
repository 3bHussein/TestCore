import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
// new lib
  // create http Request 24/08/2021

import {HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
      // create http Request 24/08/2021

    HttpClientModule
  ],

  providers: [],
  bootstrap: [AppComponent]

})
export class AppModule { }
