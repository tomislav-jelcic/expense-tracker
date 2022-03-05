import Keycloak, { KeycloakConfig, KeycloakInitOptions } from "keycloak-js";
const keycloakConfig = {
  url: "http://localhost:5500/auth",
  realm: "main",
  clientId: "expense-tracker-client",
} as KeycloakConfig;

const keycloak = Keycloak(keycloakConfig);

export const initOptions = {
  onLoad: "login-required",
  checkLoginIframe: false,
} as KeycloakInitOptions;

export default keycloak;
