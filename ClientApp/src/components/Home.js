import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;
    constructor(props) {
        super(props);
        this.state = { result: ""};
    }

    componentDidMount() {
        // fetch data here
        const accessToken = this.props.auth.getAccessToken();

        fetch("/api/JustA", {
            headers: new Headers({
                "Accept": "application/json",
                "Authorization": `Bearer ${accessToken}`
            })
        }).then(response => this.setState({ result: response.body })).catch(error => console.log(error));
    }

    render() {
        return (
            <div>
                {this.result}
            </div>
        );
    }
}
