using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
        }

        private double Func(double x, double y, double z)
        {
            return Math.Pow(8 + Math.Pow(Math.Abs(x - y), 2) + 1, 1 / 3) / (Math.Pow(x, 2) + Math.Pow(y, 2) + 2) - (Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Pow(Math.Tan(z), 2) + 1, x));
        }

        private double Func(double x)
        {
            return Math.Sin(x) * 4;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            double x_start = Convert.ToDouble(toolStripTextBox1.Text);
            double x_end = Convert.ToDouble(toolStripTextBox2.Text);
            int N = Convert.ToInt32(toolStripTextBox3.Text);

            double y = Convert.ToDouble(toolStripTextBox5.Text);
            double z = Convert.ToDouble(toolStripTextBox4.Text);

            double delta_x = (x_end - x_start) / N;
            for (double x = x_start; x <= x_end; x += delta_x)
            {
                double u = Func(x, y, z);
                chart1.Series[0].Points.AddXY(x, u);

                chart1.Series[1].Points.AddXY(x, Func(x));
            }
        }
    }
}
