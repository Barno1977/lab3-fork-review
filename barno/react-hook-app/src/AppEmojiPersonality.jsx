import React from 'react'
import ResultsModal from './components/ResultsModal'
import EmojiLists from './components/EmojiLists'
import emojis from './data/emojis'
import { nanoid } from 'nanoid'
import './style.css'

export default function App() {
  // State to track emojis liked by the user
  const [likedEmojis, setLikedEmojis] = React.useState([])
  // State to track emojis the user didn't click
  const [passedEmojis, setPassedEmojis] = React.useState([])
  // Current set of three emojis to display
  const [currentEmojis, setCurrentEmojis] = React.useState(getRandomEmojis)
  // Control whether the results modal is shown
  const [showResults, setShowResults] = React.useState(false)
  // Control whether the final results are ready (after animation)
  const [resultsReady, setResultsReady] = React.useState(false)

  /**
   * handleClick — invoked when an emoji button is clicked.
   * 1. Add clicked emoji to likedEmojis.
   * 2. Add the other two emojis to passedEmojis.
   * 3. Refresh currentEmojis via getRandomEmojis().
   */
  function handleClick(event) {
    // Determine which emoji was clicked
    const clicked = event.target.innerText

    // 1️⃣ Add the clicked emoji to the end of likedEmojis array
    setLikedEmojis((prev) => [...prev, clicked])

    // 2️⃣ Collect the other two emojis and add them to passedEmojis
    const others = currentEmojis.filter((e) => e !== clicked)
    setPassedEmojis((prev) => [...prev, ...others])

    // 3️⃣ Generate three new random emojis for the next round
    setCurrentEmojis(getRandomEmojis)
  }

  /**
   * getRandomEmojis — returns an array of three random emojis
   * picked from the data/emojis.js array.
   */
  function getRandomEmojis() {
    function chooseRandomEmoji() {
      return emojis[Math.floor(Math.random() * emojis.length)]
    }
    return new Array(3).fill('').map(() => chooseRandomEmoji())
  }

  /** Show the results modal */
  function getResults() {
    setShowResults(true)
  }

  /** Reset all state for a new test */
  function reset() {
    setLikedEmojis([])
    setPassedEmojis([])
    setShowResults(false)
    setResultsReady(false)
  }

  // When showResults becomes true, start a timer to trigger the "resultsReady" state
  React.useEffect(() => {
    if (showResults) {
      setTimeout(() => {
        setResultsReady(true)
      }, 2000)
    }
  }, [showResults])

  // Utility to generate list items with unique keys
  function generateListItems(element) {
    return <li key={nanoid()}>{element}</li>
  }

  return (
    <div className="wrapper">
      {/* Counter showing how many emojis have been liked out of 10 */}
      <div className="results-counter">{likedEmojis.length} / 10</div>

      {/* Modal component for displaying final results */}
      <ResultsModal
        showResults={showResults}
        getResults={getResults}
        resultsReady={resultsReady}
        reset={reset}
        generateListItems={generateListItems}
        likedEmojis={likedEmojis}
      />

      <h1>Emoji Personality Test</h1>

      {/* Show three emoji buttons until 10 selections, then show Get Results */}
      {likedEmojis.length < 10 ? (
        <div className="overall-emojis-container">
          <button onClick={handleClick}>{currentEmojis[0]}</button>
          <button onClick={handleClick}>{currentEmojis[1]}</button>
          <button onClick={handleClick}>{currentEmojis[2]}</button>
        </div>
      ) : (
        !showResults && (
          <button className="get-results-button" onClick={getResults}>
            Get Results
          </button>
        )
      )}

      {/* Lists showing liked vs. passed emojis */}
      <EmojiLists
        likedEmojis={likedEmojis}
        passedEmojis={passedEmojis}
        generateListItems={generateListItems}
      />
    </div>
  )
}
