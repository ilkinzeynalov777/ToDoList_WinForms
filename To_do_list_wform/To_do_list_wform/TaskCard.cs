using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace To_do_list_wform
{
    public partial class TaskCard : UserControl
    {
        private object guna2;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RealTaskText { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int TaskId { get; set; } // Add this property to hold the task ID
        public TaskCard()
        {

            InitializeComponent();


        }



        


        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_MouseEnter(object sender, EventArgs e)
        {
            cardMain.FillColor = Color.Purple;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_MouseLeave(object sender, EventArgs e)
        {
            cardMain.FillColor = Color.FromArgb(34, 33, 42);
        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {

        }



        private void TaskCard_Load(object sender, EventArgs e)
        {

        }

        public void taskDesc_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=WIN-12MOQ9MUQPE\MSSQLSERVER02;Initial Catalog=ToDoListDb;Integrated Security=True;TrustServerCertificate=True";
            Guna.UI2.WinForms.Guna2CheckBox clickedCheckBox = (Guna.UI2.WinForms.Guna2CheckBox)sender;
            var panel = clickedCheckBox.Parent;
            To_do_list_wform.TaskCard taskCard = panel.Parent as To_do_list_wform.TaskCard;

            if (taskCard != null)
            {
                if (guna2CheckBox1.Checked == true)
                {
                    taskStatus.Text = "Completed";
                    taskStatus.ForeColor = Color.Green;
                    taskCard.finalDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                }
                else
                {
                    taskStatus.Text = "Pending";
                    taskStatus.ForeColor = Color.Red;
                    taskCard.finalDate.Text = DateTime.Now.ToString("--/--/---- --:--");
                }
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            // Open the edit form and pass this TaskCard as the current task
            editArea editForm = new editArea(this);
            editForm.guna2TextBox1.Text = this.RealTaskText;

            // Properties
            editForm.StartPosition = FormStartPosition.Manual;
            editForm.FormBorderStyle = FormBorderStyle.None;

            // Position the form over the card
            Point cardLocation = this.PointToScreen(Point.Empty);
            int xCorrection = cardLocation.X;
            int yCorrection = cardLocation.Y;
            editForm.Location = new Point(xCorrection, yCorrection);

            editForm.Width = this.ClientSize.Width;
            editForm.Height = this.ClientSize.Height;

            // If the user saved changes, update this card's text
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                
                this.RealTaskText = editForm.guna2TextBox1.Text;
                this.taskDesc.Text = this.RealTaskText;
                this.taskDesc.Text = editForm.guna2TextBox1.Text;
            }


        }
    }
}

