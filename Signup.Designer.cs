namespace DP_Project
{
    partial class Signup
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
            labelUsername = new Label();
            labelError = new Label();
            label1 = new Label();
            textBoxConfirmPassword = new TextBox();
            buttonSignup = new Button();
            textBoxPassword = new TextBox();
            label2 = new Label();
            textBoxUsername = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(labelError);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxConfirmPassword);
            panel1.Controls.Add(buttonSignup);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxUsername);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(38, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 302);
            panel1.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(45, 19);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(95, 21);
            labelUsername.TabIndex = 9;
            labelUsername.Text = "Username: ";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(69, 275);
            labelError.Name = "labelError";
            labelError.Size = new Size(10, 15);
            labelError.TabIndex = 8;
            labelError.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 157);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 7;
            label1.Text = "Confirm Password: ";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(45, 181);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(248, 23);
            textBoxConfirmPassword.TabIndex = 6;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // buttonSignup
            // 
            buttonSignup.BackColor = Color.White;
            buttonSignup.FlatAppearance.BorderSize = 0;
            buttonSignup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSignup.ForeColor = Color.Black;
            buttonSignup.Location = new Point(45, 240);
            buttonSignup.Name = "buttonSignup";
            buttonSignup.Size = new Size(248, 32);
            buttonSignup.TabIndex = 5;
            buttonSignup.Text = "Signup";
            buttonSignup.UseVisualStyleBackColor = false;
            buttonSignup.Click += buttonSignup_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(45, 109);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(248, 23);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 85);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 2;
            label2.Text = "Password: ";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(45, 43);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(248, 23);
            textBoxUsername.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 19);
            label3.Name = "label3";
            label3.Size = new Size(278, 30);
            label3.TabIndex = 10;
            label3.Text = "Hotel Management System";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(410, 417);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Signup";
            Text = "Signup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonSignup;
        private TextBox textBoxPassword;
        private Label label2;
        public TextBox textBoxUsername;
        private Label labelError;
        private Label label1;
        private TextBox textBoxConfirmPassword;
        private Label labelUsername;
        private Label label3;
    }
}