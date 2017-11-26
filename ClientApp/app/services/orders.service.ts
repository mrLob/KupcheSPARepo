import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Order } from '../shared/models';

@Injectable()
export class OrdersService {
    private url = "/api/orders";

    constructor(private http: HttpClient) {
    }

    getOrders(){
        return this.http.get(this.url);
    }

    createOrders(neworder: Order){
        return this.http.post(this.url,neworder);
    }
    
}