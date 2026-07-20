import React from "react";

function App() {

  const officeImage =
    "https://images.unsplash.com/photo-1497366754035-f200968a6e72?w=800";

  const offices = [
    {
      id: 1,
      name: "Regus Business Center",
      rent: 55000,
      address: "Bhubaneswar, Odisha"
    },
    {
      id: 2,
      name: "WeWork",
      rent: 75000,
      address: "Bengaluru, Karnataka"
    },
    {
      id: 3,
      name: "Smart Office",
      rent: 48000,
      address: "Hyderabad, Telangana"
    },
    {
      id: 4,
      name: "Tech Hub",
      rent: 90000,
      address: "Pune, Maharashtra"
    }
  ];

  return (
    <div style={{ padding: "20px", fontFamily: "Arial" }}>

      <h1 style={{ textAlign: "center", color: "navy" }}>
        Office Space Rental App
      </h1>

      <img
        src={officeImage}
        alt="Office Space"
        width="500"
        height="300"
      />

      <hr />

      {offices.map((office) => (
        <div
          key={office.id}
          style={{
            border: "1px solid gray",
            borderRadius: "10px",
            padding: "15px",
            marginTop: "20px",
            width: "500px"
          }}
        >
          <h2>{office.name}</h2>

          <h3
            style={{
              color: office.rent < 60000 ? "red" : "green"
            }}
          >
            Rent: ₹{office.rent}
          </h3>

          <h3>Address: {office.address}</h3>
        </div>
      ))}
    </div>
  );
}

export default App;