import { Component, OnInit } from '@angular/core';

import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {

  constructor(private userService: UserService) { }

  ngOnInit() {
  }

  add() {
    this.userService.getUsers()
      .subscribe(
        (users: any) => this.onSuccess(users),
        (errors: string[]) => this.onFailed(errors));
  }

  onSuccess(data: any) {
    const users = data;
  }

  onFailed(error: any) {
    const errors = error;
  }

}
