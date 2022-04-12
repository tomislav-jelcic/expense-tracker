import React, { useMemo, useState } from 'react';
import { ReactKeycloakProvider } from '@react-keycloak/web';
import { BrowserRouter } from 'react-router-dom';
import Router from './Routes';
import Sidebar from './Widgets/Sidebar/Sidebar';
import keycloak, { initOptions } from './keycloack';
import Loading from './Components/Loading';
import Header from './Widgets/Header/Header';
import MobileSidebarShownContext from './Services/Contexts/MobileSidebarShownContext';

const App = () => {
  const [shown, setShown] = useState(window.screen.width > 600); // just a hack so the menu stays closed on small screens
  const toggleShown = () => {
    setShown(!shown);
  };

  const shownValues = useMemo(
    () => ({ shown, toggleShown }),
    [shown, toggleShown]
  );
  return (
    <ReactKeycloakProvider
      authClient={keycloak}
      initOptions={initOptions}
      LoadingComponent={<Loading />}
    >
      <Header
        name="Expense tracker"
        onHeaderIconClick={toggleShown}
      />
      <BrowserRouter>
        <div className="pt-12 lg:flex bg-whitesmoke bg-gray-50">
          <div className="flex flex-col w-full py-2 overflow-y-auto border-b md:border-r md:border-solid md:border-enhance lg:h-screen lg:w-64 bg-white">
            <MobileSidebarShownContext.Provider value={shownValues}>
              <Sidebar />
            </MobileSidebarShownContext.Provider>
          </div>
          <div className="w-full h-full mr-2 my-8 overflow-y-auto">
            <Router />
          </div>
        </div>
      </BrowserRouter>
    </ReactKeycloakProvider>
  );
};

export default App;
