import React from "react";
import { Link } from "react-router-dom";
import Icon from '@mui/material/Icon';


interface Props {
    name: string;
    to: string;
    iconName: string;
}

const SidebarItem: React.FC<Props> = ({ name, to, iconName }) => {
    return (
        <li className="text-gray flex hover:bg-gray-light rounded-lg hover:text-black text-l">
            <Link to={to} className="p-2">
                <Icon className="align-middle">{iconName}</Icon>
                <span className="ml-2 align-middle">{name}</span>
            </Link>
        </li>
    )
}

export default SidebarItem;