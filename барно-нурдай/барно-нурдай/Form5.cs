using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using static барно_нурдай.Form4;

namespace барно_нурдай
{
    public struct Note
    {
        public string FullName;
        public string PhoneNumber;
        public DateTime BirthDate;

        public override string ToString()
        {
            return $"{FullName}, {PhoneNumber}, {BirthDate:dd.MM.yyyy}";
        }
    }

    public partial class Form5 : Form
    {
        private List<Note> notes = new List<Note>();
        private int? editingIndex = null;


        private JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };
        private string filePath = "notes.json";

        public Form5()
        {
            InitializeComponent();
            SetupListView();
            LoadData();

        }

        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ФИО", 150);
            listView1.Columns.Add("Номер телефона", 120);
            listView1.Columns.Add("Дата рождения", 100);
            listView1.FullRowSelect = true;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        }

        private void DisplayNotes(List<Note> list)
        {
            listView1.Items.Clear();
            foreach (var note in list)
            {
                ListViewItem item = new ListViewItem(note.FullName);
                item.SubItems.Add(note.PhoneNumber);
                item.SubItems.Add(note.BirthDate.ToString("dd.MM.yyyy"));
                listView1.Items.Add(item);
            }
        }

        private void ClearInput()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }



        private void Form5_Load_1(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (notes.Count >= 8)
            {
                MessageBox.Show("Можно ввести только 8 записей.");
                return;
            }

            try
            {
                Note note = new Note
                {
                    FullName = textBox1.Text,
                    PhoneNumber = textBox2.Text,
                    BirthDate = DateTime.ParseExact(textBox3.Text, "dd.MM.yyyy", null)
                };

                notes.Add(note);
                DisplayNotes(notes);
                ClearInput();
                SaveData();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода. Убедитесь, что дата в формате дд.мм.гггг");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sorted = notes.OrderBy(n => n.BirthDate).ToList();
            DisplayNotes(sorted);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sorted = notes.OrderBy(n => n.FullName.ToLower()).ToList();
            DisplayNotes(sorted);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string phone = textBox4.Text;
            var found = notes.Where(n => n.PhoneNumber == phone).ToList();

            if (found.Any())
                DisplayNotes(found);
            else
                MessageBox.Show("Номер телефона не найден.");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                int month = int.Parse(textBox5.Text);
                var filtered = notes.Where(n => n.BirthDate.Month == month).ToList();

                if (filtered.Any())
                    DisplayNotes(filtered);
                else
                    MessageBox.Show("Нет людей, родившихся в этом месяце.");
            }
            catch
            {
                MessageBox.Show("Введите корректный номер месяца (1–12).");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisplayNotes(notes);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                var note = notes[index];

                textBox1.Text = note.FullName;
                textBox2.Text = note.PhoneNumber;
                textBox3.Text = note.BirthDate.ToString("dd.MM.yyyy");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите ФИО из списка.");
                return;
            }

            editingIndex = listView1.SelectedIndices[0];
            var note = notes[editingIndex.Value];

            textBox1.Text = note.FullName;
            textBox2.Text = note.PhoneNumber;
            textBox3.Text = note.BirthDate.ToString("dd.MM.yyyy");
        }


        private void SaveData()
        {
            File.WriteAllText(filePath, JsonSerializer.Serialize(notes, jsonOptions));
        }

        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                notes = JsonSerializer.Deserialize<List<Note>>(json, jsonOptions) ?? new List<Note>();
                DisplayNotes(notes);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (editingIndex == null)
            {
                MessageBox.Show("Сначала выберите ФИО и нажмите 'Редактировать'.");
                return;
            }

            try
            {
                Note updatedNote = new Note
                {
                    FullName = textBox1.Text,
                    PhoneNumber = textBox2.Text,
                    BirthDate = DateTime.ParseExact(textBox3.Text, "dd.MM.yyyy", null)
                };

                notes[editingIndex.Value] = updatedNote;
                DisplayNotes(notes);
                SaveData();

                MessageBox.Show("Данные обновлены.");
                editingIndex = null;
                ClearInput();
            }
            catch
            {
                MessageBox.Show("Ошибка! Проверьте правильность ввода даты.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            File.WriteAllText(filePath, JsonSerializer.Serialize(notes));
            MessageBox.Show("Сохранено!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0) return;

            int index = listView1.SelectedIndices[0];
            notes.RemoveAt(index);
            DisplayNotes(notes);
            SaveData();
        }
    }

}
        
    



