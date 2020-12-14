using System;
using System.Windows.Forms;
using static System.Math;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }

        private double Func(double x, double y, double z)
        {
            return Pow(8 + Pow(Abs(x - y), 2) + 1, 1 / 3) / (Pow(x, 2) + Pow(y, 2) + 2) - (Exp(Abs(x - y)) * Pow(Pow(Tan(z), 2) + 1, x));
        }

        private double Func(double x)
        {
            return Sin(x) * 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xMin = Convert.ToDouble(textBox1.Text);
            double xMax = Convert.ToDouble(textBox2.Text);
            int N = Convert.ToInt32(textBox3.Text);

            double z = Convert.ToDouble(textBox4.Text);
            double y = Convert.ToDouble(textBox5.Text);

            double step = (xMax - xMin) / N;
            for (double x = xMin; x <= xMax; x += step)
            {
                double u = Func(x, y, z);
                chart1.Series[0].Points.AddXY(x, u);

                chart1.Series[1].Points.AddXY(x, Func(x));
            }
        }
    }
}
