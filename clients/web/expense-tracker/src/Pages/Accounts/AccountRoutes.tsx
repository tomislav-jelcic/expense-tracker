import React from "react";
import { Route, Routes } from "react-router-dom";
import AccountsRoot from "./AccountsRoot";

export const AccountRootRoute = "/accounts";

const AccountRouter = () => (
  <Routes>
    <Route index element={<AccountsRoot />} />
  </Routes>
);

export default AccountRouter;
