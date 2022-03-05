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

  const [shown, setShown] = useState(false);
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
            <div className="w-full h-full p-4 my-8 overflow-y-auto">
              <div className="flex items-center justify-center p-16 border-4 border-dotted lg:p-40">
                <Router />
              </div>
            </div>
          </div>
        </BrowserRouter>
      </ReactKeycloakProvider>
    </React.Fragment>
  );
}

export default App;