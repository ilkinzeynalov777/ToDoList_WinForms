using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace To_do_list_wform
{
    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TaskFull { get; set; }
        

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

            TaskCard taskCard = new TaskCard();

            taskCard.RealTaskText = richTextBox1.Text;
            TaskFull = richTextBox1.Text;
            string shortTask = TaskFull;

            if(TaskFull.Length > 20)
            {
                shortTask = TaskFull.Substring(0, 20) + "...";
            }

            
            taskCard.taskDesc.Text = shortTask;
            flowPanel.Controls.Add(taskCard);
            richTextBox1.Clear();   
            
            
            DateTime nowDate = DateTime.Now;
            taskCard.finishDate.Text = nowDate.ToString("dd/MM/yyyy HH:mm");





        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //istifadəçinin yazdığı yerdə olan mətni ortalamağ
        }
    }
}
