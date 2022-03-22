import React from "react";

type Props = {
    name: string;
    onHeaderIconClick: Function
}


export const Header: React.FC<Props> = ({ name, onHeaderIconClick }: Props) => {
    return (
        <nav className="fixed z-30 w-full bg-gray-50 border-b-2 border-enhance">
            <div className="lg:px-4 sm:px-2 py-3">
                <div className="flex items-center justify-between">
                    <div className="flex items-center justify-start">
                        <button className="p-2 text-gray-600 rounded cursor-pointer lg:hidden" onClick={() => onHeaderIconClick()}>
                            <svg xmlns="http://www.w3.org/2000/svg" className="w-6 h-6" fill="none" viewBox="0 0 24 24"
                                stroke="currentColor">
                                <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 6h16M4 12h16M4 18h16" />
                            </svg>
                        </button>
                        <div className="flex items-center text-xl font-bold">
                            <span className="text-primary">{name}</span>
                        </div>
                    </div>
                </div>
            </div>
        </nav>
    )
}