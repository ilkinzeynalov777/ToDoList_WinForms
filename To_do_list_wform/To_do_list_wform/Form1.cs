using System.Security.Cryptography.X509Certificates;

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

            string taskFull = richTextBox1.Text;
            string shortTask = taskFull;

            if(taskFull.Length > 20)
            {
                shortTask = taskFull.Substring(0, 20) + "...";
            }

            TaskCard taskCard = new TaskCard();
            taskCard.TaskDesc = shortTask;
            flowPanel.Controls.Add(taskCard);
            richTextBox1.Clear();   
            
            




        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //istifadəçinin yazdığı yerdə olan mətni ortalamağ
        }
    }
}
