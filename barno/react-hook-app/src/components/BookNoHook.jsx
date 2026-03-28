//BookNoHoo.jsx
/** @format */

function BookNoHook({ title, author, description, subtitle, image }) {

  var isRead = true

  return (
    <div className="profile-container user-profile">
      <div>
        <img src={image} alt={title} />
      </div>
      <div>
        <h2>Title: {title}</h2>
        <h4>Subtitle: {subtitle}</h4>
        <h3>By {author}</h3>
        <p>Description: {description}</p>
        <button
          className="btn btn-primary"
          name="No Hook"
          value={isRead ? 'Read' : 'Unread'}
          onClick={(e) => {
            isRead = !isRead
            console.log('Status', isRead)
              console.log(e.target.name, e.target.value)
          }}>
          {isRead ? 'Read' : 'Unread'} //Not working. Why???
        </button>
      </div>
    </div>
  )
}
export default BookNoHook

  