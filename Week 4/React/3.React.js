import React from "react";

function CalculateScore(props) {
  const average = props.Total / props.Goal;

  const style = {
    width: "500px",
    margin: "40px auto",
    padding: "20px",
    border: "2px solid black",
    borderRadius: "10px",
    backgroundColor: "#f5f5f5",
    textAlign: "left",
    fontFamily: "Arial"
  };

  return (
    <div style={style}>
      <h1 style={{ color: "blue", textAlign: "center" }}>
        Student Management Portal
      </h1>

      <h3>Name : {props.Name}</h3>

      <h3>School : {props.School}</h3>

      <h3>Total Marks : {props.Total}</h3>

      <h3>Goal : {props.Goal}</h3>

      <h2 style={{ color: "green" }}>
        Average Score : {average.toFixed(2)}
      </h2>
    </div>
  );
}

function App() {
  return (
    <div>
      <CalculateScore
        Name="Swayamshree Nayak"
        School="ABC Public School"
        Total={480}
        Goal={5}
      />
    </div>
  );
}

export default App;