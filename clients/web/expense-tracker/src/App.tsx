import React from "react";
import { Router } from "./Routes";
import { ReactKeycloakProvider } from "@react-keycloak/web";
import { BrowserRouter } from "react-router-dom";
import Sidebar from "./Sidebar/Sidebar";
import keycloak, { initOptions } from "./keycloack";
import { Loading } from "./components/Loading";

function App() {
  return (
    <React.Fragment>
      <ReactKeycloakProvider authClient={keycloak} initOptions={initOptions} LoadingComponent={<Loading />}>
        <BrowserRouter>
          <nav className="fixed z-30 w-full bg-white border-b-2 border-indigo-600">
            <div className="px-6 py-3">
              <div className="flex items-center justify-between">
                <div className="flex items-center justify-start">
                  <button className="p-2 text-gray-600 rounded cursor-pointer lg:hidden ">
                    <svg xmlns="http://www.w3.org/2000/svg" className="w-6 h-6" fill="none" viewBox="0 0 24 24"
                      stroke="currentColor">
                      <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 6h16M4 12h16M4 18h16" />
                    </svg>
                  </button>
                  <a href="#" className="flex items-center text-xl font-bold">
                    <span className="text-blue-800">Logo</span>
                  </a>
                </div>
              </div>
            </div>
          </nav>
          <div className="pt-12 lg:flex">
            <div className="flex flex-col w-full py-2 overflow-y-auto border-b lg:border-r lg:h-screen lg:w-64 bg-white">
              <Sidebar />
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