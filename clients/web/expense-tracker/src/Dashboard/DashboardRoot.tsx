import React from "react";
import { AccountResponseDto } from "../domain/models/account/AccountResponseDto";
import { AccountType } from "../domain/models/account/AccountType";
import { MoneyResponseDto } from "../domain/models/money/MoneyResponseDto";
import { TransactionResponseDto } from "../domain/models/transaction/TransactionResponseDto";
import { TransactionType } from "../domain/models/transaction/TransactionType";
import { AccountWidgetsList } from "../Widgets/Accounts/AccountWidgetsList";
import TransactionList from "../Widgets/Transactions/TransactionList";


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

const transactions: Array<TransactionResponseDto> = [new TransactionResponseDto({
    Id: 1323,
    Description: 'Konzum',
    OriginatingAccountId: 1,
    DestinationAccountId: 2,
    TransactionType: TransactionType.Expenditure,
    Amount: new MoneyResponseDto(100, 'HRK'),
    CategoryId: 1,
    Time: new Date(+(new Date()) - Math.floor(Math.random() * 10000000000))
}),
new TransactionResponseDto({
    Id: 1324,
    Description: 'Kaufland',
    OriginatingAccountId: 1,
    DestinationAccountId: 2,
    TransactionType: TransactionType.Expenditure,
    Amount: new MoneyResponseDto(132, 'HRK'),
    CategoryId: 2,
    Time: new Date(+(new Date()) - Math.floor(Math.random() * 10000000000))
}),
new TransactionResponseDto({
    Id: 123,
    Description: 'Pekara',
    OriginatingAccountId: 1,
    DestinationAccountId: 2,
    TransactionType: TransactionType.Expenditure,
    Amount: new MoneyResponseDto(5, 'HRK'),
    CategoryId: 1,
    Time: new Date(+(new Date()) - Math.floor(Math.random() * 10000000000))
}),
new TransactionResponseDto({
    Id: 345,
    Description: 'Pekara',
    OriginatingAccountId: 1,
    DestinationAccountId: 2,
    TransactionType: TransactionType.Expenditure,
    Amount: new MoneyResponseDto(18, 'HRK'),
    CategoryId: 1,
    Time: new Date(+(new Date()) - Math.floor(Math.random() * 10000000000))
}),
new TransactionResponseDto({
    Id: 567,
    Description: 'Pekara',
    OriginatingAccountId: 1,
    DestinationAccountId: 2,
    TransactionType: TransactionType.Expenditure,
    Amount: new MoneyResponseDto(32, 'HRK'),
    CategoryId: 1,
    Time: new Date(+(new Date()) - Math.floor(Math.random() * 10000000000))
})];

export const DashboardRoot = () => {
    return (<>
        <div className="grid grid-cols-6 gap-4 px-2">
            <AccountWidgetsList accounts={accounts} />
            <div className="col-span-6 mt-2">
                <TransactionList transactions={transactions} />
            </div>
        </div>
    </>
    )
}