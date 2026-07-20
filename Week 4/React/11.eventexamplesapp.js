import React, { useState } from "react";

function App() {
  const [count, setCount] = useState(0);
  const [rupees, setRupees] = useState("");
  const [euro, setEuro] = useState("");

  // Increment Counter
  const increment = () => {
    setCount(count + 1);
    sayHello();
  };

  // Decrement Counter
  const decrement = () => {
    setCount(count - 1);
  };

  // Static Message
  const sayHello = () => {
    alert("Hello! Have a nice day.");
  };

  // Welcome Message
  const sayWelcome = (msg) => {
    alert(msg);
  };

  // Synthetic Event
  const handleClick = (event) => {
    alert("I was clicked");
  };

  // Currency Conversion
  const handleSubmit = () => {
    if (rupees === "" || isNaN(rupees)) {
      alert("Enter a valid amount");
      return;
    }

    const result = (parseFloat(rupees) / 90).toFixed(2);
    setEuro(result);
  };

  return (
    <div style={{ textAlign: "center", fontFamily: "Arial", marginTop: "30px" }}>
      <h1>React Event Examples</h1>

      <h2>Counter: {count}</h2>

      <button onClick={increment}>Increment</button>

      <button
        onClick={decrement}
        style={{ marginLeft: "10px" }}
      >
        Decrement
      </button>

      <br />
      <br />

      <button onClick={() => sayWelcome("Welcome")}>
        Say Welcome
      </button>

      <br />
      <br />

      <button onClick={handleClick}>
        Synthetic Event
      </button>

      <hr />

      <h2>Currency Convertor</h2>

      <input
        type="number"
        placeholder="Enter Rupees"
        value={rupees}
        onChange={(e) => setRupees(e.target.value)}
      />

      <br />
      <br />

      <button onClick={handleSubmit}>
        Convert
      </button>

      <h3>Euro: € {euro}</h3>
    </div>
  );
}

export default App;