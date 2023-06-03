import { Injectable } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";

@Injectable({ providedIn: 'root' })

export class LicenciaChoferForms {
    baseForm: FormGroup;
    constructor(private fb: FormBuilder) {
        this.baseForm = this.fb.group({

            IdLicencia: ['', [Validators.required, Validators.maxLength(12), Validators.minLength(9)]],

            IdTipoLicencia: ['', [Validators.required, Validators.maxLength(12)]],

            FechaEmicion: ['', [Validators.required]],

            FechaVenc: ['', [Validators.required]]
        });
    }
}