import React, { Component } from 'react';

// Home Component
class Home extends Component {
  render() {
    return (
      <div>
        <h2>Welcome to the Home page of Student Management Portal</h2>
      </div>
    );
  }
}

// About Component
class About extends Component {
  render() {
    return (
      <div>
        <h2>Welcome to the About page of the Student Management Portal</h2>
      </div>
    );
  }
}

// Contact Component
class Contact extends Component {
  render() {
    return (
      <div>
        <h2>Welcome to the Contact page of the Student Management Portal</h2>
      </div>
    );
  }
}

// Main App Component
class App extends Component {
  render() {
    return (
      <div>
        <Home />
        <About />
        <Contact />
      </div>
    );
  }
}

export default App;