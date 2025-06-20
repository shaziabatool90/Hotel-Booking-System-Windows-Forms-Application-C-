namespace DP_Project
{
    partial class Login
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
            panel1 = new Panel();
            linkLabelSignup = new LinkLabel();
            buttonLogin = new Button();
            label3 = new Label();
            textBoxPassword = new TextBox();
            label2 = new Label();
            textBoxUserName = new TextBox();
            labelUsername = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(linkLabelSignup);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxUserName);
            panel1.Controls.Add(labelUsername);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(44, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 285);
            panel1.TabIndex = 0;
            // 
            // linkLabelSignup
            // 
            linkLabelSignup.ActiveLinkColor = Color.DimGray;
            linkLabelSignup.AutoSize = true;
            linkLabelSignup.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelSignup.LinkColor = Color.Black;
            linkLabelSignup.Location = new Point(227, 191);
            linkLabelSignup.Name = "linkLabelSignup";
            linkLabelSignup.Size = new Size(51, 17);
            linkLabelSignup.TabIndex = 6;
            linkLabelSignup.TabStop = true;
            linkLabelSignup.Text = "Signup";
            linkLabelSignup.VisitedLinkColor = Color.DimGray;
            linkLabelSignup.LinkClicked += linkLabelSignup_LinkClicked;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.White;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.Black;
            buttonLogin.Location = new Point(54, 221);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(248, 35);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(70, 191);
            label3.Name = "label3";
            label3.Size = new Size(151, 17);
            label3.TabIndex = 4;
            label3.Text = "Don't have an account?";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(54, 125);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(248, 23);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 101);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 2;
            label2.Text = "Password: ";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(54, 57);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(248, 23);
            textBoxUserName.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(54, 33);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(95, 21);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 27);
            label1.Name = "label1";
            label1.Size = new Size(278, 30);
            label1.TabIndex = 13;
            label1.Text = "Hotel Management System";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 386);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox textBoxPassword;
        private Label label2;
        public TextBox textBoxUserName;
        private Label labelUsername;
        private Button buttonLogin;
        private LinkLabel linkLabelSignup;
        private Label label1;
    }
}