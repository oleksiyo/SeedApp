import { Component, AfterViewInit, OnDestroy  } from '@angular/core';
import { Subscription } from 'rxjs';
import {startWith} from 'rxjs/operators';

import { Helpers } from '../../helpers/helpers';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements AfterViewInit, OnDestroy {
  subscription: Subscription;
  authentication = false;

  constructor(private helpers: Helpers) { }

  ngAfterViewInit() {
    this.subscription = this.helpers.isAuthenticationChanged().pipe(
      startWith(this.helpers.isAuthenticated())).subscribe((value) =>
        this.authentication = value
      );
  }

  ngOnDestroy() {
    this.authentication = false;
    this.subscription.unsubscribe();
  }
}
