import { Component } from '@angular/core';

import { Helpers } from '../../helpers/helpers';

@Component({
  selector: 'app-head',
  templateUrl: './head.component.html',
  styleUrls: ['./head.component.css']
})

export class HeadComponent {
  title = 'Header Part';
  isAuthorized: boolean;
  userName: string;

  constructor(private helpers: Helpers) {
    this.isAuthorized = this. isAuth();
    this.userName = this.getUserName();
  }

  isAuth(): boolean {
   return this.helpers.isAuthenticated();
  }

  getUserName(): string {
    if (!this.isAuth()) {
      return '';
    }
    return this.helpers.getAuthData().email;
  }
}
