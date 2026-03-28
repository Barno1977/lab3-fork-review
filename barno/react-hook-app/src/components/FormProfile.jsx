import React from 'react';
//import PropTypes from 'prop-types';

function FormProfile({ userImage, name, email, profession }) {
  return (
    <div className="user-profile d-flex border p-3 rounded">
      <div className="left-item me-3">
        <img src={userImage} alt={name} className="img-fluid rounded" style={{ width: '100px', height: '100px' }} />
      </div>
      <div className="right-item d-flex flex-column">
        <h5>{name}</h5>
        <p>{email}</p>
        <p>{profession}</p>
      </div>
    </div>
  );
}

/* FormProfile.propTypes = {
  userImage: PropTypes.string.isRequired,
  name: PropTypes.string.isRequired,
  email: PropTypes.string.isRequired,
  profession: PropTypes.string.isRequired,
}; */

export default FormProfile;