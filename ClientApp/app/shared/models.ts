export class Order {
    constructor(
        public Caption?: string,
        public Text?: string,
        public Geomap?:string,
        public Cost?: number,
        public UsersId?: number,
        public ThereImages?: boolean,
        public ThereFiles?: boolean
    ){}
}
export class User{
    constructor(){}
}