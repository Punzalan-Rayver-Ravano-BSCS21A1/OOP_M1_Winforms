using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private int _nextId = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentManager.Create().AddItem(
                textBox2.Text, 
                textBox1.Text,
                textBox4.Text,
                textBox3.Text);
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _nextId = StudentManager.Create().GetItems().Count + 1;
        }
    }
}
