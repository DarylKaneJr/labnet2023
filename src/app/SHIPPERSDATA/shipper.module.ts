import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { ShippersComponent } from './shippers/shippers.component';
import { HttpClientModule} from '@angular/common/http';

@NgModule({
  declarations: [
    ShippersComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    HttpClientModule,
    CommonModule

  ]
})
export class ShipperModule { }
