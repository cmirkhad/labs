using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit (); // or here we use the class and the Exit method to exit the program
            this.Close(); // in this line we close this form objectloadPictureSFile ToolStripMenuItem_Click
        }
        private void (object sender, EventArgs e){
            if (openFileDialog1.ShowDialog() == DialogResult.OK)           {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
// load an image from a file.

            }
        }
private void normalToolStripMenuItem_Click(object sender, EventArgs e)
{
    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
}

private void stretchImageToolStripMenuItem_Click(object sender, EventArgs e)
{
    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
}

private void autoSizeToolStripMenuItem_Click(object sender, EventArgs e)
{
    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

}

void centerImageToolStripMenuItem_Click(object sender, EventArgs e)
{
    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
}
void zoomToolStripMenuItem_Click(object sender, EventArgs e)
{
    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
}
private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
{
    label1.Text = toolStripTextBox1.Text;
}
On the ComboBox toolStripComboBox1_SelectedIndexChanged
private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
{

    label3.Text = toolStripComboBox1.SelectedItem.ToString();
}




    }
}
