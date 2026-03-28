import express from 'express';
import cors from 'cors';

const app = express();
const PORT = 3000;


app.use(cors());
//app.use(bodyParser.json()); // Enable parsing JSON request bodies
app.use(express.json());

// Sample data
let books = [
  { id: 1, title: '1984', author: 'George Orwell' },
  { id: 2, title: 'To Kill a Mockingbird', author: 'Harper Lee' },
];

// GET all books - API Endpoints
app.get('/books', (req, res) => {
  res.json(books);
});

// GET a specific book
app.get('/books/:id', (req, res) => {
  const book = books.find(b => b.id == req.params.id);
  if (book) res.json(book);
  else res.status(404).send('Book not found');
});

// POST a new book
app.post('/books', (req, res) => {
  const newBook = { id: books.length + 1, ...req.body };
  books.push(newBook);
  res.status(201).json(newBook);// 201 Created status code
});

// PUT to update a book
app.put('/books/:id', (req, res) => {
  const index = books.findIndex(b => b.id == req.params.id);
  if (index !== -1) {
    books[index] = { id: parseInt(req.params.id), ...req.body };
    res.json(books[index]);
  } else res.status(404).send('Book not found');
});

// DELETE a book
app.delete('/books/:id', (req, res) => {
  books = books.filter(b => b.id != req.params.id);
  res.status(204).send();
});

app.listen(PORT, () => console.log(`Server running on http://localhost:${PORT}`));