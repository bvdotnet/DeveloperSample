import React, { useState } from "react";
import './LoginForm.css';

const LoginForm = (props) => {
    const [login, setLogin] = useState("");
    const [password, setPassword] = useState("");
    const [loggedInUsers, setLoggedInUsers] = useState([]);

    const handleSubmit = (event) => {
        event.preventDefault();
        if (!login || !password) {
            alert("Please enter a valid name and password.");
            return;
        }

        // check if the user is already logged in
        if (loggedInUsers.find(user => user.login === login)) {
            alert("User is already logged in!");
            return;
        }

        // add user to logged in users list
        setLoggedInUsers([...loggedInUsers, { login }]);

        // pass the login and password to the parent component
        props.onSubmit({
            login,
            password
        });
    }

    return (
        <div>
            <form className="form">
                <h1>Login</h1>
                <label htmlFor="name">Name</label>
                <input type="text" id="name" value={login} onChange={e => setLogin(e.target.value)} />
                <label htmlFor="password">Password</label>
                <input type="password" id="password" value={password} onChange={e => setPassword(e.target.value)} />
                <button type="submit" onClick={handleSubmit}>Continue</button>
            </form>
            <div className="logged-in-users">
                <h2>Logged In Users</h2>
                <ul>
                    {loggedInUsers.map((user, index) => (
                        <li key={index}>{user.login}</li>
                    ))}
                </ul>
            </div>
        </div>
    )
}

export default LoginForm;
