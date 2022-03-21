import React from "react";
import { AccountResponseDto } from "../../domain/models/account/AccountResponseDto";
import { AccountWidget } from "./AccountWidget";

interface IProps {
    accounts: AccountResponseDto[];
};

export const AccountList: React.FC<IProps> = ({ accounts }: IProps) => {

    return (<>
        {accounts.map((account) => {
            return (
                <div className="px-2 sm:pd-2">
                    <AccountWidget account={account} key={account.Id}></AccountWidget>
                </div>
            )
        })}
    </>)
}