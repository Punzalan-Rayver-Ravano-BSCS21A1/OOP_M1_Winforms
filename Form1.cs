using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // Bind the list to a DataGridView
            dataGridView1.DataSource = StudentManager.Create().GetItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog(this);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentManager.Create().GetItems();
            dataGridView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
