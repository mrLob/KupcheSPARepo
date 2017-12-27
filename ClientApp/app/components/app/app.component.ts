import { Component, ViewEncapsulation, OnInit } from '@angular/core';
import {MatDialog, MatDialogRef} from '@angular/material';

import { AuthenticationService } from '../../services/authentication.service';
import { LoginComponent } from '../login/login.component';
@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css'],
    providers: [AuthenticationService],
    encapsulation: ViewEncapsulation.None,
    preserveWhitespaces: false,
})
export class AppComponent implements OnInit  {
    public profile: string | null;
    public profLoad:boolean=false;
    constructor(private authenticationService: AuthenticationService, public dialog: MatDialog) { }
    
    ngOnInit(){
    }
    startTimer(){
        setInterval(this.loadProfile(),1000);
    }

    openDialog(): void {
        let dialog = this.dialog.open(LoginComponent,{width: '250px'});
        dialog.afterClosed().subscribe((result: boolean) => {
                console.log(result);
                this.profLoad = result;              
            });
    }

    loadProfile(){
        console.log("message logged"+this.authenticationService.getStates());
        if(this.authenticationService.getStates() === "authorized"){
            console.log("message logged");
            this.profile = this.authenticationService.getProfile();
            this.profLoad = true;
        }
    }

}
