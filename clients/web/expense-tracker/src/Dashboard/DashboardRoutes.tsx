import React from "react";
import { Route, Routes } from "react-router-dom";
import { DashboardRoot } from "./DashboardRoot";

export const DashboardRootRoute = '/dashboard';

export const DashboardRouter = () => {
    return (
        <Routes>
            <Route index element={<DashboardRoot />}></Route>
        </Routes>
    )
}