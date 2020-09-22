using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Дробные числа следует вводить в десятичном представлении, с помощью символа ',' (запятой).", "Напоминание");
        }

        void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                double sum = a + b;
                 sum = Math.Round(sum, 10);
                MessageBox.Show(a + " " + "+" + " " + b + " " + "=" + " " + sum,"Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString(a + " " + "+" + " " + b + " " + "=" + " " + sum);
                listBox1.Items.Add(s);

            }
            else if (double.TryParse(textBox1.Text, out a) || double.TryParse(textBox2.Text, out b))
            {
                if (!(double.TryParse(textBox1.Text, out a)) || double.TryParse(textBox2.Text, out b))
                {
                    MessageBox.Show("Не введен или введен некорректно Аргумент 1","Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен или введен некорректно Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы/Оба аргумента не введены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                double res = a - b;
                res = Math.Round(res, 10);
                MessageBox.Show(a + " " + "-" + " " + b + " " + "=" + " " + res, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString(a + " " + "-" + " " + b + " " + "=" + " " + res);
                listBox1.Items.Add(s);
            }
            else if (double.TryParse(textBox1.Text, out a) || double.TryParse(textBox2.Text, out b))
            {
                if (!(double.TryParse(textBox1.Text, out a)) || double.TryParse(textBox2.Text, out b))
                {
                    MessageBox.Show("Не введен или введен некорректно Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен или введен некорректно Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы/Оба аргумента не введены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                double prod = a * b;
                prod = Math.Round(prod, 10);
                MessageBox.Show(a + " " + "*" + " " + b + " " + "=" + " " + prod,"Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString(a + " " + "*" + " " + b + " " + "=" + " " + prod);
                listBox1.Items.Add(s);
            }
            else if (double.TryParse(textBox1.Text, out a) || double.TryParse(textBox2.Text, out b))
            {
                if (!(double.TryParse(textBox1.Text, out a)) || double.TryParse(textBox2.Text, out b))
                {
                    MessageBox.Show("Не введен или введен некорректно Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен или введен некорректно Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы/Оба аргумента не введены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                double quo = a / b;
                quo = Math.Round(quo, 10);
                MessageBox.Show(a + " " + "/" + " " + b + " " + "=" + " " + quo, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString(a + " " + "/" + " " + b + " " + "=" + " " + quo);
                listBox1.Items.Add(s);
            }
            else if (double.TryParse(textBox1.Text, out a) || double.TryParse(textBox2.Text, out b))
            {
                if (!(double.TryParse(textBox1.Text, out a)) || double.TryParse(textBox2.Text, out b))
                {
                    MessageBox.Show("Не введен или введен некорректно Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен или введен некорректно Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы/Оба аргумента не введены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {             
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                
                double div = a % b;

                MessageBox.Show(a + " " + "%" + " " + b + " " + "=" + " " + div, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString(a + " " + "%" + " " + b + " " + "=" + " " + div);
                listBox1.Items.Add(s);
            }
            else if (double.TryParse(textBox1.Text, out a) || double.TryParse(textBox2.Text, out b))
            {
                if (!(double.TryParse(textBox1.Text, out a)) || double.TryParse(textBox2.Text, out b))
                {
                    MessageBox.Show("Не введен или введен некорректно Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен или введен некорректно Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы/Оба аргумента не введены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool a, b;
            int a_, b_;
            if (bool.TryParse(textBox1.Text, out a) && bool.TryParse(textBox2.Text, out b))
            {
                bool and = a && b;
                MessageBox.Show(a + " " + "&&" + " " + b + " " + "=" + " " + and, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString(a + " " + "&&" + " " + b + " " + "=" + " " + and);
                listBox1.Items.Add(s);
            }
            
            else if (int.TryParse(textBox1.Text, out a_) && int.TryParse(textBox2.Text, out b_))
            {
                int and = a_ & b_;
                MessageBox.Show(a_ + " " + "&" + " " + b_ + " " + "=" + " " + and, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString(a_ + " " + "&" + " " + b_ + " " + "=" + " " + and);
                listBox1.Items.Add(s);
            }
            else if (bool.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b_))
            {
                MessageBox.Show("Аргумент 1 - логический; Аргумент 2 - целочисленный", "Некорректная комбинация аргументов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(textBox1.Text, out a_) && bool.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Аргумент 1 - целочисленный; Аргумент 2 - логический", "Некорректная комбинация аргументов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(textBox1.Text, out a_) || int.TryParse(textBox2.Text, out b_))
            {
                if (!(int.TryParse(textBox1.Text, out a_)) || int.TryParse(textBox2.Text, out b_))
                {
                    MessageBox.Show("Не введен или неверно введен Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен или неверно введен Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (bool.TryParse(textBox1.Text, out a) || bool.TryParse(textBox2.Text, out b))
            {
                if (!(bool.TryParse(textBox1.Text, out a)) || bool.TryParse(textBox2.Text, out b))
                {
                    MessageBox.Show("Не введен или неверно введен Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен или неверно введен Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы/Оба аргумента не введены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            bool a, b;
            int a_, b_;
            if (bool.TryParse(textBox1.Text, out a) && bool.TryParse(textBox2.Text, out b))
            {
                bool or = a || b;
                MessageBox.Show(a + " " + "||" + " " + b + " " + "=" + " " + or, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString(a + " " + "||" + " " + b + " " + "=" + " " + or);
                listBox1.Items.Add(s);
            }

            else if (int.TryParse(textBox1.Text, out a_) && int.TryParse(textBox2.Text, out b_))
            {
                int or = a_ | b_;
                MessageBox.Show(a_ + " " + "||" + " " + b_ + " " + "=" + " " + or, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString(a_ + " " + "||" + " " + b_ + " " + "=" + " " + or);
                listBox1.Items.Add(s);
            }
            else if (bool.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b_))
            {
                MessageBox.Show("Аргумент 1 - логический; Аргумент 2 - целочисленный", "Некорректная комбинация аргументов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(textBox1.Text, out a_) && bool.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Аргумент 1 - целочисленный; Аргумент 2 - логический", "Некорректная комбинация аргументов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(textBox1.Text, out a_) || int.TryParse(textBox2.Text, out b_))
            {
                if (!(int.TryParse(textBox1.Text, out a_)) || int.TryParse(textBox2.Text, out b_))
                {
                    MessageBox.Show("Не введен или неверно введен Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен или неверно введен Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (bool.TryParse(textBox1.Text, out a) || bool.TryParse(textBox2.Text, out b))
            {
                if (!(bool.TryParse(textBox1.Text, out a)) || bool.TryParse(textBox2.Text, out b))
                {
                    MessageBox.Show("Не введен Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы/Оба аргумента не введены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool a, b;
            int a_, b_;
            if (bool.TryParse(textBox1.Text, out a) && bool.TryParse(textBox2.Text, out b))
            {
                bool Xor = a ^ b;
                MessageBox.Show(a + " " + "^" + " " + b + " " + "=" + " " + Xor, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString(a + " " + "^" + " " + b + " " + "=" + " " + Xor);
                listBox1.Items.Add(s);
            }

            else if (int.TryParse(textBox1.Text, out a_) && int.TryParse(textBox2.Text, out b_))
            {
                int Xor = a_ ^ b_;
                MessageBox.Show(a_ + " " + "^" + " " + b_ + " " + "=" + " " + Xor, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString(a_ + " " + "^" + " " + b_ + " " + "=" + " " + Xor);
                listBox1.Items.Add(s);
            }
            else if (bool.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b_))
            {
                MessageBox.Show("Аргумент 1 - логический; Аргумент 2 - целочисленный", "Некорректная комбинация аргументов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(textBox1.Text, out a_) && bool.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Аргумент 1 - целочисленный; Аргумент 2 - логический", "Некорректная комбинация аргументов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(textBox1.Text, out a_) || int.TryParse(textBox2.Text, out b_))
            {
                if (!(int.TryParse(textBox1.Text, out a_)) || int.TryParse(textBox2.Text, out b_))
                {
                    MessageBox.Show("Не введен или неверно введен Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен или неверно введен Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (bool.TryParse(textBox1.Text, out a) || bool.TryParse(textBox2.Text, out b))
            {
                if (!(bool.TryParse(textBox1.Text, out a)) || bool.TryParse(textBox2.Text, out b))
                {
                    MessageBox.Show("Не введен Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы/Оба аргумента не введены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            bool a, b;
            int a_, b_;
            if (bool.TryParse(textBox1.Text, out a) && bool.TryParse(textBox2.Text, out b))
            {
                a = !a;
                b = !b;
                MessageBox.Show("Не Аргумент 1 = " + a + ";" + " " + "Не Аргумент 2 =" + b + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString("Не Аргумент 1 = " + a + ";" + " " + "Не Аргумент 2 =" + b + ".");
                listBox1.Items.Add(s);
            }
            else if (int.TryParse(textBox1.Text, out a_) && int.TryParse(textBox2.Text, out b_))
            {
                a_ = ~a_;
                b_ = ~b_;
                MessageBox.Show("Не Аргумент 1 = " + a_ + ";" + " " + "Не Аргумент 2 =" + b_ + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString("Не Аргумент 1 = " + a_ + ";" + " " + "Не Аргумент 2 =" + b_ + ".");
                listBox1.Items.Add(s);
            }
            else if (bool.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b_))
            {
                a = !a;
                b_ = ~b_;
                MessageBox.Show("Не Аргумент 1 = " + a + ";" + " " + "Не Аргумент 2 =" + b_ + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString("Не Аргумент 1 = " + a + ";" + " " + "Не Аргумент 2 =" + b_ + ".");
                listBox1.Items.Add(s);
            }
            else if (int.TryParse(textBox1.Text, out a_) && bool.TryParse(textBox2.Text, out b))
            {
                a_ = ~a_;
                b = !b;
                MessageBox.Show("Не Аргумент 1 = " + a_ + ";" + " " + "Не Аргумент 2 =" + b + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString("Не Аргумент 1 = " + a_ + ";" + " " + "Не Аргумент 2 =" + b + ".");
                listBox1.Items.Add(s);
            }
            else if (bool.TryParse(textBox1.Text, out a) ^ bool.TryParse(textBox2.Text, out b))
            
                if (!(bool.TryParse(textBox1.Text, out a)) || bool.TryParse(textBox2.Text, out b))
                {
                    MessageBox.Show("Аргумент 1 не введен или не корректен", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    b = !b;
                    MessageBox.Show("Не Аргумент 2 = " + b + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString("Не Аргумент 2 = " + b + ".");
                    listBox1.Items.Add(s);
                }
                else
                {
                    a = !a;
                    MessageBox.Show("Не Аргумент 1 = " + a + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString("Не Аргумент 1 = " + a + ".");
                    listBox1.Items.Add(s);
                    MessageBox.Show("Аргумент 2 не введен или не корректен", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            else if (int.TryParse(textBox1.Text, out a_) ^ int.TryParse(textBox2.Text, out b_))
            {
                if (!(int.TryParse(textBox1.Text, out a_)) || int.TryParse(textBox2.Text, out b_))
                {
                    MessageBox.Show("Аргумент 1 не введен или не корректен", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    b_ = ~b_;
                    MessageBox.Show("Не Аргумент 2 = " + b_ + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString("Не Аргумент 2 = " + b_ + ".");
                    listBox1.Items.Add(s);
                }
                else
                {
                    a_ = ~a_;
                    MessageBox.Show("Не Аргумент 1 = " + a_ + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString("Не Аргумент 1 = " + a_ + ".");
                    listBox1.Items.Add(s);
                    MessageBox.Show("Аргумент 2 не введен или не корректен", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы/Оба аргумента не введены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                if (a > b)
                {
                    MessageBox.Show(a + " " + ">" + " " + b + " ", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString(a + " " + ">" + " " + b + " ".ToString());
                    listBox1.Items.Add(s);
                }
                else if (a == b)
                {
                    MessageBox.Show(b + " " + "==" + " " + a + " ", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString(a + " " + "==" + " " + b + " ".ToString());
                }
                else
                {
                    MessageBox.Show(b + " " + ">" + " " + a + " ", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString(b + " " + ">" + " " + a + " ".ToString());
                    listBox1.Items.Add(s);
                }
            }
            else if (double.TryParse(textBox1.Text, out a) || double.TryParse(textBox2.Text, out b))
            {
                if (!(double.TryParse(textBox1.Text, out a)) || double.TryParse(textBox2.Text, out b))
                {
                    MessageBox.Show("Не введен Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы/Оба аргумента не введены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
                if (a < b)
                {
                    MessageBox.Show(a + " " + "<" + " " + b + " ", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString(a + " " + "<" + " " + b + " ".ToString());
                    listBox1.Items.Add(s);
                }
                else if (a == b)
                {
                    MessageBox.Show(b + " " + "==" + " " + a + " ", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString(a + " " + "==" + " " + b + " ".ToString());
                }
                else
                {
                    MessageBox.Show(b + " " + "<" + " " + a + " ".ToString());
                    string s = Convert.ToString(b + " " + "<" + " " + a + " ".ToString());
                    listBox1.Items.Add(s);
                }
            else if (double.TryParse(textBox1.Text, out a) || double.TryParse(textBox2.Text, out b))
            {
                if (!(double.TryParse(textBox1.Text, out a)) || double.TryParse(textBox2.Text, out b))
                {
                    MessageBox.Show("Не введен Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы/Оба аргумента не введены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                if (a >= b)
                {
                    MessageBox.Show(a + " " + ">=" + " " + b + " ", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString(a + " " + ">=" + " " + b + " ".ToString());
                    listBox1.Items.Add(s);
                }
                else
                {
                    MessageBox.Show(b + " " + ">=" + " " + a + " ", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString(b + " " + ">=" + " " + a + " ".ToString());
                    listBox1.Items.Add(s);
                }
            }
            else if (double.TryParse(textBox1.Text, out a) || double.TryParse(textBox2.Text, out b))
            {
                if (!(double.TryParse(textBox1.Text, out a)) || double.TryParse(textBox2.Text, out b))
                {
                    MessageBox.Show("Не введен Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы/Оба аргумента не введены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
                if (a <= b)
                {
                    MessageBox.Show(a + " " + "<=" + " " + b + " ", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString(a + " " + "<=" + " " + b + " ");
                    listBox1.Items.Add(s);
                }
                else
                {
                    MessageBox.Show(b + " " + "<=" + " " + a + " ", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString(b + " " + "<=" + " " + a + " ".ToString());
                    listBox1.Items.Add(s);
                }
            else if (double.TryParse(textBox1.Text, out a) || double.TryParse(textBox2.Text, out b))
            {
                if (!(double.TryParse(textBox1.Text, out a)) || double.TryParse(textBox2.Text, out b))
                {
                    MessageBox.Show("Не введен Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы/Оба аргумента не введены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                if (a == b)
                {
                    MessageBox.Show(a + " " + "==" + " " + b + " ", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString(a + " " + "==" + " " + b + " ".ToString());
                    listBox1.Items.Add(s);
                }
                else if (a != b || b != a)
                {
                    MessageBox.Show(a + " " + "!=" + " " + b + " " + " или " + b + " " + "!=" + " " + a + " ", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString(a + " " + "!=" + " " + b + " " + " или " + b + " " + "!=" + " " + a + " ".ToString());
                    listBox1.Items.Add(s);
                }
            }
            else if (double.TryParse(textBox1.Text, out a) || double.TryParse(textBox2.Text, out b))
            {
                if (!(double.TryParse(textBox1.Text, out a)) || double.TryParse(textBox2.Text, out b))
                {
                    MessageBox.Show("Не введен Аргумент 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не введен Аргумент 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы/Оба аргумента не введены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {               
                int count1 = 0;
                int count2 = 0;
                while (a < 1 && a > 0) { a = a * 2; count1--; }
                while (b < 1 && b > 0) { b = b * 2; count2--; }
                while (b > 1) { b = b / 2; count2++; }
                while (a > 1) { a = a / 2; count1++; }
                if (a > 0 && b > 0)
                {
                    if (a == 1 && b == 1)
                    {
                        MessageBox.Show("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string s = Convert.ToString("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2);
                        listBox1.Items.Add(s);
                    }
                    else if (a == 1 && b != 1)
                    {
                        if (a == 1 && (b % 1 != 0))
                        {
                            MessageBox.Show("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - не степень двойки", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            string s = Convert.ToString("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - не степень двойки");
                            listBox1.Items.Add(s);
                        }
                        else if (a == 1 && (b % 1 == 0))
                        {
                            MessageBox.Show("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + " " + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            string s = Convert.ToString("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2);
                            listBox1.Items.Add(s);
                        }
                    }
                    else if (a != 1 && b == 1)
                    {
                        if (b == 1 && (a % 1 != 0))
                        {
                            MessageBox.Show("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            string s = Convert.ToString("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2);
                            listBox1.Items.Add(s);
                        }
                        else if (b == 1 && (a % 1 == 0))
                        {
                            MessageBox.Show("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            string s = Convert.ToString("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2);
                            listBox1.Items.Add(s);
                        }
                    }
                    else if (a != 1 && b != 1)
                    {
                        if ((a % 1 == 0) && (b % 1 == 0))
                        {
                            MessageBox.Show("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            string s = Convert.ToString("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2);
                            listBox1.Items.Add(s);
                        }
                        else if ((a % 1 == 0) && (b % 1 != 0))
                        {
                            MessageBox.Show("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - не степень двойки", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            string s = Convert.ToString("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - не степень двойки");
                            listBox1.Items.Add(s);
                        }
                        else if ((a % 1 != 0) && (b == 0))
                        {
                            MessageBox.Show("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            string s = Convert.ToString("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2);
                            listBox1.Items.Add(s);
                        }
                        else if ((a % 1 != 0) && (b % 1 != 0))
                        {
                            MessageBox.Show("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            string s = Convert.ToString("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки");
                            listBox1.Items.Add(s);
                        }
                        else if ((a % 1 != 0) && (b % 1 == 0))
                        {
                            MessageBox.Show("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            string s = Convert.ToString("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки");
                            listBox1.Items.Add(s);
                        }
                        else if ((a % 1 == 0) && (b % 1 != 0))
                        {
                            MessageBox.Show("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            string s = Convert.ToString("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки");
                            listBox1.Items.Add(s);
                        }
                    }
                }
                else if (a > 0 && b == 0)
                {
                    if (a % 1 == 0)
                    {
                        MessageBox.Show("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - не степень двойки", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string s = Convert.ToString("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - не степень двойки");
                        listBox1.Items.Add(s);
                    }
                    else
                    {
                        MessageBox.Show("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string s = Convert.ToString("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки");
                        listBox1.Items.Add(s);
                    }
                }
                else if (a == 0 && b > 0)
                {
                    if (b % 1 == 0)
                    {
                        MessageBox.Show("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string s = Convert.ToString("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2);
                        listBox1.Items.Add(s);
                    }
                    else
                    {
                        MessageBox.Show("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string s = Convert.ToString("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки");
                        listBox1.Items.Add(s);
                    }
                }
                else if (a == 0 && b == 0)
                {
                    MessageBox.Show("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки");
                    listBox1.Items.Add(s);
                }
                else if (a > 0 && b < 0)
                {
                    if (a % 1 == 0)
                    {
                        MessageBox.Show("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - не степень двойки", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string s = Convert.ToString("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ";" + " " + "Аргумент 2 - не степень двойки");
                        listBox1.Items.Add(s);
                    }
                    else
                    {
                        MessageBox.Show("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string s = Convert.ToString("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки");
                        listBox1.Items.Add(s);
                    }
                }
                else if (a < 0 && b > 0)
                {
                    if (b % 1 == 0)
                    {
                        MessageBox.Show("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string s = Convert.ToString("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - степень двойки, это" + " " + "2^" + count2);
                        listBox1.Items.Add(s);
                    }
                    else
                    {
                        MessageBox.Show("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string s = Convert.ToString("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки");
                        listBox1.Items.Add(s);
                    }
                }
                else if (a < 0 && b < 0)
                {
                    MessageBox.Show("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString("Аргумент 1 - не степень двойки" + ";" + " " + "Аргумент 2 - не степень двойки");
                    listBox1.Items.Add(s);
                }
            }
            else if (double.TryParse(textBox1.Text, out a) ^ double.TryParse(textBox2.Text, out b))
            {
                if (!(double.TryParse(textBox1.Text, out a)) || double.TryParse(textBox2.Text, out b))
                {
                    int count2 = 0;
                    while (b < 1 && b > 0) { b = b * 2; count2--; }
                    while (b > 1) { b = b / 2; count2++; }
                    if (b == 1) 
                    {
                        MessageBox.Show("Аргумент 2 - степень двойки, это" + " " + "2^" + count2, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string s = Convert.ToString("Аргумент 2 - степень двойки, это" + " " + "2^" + count2);
                        listBox1.Items.Add(s);
                        MessageBox.Show("Аргумент 1 не введен или введен неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((b % 1 != 0) || (b == 0) || (b < 0))
                    {
                        MessageBox.Show("Аргумент 2 -  не степень двойки", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string s = Convert.ToString("Аргумент 2 -  не степень двойки");
                        listBox1.Items.Add(s);
                        MessageBox.Show("Аргумент 1 не введен или введен неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                }
                else
                {
                    int count1 = 0;
                    while (a < 1 && a > 0) { a = a * 2; count1--; }
                    while (a > 1) { a = a / 2; count1++; }
                    if (a == 1)
                    {
                        MessageBox.Show("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string s = Convert.ToString("Аргумент 1 - степень двойки, это" + " " + "2^" + count1 + ".");
                        listBox1.Items.Add(s);
                        MessageBox.Show("Аргумент 2 не введен или введен неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((a % 1 != 0) || (a == 0) || (a < 0))
                    {
                        MessageBox.Show("Аргумент 1 - не степень двойки" + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string s = Convert.ToString("Аргумент 1 - не степень двойки" + ".");
                        listBox1.Items.Add(s);
                        MessageBox.Show("Аргумент 2 не введен или введен неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Аргументы не введены или введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                a = Math.Sin(a);
                b = Math.Sin(b);
                a = Math.Round(a, 4);
                b = Math.Round(b, 4);
                MessageBox.Show("Синус от Аргумента 1 равен" + " " + a + ";" + " " + "Синус от Аргумента 2 равен" + " " + b + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString("Синус от Аргумента 1 равен" + " " + a + "; " + " " + "Синус от Аргумента 2 равен" + " " + b + ".");
                listBox1.Items.Add(s);
            }
            else if (double.TryParse(textBox1.Text, out a) ^ double.TryParse(textBox2.Text, out b))
            {
                if (!(double.TryParse(textBox1.Text, out a)) || double.TryParse(textBox2.Text, out b))
                {
                    b = Math.Sin(b);
                    b = Math.Round(b, 4);
                    MessageBox.Show("Синус от Аргумента 2 равен" + " " + b + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString("Синус от аргумента 2 равен" + " " + b + ".");
                    listBox1.Items.Add(s);
                    MessageBox.Show("Аргумент 1 не введен или введен неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    a = Math.Sin(a);
                    a = Math.Round(a, 4);
                    MessageBox.Show("Синус от Аргумента 1 равен" + " " + a + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString("Синус от Аргумента 1 равен" + " " + a + ".");
                    listBox1.Items.Add(s);
                    MessageBox.Show("Аргумент 2 не введен или введен неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Аргументы не введены или введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                a = Math.Tan(a);
                b = Math.Tan(b);
                a = Math.Round(a, 4);
                b = Math.Round(b, 4);
                MessageBox.Show("Тангенс от Аргумента 1 равен" + " " + a + ";" + " " + "Тангенс от Аргумента 2 равен" + " " + b + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString("Тангенс от Аргумента 1 равен" + " " + a + "; " + " " + "Тангенс от Аргумента 2 равен" + " " + b + ".");
                listBox1.Items.Add(s);
            }
            else if (double.TryParse(textBox1.Text, out a) ^ double.TryParse(textBox2.Text, out b))
            {
                if (!(double.TryParse(textBox1.Text, out a)) || double.TryParse(textBox2.Text, out b))
                {
                    b = Math.Tan(b);
                    b = Math.Round(b, 4);
                    MessageBox.Show("Тангенс от Аргумента 2 равен" + " " + b + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString("Тангенс от Аргумента 2 равен" + " " + b + ".");
                    listBox1.Items.Add(s);
                    MessageBox.Show("Аргумент 1 не введен или введен неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    a = Math.Tan(a);
                    a = Math.Round(a, 4);
                    MessageBox.Show("Тангенс от Аргумента 1 равен" + " " + a + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString("Тангенс от Аргумента 1 равен" + " " + a + ".");
                    listBox1.Items.Add(s);
                    MessageBox.Show("Аргумент 2 не введен или введен неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Аргументы не введены или введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b)) 
            {
                a = Math.Exp(a);
                b = Math.Exp(b);
                a = Math.Round(a, 2);
                b = Math.Round(b, 2);
                MessageBox.Show("Экспонента в степени Аргумента 1 равна" + " " + a + ";", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s = Convert.ToString("Экспонента в степени аргумента 1 равна" + " " + a + ";");
                MessageBox.Show("Экспонента в степени Аргумента 2 равна" + " " + b + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string s_ = Convert.ToString("Экспонента в степени аргумента 2 равна" + " " + b + ".");
                listBox1.Items.Add(s);
                listBox1.Items.Add(s_);
            }
            else if (double.TryParse(textBox1.Text, out a) ^ double.TryParse(textBox2.Text, out b))
            {
                if (!(double.TryParse(textBox1.Text, out a)) || double.TryParse(textBox2.Text, out b))
                {
                    b = Math.Exp(b);
                    b = Math.Round(b, 2);
                    MessageBox.Show("Экспонента в степени Аргумента 2 равна" + " " + b + ".", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s_ = Convert.ToString("Экспонента в степени Аргумента 2 равна" + " " + b + ".");
                    listBox1.Items.Add(s_);
                }
                else
                {
                    a = Math.Exp(a);
                    a = Math.Round(a, 2);
                    MessageBox.Show("Экспонента в степени аргумента 1 равна" + " " + a + ";", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    string s = Convert.ToString("Экспонента в степени Аргумента 1 равна" + " " + a + ";");
                    listBox1.Items.Add(s);
                }
            }
            else 
            {
                MessageBox.Show("Аргументы не введены или введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }      
    }
}


