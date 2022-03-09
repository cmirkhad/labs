using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try { 
            int viNumber = Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text);
            textBox4.Text = viNumber.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter only numbers");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { 
            int viNumber = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text);
            textBox4.Text = viNumber.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter only numbers");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { 
            int viNumber = Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox3.Text);
            textBox4.Text = viNumber.ToString();
        }
            catch (Exception)
            {
                MessageBox.Show("Enter only numbers");
            }

}

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int viNumber = Convert.ToInt32(textBox2.Text);
                int viNumber1 = Convert.ToInt32(textBox3.Text);
                textBox4.Text = (viNumber / viNumber1).ToString();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Don't divide by 0");
            }catch (Exception)
            {
                MessageBox.Show("Enter only numbers");
            }
          
            
                
                
            

            
        }
    }
}
