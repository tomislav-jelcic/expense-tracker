import React from "react";
import { ReactKeycloakProvider } from "@react-keycloak/web";
import keycloak from "./keycloack";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Nav from "./components/Nav";
import WelcomePage from "./pages/Homepage";
import SecuredPage from "./pages/SecuredPage";
import PrivateRoute from "./helpers/PrivateRoute";
import Sidebar from "./components/sidebar/Sidebar";

function App() {
  return (
    <React.Fragment>
      <ReactKeycloakProvider authClient={keycloak}>
        <BrowserRouter>
          <Nav />
          <div className="grid grid-cols-12 overflow-hidden bg-white h-full pt-5">
            <div className="col-span-2">
              <Sidebar />
            </div>
            <div className="col-span-10">
              <div className="grid grid-cols-12">
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
              </div>
            </div>
          </div>
        </BrowserRouter>
      </ReactKeycloakProvider>
    </React.Fragment>
  );
}

export default App;