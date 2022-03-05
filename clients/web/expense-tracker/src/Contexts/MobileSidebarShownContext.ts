import React from "react";
interface ISidebarContext {
  shown: boolean;
  toggleShown?: () => void;
}

const defaultState = {
  shown: false,
};
export const MobileSidebarShownContext =
  React.createContext<ISidebarContext>(defaultState);
