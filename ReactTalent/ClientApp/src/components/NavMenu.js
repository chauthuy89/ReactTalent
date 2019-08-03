import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './NavMenu.css';

export class NavMenu extends Component {
  displayName = NavMenu.name

  render() {
    return (
      <Navbar inverse fixedTop fluid collapseOnSelect>
        <Navbar.Header>
          <Navbar.Brand>
            <Link to={'/'}>ReactTalent</Link>
          </Navbar.Brand>
          <Navbar.Toggle />
        </Navbar.Header>
        <Navbar.Collapse>
          <Nav>
            <LinkContainer to={'/'} exact>
              <NavItem>
                <Glyphicon glyph='home' /> Home
              </NavItem>
            </LinkContainer>
            <LinkContainer to={'/counter'}>
              <NavItem>
                <Glyphicon glyph='education' /> Counter
              </NavItem>
            </LinkContainer>
            <LinkContainer to={'/fetchdata'}>
              <NavItem>
                <Glyphicon glyph='th-list' /> Fetch data
              </NavItem>
                    </LinkContainer>
            <LinkContainer to={'/fetchcustomer1'}>
                        <NavItem>
                            <Glyphicon glyph='th-list' /> Fetch Customer 1
              </NavItem>
                    </LinkContainer>
                    <LinkContainer to={'/customertest'}>
                        <NavItem>
                            <Glyphicon glyph='th-list' /> Customer test
              </NavItem>
                    </LinkContainer>
                    <LinkContainer to={'/fetchcustomer'}>
                        <NavItem>
                            <Glyphicon glyph='th-list' /> Fetch Customer
              </NavItem>
                    </LinkContainer>
                    <LinkContainer to={'/customer'}>
                        <NavItem>
                            <Glyphicon glyph='th-list' /> Customer
              </NavItem>
                    </LinkContainer>
                    <LinkContainer to={'/product'}>
                        <NavItem>
                            <Glyphicon glyph='th-list' /> Product
              </NavItem>
                    </LinkContainer>
                    <LinkContainer to={'/store'}>
                        <NavItem>
                            <Glyphicon glyph='th-list' /> Store
              </NavItem>
                    </LinkContainer>
            

                <LinkContainer to={'/sale'}>
                    <NavItem>
                        <Glyphicon glyph='th-list' /> Sale
              </NavItem>
                </LinkContainer>

          </Nav>
        </Navbar.Collapse>
      </Navbar>
    );
  }
}
