import React, { Component } from 'react'


export class Registration extends Component {

    componentDidMount() {
        this.populateUserData();
    }

    render() {
        return (
            <div>
                <h1>This is a test page</h1>
                <h1>check console for data</h1>
            </div>
        );
    }

    async populateUserData() {
        const response = await fetch('User');
        const data = await response.json();
        console.log(data);

    }
}