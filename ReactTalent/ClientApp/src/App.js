import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { FetchCustomer1 } from './components/FetchCustomer1';
import { CustomerTest } from './components/CustomerTest';

import { AddCustomer } from './components/AddCustomer';  
import { Customer } from './components/Customer';
import { Product } from './components/Product';
import { Store } from './components/Store';
import { Sale } from './components/Sale';




export default class App extends Component {
  displayName = App.name

  render() {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
            <Route path='/fetchdata' component={FetchData} />
            <Route path='/fetchcustomer1' component={FetchCustomer1} />
            <Route path='/customertest' component={CustomerTest} />

            <Route path='/AddCustomer' component={AddCustomer} />
            <Route path='/Customer/edit/:custid' component={AddCustomer} /> 
            <Route path='/Customer' component={Customer} />
            <Route path='/Product' component={Product} />
            <Route path='/Store' component={Store} />
            <Route path='/Sale' component={Sale} />
     
            
      </Layout>
    );
  }
}
