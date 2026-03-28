using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИСТ3_23_ООП_Нурс_Лб_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, y, a1, b2, c3, d4, y5, x,sk;
            a = Convert.ToDouble(textBox1.Text); //арбуз 1
            b = Convert.ToDouble(textBox2.Text); // общ тетр 2
            c = Convert.ToDouble(textBox3.Text); // яблоки 3
            d = Convert.ToDouble(textBox4.Text); // Ананасы 4 
            y = Convert.ToDouble(textBox5.Text); // молоко  5
            a1 = Convert.ToDouble(textBox6.Text); //1
            b2 = Convert.ToDouble(textBox7.Text); //2
            c3 = Convert.ToDouble(textBox8.Text); //3
            d4 = Convert.ToDouble(textBox9.Text); //4
            y5 = Convert.ToDouble(textBox10.Text);//5
            x = (a * a1) + (b * b2) + (c * c3) + (d * d4) + (y * y5);
            
            double s = 0;
            
            if (x > 1000 & x < 3000)
                s = 0.05;
            else if (x > 3000 & x < 10000)
                s = 0.10;
            else if (x > 10000)
                s = 0.15;
            else if (x < 1000)
                s = 0;
            
            sk = x * (1 - s);
            

                        

            listBox1.Items.Clear();
            listBox1.Items.Add("Арбуз=" + (textBox1.Text + "*" + textBox6.Text) + "=" + a * a1);
            listBox1.Items.Add("Общ тет=" + (textBox2.Text + "*" + textBox7.Text) + "=" + b * b2);
            listBox1.Items.Add("Яблоки=" + (textBox3.Text + "*" + textBox8.Text) + "=" + c * c3);
            listBox1.Items.Add("Ананасы=" + (textBox4.Text + "*" + textBox9.Text) + "=" + d * d4);
            listBox1.Items.Add("Молоко=" + (textBox5.Text + "*" + textBox10.Text) + "=" + y * y5);
            listBox1.Items.Add("Общая сумма" + x);
            listBox1.Items.Add("Скидка" + s*100+"%");
            listBox1.Items.Add("Общая сумма с учетом скидки" + sk);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
