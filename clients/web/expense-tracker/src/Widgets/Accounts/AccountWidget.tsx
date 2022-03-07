import React from "react";
import { AccountResponseDto } from "../../domain/models/account/AccountResponseDto";

interface IProps {
    account: AccountResponseDto;
}

export const AccountWidget: React.FC<IProps> = ({ account }: IProps) => {
    return (
        <div className="md-rounded">
            <h3>{account.Name}</h3>
            <div>{account.Balance.amount} {account.Balance.currency}</div>
        </div>
    )
}