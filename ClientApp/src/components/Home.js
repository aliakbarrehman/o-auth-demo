import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;
    constructor(props) {
        super(props);
        this.state = { result: "", loading: true };
    }

    componentDidMount() {
        this.authorize();
    }

    render() {
        return (
            <div>
                {this.state.loading ? <p>Loading...</p> : <p>{this.state.result}</p>}
            </div>
        );
    }

    async authorize() {
        const response = await fetch('auth');
        this.setState({ result: response.text, loading: false });
    }
}
