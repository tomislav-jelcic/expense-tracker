import SidebarItem from "./SidebarItem";

const Sidebar = () => {
    return (
        <aside id="sidebar" className="hidden z-20 h-full top-0 left-0 flex lg:flex flex-shrink-0 flex-col w-64 transition-width duration-75" aria-label="Sidebar">
            <div className="relative flex-1 flex flex-col min-h-0 border-r border-gray-light bg-white pt-0">
                <div className="flex-1 flex flex-col pt-5 pb-4 overflow-y-auto">
                    <div className="flex-1 px-3 bg-white divide-y space-y-1">
                        <ul className="space-y-2 pb-2">
                            <SidebarItem iconName="dashboard" name="Dashboard" to="" />
                            <SidebarItem iconName="account_balance_wallet" name="Accounts" to="" />
                            <SidebarItem iconName="attach_money" name="Transactions" to="" />
                            <SidebarItem iconName="settings" name="Settings" to="" />
                        </ul>
                    </div>
                </div>
            </div>
        </aside>
    )
}

export default Sidebar;