namespace todo_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descriereSarcina = txtDescriereSarcina.Text;

            dataGridView1.Rows.Add(descriereSarcina);
            txtDescriereSarcina.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string descriereSarcina = selectedRow.Cells["sarcina"].Value.ToString();

                MessageBox.Show($"Descriere sarcină: {descriereSarcina}");
            }
            else
            {
                MessageBox.Show("Selectează o sarcină pentru a vizualiza detalii.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string descriereSarcina = selectedRow.Cells["sarcina"].Value.ToString();

                string descriereEditata = PromptForInput("Editează sarcina:", descriereSarcina);

                if (descriereEditata != null)
                {
                    selectedRow.Cells["sarcina"].Value = descriereEditata;


                    MessageBox.Show("Sarcina a fost editată cu succes!");
                }
            }
            else
            {
                MessageBox.Show("Selectează o sarcină pentru a o edita.");
            }
        }

        private string PromptForInput(string prompt, string initialValue)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox(prompt, "Editare Sarcina", initialValue);
            return string.IsNullOrEmpty(result) ? null : result;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                DialogResult result = MessageBox.Show("Ești sigur că vrei să ștergi această sarcină?", "Confirmare ștergere", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(selectedRow);

                }
            }
            else
            {
                MessageBox.Show("Selectează o sarcină pentru a o șterge.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}