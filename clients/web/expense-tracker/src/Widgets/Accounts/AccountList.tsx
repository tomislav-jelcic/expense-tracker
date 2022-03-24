import React from "react";
import { AccountResponseDto } from "../../domain/models/account/AccountResponseDto";

interface IProps {
    accounts: AccountResponseDto[];
}

const AccountList: React.FC<IProps> = ({ accounts }: IProps) => {
    return (<>
        <table className="table table-fixed overflow-hidden text-center rounded-md w-full font-normal">
            <thead className="text-md">
                <tr className="rounded-md border-2 border-solid border-enhance font-light">
                    <th>Id</th>
                    <th>Name</th>
                    <th>Type</th>
                    <th>Balance</th>
                </tr>
            </thead>
            <tbody className="border-d-2">
                {accounts.map((account: AccountResponseDto) => {
                    return <tr className="rounded-md hover:bg-enhance hover:text-textSecondary text-md bg-active border-l-2 border-r-2 border-solid border-enhance font-light">
                        <td>{account.Id}</td>
                        <td>{account.Name}</td>
                        <td>{account.Type}</td>
                        <td>{account.Balance.amount} {account.Balance.currency}</td>
                    </tr>
                })}
            </tbody>
        </table>
    </>)
}

export default AccountList;