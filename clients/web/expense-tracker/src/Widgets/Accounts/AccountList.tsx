import React from "react";
import { AccountResponseDto } from "../../domain/models/account/AccountResponseDto";
import { AccountWidget } from "./AccountWidget";

interface IProps {
    accounts: AccountResponseDto[];
};

export const AccountList: React.FC<IProps> = ({ accounts }: IProps) => {

    return (<div className="flex flex-row sm:flex-col">
        {accounts.map((account) => {
            return (
                <div className="px-2 md:pb-2 md:pt-0 sm:py-2">
                    <AccountWidget account={account} key={account.Id}></AccountWidget>
                </div>
            )
        })}
    </div>)
}