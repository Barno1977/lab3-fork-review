import React, { useState } from "react";

const flowersData = [
  { name: "Тюльпан", category: "garden" },
  { name: "Ромашка", category: "field" },
  { name: "Роза", category: "decorative" },
  // Добавьте больше цветов по желанию
];

const App = () => {
  const [selectedCategory, setSelectedCategory] = useState("all");

  const filteredFlowers =
    selectedCategory === "all"
      ? flowersData
      : flowersData.filter(flower => flower.category === selectedCategory);

  return (
    <div style={{ fontFamily: "Arial, sans-serif", backgroundColor: "#fef9f4" }}>
      <header style={{ backgroundColor: "#ffebf0", textAlign: "center", padding: "1em", fontSize: "1.5em", fontWeight: "bold" }}>
        🌼 Энциклопедия Цветов
      </header>

      <div style={{ textAlign: "center", padding: "1em", backgroundColor: "#fff6f0", borderBottom: "1px solid #ccc" }}>
        <label htmlFor="category">Категория: </label>
        <select
          id="category"
          value={selectedCategory}
          onChange={e => setSelectedCategory(e.target.value)}
        >
          <option value="all">Все</option>
          <option value="garden">Садовые</option>
          <option value="field">Полевые</option>
          <option value="decorative">Декоративные</option>
        </select>
      </div>

      <div style={{ display: "flex" }}>
        <aside style={{ width: "200px", backgroundColor: "#fff0f5", padding: "1em", borderRight: "1px solid #ccc" }}>
          <ul style={{ listStyle: "none", padding: 0 }}>
            <li onClick={() => setSelectedCategory("all")} style={{ cursor: "pointer", margin: "0.5em 0" }}>Все</li>
            <li onClick={() => setSelectedCategory("garden")} style={{ cursor: "pointer", margin: "0.5em 0" }}>Садовые</li>
            <li onClick={() => setSelectedCategory("field")} style={{ cursor: "pointer", margin: "0.5em 0" }}>Полевые</li>
            <li onClick={() => setSelectedCategory("decorative")} style={{ cursor: "pointer", margin: "0.5em 0" }}>Декоративные</li>
          </ul>
        </aside>

        <main style={{ flex: 1, padding: "1em" }}>
          {filteredFlowers.length > 0 ? (
            filteredFlowers.map((flower, index) => (
              <div
                key={index}
                style={{
                  border: "1px solid #ccc",
                  padding: "1em",
                  margin: "1em 0",
                  backgroundColor: "#ffffff",
                  borderRadius: "8px",
                  boxShadow: "1px 1px 5px rgba(0,0,0,0.1)"
                }}
              >
                FlowerCard: {flower.name}
              </div>
            ))
          ) : (
            <div style={{ textAlign: "center", color: "#888", fontStyle: "italic", padding: "2em" }}>
              Нет цветов в этой категории 🌸
            </div>
          )}
        </main>
      </div>

      <footer style={{ backgroundColor: "#ffebf0", textAlign: "center", padding: "1em", marginTop: "2em" }}>
        <div>© 2025 Цветочный сайт</div>
        <div>✨Asanbekova Akina✨</div>
      </footer>
    </div>
  );
};

export default App;
