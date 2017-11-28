export class Order {
    constructor(
        public idOrders?: number,
        public caption?: string,
        public text?: string,
        public Geomap?:string,
        public cost?: number,
        public UsersId?: number,
        public ThereImages?: boolean,
        public ThereFiles?: boolean
    ){}
}
export class User{
    constructor(){}
}