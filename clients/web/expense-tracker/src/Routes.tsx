import React from "react";
import { Route, Routes, Navigate } from "react-router-dom";
import { AccountRouter, AccountRootRoute } from "./Accounts/AccountRoutes";
import { DashboardRootRoute, DashboardRouter } from "./Dashboard/DashboardRoutes";
import PrivateRoute from "./helpers/PrivateRoute";

const RootRoute = "/";

export const Router = () => {
    return (
        <Routes>
            <Route path={RootRoute} element={<PrivateRoute />}>
                <Route path={DashboardRootRoute} element={<DashboardRouter />}> </Route>
                <Route path={AccountRootRoute} element={<AccountRouter />}> </Route>
                <Route
                    path="*"
                    element={<Navigate to={DashboardRootRoute} />}
                />
            </Route>
        </Routes>
    )
};