import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ShipperModule } from './SHIPPERSDATA/shipper.module';
@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ShipperModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
