import { Component } from '@angular/core';
import { FormArray, FormBuilder } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { ToastrService } from 'ngx-toastr';
import { ChoferForms } from 'src/app/shared/Utilities/ProfileForms/ChoferProfile';
import { LicenciaChoferForms } from 'src/app/shared/Utilities/ProfileForms/LicenciaChofer';
import { LicenciaChoferComponent } from './licencia-chofer/licencia-chofer.component';
import { ChoferService } from 'src/app/shared/service/Chofer.service';
import { LicenciaChofer } from 'src/app/shared/Models/LicenciaChofer';

@Component({
  selector: 'app-chofer-form',
  templateUrl: './chofer-form.component.html',
  styleUrls: ['./chofer-form.component.css']
})
export class ChoferFormComponent {

  displayedColumns: string[] = ['tipoLicencia', 'fechaEmision', 'fechaVenc'];
  dataSource = new MatTableDataSource<any>([]);

  constructor(
    private choferService: ChoferService,
    private fb: FormBuilder,
    public choferForm: ChoferForms,
    public licenciaChoferForm: LicenciaChoferForms,
    private dialog: MatDialog,
    private msg: ToastrService
  ) { }

  ngOnInit() {
    this.cargarChofer()
    this.cargarlista()
  }

  openModal() {
    let dialogProd = this.dialog.open(LicenciaChoferComponent, {
      maxHeight: "500px",
      width: '500px',
      disableClose: true,
      data: { id: this.choferForm.baseForm.get('Cedula')?.value }
    })
    dialogProd.afterClosed().subscribe((datos?: LicenciaChofer) => {
      if (datos != null) {
        // variable de la fechas para validar 
        const fechaEmicion = new Date(datos.FechaEmicion);
        const fechaVenc = new Date(datos.FechaVenc);

        // Busca la licencia en la lista del choferForm, verifica si exite
        const licenciaExiste = this.TbLicenciaChofers.controls.find(control => control.get('IdTipoLicencia')?.value === datos.IdTipoLicencia);

        // valida si la fecha es menos o igual a la fecha 
        if (fechaEmicion.getTime() >= fechaVenc.getTime() || datos.FechaEmicion?.toString() == '' || datos.FechaVenc?.toString() == '') {
          this.msg.error('Fecha incorrects!', 'Las fecha no encajas o falta alguna!')
        } else if (datos.IdTipoLicencia == '' || datos.IdTipoLicencia == null) {
          this.msg.error('Sin dato!', 'No Ingresaste el Tipo de licencia!')
        } else if (!licenciaExiste) {
          // si no existe se ingresa al array
          const TbLicenciaChofers = this.fb.group(datos)
          this.TbLicenciaChofers.push(TbLicenciaChofers);
          this.cargarlista()
        } else {
          this.msg.error('Error!', 'La licencia ya existe!')
        }
      }
    });
  }

  // carga el form en blanco
  cargarChofer() {
    this.choferForm.baseForm.patchValue({
      Cedula: '',
      Nombre: '',
      Apellido1: '',
      Apellido2: '',
      TbLicenciaChofers: []
    })
  }

  //metodo para obtener array licencia
  get TbLicenciaChofers() {
    return this.choferForm.baseForm.get('TbLicenciaChofers') as FormArray;
  }

  // Cargamos una copia del array en la tabla dataSource solo para mostrar
  cargarlista() {
    this.dataSource.data = this.choferForm.baseForm.get('TbLicenciaChofers')?.value;
  }

  // se conecta con se servicio para guardar
  guardarChofer() {
    if (this.choferForm.baseForm.valid) {
      console.log(this.choferForm.baseForm.value)
      this.choferService.guardar(this.choferForm.baseForm.value).subscribe(() => {
        // console.log("guardo")
        this.msg.success('Succefull!', 'El Chofer se guardo correctamente!');
      }, (err) => {
        this.msg.error(err);
      });
      this.limpiarForm()
    }
  }

  limpiarForm(): void {
    this.choferForm.baseForm.reset(); // Reseteamos el formulario
    this.TbLicenciaChofers.clear(); // Eliminamos todos los elementos del FormArray
    this.cargarlista(); // Actualizamos el dataSource con la lista vacía
    this.dataSource.data = []; // Asignamos un arreglo vacío al método data de MatTableDataSource
  }
}

