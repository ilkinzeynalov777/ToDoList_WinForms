using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace To_do_list_wform
{
    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TaskFull { get; set; }
        TaskCard tskSql = new TaskCard();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //------------------------------------------------------
            //bu hissədə sql database-ə tapşırıq əlavə etmək üçün kod yazılır
            //tasks add sql database
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ToDoListDb;Integrated Security=True;TrustServerCertificate=True";

            //string query
            string query = "INSERT INTO Tasks (Username, Description, StartDate,FinishDate,Status,IsCompleted) VALUES (@usernameText, @taskDesc, @finishDate , @finalDate,@taskStatus , @guna2CheckBox1)";

            //variables TascCard variables
            string usernameText = tskSql.usernameText.Text;
            string taskDesc = tskSql.taskDesc.Text;
            string startDate = tskSql.finishDate.Text;  
            string endDate = tskSql.finalDate.Text;
            string status  = tskSql.taskStatus.Text;
            string isCompleted = tskSql.guna2CheckBox1.Checked.ToString();


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usernameText", usernameText);
                        cmd.Parameters.AddWithValue("@taskDesc", taskDesc);
                        cmd.Parameters.AddWithValue("@finishDate", startDate);
                        cmd.Parameters.AddWithValue("@finalDate", endDate);
                        cmd.Parameters.AddWithValue("@taskStatus", status);
                        cmd.Parameters.AddWithValue("@guna2CheckBox1", false);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }


            //-------------------------------------------------------------------------------







            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Zehmet olmasa tapşırığı əlavə edin.");
                return;
            }

            TaskCard taskCard = new TaskCard();

            taskCard.RealTaskText = richTextBox1.Text;
            TaskFull = richTextBox1.Text;
            string shortTask = TaskFull;
            //username taskcard add 
            taskCard.usernameText.Text = Program.CurrentUsername;


            if (TaskFull.Length > 20)
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
