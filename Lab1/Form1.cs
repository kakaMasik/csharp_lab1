using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Початкове значення X
            textBox1.Text = "3,4";
            // Початкове значення Y
            textBox2.Text = "0,74";
            // Початкове значення Z
            textBox3.Text = "19,43";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string v = (textBox5.Text);
            textBox4.Text += v;
            // Зчитування значення X
            double x = double.Parse(textBox1.Text);
            // Виведення значення X у вікно
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            // Зчитування значення Y
            double y = double.Parse(textBox2.Text);
            // Виведення значення Y у вікно
            textBox4.Text += Environment.NewLine + "Y=" + y.ToString();
            // Зчитування значення Z
            double z = double.Parse(textBox3.Text);
            // Виведення значення Z у вікно
            textBox4.Text += Environment.NewLine + "Z=" + z.ToString();
            // Обчислюємо арифметичний вираз
            double a = Math.Tan(x + y) * Math.Tan(x + y);
            double b = Math.Exp(y - z);
            double c = Math.Sqrt(Math.Cos(x * x) + Math.Sin(z * z));
            double u = a - b * c;
            // Виводимо результат у вікно
            textBox4.Text += Environment.NewLine + "Рзультат функції U = " + u.ToString();
        }
    }
}

