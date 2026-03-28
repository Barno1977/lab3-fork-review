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
    public partial class Form12 : Form
    {
        private int[,] matrix; // Глобальная матрица
        private int rows, cols; // Глобальные размеры матрицы
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRows.Text, out rows) && int.TryParse(txtCols.Text, out cols))
            {
                if (rows > 0 && cols > 0)
                {
                    FillMatrix(rows, cols);
                    CalculateSums();
                    FillListBoxes();   // Заполняем ListBox числами
                }
                else
                {
                    MessageBox.Show("Введите положительное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Введите корректные числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FillMatrix(int rows, int cols)
        {
            Random rand = new Random();
            matrix = new int[rows, cols];

            // Заполняем массив случайными числами от -10 до 10 включительно
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(-10, 11); // Генерирует числа от -10 до 10
                }
            }

            // Очищаем DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Создаём колонки
            for (int i = 0; i < cols; i++)
            {
                dataGridView1.Columns.Add("Column" + i, "Col " + (i + 1));
            }

            // Заполняем DataGridView числами
            for (int i = 0; i < rows; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < cols; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
        private void CalculateSums()
        {
            int sumPositive = 0;
            int sumNegative = 0;

            // Перебираем все ячейки DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && int.TryParse(cell.Value.ToString(), out int value))
                    {
                        if (value > 0)
                            sumPositive += value;
                        else if (value < 0)
                            sumNegative += value;
                    }
                }
            }

            // Отображаем суммы в Label
            lblPositiveSum.Text = "Сумма положительных: " + sumPositive;
            lblNegativeSum.Text = "Сумма отрицательных: " + sumNegative;
        }


        private void sorted_Click(object sender, EventArgs e)
        {
            // Очищаем DataGridView перед заполнением
            dataGridViewPositive.Rows.Clear();
            dataGridViewPositive.Columns.Clear();
            dataGridViewNegative.Rows.Clear();
            dataGridViewNegative.Columns.Clear();

            // Создаём колонки в обеих таблицах
            for (int i = 0; i < cols; i++)
            {
                dataGridViewPositive.Columns.Add("ColumnP" + i, "Col " + (i + 1));
                dataGridViewNegative.Columns.Add("ColumnN" + i, "Col " + (i + 1));
            }

            // Заполняем таблицы числами
            for (int i = 0; i < rows; i++)
            {
                dataGridViewPositive.Rows.Add();
                dataGridViewNegative.Rows.Add();

                for (int j = 0; j < cols; j++)
                {
                    int value = matrix[i, j];

                    if (value > 0)
                        dataGridViewPositive.Rows[i].Cells[j].Value = value;
                    else if (value < 0)
                        dataGridViewNegative.Rows[i].Cells[j].Value = value;
                }
            }
        }

        private void FillListBoxes()
        {
            // Очищаем ListBox перед заполнением
            listBoxPositive.Items.Clear();
            listBoxNegative.Items.Clear();

            // Заполняем ListBox значениями
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int value = matrix[i, j];

                    if (value > 0)
                        listBoxPositive.Items.Add(value);
                    else if (value < 0)
                        listBoxNegative.Items.Add(value);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBoxPositive_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}