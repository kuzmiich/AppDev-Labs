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
    public partial class Form2 : Form
    {
        Pen pn;
        Graphics g;

        public Form2()
        {
            InitializeComponent();
            pn = new Pen(Color.Black, 5);
            g = panel1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.DrawRectangle(pn, 50, 50, 500, 500);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.DrawEllipse(pn, 50, 50, 500, 500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.DrawLine(pn, 50, 50, 550, 550);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }
    }
}
