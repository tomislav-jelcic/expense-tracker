import React from 'react';
import AccountWidget from '../components/account/AccountWidget';
import { Money } from '../domain/models/money/Money';

const Home = () => {

  return (
    <React.Fragment>
      <div className='col-span-2'>
        <AccountWidget accountType='Bank Account' balance={new Money(1000, 'HRK')} id={123} name='Tekuci' />
      </div>
      <div className='col-span-2'>
        <AccountWidget accountType='Bank Account' balance={new Money(1233, 'EUR')} id={123} name='Stednja' />
      </div>
      <div className='col-span-2'>
        <AccountWidget accountType='Cash' balance={new Money(213, 'HRK')} id={123} name='Novcanik' />
      </div>
    </React.Fragment>
  );
};

export default Home;