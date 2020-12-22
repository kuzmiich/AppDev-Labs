using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pen pn;
        Graphics g;
        Color color = Color.Black;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();

            openFileDialog1.Title = "Open Image";

            if (res == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox2.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox3.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox4.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pn = new Pen(color, 5);
            g = pictureBox1.CreateGraphics();
            g.DrawLine(pn, 0, 0, pictureBox1.Width, pictureBox1.Height);
        }

        private void DrawTwoLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pn = new Pen(color, 5);
            g = pictureBox1.CreateGraphics();
            g.DrawLine(pn, 0, pictureBox1.Height, pictureBox1.Width, 0);
        }
        private void BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Black;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Red;
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Green;
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
        }
    }
}
