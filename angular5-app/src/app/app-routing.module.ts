import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from './helpers/authGuard';
import { LoginComponent } from './components/login.component/login.component';
import { LogoutComponent } from './components/logout.component';
import { DashboardComponent } from './components/dashboard.component/dashboard.component';
import { UsersComponent } from './components/users.component/users.component';


const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full', canActivate: [AuthGuard] },
  { path: 'login', component: LoginComponent},
  { path: 'logout', component: LogoutComponent },
  { path: 'dashboard', component: DashboardComponent},
  { path: 'users', component: UsersComponent}
];

@NgModule({
  declarations: [LogoutComponent],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
