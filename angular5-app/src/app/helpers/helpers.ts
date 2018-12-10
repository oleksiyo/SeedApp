import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable()

export class Helpers {

    private authenticationChanged = new Subject<boolean>();

    constructor() {
    }

    public isAuthenticated(): boolean {
        return (!(window.localStorage['token'] === undefined ||
            window.localStorage['token'] === null ||
            window.localStorage['token'] === 'null' ||
            window.localStorage['token'] === 'undefined' ||
            window.localStorage['token'] === ''));
    }

    public isAuthenticationChanged(): any {
        return this.authenticationChanged.asObservable();
    }

    public getToken(): any {
        if (window.localStorage['token'] === undefined ||
            window.localStorage['token'] === null ||
            window.localStorage['token'] === 'null' ||
            window.localStorage['token'] === 'undefined' ||
            window.localStorage['token'] === '') {
            return '';
        }
        const obj = JSON.parse(window.localStorage['token']);
        return obj.token;
    }

    public setToken(data: any) {
        this.setStorageToken(JSON.stringify(data));
    }

    public failToken() {
        this.setStorageToken(undefined);
    }

    public logout() {
        this.setStorageToken(undefined);
    }

    private setStorageToken(value: any) {
        window.localStorage['token'] = value;
        this.authenticationChanged.next(this.isAuthenticated());
    }
}
