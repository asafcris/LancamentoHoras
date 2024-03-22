import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProjetoTableComponent } from './pages/produto/table/projeto-table.component';

const routes: Routes = [
{
  path: 'projeto',component:ProjetoTableComponent
}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
