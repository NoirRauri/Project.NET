import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialog, MatDialogRef } from '@angular/material/dialog';
import { ToastrService } from 'ngx-toastr';
import { TipoLicencia } from 'src/app/shared/Models/TipoLicencia';
import { LicenciaChoferForms } from 'src/app/shared/Utilities/ProfileForms/LicenciaChofer';
import { TipoLicenciaService } from 'src/app/shared/service/TipoLicencia.service';

@Component({
  selector: 'app-licencia-chofer',
  templateUrl: './licencia-chofer.component.html',
  styleUrls: ['./licencia-chofer.component.css']
})
export class LicenciaChoferComponent {

  tipolicencia: TipoLicencia[];

  constructor(@Inject(MAT_DIALOG_DATA) private Cedula: any,
    private dialogRef: MatDialogRef<LicenciaChoferComponent>,
    private tipolicenciaServ: TipoLicenciaService,
    public licenciaChoferForm: LicenciaChoferForms,
    private msg: ToastrService, private dialog: MatDialog) { }

  ngOnInit() {
    // inicializacion del combo
    this.cargarCombo();
    // carga de la cedula
    this.licenciaChoferForm.baseForm.patchValue({
      IdLicencia: this.Cedula.id
    });
  }

  // carga el combobox de los tipos de licencia
  cargarCombo() {
    this.tipolicenciaServ.getALL().subscribe((datos) => {
      this.tipolicencia = datos
      // console.log(this.tipolicencia)
    }, (err) => {
      this.msg.error(err);
    });
  }

  addLicencia() {
    // agrega los datos de la licencia al form 
    this.licenciaChoferForm.baseForm.patchValue({
      IdLicencia: this.licenciaChoferForm.baseForm.get('IdLicencia')?.value,
      IdTipoLicencia: this.licenciaChoferForm.baseForm.get('IdTipoLicencia')?.value,
      FechaEmicion: this.licenciaChoferForm.baseForm.get('FechaEmicion')?.value,
      FechaVenc: this.licenciaChoferForm.baseForm.get('FechaVenc')?.value
    });
  }

  cerrarDialogo() {
    // se envial los datos del form al cerrar y se resetea el form
    this.dialogRef.close(this.licenciaChoferForm.baseForm.value);
    this.licenciaChoferForm.baseForm.reset(); // Limpiamos el formulario
  }
}
