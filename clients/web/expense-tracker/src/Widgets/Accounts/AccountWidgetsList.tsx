import React from "react";
import AccountResponseDto from "../../domain/models/account/AccountResponseDto";
import AccountWidget from "./AccountWidget";

interface IProps {
  accounts: AccountResponseDto[];
}

const AccountWidgetsList: React.FC<IProps> = ({ accounts }: IProps) => (
  <>
    {accounts.map((account) => (
      <AccountWidget account={account} key={account.Id} />
    ))}
  </>
);

export default AccountWidgetsList;
