// App.jsx  parent component
import Header from './components/Header'
import TravelEntry from './components/TravelEntry'
import travelData from './components/travelData'
import './App.css'
import 'bootstrap/dist/css/bootstrap.min.css'

function App() {

  return (
    <>
      <div>
        <Header />
        <div className="container">
          {travelData.map((entry) => (
            <TravelEntry key={entry.id} {...entry} />
          ))}
        </div>
      </div>
    </>
  )
}

export default App
