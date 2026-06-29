using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace To_do_list_wform
{
    public partial class editArea : Form
    {

       
        // Expose the current task so callers can assign it before showing the form
        public TaskCard CurrentTask;
        

        public editArea(TaskCard task)
        {
            InitializeComponent();
            CurrentTask = task;
            guna2ImageButton1.ImageSize = new Size(48, 45);

            guna2ImageButton1.HoverState.ImageSize = new Size(48, 45);

            guna2ImageButton1.PressedState.ImageSize = new Size(48, 45);
            this.KeyPreview = true;
        }




        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

            //SAVE DÜYMƏSİNƏ KLİK EDƏNDƏ İSTƏYİRƏM Kİ,SQL GÜNCƏLLƏNSİN
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ToDoListDb;Integrated Security=True;TrustServerCertificate=True";
            string query = "Update Tasks Set Description = @taskDesc where id = @taskId";
            


            if (guna2TextBox1.Text == null || guna2TextBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a task description.");
                }
                else if (guna2TextBox1 != null)
                {

                    CurrentTask.RealTaskText = guna2TextBox1.Text;
                    CurrentTask.taskDesc.Text = guna2TextBox1.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
        }

        private void editArea_Load(object sender, EventArgs e)
        {


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_MouseHover(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void editArea_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }



        }

        private void editMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
