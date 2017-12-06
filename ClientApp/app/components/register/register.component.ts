import { Component } from '@angular/core';
import { Router } from '@angular/router';
 
import { AlertService } from '../../services/alert.service';
import { UserService } from '../../services/users.service';
 
@Component({
    selector: 'register',
    templateUrl: 'register.component.html',
    providers: [ UserService,AlertService ]
})
 
export class RegisterComponent {
    model: any = {};
    loading = false;
 
    constructor(
        private router: Router,
        private userService: UserService,
        private alertService: AlertService) { }
 
    register() {
        this.loading = true;
        this.userService.create(this.model);
    }
}