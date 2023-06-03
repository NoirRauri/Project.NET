import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ChoferFormRoutingModule } from './chofer-form-routing.module';
import { ChoferFormComponent } from './chofer-form.component';
import { LicenciaChoferComponent } from './licencia-chofer/licencia-chofer.component';
import { MaterialModule } from 'src/app/material.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    ChoferFormComponent,
    LicenciaChoferComponent
  ],
  imports: [
    CommonModule,
    ChoferFormRoutingModule,
    MaterialModule,
    ReactiveFormsModule,
    FormsModule
  ]
})
export class ChoferFormModule { }
