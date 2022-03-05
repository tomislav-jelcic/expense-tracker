import React from "react";
import { Route, Routes } from "react-router-dom";
import { AccountsRoot } from "./AccountsRoot";

export const AccountRootRoute = '/accounts';

export const AccountRouter = () => {
    return (
        <Routes>
            <Route index element={<AccountsRoot />}></Route>
        </Routes>
    )
}