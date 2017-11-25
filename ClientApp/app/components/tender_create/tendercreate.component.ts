import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms/src/model';
import { Order } from "../../shared/models";
@Component({
    selector: 'tender-create',
    templateUrl: './tendercreate.component.html',
    styleUrls:  ["./tendercreate.component.css"]
})
export class TenderCreateComponent{  
    order: Order= new Order();
    onSubmit(){
            
    }    
}