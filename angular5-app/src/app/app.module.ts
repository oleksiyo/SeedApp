import { BrowserModule  } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MatButtonModule, MatCheckboxModule } from '@angular/material';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSidenavModule } from '@angular/material/sidenav';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './layout/app.component/app.component';
import { AppRoutingModule } from './app-routing.module';
import { HeadComponent } from './layout/head.component/head.component';
import { LeftPanelComponent } from './layout/left-panel.component/left-panel.component';


@NgModule({
  declarations: [
    AppComponent,
    HeadComponent,
    LeftPanelComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatCheckboxModule,
    MatInputModule,
    MatFormFieldModule,
    MatSidenavModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
