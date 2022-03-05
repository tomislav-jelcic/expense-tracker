import React, { useContext, useEffect, useState } from "react";
import { AccountRootRoute } from "../Accounts/AccountRoutes";
import SidebarItem from "./SidebarItem";
import { MobileSidebarShownContext } from "../Contexts/MobileSidebarShownContext";

const Sidebar = () => {
    const sidebarContext = useContext(MobileSidebarShownContext);

    let hiddenClass = sidebarContext.shown ? "" : "hidden";

    return <div className={`flex flex-col justify-between mt-4 ${hiddenClass}`} >
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