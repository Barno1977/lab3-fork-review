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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(); // Инициализация компонентов формы (текстовые поля, кнопки и т.д.)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Объявление переменных для хранения значений цены и количества
            double a, b, c, d, p, a1, b1, c1, d1, p1, total, discount = 0, finalAmount = 0;

            // Чтение значений из текстовых полей и преобразование их в числа
            a = Convert.ToDouble(textBox1.Text);  // Цена порошка
            b = Convert.ToDouble(textBox2.Text);  // Цена макарон
            c = Convert.ToDouble(textBox3.Text);  // Цена мороженого
            d = Convert.ToDouble(textBox4.Text);  // Цена чайника
            p = Convert.ToDouble(textBox5.Text);  // Цена сахара

            a1 = Convert.ToDouble(textBox6.Text); // Количество порошка
            b1 = Convert.ToDouble(textBox7.Text); // Количество макарон
            c1 = Convert.ToDouble(textBox8.Text); // Количество мороженого
            d1 = Convert.ToDouble(textBox9.Text); // Количество чайников
            p1 = Convert.ToDouble(textBox10.Text);// Количество сахара

            // Вычисление стоимости каждого товара (цена * количество)
            double f = a * a1;
            double g = b * b1;
            double z = c * c1;
            double n = d * d1;
            double m = p * p1;

            // Итоговая стоимость всех товаров
            total = f + g + z + n + m;

            // Определение скидки в зависимости от итоговой суммы
            if (total >= 1000 && total < 2000)
            {
                discount = Math.Round(total * 0.05, 0); // 5% скидка
            }
            else if (total >= 2000 && total < 3000)
            {
                discount = Math.Round(total * 0.10, 0); // 10% скидка
            }
            else if (total >= 3000 && total <= 4000)
            {
                discount = Math.Round(total * 0.15, 0); // 15% скидка
            }

            // Итоговая сумма после вычета скидки
            finalAmount = Math.Round(total - discount, 0);

            // Очистка списка перед выводом новых значений
            listBox1.Items.Clear();

            // Вывод информации в ListBox
            listBox1.Items.Add($"Порошок: {a} сом * {a1} кг = {f}");
            listBox1.Items.Add($"Макароны: {b} сом * {b1} кг = {g}");
            listBox1.Items.Add($"Мороженое: {c} сом * {c1} шт = {z}");
            listBox1.Items.Add($"Чайник: {d} сом * {d1} шт = {n}");
            listBox1.Items.Add($"Сахар: {p} сом * {p1} кг = {m}");
            listBox1.Items.Add($"Итого: {total} сом");
            listBox1.Items.Add($"Скидка: {discount} сом");
            listBox1.Items.Add($"Итоговая сумма со скидкой: {finalAmount} сом");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закрытие программы
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


