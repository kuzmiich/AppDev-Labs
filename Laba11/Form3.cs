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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Pen pn;
        Graphics g;
        Graphics pre;
        static int red = 0;
        static int green = 0;
        static int blue = 0;

        private void Form4_Load(object sender, EventArgs e)
        {
            pn = new Pen(Color.Black, 5);
            pre = panel2.CreateGraphics();
            g = panel1.CreateGraphics();
            UpdateTextBox();
            UpdateColor();
        }

        private void UpdateColor()
        {
            textBox9.Text = red.ToString();
            textBox10.Text = green.ToString();
            textBox11.Text = blue.ToString();
            trackBar1.Value = red;
            trackBar2.Value = green;
            trackBar3.Value = blue;
            pn.Color = Color.FromArgb(red, green, blue);
            pn.Width = (float)numericUpDown1.Value;
            
            pre.Clear(Color.White);
            pre.DrawLine(pn, 25, 25, 207, 25);
        }

        private void UpdateTextBox()
        {
            if (radioButton1.Checked)
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
            }
            else if (radioButton2.Checked)
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
            }
            else if (radioButton3.Checked)
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
            }
            else
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
                textBox7.ReadOnly = false;
                textBox8.ReadOnly = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            red = trackBar1.Value;
            UpdateColor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            green = trackBar2.Value;
            UpdateColor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            blue = trackBar3.Value;
            UpdateColor();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x1 = Convert.ToSingle(textBox1.Text);
            float x2 = Convert.ToSingle(textBox2.Text);
            float y1 = Convert.ToSingle(textBox3.Text);
            float y2 = Convert.ToSingle(textBox4.Text);
            float width = Convert.ToSingle(textBox5.Text);
            float height = Convert.ToSingle(textBox6.Text);
            float angle1 = Convert.ToSingle(textBox7.Text);
            float angle2 = Convert.ToSingle(textBox8.Text);

            if (radioButton1.Checked)
            {
                g.DrawRectangle(pn, x1, x2, width, height);
            }
            else if (radioButton2.Checked)
            {
                g.DrawEllipse(pn, x1, x2, width, height);
            }
            else if (radioButton3.Checked)
            {
                g.DrawLine(pn, x1, x2, y1, y2);
            }
            else
            {
                g.DrawPie(pn, x1, x2, width, height, angle1, angle2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float x1 = Convert.ToSingle(textBox1.Text);
            float x2 = Convert.ToSingle(textBox2.Text);
            float size = Convert.ToSingle(numericUpDown1.Value);
            g.DrawString(textBox12.Text, new Font("Arial", size), new SolidBrush(Color.FromArgb(red, green, blue)), new PointF(x1, x2));
        }
    }
}
