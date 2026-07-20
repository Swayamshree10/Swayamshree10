import React from "react";

function CohortDetails({ name, status, startDate, coach, trainer }) {
  const boxStyle = {
    width: "300px",
    display: "inline-block",
    margin: "10px",
    padding: "10px 20px",
    border: "1px solid black",
    borderRadius: "10px",
    verticalAlign: "top"
  };

  const dtStyle = {
    fontWeight: 500
  };

  const headingStyle = {
    color: status.toLowerCase() === "ongoing" ? "green" : "blue"
  };

  return (
    <div style={boxStyle}>
      <h3 style={headingStyle}>{name}</h3>

      <dl>
        <dt style={dtStyle}>Status</dt>
        <dd>{status}</dd>

        <dt style={dtStyle}>Start Date</dt>
        <dd>{startDate}</dd>

        <dt style={dtStyle}>Coach</dt>
        <dd>{coach}</dd>

        <dt style={dtStyle}>Trainer</dt>
        <dd>{trainer}</dd>
      </dl>
    </div>
  );
}

function App() {
  return (
    <div>
      <h1 style={{ textAlign: "center" }}>
        Cognizant Academy Dashboard
      </h1>

      <CohortDetails
        name="React Learning Program"
        status="Ongoing"
        startDate="01-Jul-2026"
        coach="John"
        trainer="David"
      />

      <CohortDetails
        name="ASP.NET Core"
        status="Completed"
        startDate="15-May-2026"
        coach="Alice"
        trainer="James"
      />

      <CohortDetails
        name="Angular Training"
        status="Ongoing"
        startDate="10-Jul-2026"
        coach="Robert"
        trainer="Smith"
      />
    </div>
  );
}

export default App;