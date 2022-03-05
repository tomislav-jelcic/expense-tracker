import React, { lazy, Suspense } from "react";
import { Route, Routes } from "react-router-dom";
import { AccountRouter, AccountRootRoute } from "./Accounts/AccountRoutes";
import PrivateRoute from "./helpers/PrivateRoute";

const RootRoute = "/";



export const Router = () => {
    return (
        <Routes>
            <Route path={RootRoute} element={<PrivateRoute />}>
                <Route path={AccountRootRoute} element={<AccountRouter />}>
                </Route>
            </Route>
        </Routes>
    )
};