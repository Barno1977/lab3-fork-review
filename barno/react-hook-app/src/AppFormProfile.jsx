import React, { useState } from 'react';
import FormProfile from './components/FormProfile';
import 'bootstrap/dist/css/bootstrap.min.css';

function AppFormProfile() {
  const [formData, setFormData] = useState({
    userImage: './src/assets/IMG_0003.JPG', // Replace with a real image URL,
    name: '',
    email: '',
    profession: ''
  });

  const [profiles, setProfiles] = useState([]);

  const handleChange = (event) => {
    const { name, value } = event.target;
    setFormData({
      ...formData,  // create a copy of the formData array.
      [name]: value
    }); //update form data input
  };

  const handleSubmit = (event) => {
    event.preventDefault();
    setProfiles([...profiles, formData]);
    setFormData({ userImage: '', name: '', email: '', profession: '' });
  }; //clear form inputs

  return (
    <div className="container mt-5">
      <h1 className="text-center">React Profile App</h1>
      <form onSubmit={handleSubmit} className="mb-4">
        <div className="mb-3">
          <input
            type="text"
            name="userImage"
            value={formData.userImage}
            onChange={handleChange}
            placeholder="Image URL"
            className="form-control"
          />
        </div>
        <div className="mb-3">
          <input
            type="text"
            name="name"
            value={formData.name}
            onChange={handleChange}
            placeholder="Name"
            className="form-control"
          />
        </div>
        <div className="mb-3">
          <input
            type="email"
            name="email"
            value={formData.email}
            onChange={handleChange}
            placeholder="Email"
            className="form-control"
          />
        </div>
        <div className="mb-3">
          <input
            type="text"
            name="profession"
            value={formData.profession}
            onChange={handleChange}
            placeholder="Profession"
            className="form-control"
          />
        </div>
        <button type="submit" className="btn btn-primary">Add Profile</button>
      </form>
      <div className="profile-container d-flex flex-wrap gap-4">
        {profiles.map((profile, index) => (
          <FormProfile
            key={index}
            userImage={profile.userImage}
            name={profile.name}
            email={profile.email}
            profession={profile.profession}
          />
        ))}
      </div>
    </div>
  );
}

export default AppFormProfile;