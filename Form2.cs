namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        int? id = null;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Student student) : this()
        {
            id = student.ID;
            textBox1.Text = student.FirstName;
            textBox2.Text = student.LastName;
            textBox3.Text = student.Section;
            textBox4.Text = student.Course;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                StudentManager.Instance().UpdateItem(
                   id.Value,
                   textBox2.Text,
                   textBox1.Text,
                   textBox4.Text,
                   textBox3.Text);
            }
            else
            {
                StudentManager.Instance().AddItem(
                    textBox2.Text,
                    textBox1.Text,
                    textBox4.Text,
                    textBox3.Text);
            }
            this.Close();
        }
    }
}
