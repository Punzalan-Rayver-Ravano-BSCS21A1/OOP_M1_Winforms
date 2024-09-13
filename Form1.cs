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
            // Create a list of objects
            List<Person> people = new List<Person>();
            people.Add(new Person { ID = 1, Name = "John Doe" });
            people.Add(new Person { ID = 2, Name = "Jane Smith" });

            // Bind the list to a DataGridView
            dataGridView1.DataSource = people;
        }
    }

    internal class Person
    {
        public string Name { get; internal set; }
        public int ID { get; internal set; }
    }
}
