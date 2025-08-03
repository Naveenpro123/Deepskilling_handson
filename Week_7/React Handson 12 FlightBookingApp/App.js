import React, { useState } from 'react';

function LoginButton(props) {
  return <button onClick={props.onClick}>Login</button>;
}

function LogoutButton(props) {
  return <button onClick={props.onClick}>Logout</button>;
}

function GuestGreeting() {
  return <h2>Please sign up.</h2>;
}

function UserGreeting() {
  return <h2>Welcome back.</h2>;
}

function Greeting(props) {
  if (props.isLoggedIn) {
    return <UserGreeting />;
  }
  return <GuestGreeting />;
}

function GuestView({ flights }) {
  return (
    <div>
      <h3>Available Flights</h3>
      <ul>
        {flights.map(f => (
          <li key={f.id}>{f.route} - ₹{f.price}</li>
        ))}
      </ul>
    </div>
  );
}

function UserView({ flights }) {
  return (
    <div>
      <h3>Book Your Tickets</h3>
      {flights.map(f => (
        <div key={f.id}>
          {f.route} - ₹{f.price}
          <button style={{ marginLeft: "10px" }}>Book</button>
        </div>
      ))}
    </div>
  );
}

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const flights = [
    { id: 1, route: "Chennai → Delhi", price: 4500 },
    { id: 2, route: "Mumbai → Bangalore", price: 4000 },
    { id: 3, route: "Hyderabad → Kolkata", price: 4800 },
  ];

  return (
    <div style={{ textAlign: "center", marginTop: "40px" }}>
      <h1>Ticket Booking App ✈️</h1>

      <Greeting isLoggedIn={isLoggedIn} />

      {isLoggedIn ? (
        <LogoutButton onClick={() => setIsLoggedIn(false)} />
      ) : (
        <LoginButton onClick={() => setIsLoggedIn(true)} />
      )}

      <hr />

      {isLoggedIn ? (
        <UserView flights={flights} />
      ) : (
        <GuestView flights={flights} />
      )}
    </div>
  );
}

export default App;
