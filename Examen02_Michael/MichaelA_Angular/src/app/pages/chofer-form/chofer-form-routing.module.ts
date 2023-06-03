import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ChoferFormComponent } from './chofer-form.component';

const routes: Routes = [{ path: '', component: ChoferFormComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ChoferFormRoutingModule { }
