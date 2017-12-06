import { Input, Output, Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms/src/model';

import { OrdersService } from "../../services/orders.service";
import { Order } from "../../shared/models";

@Component({
    selector: 'order-form',
    templateUrl: './form.orders.component.html',
    providers: [OrdersService]
})
export class OrdersFormComponent implements OnInit {
    public order: Order= new Order();
    public orders: Order[];
    
    constructor(private ordersService: OrdersService){}

    ngOnInit(){
        this.loadOrders();
    }

    loadOrders(){
        this.ordersService.getOrders()
        .subscribe((data: Order[]) => this.orders = data);
        
    }

    onSubmit(){
        this.ordersService.createOrders(this.order);    
    } 
}