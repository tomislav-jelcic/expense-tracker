import React from 'react';
import AccountType from '../../domain/models/account/AccountType';

const CreateAccount: React.FC = () => (
  <form>
    <label
      className="block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2"
      htmlFor="account-name"
    >
      Account name
    </label>
    <input
      className="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
      id="account-name"
      name="account-name"
      type="text"
      placeholder="Account name"
    />

    <label
      className="block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2"
      htmlFor="account-type"
    >
      Account type
    </label>
    <select
      className="block appearance-none w-full bg-gray-200 border border-gray-200 text-gray-700 py-3 px-4 pr-8 rounded leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
      id="account-type"
      name="account-type"
    >
      {Object.values(AccountType)
        .filter((x) => Number.isNaN(x))
        .map((x) => (
          <option value={x}>{x.toString()}</option>
        ))}
    </select>
    <label
      className="block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2"
      htmlFor="account-amount"
    >
      Starting amount
    </label>
    <input
      className="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
      id="account-amount"
      name="account-amount"
      type="text"
      placeholder="Account name"
    />
  </form>
);

export default CreateAccount;
