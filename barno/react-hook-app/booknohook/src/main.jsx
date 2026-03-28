import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'
import AppHook from './App.jsx'

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <AppHook />
    {/* <BooksData/>
    <BookWithHook/>
    <BookNoHook/> */}
  </StrictMode>,
)
