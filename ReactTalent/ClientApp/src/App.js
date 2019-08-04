import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Customer } from './components/Customer';
import { Product } from './components/Product';
import { Store } from './components/Store';
import { Sale } from './components/Sale';
import { AddCustomer } from './components/AddCustomer';  





export default class App extends Component {
  displayName = App.name

  render() {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/Customer' component={Customer} />
        <Route path='/Product' component={Product} />
        <Route path='/Store' component={Store} />
        <Route path='/Sale' component={Sale} />         
            //<Route path='/AddCustomer' component={AddCustomer} />
            //<Route path='/Customer/edit/:custid' component={AddCustomer} /> 
              
      </Layout>
    );
  }
}
