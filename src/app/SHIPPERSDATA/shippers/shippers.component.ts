import { Component, OnInit } from '@angular/core';
import { ShippersService } from '../service/shippers.service';
import { shipper } from '../model/shipper.interface';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
  
@Component({
  selector: 'app-shippers',
  templateUrl: './shippers.component.html',
  styleUrls: ['./shippers.component.scss']
})
export class ShippersComponent implements OnInit {
  campo: string = '';
  campo2: string = '';
  public miFormulario!: FormGroup;
  public shipp: shipper[] = [];
  constructor(private ss: ShippersService,private formBuilder: FormBuilder) { }
  personaSeleccionada!: shipper;
  ngOnInit(): void 
  {
    this.miFormulario = this.formBuilder.group({
      shipperid: ['', Validators.required],
      companyname: ['', Validators.required],
      phone: ['', Validators.required]
  })
  
   

    this.ss.listarShippers().subscribe(
      res => {(this.shipp = res)},
    );


  }
  saveNew(){

    if(this.campo === '' && this.campo2 === ''){
      alert('rellene los campos por favor');
    }
    else{
      const datos: shipper = this.miFormulario.value;
      this.ss.insertarShipper(datos).subscribe();
      location.reload();
      alert('Insert exitoso');
    }
  }
 
  editarshipper(shipper: shipper) {
    this.personaSeleccionada = shipper;
    this.miFormulario.patchValue({
      shipperid: shipper.ShippersID,
      companyname: shipper.CompanyName,
      phone: shipper.Phone
    });
    

  }
  
  updateshipper(): void{
    const datos: shipper = this.miFormulario.value;
    this.ss.updateshipper(datos).subscribe(s => {
      const indextoupdate = s
      ? this.shipp.findIndex(c=> c.ShippersID == s.ShippersID)
      : -1;
      if(indextoupdate >-1){
        this.shipp[indextoupdate] = s
      }
    });
    location.reload();
    alert('Editado exitosamente');
  }
onDeleteship(s:shipper):void {
  confirm('Esta seguro de borrar ?');
  if(confirm('Segurisimo?'))
  {
    this.ss.deleteshipper(s).subscribe();
    alert('Borrado exitosamente');
    location.reload();
  }


}

}
