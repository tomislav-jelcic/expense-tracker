import { MoneyResponseDto } from "../money/MoneyResponseDto";
import { TransactionType } from "./TransactionType";

export class TransactionResponseDto {
  public Id!: number;
  public Amount!: MoneyResponseDto;
  public Description!: string;
  public Time!: Date;
  public CategoryId!: number;
  public TransactionType!: TransactionType;
  public OriginatingAccountId!: number;
  public DestinationAccountId?: number;

  public constructor(init?: Partial<TransactionResponseDto>) {
    Object.assign(this, init);
  }
}
