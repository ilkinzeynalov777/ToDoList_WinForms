namespace To_do_list_wform
{
    partial class editArea
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editArea));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            editMain = new Guna.UI2.WinForms.Guna2Panel();
            editMain.SuspendLayout();
            SuspendLayout();
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderRadius = 5;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(12, 3);
            guna2TextBox1.Multiline = true;
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.ScrollBars = ScrollBars.Both;
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(786, 61);
            guna2TextBox1.TabIndex = 0;
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.Anchor = AnchorStyles.Left;
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(48, 45);
            guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.ImageSize = new Size(48, 45);
            guna2ImageButton1.Location = new Point(814, 12);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2ImageButton1.Size = new Size(48, 45);
            guna2ImageButton1.TabIndex = 1;
            guna2ImageButton1.Click += guna2ImageButton1_Click;
            guna2ImageButton1.MouseClick += guna2ImageButton1_MouseClick;
            guna2ImageButton1.MouseHover += guna2ImageButton1_MouseHover;
            // 
            // editMain
            // 
            editMain.BackColor = Color.Black;
            editMain.BorderRadius = 10;
            editMain.Controls.Add(guna2ImageButton1);
            editMain.Controls.Add(guna2TextBox1);
            editMain.CustomizableEdges = customizableEdges4;
            editMain.Dock = DockStyle.Fill;
            editMain.FillColor = Color.Black;
            editMain.ForeColor = Color.White;
            editMain.Location = new Point(0, 0);
            editMain.Name = "editMain";
            editMain.ShadowDecoration.BorderRadius = 15;
            editMain.ShadowDecoration.CustomizableEdges = customizableEdges5;
            editMain.Size = new Size(870, 66);
            editMain.TabIndex = 2;
            // 
            // editArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 66);
            Controls.Add(editMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "editArea";
            Text = "editArea";
            Load += editArea_Load;
            KeyDown += editArea_KeyDown_1;
            editMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Panel editMain;
    }
}