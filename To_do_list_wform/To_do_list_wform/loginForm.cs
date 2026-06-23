using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace To_do_list_wform
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void sign_Click(object sender, EventArgs e)
        {

            //connect to the database
            string connectionString = @"Data Source=WIN-12MOQ9MUQPE\MSSQLSERVER02;Initial Catalog=ToDoListDb;Integrated Security=True;TrustServerCertificate=True";


            //create a connection to the database
            string query = "SELECT COUNT(*) FROM dbo.Users where Username = @username AND PasswordHash = @password";


            using (SqlConnection conn  = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", password.Text.Trim());
                        int count =Convert.ToInt32(cmd.ExecuteScalar());
                        
                        if(count > 0)
                        {
                            MessageBox.Show("Login successful","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1 mainForm = new Form1();
                            mainForm.Show();
                            this.Hide();    
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }




            }



        }
    }
}
