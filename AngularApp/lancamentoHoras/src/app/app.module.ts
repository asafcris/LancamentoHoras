import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProjetoService } from './shared/service/projeto-service';
import { ProjetoTableComponent } from './pages/produto/table/projeto-table.component';
import { ProjetoModalComponent } from './pages/produto/modal/projeto-modal.component';

@NgModule({
  declarations: [
    AppComponent,
    ProjetoTableComponent,
    ProjetoModalComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    ProjetoService,
    provideClientHydration()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
