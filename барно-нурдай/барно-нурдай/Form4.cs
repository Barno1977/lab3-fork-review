using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace барно_нурдай
{
    public partial class Form4 : Form
    {
        private List<Student> students = new List<Student>();
        private int editingIndex = -1;
        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            UpdateGrid(students);
        }

        private void UpdateGrid(List<Student> data)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            var student = new Student
            {
                ФИО = textBox1.Text,
                Группа = textBox2.Text,
                Оценки = textBox3.Text
            };

            students.Add(student);
            UpdateGrid(students);
            ClearInputs();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                editingIndex = dataGridView1.CurrentRow.Index;
                var student = students[editingIndex];

                textBox1.Text = student.ФИО;
                textBox2.Text = student.Группа;
                textBox3.Text = student.Оценки;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (editingIndex != -1 && editingIndex < students.Count)
            {
                students[editingIndex].ФИО = textBox1.Text;
                students[editingIndex].Группа = textBox2.Text;
                students[editingIndex].Оценки = textBox3.Text;

                UpdateGrid(students);
                ClearInputs();
                editingIndex = -1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                students.RemoveAt(dataGridView1.CurrentRow.Index);
                UpdateGrid(students);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var goodStudents = students.Where(s => s.HasOnlyGoodGrades()).ToList();
            if (goodStudents.Count == 0)
            {
                MessageBox.Show("Нет студентов с оценками 4 или 5.");
            }
            UpdateGrid(goodStudents);
        }

        private void ClearInputs()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}


