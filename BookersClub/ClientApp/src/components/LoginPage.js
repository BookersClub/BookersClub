import React, { Component } from 'react';


export class Login extends Component {


    render() {
        return (
            <div>
                <div>
                    <p> Welcome to Bookers Club </p>
                </div>
                <div>
                    <label >Username</label>
                    <input className="User" type="text" />
                </div>
                <div>
                    <label>Enter Password</label>
                    <input className="User"type="text" />
                </div>
                <div>
                    <input type="submit" />
                </div>
                
            </div>
        );

    }




}
