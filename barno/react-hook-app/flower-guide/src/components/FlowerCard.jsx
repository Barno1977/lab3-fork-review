export default function FlowerCard({ flower }) {
  return (
    <div style={{
      width: "100%", // Добавлено!
      display: "flex",
      alignItems: "center",
      marginBottom: "2rem",
      padding: "1rem",
      border: "2px solid #ddd",
      borderRadius: "10px",
      backgroundColor: "yellowgreen",
      color: "white"
    }}>
      <img
        src={flower.image}
        alt={flower.name}
        style={{
          width: "180px",
          marginRight: "1.5rem",
          borderRadius: "10px",
          objectFit: "cover"
        }}
      />
      <div>
        <h2 style={{ fontWeight: "bold", textTransform: "uppercase", marginBottom: "0.5rem" }}>{flower.name}</h2>
        <p style={{ fontStyle: "italic", color: "#777", marginBottom: "0.5rem" }}>{flower.category}</p>
        <p style={{ fontSize: "1.1rem" }}>{flower.info}</p>
      </div>
    </div>
  );
}
