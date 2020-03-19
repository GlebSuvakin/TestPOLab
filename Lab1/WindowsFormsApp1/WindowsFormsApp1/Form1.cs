using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApp1.Modules;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string str1 = textBox1.Text; //Берём строку с массивом из textBox
            string[] strArr = ArrayParser.StrToArr(str1); //Вызываем метод преобразования строки в массив
            foreach (string str2 in strArr) //Проверка, что массив состоит только из цифр
            {

                if (!ArrayParser.IsNumberContains(str2))
                {
                    MessageBox.Show("Массив должен состоять из целых чисел");
                    listBox2.Text = string.Empty;
                    return;
                }

            }

            int[] intArr = ArrayParser.StrArrToIntArr(strArr); //Преобразуем string массив в int массив
            if (!Check.CheckArrayDimension(intArr)) //Проверяем, что в массиве 10 чисел
            {
                MessageBox.Show("Количество элементов в массиве меньше десяти");
                listBox2.Text = string.Empty;
                return;
            }

            else if (!Check.CheckCapacity(intArr)) //Проверяем разрядность элементов массива
            {
                MessageBox.Show("Разрядность элемента массива должна быть не меньше 4");
                listBox2.Text = string.Empty;
                return;
            }

            else if (!Check.CheckPositiveNumber(intArr)) //Проверяем, что массив состоит из положительных элементов
            {
                MessageBox.Show("Массив должен состоять из положительных чисел");
                listBox2.Text = string.Empty;
                return;

            }
            else
            {
                foreach(int num in intArr)
                {
                    if(NewMassLess.IsSimple(num) && NewMassLess.IsLess(num))
                    {
                        listBox2.Items.Add(num);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string str1 = textBox1.Text; //Берём строку с массивом из textBox
            string[] strArr = ArrayParser.StrToArr(str1); //Вызываем метод преобразования строки в массив
            foreach (string str2 in strArr) //Проверка, что массив состоит только из цифр
            {

                if (!ArrayParser.IsNumberContains(str2))
                {
                    MessageBox.Show("Массив должен состоять из целых чисел");
                    listBox2.Text = string.Empty;
                    return;
                }

            }

            int[] intArr = ArrayParser.StrArrToIntArr(strArr); //Преобразуем string массив в int массив
            if (!Check.CheckArrayDimension(intArr)) //Проверяем, что в массиве 10 чисел
            {
                MessageBox.Show("Количество элементов в массиве меньше десяти");
                listBox2.Text = string.Empty;
                return;
            }

            else if (!Check.CheckCapacity(intArr)) //Проверяем разрядность элементов массива
            {
                MessageBox.Show("Разрядность элемента массива должна быть не меньше 4");
                listBox2.Text = string.Empty;
                return;
            }

            else if (!Check.CheckPositiveNumber(intArr)) //Проверяем, что массив состоит из положительных элементов
            {
                MessageBox.Show("Массив должен состоять из положительных чисел");
                listBox2.Text = string.Empty;
                return;

            }
            else
            {
                foreach (int num in intArr)
                {
                    if (NewMassMore.IsSimple(num) && NewMassMore.IsMore(num))
                    {
                        listBox2.Items.Add(num);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
