import { useKeycloak } from "@react-keycloak/web";
import { Outlet } from "react-router-dom";

const PrivateRoute: React.FC<any> = props => {
    const { keycloak } = useKeycloak();

    const isLoggedIn = keycloak?.authenticated;

    if (isLoggedIn)
        return <Outlet />;

    keycloak.login();
    return <></>
};

export default PrivateRoute;