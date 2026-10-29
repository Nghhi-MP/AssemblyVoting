namespace AssemblyVoting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Conclude_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, int> suggestions = [];

                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    string? option = row.Cells[0].Value?.ToString();
                    int votes = Convert.ToInt32(row.Cells[1].Value);

                    suggestions[option ?? "---"] = votes;
                }

                new ConclusionWindow(suggestions.MaxBy(x => x.Value).Key)
                    .ShowDialog();
            }
            catch
            {
                MessageBox.Show("יש לבדוק שכל הקלטים תקינים.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            textBox1.Text = string.Empty;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    Conclude_Click(sender, e);
                    break;
                case Keys.Escape:
                    ClearButton_Click(sender, e);
                    break;
            }
        }
    }
}
