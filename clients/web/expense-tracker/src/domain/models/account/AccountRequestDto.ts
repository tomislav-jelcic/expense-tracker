import MoneyRequestDto from "../money/MoneyRequestDto";
import AccountType from "./AccountType";

export default class AccountResponseDto {
  OwnerId!: string;

  Name!: string;

  Type!: AccountType;

  Balance!: MoneyRequestDto;

  public constructor(init?: Partial<AccountResponseDto>) {
    Object.assign(this, init);
  }
}
