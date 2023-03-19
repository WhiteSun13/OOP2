using System;
using System.Windows.Forms;

namespace OOP2_Task2
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
        /// Перегруженный метод Евклида для любого количества значений
        /// </summary>
        /// <param name="rightData">Массив чисел</param>
        /// <returns>Возвращает НОД массива целых чисел</returns>
        int NOD(params int[] rightData)//метод Евклида
        {
            int first = NOD(rightData[0], rightData[1]);
            if (rightData.Length > 2)
            {
                for (int n = 2; n < rightData.Length; n++)
                {
                    first = NOD(first, rightData[n]);
                }
            }
            return first;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Text.Split(' ');
            int[] rightData = Array.ConvertAll(data, int.Parse);
            label1.Text = "Результат: " + NOD(rightData).ToString();
        }
    }
}
