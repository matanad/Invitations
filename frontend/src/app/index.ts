export enum OrderStatus {
    Pending = 'Pending',
    Approved = 'Approved',
    Rejected = 'Rejected'
}

export interface Invitation {
    id: number;
    customerName: string;
    totalPrice: number;
    isExceptional: boolean;
    status: OrderStatus;
}