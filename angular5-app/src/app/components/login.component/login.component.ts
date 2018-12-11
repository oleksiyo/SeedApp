import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { TokenService } from '../../services/token.service';
import { Helpers } from '../../helpers/helpers';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: [ './login.component.css' ]
})

export class LoginComponent implements OnInit {
  user = {'password': '', 'email': ''};
  constructor(private helpers: Helpers,
              private router: Router,
              private tokenService: TokenService) { }

  ngOnInit() {
  }

  login(): void {
    this.tokenService.auth(this.user).subscribe(token => {
      const authValues = this.user;
      authValues['token'] = token;
      this.helpers.setToken(authValues);
      this.router.navigate(['/dashboard']);
    });
  }
}
