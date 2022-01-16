import { useKeycloak } from "@react-keycloak/web";

const PrivateRoute: React.FC<any> = props  => {
 const { keycloak } = useKeycloak();

    const isLoggedIn = keycloak.authenticated;
    
    if (isLoggedIn)
        return props.children;
    

 return isLoggedIn ? props.children : null;
};

export default PrivateRoute;