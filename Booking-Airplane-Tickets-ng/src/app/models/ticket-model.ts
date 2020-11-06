export class TicketDtoModel {
    
    airLine: AirLines 
    firstName: string
    lastName: string
    dateOfBirth: string
    passportNo: string
    loyalMemberId: number
    useLoyalMemberCredits: boolean
    origin: string
    destination: string
    departure: string
    return: string
    freeCarryOnBag: number
    trolleyBag: number
    checkedInBag: number
}

export enum AirLines {
    airLine_A = 1,
    airLine_B
}