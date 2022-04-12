import React from "react";
import AccountResponseDto from "../../domain/models/account/AccountResponseDto";

interface IProps {
  account: AccountResponseDto;
}

const AccountWidget: React.FC<IProps> = ({ account }: IProps) => (
  <div className="px-4 group hover:bg-enhance text-textPrimary hover:text-textSecondary rounded-md border-solid border-2 border-enhance text-center cursor-pointer border-b-8 border-b-active">
    <h6 className="text-left text-sm text-gray-400 pb-4 group-hover:text-textSecondary">
      Own account
    </h6>
    <h3>{account.Name}</h3>
    <div className="mb-2">
      {account.Balance.amount} {account.Balance.currency}
    </div>
  </div>
);

export default AccountWidget;
