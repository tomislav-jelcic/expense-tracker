export default class MoneyResponseDto {
  public amount!: number;

  public currency!: string;

  constructor(amount: number, currency: string) {
    this.amount = amount;
    this.currency = currency;
  }
}
