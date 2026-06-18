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

        public string TaskDesc
        {
            get { return taskDesc.Text; }
            set { taskDesc.Text = value; }

        }

        public TaskCard()
        {

            InitializeComponent();


        }

        public string TaskDate()
        {
            get { return finishDate.Text; }
            set { finishDate.Text = value; }

        }

        //START DATE TARIXI GIRMEK


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

        private void taskDesc_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2CheckBox1.Checked)
            {
                taskStatus.Text = "Completed";
                taskStatus.ForeColor = Color.Green;
            }
            else
            {
                taskStatus.Text = "Pending";
                taskStatus.ForeColor = Color.Red;
            }
        }
    }
}
