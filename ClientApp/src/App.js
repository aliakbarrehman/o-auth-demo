import React, { Component } from 'react';
import { Route } from 'react-router';
import { Home } from './components/Home';
import AuthService from './Utils.js';

import './custom.css'

export default class App extends Component {
    static displayName = App.name;
    constructor() {
        super();
        this.authService = new AuthService();
    }
    auth() {
        let resultComponent = <Home auth={this.authService} />;

        if (!this.authService.isAuthenticated()) {
            this.authService.login();
            resultComponent = <Home auth={this.authService} />
        }

        return resultComponent;
    }

    render() {
        return (
            <>
                <Route exact path="/" render={() => this.auth()} />
                <Route exact path="/loggedin" render={() => {
                    this.authService.handleAuthentication();
                    return (<Home auth={this.authService} />);
                }} />
            </>
        );
    }
}