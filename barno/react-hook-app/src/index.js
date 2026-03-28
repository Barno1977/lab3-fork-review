import React from 'react';
import ReactDOM from 'react-dom/client';
import AppBookShelf from './AppBookShelf';
import './index.css'; // если есть стили

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <AppBookShelf />
  </React.StrictMode>
);
