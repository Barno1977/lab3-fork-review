import React from 'react';

const BookList = ({ books }) => {
  if (books.length === 0) return <p>Книги не найдены.</p>;

  return (
    <div className="row">
      {books.map((book, index) => {
        const info = book.volumeInfo;
        return (
          <div className="col-md-4 mb-4" key={index}>
            <div className="card h-100">
              {info.imageLinks?.thumbnail && (
                <img src={info.imageLinks.thumbnail} className="card-img-top" alt="обложка" />
              )}
              <div className="card-body">
                <h5 className="card-title">{info.title}</h5>
                <p className="card-text"><strong>Автор:</strong> {info.authors?.join(', ')}</p>
                <p className="card-text">{info.description?.substring(0, 100)}...</p>
                <a href={info.previewLink} target="_blank" rel="noreferrer" className="btn btn-secondary">
                  Подробнее
                </a>
              </div>
            </div>
          </div>
        );
      })}
    </div>
  );
};

export default BookList;
