export class Order {
    constructor(
        public idOrders?: number,
        public caption?: string,
        public text?: string,
        public geomap?:string,
        public cost?: number,
        public usersId?: number,
        public thereImages?: boolean,
        public thereFiles?: boolean
    ){}
}
export class User{
    constructor(
        public idUsers?: number,
        public lastName?: string,
        public firstName?: string,
        public secondName?: string,
        public telephone?: number,
        public email?: string,
        public positionId?: number,
        public rulesId?: number,
        public companyId?: number,
        public pass?: string
    ){}
}
export class Files{
    constructor(
        public IdFiles?: number,
        public Name?: string,
        public Url?: string,
        public UserId?: number
    ){}
}
export class Images{
    constructor(
        public IdImages?: number,
        public Name?: string,
        public Path?: string,
        public UserId?: number
    ){}
}