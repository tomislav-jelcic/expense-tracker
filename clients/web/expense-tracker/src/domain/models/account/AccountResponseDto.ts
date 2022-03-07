import { MoneyResponseDto } from "../money/MoneyResponseDto";
import { AccountType } from "./AccountType";

export class AccountResponseDto {
  Id!: number;
  OwnerId!: string;
  Name!: string;
  Type!: AccountType;
  Balance!: MoneyResponseDto;
  public constructor(init?: Partial<AccountResponseDto>) {
    Object.assign(this, init);
  }
}
