import React from "react";
import { Money } from "../../domain/models/money/Money";

interface Props {
    id: number;
    name: string;
    balance: Money;
    accountType: string;
}

const AccountWidget: React.FC<Props> = ({ id, name, balance, accountType }) => {
    return (
        <div className="px-4">
            <div className="bg-white p-6 rounded-lg shadow-lg">
                <h4 className="mt-1 text-xl font-semibold uppercase leading-tight truncate">{name}</h4>
                <div className="mt-1">
                    {balance.amount} 
                    <span className="text-gray-600 text-sm font-bold">{balance.currency}</span>
                </div>
            </div>
        </div>
    )
}

export default AccountWidget;