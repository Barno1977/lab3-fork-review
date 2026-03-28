import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'
import AppHook from './AppHook.jsx'
import 'bootstrap/dist/css/bootstrap.min.css';
import AppFormProfile from './AppFormProfile.jsx';


createRoot(document.getElementById('root')).render(
  <StrictMode>
    <App/>
    {/* <BooksData/>`
    <BookWithHook/>
    <BookNoHook/> */}
  </StrictMode>,
)
