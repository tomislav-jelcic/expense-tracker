import React from "react";
import { AccountResponseDto } from "../domain/models/account/AccountResponseDto";
import { AccountType } from "../domain/models/account/AccountType";
import { MoneyResponseDto } from "../domain/models/money/MoneyResponseDto";
import AccountList from "../Widgets/Accounts/AccountList";
import CreateAccount from "../Widgets/Accounts/CreateAccount";

const accounts: Array<AccountResponseDto> = [new AccountResponseDto({
    Balance: new MoneyResponseDto(100, 'HRK'),
    Id: 1323,
    Name: 'Savings',
    OwnerId: '123',
    Type: AccountType.Savings
}),
new AccountResponseDto({
    Balance: new MoneyResponseDto(150, 'EUR'),
    Id: 1243,
    Name: 'EUR Savings',
    OwnerId: '123',
    Type: AccountType.Savings
}),
new AccountResponseDto({
    Balance: new MoneyResponseDto(1003, 'HRK'),
    Id: 1523,
    Name: 'Transaction',
    OwnerId: '123',
    Type: AccountType.Transaction
})];

export const AccountsRoot = () => {
    return (
        <>
            <AccountList accounts={accounts} />
            <CreateAccount />
        </>
    )
}