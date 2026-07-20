import React from "react";

function App() {

  // Change this flag
  const flag = true;

  // List of Players
  const players = [
    { name: "Virat Kohli", score: 90 },
    { name: "Rohit Sharma", score: 75 },
    { name: "Shubman Gill", score: 68 },
    { name: "KL Rahul", score: 82 },
    { name: "Hardik Pandya", score: 65 },
    { name: "Ravindra Jadeja", score: 71 },
    { name: "R Ashwin", score: 58 },
    { name: "Mohammed Shami", score: 49 },
    { name: "Jasprit Bumrah", score: 62 },
    { name: "Mohammed Siraj", score: 55 },
    { name: "Kuldeep Yadav", score: 77 }
  ];

  // Players having score below 70
  const below70 = players.filter(player => player.score < 70);

  // Odd & Even Team Players
  const IndianPlayers = [
    "Virat",
    "Rohit",
    "Gill",
    "Rahul",
    "Hardik",
    "Jadeja"
  ];

  const oddPlayers = IndianPlayers.filter((player, index) => index % 2 === 0);
  const evenPlayers = IndianPlayers.filter((player, index) => index % 2 !== 0);

  // Merge Arrays
  const T20Players = ["Virat", "Rohit", "Hardik"];
  const RanjiPlayers = ["Pujara", "Rahane", "Iyer"];

  const mergedPlayers = [...T20Players, ...RanjiPlayers];

  return (
    <div style={{ margin: "20px", fontFamily: "Arial" }}>

      <h1>Cricket Application</h1>

      {flag ? (
        <div>

          <h2>List of Players</h2>

          <table border="1" cellPadding="8">
            <thead>
              <tr>
                <th>Name</th>
                <th>Score</th>
              </tr>
            </thead>

            <tbody>
              {players.map((player, index) => (
                <tr key={index}>
                  <td>{player.name}</td>
                  <td>{player.score}</td>
                </tr>
              ))}
            </tbody>
          </table>

          <br />

          <h2>Players with Score Below 70</h2>

          <ul>
            {below70.map((player, index) => (
              <li key={index}>
                {player.name} - {player.score}
              </li>
            ))}
          </ul>

        </div>
      ) : (
        <div>

          <h2>Odd Team Players</h2>

          <ul>
            {oddPlayers.map((player, index) => (
              <li key={index}>{player}</li>
            ))}
          </ul>

          <h2>Even Team Players</h2>

          <ul>
            {evenPlayers.map((player, index) => (
              <li key={index}>{player}</li>
            ))}
          </ul>

          <h2>Merged Players</h2>

          <ul>
            {mergedPlayers.map((player, index) => (
              <li key={index}>{player}</li>
            ))}
          </ul>

        </div>
      )}

    </div>
  );
}

export default App;