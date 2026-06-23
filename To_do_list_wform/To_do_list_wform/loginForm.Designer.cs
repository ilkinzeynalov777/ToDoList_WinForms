namespace To_do_list_wform
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            username = new TextBox();
            password = new TextBox();
            label3 = new Label();
            sign = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(125, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(158, 165);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "To-Do List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(57, 204);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // username
            // 
            username.BackColor = Color.FromArgb(26, 26, 46);
            username.BorderStyle = BorderStyle.FixedSingle;
            username.ForeColor = SystemColors.Info;
            username.Location = new Point(57, 232);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(306, 40);
            username.TabIndex = 3;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(26, 26, 46);
            password.BorderStyle = BorderStyle.FixedSingle;
            password.ForeColor = SystemColors.Info;
            password.Location = new Point(57, 322);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(306, 40);
            password.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(57, 294);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // sign
            // 
            sign.BackColor = Color.FromArgb(108, 92, 231);
            sign.FlatAppearance.BorderSize = 0;
            sign.FlatStyle = FlatStyle.Flat;
            sign.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sign.Location = new Point(135, 387);
            sign.Name = "sign";
            sign.Size = new Size(153, 39);
            sign.TabIndex = 6;
            sign.Text = "Sign In";
            sign.UseVisualStyleBackColor = false;
            sign.Click += sign_Click;
            // 
            // loginForm
            // 
            AcceptButton = sign;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 46);
            ClientSize = new Size(433, 521);
            Controls.Add(sign);
            Controls.Add(password);
            Controls.Add(label3);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginForm";
            Text = "loginForm";
            Load += loginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox username;
        private TextBox password;
        private Label label3;
        private Button sign;
    }
}