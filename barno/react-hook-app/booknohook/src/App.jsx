// AppHook.jsx
import React from 'react'
import 'bootstrap/dist/css/bootstrap.min.css'
import booksData from '../booknohook/src/components/BooksData.js'
import BookNoHook from '../booknohook/src/components/BookNoHook.jsx'
import BookWithHook from '../booknohook/src/components/BookWithHook.jsx'
import './App.css'


function AppHook() {
  return (
    <>
      <h2> Your favorable Book List </h2>
      <div className="card-container card-body">
        {booksData.items.map((book, index) => (
          <BookNoHook
            key={index}
            title={book.volume.title}
            author={book.volume.authors}
            description={book.volume.description}
            subtitle={book.volume.subtitle}
            image={book.volume.image}
          />
        ))}
       {booksData.items.map((book, index) => (
          <BookWithHook
            key={index}
            title={book.volume.title}
            author={book.volume.authors}
            description={book.volume.description}
            subtitle={book.volume.subtitle}
            image={book.volume.image}
          />
        ))}
      </div>
    </>
  )
}

export default AppHook
