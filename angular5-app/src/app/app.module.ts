import { BrowserModule  } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MatButtonModule, MatCheckboxModule } from '@angular/material';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSidenavModule } from '@angular/material/sidenav';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { HeadComponent } from './layout/head.component/head.component';
import { LeftPanelComponent } from './layout/left-panel.component/left-panel.component';
import { LoginComponent } from './components/login.component/login.component';
import { AppComponent } from './layout/app.component/app.component';
import { DashboardComponent } from './components/dashboard.component/dashboard.component';
import { Helpers } from './helpers/helpers';
import { AppConfig } from '../config/config';
import { BaseService } from './services/base.service';
import { HttpClientModule } from '@angular/common/http';
import { TokenService } from './services/token.service';
import { UserService } from './services/user.service';
import { UsersComponent } from './components/users.component/users.component';


@NgModule({
  declarations: [
    AppComponent,
    HeadComponent,
    UsersComponent,
    LeftPanelComponent,
    LoginComponent,
    DashboardComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatCheckboxModule,
    MatInputModule,
    MatFormFieldModule,
    MatSidenavModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [Helpers, TokenService, UserService, AppConfig, BaseService],
  bootstrap: [AppComponent]
})
export class AppModule { }
