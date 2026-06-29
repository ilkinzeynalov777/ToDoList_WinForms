using Microsoft.Data.SqlClient;
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

            // ---- 1. Yeni TaskCard yarat və UI-ə əlavə et ----
            TaskCard taskCard = new TaskCard();

            taskCard.RealTaskText = richTextBox1.Text;
            TaskFull = richTextBox1.Text;
            string shortTask = TaskFull;

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

            // ---- 2. İndi BU taskCard-ı SQL-ə yaz ----
            //at home
            //string connectionString = @"Data Source=WIN-12MOQ9MUQPE\MSSQLSERVER02;Initial Catalog=ToDoListDb;Integrated Security=True;TrustServerCertificate=True";
            //at work
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ToDoListDb;Integrated Security=True;TrustServerCertificate=True";

            string query = "INSERT INTO Tasks (Username, Description, StartDate, FinishDate, Status, IsCompleted) " +
                           "VALUES (@usernameText, @taskDesc, @startDate, @finalDate, @taskStatus, @isCompleted)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usernameText", taskCard.usernameText.Text);
                        cmd.Parameters.AddWithValue("@taskDesc", taskCard.RealTaskText);
                        cmd.Parameters.AddWithValue("@startDate", nowDate);
                        cmd.Parameters.AddWithValue("@finalDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@taskStatus", taskCard.taskStatus.Text);
                        cmd.Parameters.AddWithValue("@isCompleted", taskCard.guna2CheckBox1.Checked);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //istifadəçinin yazdığı yerdə olan mətni ortalamağ
        }

        public void LoadTasksFromDatabase()
        {
            ////AT HOME
            //string connectionString = @"Data Source=WIN-12MOQ9MUQPE\MSSQLSERVER02;Initial Catalog=ToDoListDb;Integrated Security=True;TrustServerCertificate=True";
            //AT WORK
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ToDoListDb;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT Description, StartDate, FinishDate, Status, IsCompleted FROM Tasks WHERE Username = @username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", Program.CurrentUsername);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TaskCard taskCard = new TaskCard();
                                taskCard.RealTaskText = reader["Description"].ToString();
                                taskCard.usernameText.Text = Program.CurrentUsername;
                                //BURA ŞƏRT VERƏCEM Kİ ƏGƏR TASKIN DESCRIPTION-U 20-DƏN UZUNDURSA, O ZAMAN SUBSTRING ET, ƏKS HALDA BİRBAŞA YAZ
                                if(reader["Description"].ToString().Length > 20)
                                {
                                    taskCard.taskDesc.Text = reader["Description"].ToString().Substring(0, 20) + "...";
                                }
                                else
                                {
                                    taskCard.taskDesc.Text = reader["Description"].ToString();
                                }
                            

                                
                                taskCard.finishDate.Text = Convert.ToDateTime(reader["StartDate"]).ToString("dd/MM/yyyy HH:mm");
                                taskCard.taskStatus.Text = reader["Status"].ToString();
                                taskCard.guna2CheckBox1.Checked = Convert.ToBoolean(reader["IsCompleted"]);

                                flowPanel.Controls.Add(taskCard);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
            }
        }


    }
}
