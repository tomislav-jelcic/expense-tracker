import React from "react";
import { AccountRootRoute } from "../Accounts/AccountRoutes";
import SidebarItem from "./SidebarItem";


const Sidebar = () => {
    return <div className="flex flex-col justify-between mt-4">
        <aside>
            <ul>
                <SidebarItem iconName="dashboard" name="Dashboard" to="" />
                <SidebarItem iconName="account_balance" name="Accounts" to={AccountRootRoute} />
                <SidebarItem iconName="attach_money" name="Transactions" to="" />
                <SidebarItem iconName="settings" name="Settings" to="" />
            </ul>
        </aside>
    </div>
}

export default Sidebar;