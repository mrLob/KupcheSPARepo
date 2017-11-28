import { Component, OnInit} from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms/src/model';

import { OrdersService } from "../../services/orders.service"
import { Order } from "../../shared/models";

@Component({
    selector: 'tender-create',
    templateUrl: './tendercreate.component.html',
    styleUrls:  ["./tendercreate.component.css"],
    providers: [OrdersService]
})
export class TenderCreateComponent implements OnInit{  
    order: Order= new Order();
    orders: Order[];
    private ordersService: OrdersService


    ngOnInit(){
        this.loadOrders();
    }

    loadOrders(){
        this.ordersService.getOrders()
        .subscribe((data: Order[]) => this.orders = data);
    }

    onSubmit(){
        this.ordersService.createOrders(this.order)
        .subscribe((data: Order)=> this.orders.push(data));    
    }    
}