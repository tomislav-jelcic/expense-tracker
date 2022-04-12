import React from "react";
import TransactionResponseDto from "../../domain/models/transaction/TransactionResponseDto";

interface IProps {
  transactions: TransactionResponseDto[];
}

const TransactionList: React.FC<IProps> = ({ transactions }: IProps) => (
  <table className="table table-fixed overflow-hidden text-center rounded-md w-full font-normal">
    <thead className="text-md">
      <tr className="rounded-md border-2 border-solid border-enhance font-light">
        <th>Id</th>
        <th>Amount</th>
        <th>Description</th>
        <th>CategoryId</th>
        <th>Transaction type</th>
        <th>Originating account id</th>
        <th>Destination account id</th>
      </tr>
    </thead>
    <tbody className="border-d-2">
      {transactions.map((transaction: TransactionResponseDto) => (
        <tr className="rounded-md hover:bg-enhance hover:text-textSecondary text-md bg-active border-l-2 border-r-2 border-solid border-enhance font-light">
          <td>{transaction.Id}</td>
          <td>
            {transaction.Amount.amount} {transaction.Amount.currency}
          </td>
          <td>{transaction.Description}</td>
          <td>{transaction.CategoryId}</td>
          <td>{transaction.TransactionType}</td>
          <td>{transaction.OriginatingAccountId}</td>
          <td>{transaction.DestinationAccountId}</td>
        </tr>
      ))}
    </tbody>
  </table>
);

export default TransactionList;
