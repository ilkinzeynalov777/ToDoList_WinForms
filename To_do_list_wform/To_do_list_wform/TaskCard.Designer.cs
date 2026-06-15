namespace To_do_list_wform
{
    partial class TaskCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskCard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cardMain = new Guna.UI2.WinForms.Guna2Panel();
            taskDesc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            delete = new Guna.UI2.WinForms.Guna2Button();
            usernameText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            finishDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            finalDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            taskStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            cardMain.SuspendLayout();
            SuspendLayout();
            // 
            // cardMain
            // 
            cardMain.BackColor = Color.Black;
            cardMain.BorderRadius = 10;
            cardMain.Controls.Add(taskDesc);
            cardMain.Controls.Add(delete);
            cardMain.Controls.Add(usernameText);
            cardMain.Controls.Add(finishDate);
            cardMain.Controls.Add(finalDate);
            cardMain.Controls.Add(guna2HtmlLabel2);
            cardMain.Controls.Add(taskStatus);
            cardMain.Controls.Add(guna2CheckBox1);
            cardMain.CustomizableEdges = customizableEdges3;
            cardMain.FillColor = Color.Black;
            cardMain.ForeColor = Color.White;
            cardMain.Location = new Point(3, 3);
            cardMain.Name = "cardMain";
            cardMain.ShadowDecoration.BorderRadius = 15;
            cardMain.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cardMain.Size = new Size(948, 60);
            cardMain.TabIndex = 0;
            cardMain.Click += guna2Panel1_Click;
            cardMain.Paint += guna2Panel1_Paint;
            cardMain.MouseEnter += guna2Panel1_MouseEnter;
            cardMain.MouseLeave += guna2Panel1_MouseLeave;
            // 
            // taskDesc
            // 
            taskDesc.Anchor = AnchorStyles.None;
            taskDesc.BackColor = Color.Transparent;
            taskDesc.ForeColor = SystemColors.ButtonHighlight;
            taskDesc.Location = new Point(271, 18);
            taskDesc.Name = "taskDesc";
            taskDesc.Size = new Size(107, 17);
            taskDesc.TabIndex = 7;
            taskDesc.Text = "Learn User Control1";
            taskDesc.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // delete
            // 
            delete.BorderRadius = 20;
            delete.CustomizableEdges = customizableEdges1;
            delete.DisabledState.BorderColor = Color.DarkGray;
            delete.DisabledState.CustomBorderColor = Color.DarkGray;
            delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            delete.FillColor = Color.Transparent;
            delete.Font = new Font("Segoe UI", 9F);
            delete.ForeColor = Color.White;
            delete.Image = (Image)resources.GetObject("delete.Image");
            delete.ImageSize = new Size(25, 25);
            delete.Location = new Point(823, 5);
            delete.Name = "delete";
            delete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            delete.Size = new Size(48, 52);
            delete.TabIndex = 1;
            delete.Click += guna2Button2_Click;
            // 
            // usernameText
            // 
            usernameText.Anchor = AnchorStyles.None;
            usernameText.BackColor = Color.Transparent;
            usernameText.ForeColor = SystemColors.ButtonHighlight;
            usernameText.Location = new Point(80, 18);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(101, 17);
            usernameText.TabIndex = 6;
            usernameText.Text = "Learn User Control";
            usernameText.TextAlignment = ContentAlignment.MiddleCenter;
            usernameText.Click += guna2HtmlLabel5_Click;
            // 
            // finishDate
            // 
            finishDate.BackColor = Color.Transparent;
            finishDate.ForeColor = SystemColors.ButtonHighlight;
            finishDate.Location = new Point(467, 18);
            finishDate.Name = "finishDate";
            finishDate.Size = new Size(61, 17);
            finishDate.TabIndex = 5;
            finishDate.Text = "21-10-2025";
            // 
            // finalDate
            // 
            finalDate.BackColor = Color.Transparent;
            finalDate.ForeColor = SystemColors.ButtonHighlight;
            finalDate.Location = new Point(593, 18);
            finalDate.Name = "finalDate";
            finalDate.Size = new Size(61, 17);
            finalDate.TabIndex = 4;
            finalDate.Text = "29-11-2025";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.ForeColor = SystemColors.ButtonHighlight;
            guna2HtmlLabel2.Location = new Point(568, 15);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(3, 2);
            guna2HtmlLabel2.TabIndex = 3;
            guna2HtmlLabel2.Text = null;
            // 
            // taskStatus
            // 
            taskStatus.BackColor = Color.Transparent;
            taskStatus.ForeColor = SystemColors.ButtonHighlight;
            taskStatus.Location = new Point(727, 18);
            taskStatus.Name = "taskStatus";
            taskStatus.Size = new Size(56, 17);
            taskStatus.TabIndex = 2;
            taskStatus.Text = "Pending...";
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.CheckedState.BorderColor = Color.White;
            guna2CheckBox1.CheckedState.BorderRadius = 3;
            guna2CheckBox1.CheckedState.BorderThickness = 0;
            guna2CheckBox1.CheckedState.FillColor = Color.Lime;
            guna2CheckBox1.Location = new Point(13, 18);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(15, 14);
            guna2CheckBox1.TabIndex = 0;
            guna2CheckBox1.UncheckedState.BorderColor = Color.White;
            guna2CheckBox1.UncheckedState.BorderRadius = 3;
            guna2CheckBox1.UncheckedState.BorderThickness = 2;
            guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(34, 32, 42);
            // 
            // TaskCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cardMain);
            Name = "TaskCard";
            Size = new Size(948, 67);
            Load += TaskCard_Load;
            cardMain.ResumeLayout(false);
            cardMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel cardMain;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel usernameText;
        private Guna.UI2.WinForms.Guna2HtmlLabel finishDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel finalDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel taskStatus;
        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2HtmlLabel taskDesc;
    }
}
