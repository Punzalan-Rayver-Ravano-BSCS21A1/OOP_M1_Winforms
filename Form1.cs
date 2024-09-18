using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        #region Ctor
        public Form1()
        {
            InitializeComponent();

        }
        #endregion

        #region Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Visible = true;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;  // Adjusts width to fill available space
            }

            dataGridView1.DataSource = StudentManager.Instance().GetItems();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form = new();
            form.ShowDialog(this);

            RefreshDataGridView();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    var selectedStudent = dataGridView1.Rows[e.RowIndex].DataBoundItem as Student;
                    if (selectedStudent != null)
                    {
                        Form2 form = new Form2(selectedStudent);
                        form.ShowDialog(this);
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region Private Methods
        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentManager.Instance().GetItems();

        }

        #endregion


    }
}
