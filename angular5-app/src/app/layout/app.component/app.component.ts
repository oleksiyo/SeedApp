import { Component, AfterViewInit, OnDestroy  } from '@angular/core';
import { Subscription } from 'rxjs';

import { Helpers } from '../../helpers/helpers';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements AfterViewInit, OnDestroy {
  subscription: Subscription;
  authentication: boolean;
  title = 'Angular 5 Seed';

  constructor(private helpers: Helpers) { }

  ngAfterViewInit() {
    // this.authentication = this.helpers.isAuthenticationChanged();
    this.authentication = true;
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }
}
