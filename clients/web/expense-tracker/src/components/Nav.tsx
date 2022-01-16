import { useKeycloak } from "@react-keycloak/web";

const Nav = () => {
  const { keycloak, initialized } = useKeycloak();

  return (
    <nav className="bg-white border-b border-gray-light z-30 w-full">
      <div className="px-3 py-3 lg:px-5 lg:pl-3">
        <div className="flex item-center justify-between">
          <div className="flex items-center justify-start">
            <button id="toggleSidebarModal" aria-expanded="true"></button>
            <span className="text-xl">Expense tracker</span>
          </div>
          <div className="flex items center">
          </div>
        </div>
      </div>
    </nav>
  );
};

export default Nav;