using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stroki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox2.Text = str.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox2.Text = str.ToLower();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("D:/example.txt");
            string numbers = sr.ReadLine();
            foreach (var number in numbers.Split()) ;
             string result = string.Join("", numbers);
            textBox1.Text = result; ;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox2.Text = str.Substring(2, 5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox2.Text = str.Remove(2,2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

           int len= str.Length;
            textBox2.Text = "Длина строки =" + len;
        }
    }
}
