import { Injectable } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";

@Injectable({ providedIn: 'root' })

export class ChoferForms {
    baseForm: FormGroup;
    constructor(private fb: FormBuilder) {
        this.baseForm = this.fb.group({
            Cedula: ['', [Validators.required, Validators.maxLength(12), Validators.minLength(9)]],

            Nombre: ['', [Validators.required, Validators.maxLength(12)]],

            Apellido1: ['', [Validators.required, Validators.maxLength(12)]],

            Apellido2: ['', [Validators.required, Validators.maxLength(12)]],

            TbLicenciaChofers: this.fb.array([])
        });
    }
}