
export class Form {
    email = '';
    password = '';

    submit() {
        var myUser = { email: this.email }
        console.log(myUser);
    };
}
