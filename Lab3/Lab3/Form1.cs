using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            double c = Convert.ToDouble(textBox6.Text);
            double result = (i + b) / c;
            textBox7.Text = Convert.ToString(result);
            // or
            //textBox4.Text = Convert.ToString ((Convert.ToDouble (textBox1.Text) + Convert.ToDouble (textBox2.Text)) / Convert.ToDouble (textBox3.Text));
        }
        private void button2_Click(object sender, EventArgs e)
        {// check which radiobutton was selected
            if (radioButton4.Checked == true)
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 10 / 100);
            if (radioButton5.Checked == true)
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 20 / 100);
            if (radioButton6.Checked == true)
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 50 / 100);
        }


    }
}
