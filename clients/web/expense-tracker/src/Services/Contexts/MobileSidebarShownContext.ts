import React from "react";

interface ISidebarContext {
  shown: boolean;
  toggleShown?: () => void;
}

const defaultState = {
  shown: false,
};
const MobileSidebarShownContext =
  React.createContext<ISidebarContext>(defaultState);

export default MobileSidebarShownContext;
