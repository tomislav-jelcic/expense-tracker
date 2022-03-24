import React from "react";
import { AccountResponseDto } from "../../domain/models/account/AccountResponseDto";
import { AccountWidget } from "./AccountWidget";

interface IProps {
    accounts: AccountResponseDto[];
};

export const AccountWidgetsList: React.FC<IProps> = ({ accounts }: IProps) => {

    return (<>
        {accounts.map((account) => {
            return (
                <AccountWidget account={account} key={account.Id}></AccountWidget>
            )
        })}
    </>)
}