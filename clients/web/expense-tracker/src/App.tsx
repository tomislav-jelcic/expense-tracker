import React from "react";
import { ReactKeycloakProvider } from "@react-keycloak/web";
import keycloak, { initOptions } from "./keycloack";
import { BrowserRouter } from "react-router-dom";
import { Router } from "./Routes";
import { Loading } from "./Components/Loading";

function App() {
  return (
    <React.Fragment>
      <ReactKeycloakProvider authClient={keycloak} initOptions={initOptions} LoadingComponent={<Loading />}>
        <BrowserRouter>
          <Router />
        </BrowserRouter>
      </ReactKeycloakProvider>
    </React.Fragment>
  );
}

export default App;