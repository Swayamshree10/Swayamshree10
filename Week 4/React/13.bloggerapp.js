import React from "react";

function App() {

  // Change these flags to test different conditional rendering methods
  const showBooks = true;
  const showBlogs = true;
  const showCourses = true;

  const books = [
    { id: 1, title: "React Basics", author: "John" },
    { id: 2, title: "Learning JavaScript", author: "David" }
  ];

  const blogs = [
    { id: 1, title: "React Hooks", writer: "Alice" },
    { id: 2, title: "Understanding JSX", writer: "Bob" }
  ];

  const courses = [
    { id: 1, name: "ReactJS", duration: "30 Days" },
    { id: 2, name: "Angular", duration: "45 Days" }
  ];

  // Conditional Rendering using if-else
  let bookComponent;
  if (showBooks) {
    bookComponent = (
      <div>
        <h2>Book Details</h2>
        <ul>
          {books.map(book => (
            <li key={book.id}>
              <b>{book.title}</b> - {book.author}
            </li>
          ))}
        </ul>
      </div>
    );
  } else {
    bookComponent = <h3>Books are not available.</h3>;
  }

  return (
    <div style={{ fontFamily: "Arial", padding: "20px" }}>
      <h1>Blogger Application</h1>

      {/* Method 1 - if else */}
      {bookComponent}

      <hr />

      {/* Method 2 - Ternary Operator */}
      {showBlogs ? (
        <div>
          <h2>Blog Details</h2>
          <ul>
            {blogs.map(blog => (
              <li key={blog.id}>
                <b>{blog.title}</b> - {blog.writer}
              </li>
            ))}
          </ul>
        </div>
      ) : (
        <h3>No Blogs Available.</h3>
      )}

      <hr />

      {/* Method 3 - Logical && */}
      {showCourses && (
        <div>
          <h2>Course Details</h2>
          <ul>
            {courses.map(course => (
              <li key={course.id}>
                <b>{course.name}</b> - {course.duration}
              </li>
            ))}
          </ul>
        </div>
      )}
    </div>
  );
}

export default App;