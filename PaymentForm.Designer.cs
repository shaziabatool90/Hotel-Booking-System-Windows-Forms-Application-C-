namespace DP_Project
{
    partial class PaymentForm
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
            comboBoxPaymentMethod = new ComboBox();
            labelPaymentMethod = new Label();
            label2 = new Label();
            buttonPay = new Button();
            groupBoxCardDetails = new GroupBox();
            comboBoxCardType = new ComboBox();
            label1 = new Label();
            textBoxCVV = new TextBox();
            label4 = new Label();
            labelCardNum = new Label();
            textBoxCardNumber = new TextBox();
            textBoxIBAN = new TextBox();
            labelBankName = new Label();
            label6 = new Label();
            textBoxBankName = new TextBox();
            groupBoxBankDetails = new GroupBox();
            groupBox3 = new GroupBox();
            labelRoomDetails = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            labelUsername = new Label();
            panel5 = new Panel();
            linkLabelLogout = new LinkLabel();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label7 = new Label();
            panel6 = new Panel();
            groupBoxCardDetails.SuspendLayout();
            groupBoxBankDetails.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxPaymentMethod
            // 
            comboBoxPaymentMethod.FormattingEnabled = true;
            comboBoxPaymentMethod.Location = new Point(166, 25);
            comboBoxPaymentMethod.Margin = new Padding(4);
            comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            comboBoxPaymentMethod.Size = new Size(279, 25);
            comboBoxPaymentMethod.TabIndex = 0;
            comboBoxPaymentMethod.SelectedIndexChanged += comboBoxPaymentMethod_SelectedIndexChanged;
            // 
            // labelPaymentMethod
            // 
            labelPaymentMethod.AutoSize = true;
            labelPaymentMethod.BackColor = Color.Transparent;
            labelPaymentMethod.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPaymentMethod.Location = new Point(25, 30);
            labelPaymentMethod.Margin = new Padding(4, 0, 4, 0);
            labelPaymentMethod.Name = "labelPaymentMethod";
            labelPaymentMethod.Size = new Size(134, 20);
            labelPaymentMethod.TabIndex = 1;
            labelPaymentMethod.Text = "Payment Method:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(245, 38);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 2;
            label2.Text = "Payment";
            // 
            // buttonPay
            // 
            buttonPay.Location = new Point(40, 151);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(405, 32);
            buttonPay.TabIndex = 3;
            buttonPay.Text = "Pay ";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // groupBoxCardDetails
            // 
            groupBoxCardDetails.BackColor = Color.Thistle;
            groupBoxCardDetails.BackgroundImageLayout = ImageLayout.Stretch;
            groupBoxCardDetails.Controls.Add(comboBoxCardType);
            groupBoxCardDetails.Controls.Add(label1);
            groupBoxCardDetails.Controls.Add(textBoxCVV);
            groupBoxCardDetails.Controls.Add(label4);
            groupBoxCardDetails.Controls.Add(labelCardNum);
            groupBoxCardDetails.Controls.Add(textBoxCardNumber);
            groupBoxCardDetails.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxCardDetails.Location = new Point(7, 234);
            groupBoxCardDetails.Name = "groupBoxCardDetails";
            groupBoxCardDetails.Size = new Size(406, 181);
            groupBoxCardDetails.TabIndex = 4;
            groupBoxCardDetails.TabStop = false;
            groupBoxCardDetails.Text = "Payment by Card";
            // 
            // comboBoxCardType
            // 
            comboBoxCardType.FormattingEnabled = true;
            comboBoxCardType.Location = new Point(154, 32);
            comboBoxCardType.Name = "comboBoxCardType";
            comboBoxCardType.Size = new Size(223, 25);
            comboBoxCardType.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 10;
            label1.Text = "Card Type:";
            // 
            // textBoxCVV
            // 
            textBoxCVV.Location = new Point(154, 126);
            textBoxCVV.Name = "textBoxCVV";
            textBoxCVV.Size = new Size(223, 25);
            textBoxCVV.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 131);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 8;
            label4.Text = "CVV:";
            // 
            // labelCardNum
            // 
            labelCardNum.AutoSize = true;
            labelCardNum.BackColor = Color.Transparent;
            labelCardNum.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCardNum.Location = new Point(30, 84);
            labelCardNum.Margin = new Padding(4, 0, 4, 0);
            labelCardNum.Name = "labelCardNum";
            labelCardNum.Size = new Size(108, 20);
            labelCardNum.TabIndex = 6;
            labelCardNum.Text = "Card Number:";
            // 
            // textBoxCardNumber
            // 
            textBoxCardNumber.Location = new Point(154, 79);
            textBoxCardNumber.Name = "textBoxCardNumber";
            textBoxCardNumber.Size = new Size(223, 25);
            textBoxCardNumber.TabIndex = 8;
            // 
            // textBoxIBAN
            // 
            textBoxIBAN.Location = new Point(118, 32);
            textBoxIBAN.Name = "textBoxIBAN";
            textBoxIBAN.Size = new Size(221, 25);
            textBoxIBAN.TabIndex = 10;
            // 
            // labelBankName
            // 
            labelBankName.AutoSize = true;
            labelBankName.BackColor = Color.Transparent;
            labelBankName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBankName.Location = new Point(7, 79);
            labelBankName.Margin = new Padding(4, 0, 4, 0);
            labelBankName.Name = "labelBankName";
            labelBankName.Size = new Size(94, 20);
            labelBankName.TabIndex = 7;
            labelBankName.Text = "Bank Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 37);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 10;
            label6.Text = "IBAN:";
            // 
            // textBoxBankName
            // 
            textBoxBankName.Location = new Point(118, 74);
            textBoxBankName.Name = "textBoxBankName";
            textBoxBankName.Size = new Size(221, 25);
            textBoxBankName.TabIndex = 9;
            // 
            // groupBoxBankDetails
            // 
            groupBoxBankDetails.BackColor = Color.Thistle;
            groupBoxBankDetails.BackgroundImageLayout = ImageLayout.Stretch;
            groupBoxBankDetails.Controls.Add(labelBankName);
            groupBoxBankDetails.Controls.Add(textBoxIBAN);
            groupBoxBankDetails.Controls.Add(textBoxBankName);
            groupBoxBankDetails.Controls.Add(label6);
            groupBoxBankDetails.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxBankDetails.Location = new Point(451, 234);
            groupBoxBankDetails.Name = "groupBoxBankDetails";
            groupBoxBankDetails.Size = new Size(356, 114);
            groupBoxBankDetails.TabIndex = 10;
            groupBoxBankDetails.TabStop = false;
            groupBoxBankDetails.Text = "Online Transfer";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Thistle;
            groupBox3.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox3.Controls.Add(labelRoomDetails);
            groupBox3.Controls.Add(buttonPay);
            groupBox3.Controls.Add(comboBoxPaymentMethod);
            groupBox3.Controls.Add(labelPaymentMethod);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(165, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(467, 196);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            // 
            // labelRoomDetails
            // 
            labelRoomDetails.AutoSize = true;
            labelRoomDetails.Location = new Point(40, 65);
            labelRoomDetails.Name = "labelRoomDetails";
            labelRoomDetails.Size = new Size(14, 17);
            labelRoomDetails.TabIndex = 5;
            labelRoomDetails.Text = "?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBoxBankDetails);
            panel1.Controls.Add(groupBoxCardDetails);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(278, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 427);
            panel1.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Thistle;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(labelUsername);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(256, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(862, 160);
            panel4.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Thistle;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 104);
            label5.Name = "label5";
            label5.Size = new Size(90, 21);
            label5.TabIndex = 3;
            label5.Text = "Welcome: ";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Thistle;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.Black;
            labelUsername.Location = new Point(121, 104);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(17, 21);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "?";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(linkLabelLogout);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(862, 79);
            panel5.TabIndex = 2;
            // 
            // linkLabelLogout
            // 
            linkLabelLogout.ActiveLinkColor = Color.Thistle;
            linkLabelLogout.AutoSize = true;
            linkLabelLogout.BackColor = Color.White;
            linkLabelLogout.Cursor = Cursors.Hand;
            linkLabelLogout.DisabledLinkColor = Color.Black;
            linkLabelLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelLogout.ForeColor = Color.Black;
            linkLabelLogout.LinkColor = Color.Black;
            linkLabelLogout.Location = new Point(726, 47);
            linkLabelLogout.Name = "linkLabelLogout";
            linkLabelLogout.Size = new Size(64, 21);
            linkLabelLogout.TabIndex = 0;
            linkLabelLogout.TabStop = true;
            linkLabelLogout.Text = "Logout";
            linkLabelLogout.VisitedLinkColor = Color.Black;
            linkLabelLogout.LinkClicked += linkLabelLogout_LinkClicked;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 619);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Thistle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(panel6);
            panel3.ForeColor = Color.DimGray;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(256, 160);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(76, 79);
            label3.Name = "label3";
            label3.Size = new Size(82, 30);
            label3.TabIndex = 3;
            label3.Text = "System";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(20, 49);
            label7.Name = "label7";
            label7.Size = new Size(209, 30);
            label7.TabIndex = 2;
            label7.Text = "Hotel Management ";
            // 
            // panel6
            // 
            panel6.Location = new Point(277, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(687, 107);
            panel6.TabIndex = 1;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1118, 615);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "PaymentForm";
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            groupBoxCardDetails.ResumeLayout(false);
            groupBoxCardDetails.PerformLayout();
            groupBoxBankDetails.ResumeLayout(false);
            groupBoxBankDetails.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxPaymentMethod;
        private Label labelPaymentMethod;
        private Label label2;
        private Button buttonPay;
        private GroupBox groupBoxCardDetails;
        private TextBox textBoxCardNumber;
        private Label labelBankName;
        private Label labelCardNum;
        private TextBox textBoxBankName;
        private TextBox textBoxCVV;
        private Label label4;
        private Label label6;
        private TextBox textBoxIBAN;
        private GroupBox groupBoxBankDetails;
        private GroupBox groupBox3;
        private Label label1;
        private ComboBox comboBoxCardType;
      
        private Label labelRoomDetails;

        private Panel panel1;
        private Panel panel4;
        private Label label5;
        private Label labelUsername;
        private Panel panel5;
        private LinkLabel linkLabelLogout;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label7;
        private Panel panel6;
    }
}