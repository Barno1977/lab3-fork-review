using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace барно_нурдай
{
    public partial class Form3 : Form
    {
        private Matrix2D matrix;
        private Combinational combElement = new Combinational("AND_Gate", 3);

        public Form3()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int val1 = int.Parse(textBox1.Text);
                int val2 = int.Parse(textBox2.Text);
                int val3 = int.Parse(textBox3.Text);

                if ((val1 == 0 || val1 == 1) && (val2 == 0 || val2 == 1) && (val3 == 0 || val3 == 1))
                {
                    combElement.SetInputs(val1, val2, val3);
                    MessageBox.Show("Входы установлены!", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Введите только 0 или 1!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода! Введите только 0 или 1.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            combElement.ComputeOutput();
            label1.Text = $"Выход: {combElement.GetOutput()}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox4.Text);
            int m = Convert.ToInt32(textBox5.Text);
            matrix = new Matrix2D(n, m);
            matrix.FillRandom(-100, 50);
            matrix.DisplayInDataGridView(dataGridView1);

            if (matrix != null)
            {
                int sum = matrix.GetPositiveSum();
                label5.Text = $"Сумма: {sum}";
                int sum_pol = matrix.GetPositiveMax();
                label7.Text = $"Максимальное число: {sum_pol}";
                int sum_otriz = matrix.GetOtrizMin();
                label8.Text = $"Минимальное число: {sum_otriz}";
            }
            else
            {
                MessageBox.Show("Сначала создайте матрицу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Сначала создайте матрицу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем только положительные и только отрицательные двумерные массивы
            int[,] positiveMatrix = matrix.GetPositiveMatrix();
            int[,] negativeMatrix = matrix.GetNegativeMatrix();

            // Отображаем их в DataGridView
            Matrix2D.DisplayMatrixInDataGridView(positiveMatrix, dataGridView2);
            Matrix2D.DisplayMatrixInDataGridView(negativeMatrix, dataGridView3);
        }





        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}