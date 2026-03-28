// Some code
export default function ResultsModal({
    showResults,
    resultsReady,
    getResults,
    reset,
    likedEmojis,
    generateListItems,
  }) {
    if (!showResults) return null
    return (
      <div className="results-modal-container">
        <div className="modal-inner-container bounce-top">
          {resultsReady ? (
            <ul>{likedEmojis.map(generateListItems)}</ul>
          ) : (
            <p onClick={getResults} className="get-results-button">
              Get Results
            </p>
          )}
          {resultsReady && (
              <>
              <p>You have a great personality! </p>
            <p onClick={reset} className="try-again-button">
              Try Again
            </p>
            </>
          )}
        </div>
      </div>
    )
  }
  