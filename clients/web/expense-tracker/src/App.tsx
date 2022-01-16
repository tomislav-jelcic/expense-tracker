import React from "react";
import { ReactKeycloakProvider } from "@react-keycloak/web";
import keycloak from "./keycloack";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Nav from "./components/Nav";
import WelcomePage from "./pages/Homepage";
import SecuredPage from "./pages/SecuredPage";
import PrivateRoute from "./helpers/PrivateRoute";
import Sidebar from './components/Sidebar';

function App() {
  return (
    <React.Fragment>
      <ReactKeycloakProvider authClient={keycloak}>
        <Nav />
        <div className="flex overflow-hidden bg-white h-full">
          <BrowserRouter>
            <Sidebar />
            <Routes>
              <Route path="/" element={<WelcomePage />} />
              <Route
                path="/secured"
                element={
                  <PrivateRoute>
                    <SecuredPage />
                  </PrivateRoute>
                }
              />
            </Routes>
          </BrowserRouter>
        </div>
      </ReactKeycloakProvider>
    </React.Fragment>
  );
}

export default App;