import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Order } from '../shared/models';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class OrdersService {


    constructor(private http: HttpClient) {
    }
    //private url = this.config.apiUrl+"/orders";
    private url = "api/orders";
    
    getOrders(){
        return this.http.get<Order[]>(this.url);
    }

    createOrders(neworder: Order){
        return this.http.post<Order>(this.url,neworder);
    }
    
}