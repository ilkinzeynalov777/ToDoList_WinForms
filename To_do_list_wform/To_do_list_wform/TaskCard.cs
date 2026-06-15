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

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void TaskCard_Load(object sender, EventArgs e)
        {

        }
    }
}
