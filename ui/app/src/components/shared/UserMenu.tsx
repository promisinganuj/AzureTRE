import React from 'react';
import { Persona, PersonaSize } from '@fluentui/react';
import { useAccount, useMsal } from '@azure/msal-react';

// TODO:
// - Dropdown / option to logout
// - Graph query to get user profile picture? 

export const UserMenu: React.FunctionComponent = () => {
  const { accounts } = useMsal();
  const account = useAccount(accounts[0] || {});

  return (
    <div className='tre-user-menu'>
      <Persona
        text={account?.name}
        size={PersonaSize.size32}
        imageAlt={account?.name}
      />
    </div>
  );
};
