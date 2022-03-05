import React from "react";
import { NavLink } from "react-router-dom";
import Icon from '@mui/material/Icon';

interface Props {
    name: string;
    to: string;
    iconName: string;
}

const SidebarItem: React.FC<Props> = ({ name, to, iconName }) => {
    return (
        <li className="hover:bg-enhance text-textPrimary hover:text-textSecondary rounded-lg my-2 active:bg-textPrimary">
            <NavLink style={({ isActive }) => {
                return {
                    backgroundColor: isActive ? "hotpink" : ""
                };
            }}
                className="flex items-center px-3 py-3 rounded-md" to={to}>
                <Icon className="w-6 h-6">{iconName}</Icon>
                <span className="mx-4 font-medium">{name}</span>
            </NavLink>
        </li>
    )
}

export default SidebarItem;