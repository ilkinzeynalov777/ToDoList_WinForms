namespace To_do_list_wform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Zehmet olmasa tapşırığı əlavə edin.");
                return;
            }
            else
            {
                string task = richTextBox1.Text;
                TaskCard taskCard = new TaskCard();
                taskCard.TaskDesc = task;
                flowPanel.Controls.Add(taskCard);
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //istifadəçinin yazdığı yerdə olan mətni ortalamağ
        }
    }
}
