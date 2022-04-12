import React from 'react';
import { Route, Routes, Navigate } from 'react-router-dom';
import AccountRouter, {
  AccountRootRoute,
} from './Pages/Accounts/AccountRoutes';
import DashboardRouter, {
  DashboardRootRoute,
} from './Pages/Dashboard/DashboardRoutes';

import PrivateRoute from './helpers/PrivateRoute';

const RootRoute = '/';

const Router = () => (
  <Routes>
    <Route path={RootRoute} element={<PrivateRoute />}>
      <Route path={DashboardRootRoute} element={<DashboardRouter />}>
        {' '}
      </Route>
      <Route path={AccountRootRoute} element={<AccountRouter />}>
        {' '}
      </Route>
      <Route
        path="*"
        element={<Navigate to={DashboardRootRoute} />}
      />
    </Route>
  </Routes>
);

export default Router;
