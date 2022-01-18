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
        <li className="text-gray hover:bg-gray-light rounded-lg hover:text-black text-l pb-2 pt-2">
            <Link to={to}>
                <Icon className="align-middle">{iconName}</Icon>
                <span className="ml-2 align-middle">{name}</span>
            </Link>
        </li>
    )
}

export default SidebarItem;