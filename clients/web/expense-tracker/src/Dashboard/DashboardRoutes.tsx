import React from "react";
import { Route, Routes } from "react-router-dom";
import DashboardRoot from "./DashboardRoot";

export const DashboardRootRoute = "/dashboard";

const DashboardRouter = () => (
  <Routes>
    <Route index element={<DashboardRoot />} />
  </Routes>
);

export default DashboardRouter;
