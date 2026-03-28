import { useState } from 'react';
import Header from './components/Header';
import Footer from './components/Footer';
import FlowerCard from './components/FlowerCard';
import { flowers } from './data';

export default function App() {
  const [filter, setFilter] = useState("Все");

  const categories = ["Все", ...new Set(flowers.map(f => f.category))];

  const filteredFlowers = filter === "Все"
    ? flowers
    : flowers.filter(flower => flower.category === filter);

  return (
    <div>
      <Header />
      <main style={{ padding: "2rem" }}>
        <div style={{ marginBottom: "2rem", textAlign: "center" }}>
          <label htmlFor="category" style={{ fontWeight: "bold", marginRight: "1rem" }}>Категория:</label>
          <select
            id="category"
            value={filter}
            onChange={(e) => setFilter(e.target.value)}
            style={{
              padding: "0.5rem",
              borderRadius: "8px",
              border: "1px solid #ccc",
              fontSize: "1rem"
            }}
          >
            {categories.map((cat, index) => (
              <option key={index} value={cat}>{cat}</option>
            ))}
          </select>
        </div>
<div style={{ Width: "100px", margin: "0 auto" }}>
  {filteredFlowers.map((flower, index) => (
    <FlowerCard key={index} flower={flower} />
  ))}

  {filteredFlowers.length === 0 && (
    <p style={{ textAlign: "center", fontStyle: "italic", color: "#888" }}>
      Нет цветов в этой категории 🌸
    </p>
  )}
</div>
      </main>
      <Footer />
    </div>
  );
}
