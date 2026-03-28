// Header.jsx component
// 4. Create Header.jsx component

function Header() {
  return (
    <header className="d-flex align-items-center bg-warning p-3 ">
      <img
        src="/src/images/globe.png"
        alt="globe icon"
        style={{ width: '30px', marginRight: '10px' }}
      />
      <h1>My Favorite Travel Places in Kyrgyz</h1>
    </header>
  )
}

export default Header;