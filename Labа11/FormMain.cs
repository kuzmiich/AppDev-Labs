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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 first_form = new Form1();

            first_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 second_form = new Form2();

            second_form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 third_form = new Form3();

            third_form.Show();
        }
    }
}
