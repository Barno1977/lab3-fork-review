// BookWithHook.jsx
/** @format */

import { useState } from "react";

function BookWithHook({ title, author, description, subtitle, image }) {
  const [isRead, setIsRead] = useState(false);// state

  function onIsRead(event) {  //event handler for button click
    setIsRead(!isRead)
    console.log(event.target)
  }
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
        <button className="btn btn-primary" 
         name="With Hook" 
         value= {isRead ? 'Read' : 'Unread'}
         onClick={onIsRead}>
          {isRead ? "Read" : "Unread"}
        </button>
      </div>
    </div>
  );
}
export default BookWithHook;