import React, { useState } from "react";
import { Router } from "./Routes";
import { ReactKeycloakProvider } from "@react-keycloak/web";
import { BrowserRouter } from "react-router-dom";
import Sidebar from "./Sidebar/Sidebar";
import keycloak, { initOptions } from "./keycloack";
import { Loading } from "./Components/Loading";
import { Header } from "./Header/Header";
import { MobileSidebarShownContext } from "./Contexts/MobileSidebarShownContext";

function App() {

  const [shown, setShown] = useState(window.screen.width > 600); // just a hack so the menu stays closed on small screens
  const toggleShown = () => {
    setShown(!shown);
  };

  return (
    <React.Fragment>
      <ReactKeycloakProvider authClient={keycloak} initOptions={initOptions} LoadingComponent={<Loading />}>
        <Header name="Expense tracker" onHeaderIconClick={toggleShown} />
        <BrowserRouter>
          <div className="pt-12 lg:flex">
            <div className="flex flex-col w-full py-2 overflow-y-auto border-b lg:border-r lg:h-screen lg:w-64 bg-white">
              <MobileSidebarShownContext.Provider value={{
                shown,
                toggleShown
              }}>
                <Sidebar />
              </MobileSidebarShownContext.Provider>
            </div>
            <div className="w-full h-full mx-2 my-8 overflow-y-auto">
              <Router />
            </div>
          </div>
        </BrowserRouter>
      </ReactKeycloakProvider>
    </React.Fragment>
  );
}

export default App;