import SidebarItem from "./SidebarItem";

const Sidebar = () => {
    return (
        <aside id="sidebar" className="grid grid-cols-1 z-20 h-full top-0 left-0 w-64 transition-width duration-75" aria-label="Sidebar">
                <ul className="ml-4 mr-4 min-h-0 border-r border-gray-light bg-white">
                    <SidebarItem iconName="dashboard" name="Dashboard" to="" />
                    <SidebarItem iconName="account_balance_wallet" name="Accounts" to="" />
                    <SidebarItem iconName="attach_money" name="Transactions" to="" />
                    <SidebarItem iconName="settings" name="Settings" to="" />
                </ul>
        </aside>
    )
}

export default Sidebar;