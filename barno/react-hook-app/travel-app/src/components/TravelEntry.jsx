// TravelEntry.jsx component

// 5. Create TravelEntry.jsx component
import React from 'react'

function TravelEntry({ img, title, country, googleMapsLink, dates, text }) {
  return (
    <article className="container mt-4 p-3 border rounded">
      <div className="row">
        <div className="col-md-4">
          <img src={img.src} alt={img.alt} className="img-fluid rounded" />
        </div>
        <div className="col-md-8">
          <div className="d-flex align-items-center mb-2">
            <img
              src="/src/images/marker.png"
              alt="marker"
              style={{ width: '16px', marginRight: '5px' }}
            />
            <span>{country}</span>
            <a 
              href={googleMapsLink}
              target="_blank"
              rel="noreferrer"
              className="ms-2 text-primary text-decoration-none ">
              View on Google Maps
            </a>
          </div>
          <h2>{title}</h2>
          <p className="text-muted fst-italic">{dates}</p>
          <p className="fs-5">{text}</p>
        </div>
      </div>
    </article>
  )
}

export default TravelEntry
