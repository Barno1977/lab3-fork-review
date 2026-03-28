import React, { useState } from 'react';
import './NavBar.css';

const NavBar = ({ query, onSearch }) => {
  const [input, setInput] = useState(query);

  const handleSubmit = (e) => {
    e.preventDefault();
    onSearch(input);
  };

  return (
    <nav className="navbar navbar-light bg-light mb-4">
      <div className="container">
        <h1>📚 Google Bookshelf</h1>
        <form onSubmit={handleSubmit} className="form-inline">
          <input
            type="text"
            className="form-control mr-2"
            value={input}
            onChange={(e) => setInput(e.target.value)}
            placeholder="Поиск книги..."
          />
          <button type="submit" className="btn btn-primary">Искать</button>
        </form>
      </div>
    </nav>
  );
};

export default NavBar;
