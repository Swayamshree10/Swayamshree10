import React, { Component } from "react";

class App extends Component {
  constructor(props) {
    super(props);

    this.state = {
      posts: [],
      error: null
    };
  }

  // Fetch posts
  loadPosts = () => {
    fetch("https://jsonplaceholder.typicode.com/posts")
      .then((response) => response.json())
      .then((data) => {
        this.setState({ posts: data });
      })
      .catch((error) => {
        this.setState({ error: error.message });
      });
  };

  // Lifecycle Hook
  componentDidMount() {
    this.loadPosts();
  }

  // Error Handling Hook
  componentDidCatch(error) {
    alert("Error: " + error);
  }

  render() {
    return (
      <div style={{ padding: "20px" }}>
        <h1>Blog Application</h1>

        {this.state.error && (
          <h3 style={{ color: "red" }}>{this.state.error}</h3>
        )}

        {this.state.posts.map((post) => (
          <div
            key={post.id}
            style={{
              border: "1px solid gray",
              padding: "10px",
              marginBottom: "10px",
              borderRadius: "5px"
            }}
          >
            <h3>{post.title}</h3>
            <p>{post.body}</p>
          </div>
        ))}
      </div>
    );
  }
}

export default App;