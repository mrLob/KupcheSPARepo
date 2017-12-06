import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material';
import { AlertService } from '../../services/alert.service';

@Component({
   selector: 'alert',
   templateUrl: 'alert.component.html',
   providers: [AlertService]
})

export class AlertComponent {
   message: any;

   constructor(private alertService: AlertService,public snackBar: MatSnackBar) { }

   ngOnInit() {
       this.alertService.getMessage().subscribe(message => { this.message = message; });
       this.snackBar.open(this.message,"OK",{duration:2000});
   }
}