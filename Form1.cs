using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_
{
    public partial class Form1 : Form
    {
        Pan first = new Pan();
        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                first.name[x] = textBox1.Text;
                first.testo[x] = textBox2.Text;
                first.krem[x] = textBox3.Text;
                first.ves[x] = Convert.ToDouble(textBox4.Text);
                first.kal[x] = Convert.ToDouble(textBox5.Text);
                first.cena[x] = Convert.ToDouble(textBox6.Text);
                x++;
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if ((int)numericUpDown1.Value == 1)
                {
                    MessageBox.Show($"Название: {first.name[0]}\n Тесто: {first.testo[0]}\n Крем: {first.krem[0]}\n Вес: {first.ves[0]}\n Каллорийность: {first.kal[0]}\n Цена: {first.cena[0]}");
                }
                else if ((int)numericUpDown1.Value == 2)
                {
                    MessageBox.Show($"Название: {first.name[1]}\n Тесто: {first.testo[1]}\n Крем: {first.krem[1]}\n Вес: {first.ves[1]}\n Каллорийность: {first.kal[1]}\n Цена: {first.cena[1]}");
                }
                else label7.Text = "Неверное значение";

            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int)numericUpDown2.Value != 0 && (int)numericUpDown3.Value != 0)
                {
                    int z = (int)numericUpDown2.Value;
                    int c = (int)numericUpDown3.Value;
                    double n = first.cena[1] * c;
                    double t = first.cena[0] * z;
                    MessageBox.Show($"Итог: {n+t}");
                }
                else if ((int)numericUpDown2.Value != 0 || (int)numericUpDown3.Value != 0)
                {
                    int z = (int)numericUpDown2.Value;
                    if (z == 0)
                    {
                        int c = (int)numericUpDown3.Value;
                        double n = first.cena[1] * c;
                        MessageBox.Show($"Итог: {n}");
                    }
                    else
                    {
                        double n = first.cena[0] * z;
                        MessageBox.Show($"Итог: {n}");
                    }
                }
                else label9.Text = "Не введено кол-во";
            }
            catch { }
        }
    }
}
