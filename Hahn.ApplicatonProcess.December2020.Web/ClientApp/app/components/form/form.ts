import { HttpClient } from 'aurelia-fetch-client';
import { inject } from 'aurelia-framework';

@inject(HttpClient)
export class Form {

    email = '';
    password = '';

    submit() {
        var myUser = { email: this.email }
        console.log(myUser);
    };
}
