import { Component, OnInit, Input } from '@angular/core';
import { DataSource } from '@angular/cdk/collections';
import {MatPaginator, MatTableDataSource} from '@angular/material';

import { OrdersService } from "../../services/orders.service";
import { Order } from "../../shared/models";

@Component({
    selector: 'order-list',
    templateUrl: './list.orders.component.html',
    styleUrls: ['./orders.component.css'],
    providers: [OrdersService]
})
export class OrdersListComponent implements OnInit {
    @Input("model")
    public orders: Order[];

    public displayedColumns = ['caption','text'];
    public dataSource = new MatTableDataSource<Order>(this.orders);
    
    constructor(private ordersService: OrdersService){}

    ngOnInit(){
        
    }
}
export interface IOrder{
    caption: string;
    text: string;
    cost: number;
    geomap: string;

}