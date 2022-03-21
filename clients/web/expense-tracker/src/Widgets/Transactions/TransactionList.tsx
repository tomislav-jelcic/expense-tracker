import React from "react";
import { TransactionResponseDto } from "../../domain/models/transaction/TransactionResponseDto";

interface IProps {
    transactions: TransactionResponseDto[];
}

const TransactionList: React.FC<IProps> = ({ transactions }: IProps) => {
    return (<>
        <table>
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Amount</th>
                    <th>Description</th>
                    <th>CategoryId</th>
                    <th>Transaction type</th>
                    <th>Originating account id</th>
                    <th>Destination account id</th>
                </tr>
            </thead>
            <tbody>
                {transactions.map((transaction: TransactionResponseDto) => {
                    return <></>
                })}
            </tbody>
        </table>
    </>)
}

export default TransactionList;