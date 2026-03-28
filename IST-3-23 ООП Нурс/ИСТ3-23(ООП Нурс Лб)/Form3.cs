using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ИСТ3_23_ООП_Нурс_Лб_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.Add("");
            comboBox1.Items.Add("Молочная продукция");
            comboBox1.Items.Add("Овощи");
            comboBox1.Items.Add("Фрукты");

            comboBox1.SelectedIndex = 0; //  категория по умолчанию
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string kategoriya = comboBox1.SelectedItem.ToString();

            if (kategoriya == "Канцтовары")
            {
                dataGridView1.Rows.Add("", 50, 100, 50 * 100);
                dataGridView1.Rows.Add("Школьная тетрадь лн 12 л", 50, 100, 50 * 100);
                dataGridView1.Rows.Add("Общая тетрадь 48 л", 50, 100, 50 * 100);
                dataGridView1.Rows.Add("Общая тетрадь 96 л", 50, 100, 50 * 100);
                dataGridView1.Rows.Add("Общая тетрадь 120 л", 50, 100, 50 * 100);
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text));
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Cells[3].Value = (Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value) * Convert.ToDouble(dataGridView1.CurrentRow.Cells[1].Value));
        }

    }
    }

