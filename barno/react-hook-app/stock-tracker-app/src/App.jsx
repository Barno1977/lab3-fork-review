// src/App.jsx
import React, useState from 'react';
import stockData from './data/stockData';
import Stock from './components/Stock';
import './style.css';

export default function App() {
  const [currentData, setCurrentData] = React.useState(stockData);

  React.useEffect(() => {
    const id = setInterval(() => {
      setCurrentData(prev =>
        prev.map(s => ({
          ...s,
          currentPrice: +(
            Math.random() > 0.5
              ? s.currentPrice + Math.random() * 20
              : s.currentPrice - Math.random() * 20
          ).toFixed(2)
        }))
      );
    }, 4000);

    return () => clearInterval(id);
  }, []);

  return (
    <div>
      <header>
        <img className="app-logo" src="./images/app-logo.svg" alt="Logo" />
        <h1><span>Stock Tracker</span></h1>
      </header>

      <div className="wrapper">
        {currentData.map(stock => (
          <Stock key={stock.stockName} stock={stock} />
        ))}
      </div>
    </div>
  );
}