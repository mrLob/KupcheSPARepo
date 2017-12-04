import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms/src/model';

import { OrdersFormComponent } from "./form.orders.component";

import { OrdersService } from "../../services/orders.service";
import { Order } from "../../shared/models";

@Component({
    selector: 'orders',
    templateUrl: './orders.component.html',
    styleUrls: ["./orders.component.css"],
    providers: [OrdersService]
})
export class OrdersComponent implements OnInit {
    public order: Order = new Order();
    public orders: Order[];
    
    constructor(private ordersService: OrdersService){}

    ngOnInit(){
        this.loadOrders();
    }

    loadOrders(){
        this.ordersService.getOrders()
        .subscribe((data: Order[]) => this.orders = data);
        
    }
}