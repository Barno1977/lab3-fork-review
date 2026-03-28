// EmojiLists.jsx
export default function EmojiLists({
    likedEmojis,
    passedEmojis,
    generateListItems,
  }) {
    return (
      <div className="overall-emoji-lists-container">
        <div className="individual-emoji-list-container">
          <h3>Liked Emojis</h3>
          <ul>{likedEmojis.map(generateListItems)}</ul>
        </div>
        <div className="individual-emoji-list-container">
          <h3>Unselected Emojis</h3>
          <ul>{passedEmojis.map(generateListItems)}</ul>
        </div>
      </div>
    )
  }
  