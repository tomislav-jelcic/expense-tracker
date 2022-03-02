import React from "react";
import { ReactKeycloakProvider } from "@react-keycloak/web";
import keycloak from "./keycloack";
import { BrowserRouter } from "react-router-dom";

function App() {
  return (
    <React.Fragment>
      <ReactKeycloakProvider authClient={keycloak}>
        <BrowserRouter>
        </BrowserRouter>
      </ReactKeycloakProvider>
    </React.Fragment>
  );
}

export default App;