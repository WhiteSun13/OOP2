using System;
using System.Windows.Forms;

namespace OOP2_Task1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Метод, вычисляющий НОД методом Евклида.
        /// </summary>
        /// <param name="a">Число из textBox1</param>
        /// <param name="b">Число из textBox2</param>
        /// <returns>Наибольший общий делитель</returns>
        public static int NOD(int a, int b)//метод Евклида
        {
            if (a == 0) return b;
            while (b != 0)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            return a;
        }
        /// <summary>
        /// Перегруженная версия метода НОД для трех переменных
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int NOD(int a, int b, int c)
        {
            int q = NOD(a, b);
            int w = NOD(q, c);
            return w;
        }
        /// <summary>
        /// Перегруженная версия метода НОД для четырех переменных
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int NOD(int a, int b, int c, int d)
        {
            int q = NOD(a, b, c);
            int w = NOD(q, d);
            return w;
        }
        /// <summary>
        /// Перегруженная версия метода НОД для пяти переменных
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static int NOD(int a, int b, int c, int d, int e)
        {
            int q = NOD(a, b, c, d);
            int w = NOD(q, e);
            return w;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out var a))
            {
                if (int.TryParse(textBox2.Text, out var b))
                {
                    Result.Text = "НОД (метод Евклида) = " + NOD(a, b); return;
                }
            }
            MessageBox.Show("Неверный ввод");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out var a))
            {
                if (int.TryParse(textBox2.Text, out var b))
                {
                    if (int.TryParse(textBox3.Text, out var c))
                    {
                        Result.Text = "НОД (метод Евклида) = " + NOD(a, b, c); return;
                    }
                }
            }
            MessageBox.Show("Неверный ввод");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out var a))
            {
                if (int.TryParse(textBox2.Text, out var b))
                {
                    if (int.TryParse(textBox3.Text, out var c))
                    {
                        if (int.TryParse(textBox4.Text, out var d))
                        {
                            Result.Text = "НОД (метод Евклида) = " + NOD(a, b, c, d); return;
                        }
                    }
                }
            }
            MessageBox.Show("Неверный ввод");
        }
        private void btn4_Click(object sender, EventArgs q)
        {
            if (int.TryParse(textBox1.Text, out var a))
            {
                if (int.TryParse(textBox2.Text, out var b))
                {
                    if (int.TryParse(textBox3.Text, out var c))
                    {
                        if (int.TryParse(textBox4.Text, out var d))
                        {
                            if (int.TryParse(textBox5.Text, out var e))
                            {
                                Result.Text = "НОД (метод Евклида) = " + NOD(a, b, c, d, e); return;
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Неверный ввод");
        }
    }
}
