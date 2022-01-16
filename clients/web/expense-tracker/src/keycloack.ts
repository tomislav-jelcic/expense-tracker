import Keycloak, { KeycloakConfig } from 'keycloak-js'; 
const keycloakConfig = {
    url: 'http://localhost:5500/auth',
    realm: 'main',
    clientId: 'expense-tracker-client'
} as KeycloakConfig;

const keycloak =  Keycloak(keycloakConfig);

export default keycloak;