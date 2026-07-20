import React, { useState } from "react";

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const flights = [
    {
      id: 1,
      flight: "AI-202",
      from: "Bhubaneswar",
      to: "Delhi",
      price: 5500
    },
    {
      id: 2,
      flight: "6E-501",
      from: "Kolkata",
      to: "Mumbai",
      price: 6200
    },
    {
      id: 3,
      flight: "UK-303",
      from: "Chennai",
      to: "Bengaluru",
      price: 4200
    }
  ];

  return (
    <div style={{ textAlign: "center", fontFamily: "Arial", padding: "20px" }}>
      <h1>Ticket Booking Application</h1>

      {isLoggedIn ? (
        <>
          <h2 style={{ color: "green" }}>Welcome User</h2>

          <h3>You can book flight tickets.</h3>

          <table
            border="1"
            cellPadding="10"
            style={{ margin: "20px auto" }}
          >
            <thead>
              <tr>
                <th>Flight</th>
                <th>From</th>
                <th>To</th>
                <th>Price</th>
                <th>Action</th>
              </tr>
            </thead>

            <tbody>
              {flights.map((item) => (
                <tr key={item.id}>
                  <td>{item.flight}</td>
                  <td>{item.from}</td>
                  <td>{item.to}</td>
                  <td>₹{item.price}</td>
                  <td>
                    <button
                      onClick={() =>
                        alert("Ticket booked successfully!")
                      }
                    >
                      Book Ticket
                    </button>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>

          <button onClick={() => setIsLoggedIn(false)}>
            Logout
          </button>
        </>
      ) : (
        <>
          <h2 style={{ color: "blue" }}>Welcome Guest</h2>

          <h3>You can browse the available flights.</h3>

          <table
            border="1"
            cellPadding="10"
            style={{ margin: "20px auto" }}
          >
            <thead>
              <tr>
                <th>Flight</th>
                <th>From</th>
                <th>To</th>
                <th>Price</th>
              </tr>
            </thead>

            <tbody>
              {flights.map((item) => (
                <tr key={item.id}>
                  <td>{item.flight}</td>
                  <td>{item.from}</td>
                  <td>{item.to}</td>
                  <td>₹{item.price}</td>
                </tr>
              ))}
            </tbody>
          </table>

          <button onClick={() => setIsLoggedIn(true)}>
            Login
          </button>
        </>
      )}
    </div>
  );
}

export default App;