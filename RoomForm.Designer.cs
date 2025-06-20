namespace DP_Project
{
    partial class RoomForm
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
            groupBoxRoomType = new GroupBox();
            labelRoomType = new Label();
            comboBoxRoomType = new ComboBox();
            groupBoxFeatures = new GroupBox();
            checkBoxWiFi = new CheckBox();
            checkBoxMinibar = new CheckBox();
            checkBoxRoomService = new CheckBox();
            groupBoxSummary = new GroupBox();
            labelRoomDetails = new Label();
            labelTotalCost = new Label();
            buttonSave = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            labelUsername = new Label();
            panel5 = new Panel();
            linkLabelLogout = new LinkLabel();
            label2 = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel7 = new Panel();
            groupBoxRoomType.SuspendLayout();
            groupBoxFeatures.SuspendLayout();
            groupBoxSummary.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRoomType
            // 
            groupBoxRoomType.Controls.Add(labelRoomType);
            groupBoxRoomType.Controls.Add(comboBoxRoomType);
            groupBoxRoomType.Location = new Point(13, 25);
            groupBoxRoomType.Name = "groupBoxRoomType";
            groupBoxRoomType.Padding = new Padding(10);
            groupBoxRoomType.Size = new Size(560, 100);
            groupBoxRoomType.TabIndex = 0;
            groupBoxRoomType.TabStop = false;
            groupBoxRoomType.Text = "Room Type";
            // 
            // labelRoomType
            // 
            labelRoomType.AutoSize = true;
            labelRoomType.Location = new Point(20, 30);
            labelRoomType.Name = "labelRoomType";
            labelRoomType.Size = new Size(128, 17);
            labelRoomType.TabIndex = 0;
            labelRoomType.Text = "Select Room Type:";
            // 
            // comboBoxRoomType
            // 
            comboBoxRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoomType.Location = new Point(20, 55);
            comboBoxRoomType.Name = "comboBoxRoomType";
            comboBoxRoomType.Size = new Size(520, 24);
            comboBoxRoomType.TabIndex = 1;
            comboBoxRoomType.SelectedIndexChanged += comboBoxRoomType_SelectedIndexChanged;
            // 
            // groupBoxFeatures
            // 
            groupBoxFeatures.Controls.Add(checkBoxWiFi);
            groupBoxFeatures.Controls.Add(checkBoxMinibar);
            groupBoxFeatures.Controls.Add(checkBoxRoomService);
            groupBoxFeatures.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxFeatures.Location = new Point(13, 144);
            groupBoxFeatures.Name = "groupBoxFeatures";
            groupBoxFeatures.Padding = new Padding(10);
            groupBoxFeatures.Size = new Size(560, 120);
            groupBoxFeatures.TabIndex = 1;
            groupBoxFeatures.TabStop = false;
            groupBoxFeatures.Text = "Additional Features";
            // 
            // checkBoxWiFi
            // 
            checkBoxWiFi.AutoSize = true;
            checkBoxWiFi.Location = new Point(20, 30);
            checkBoxWiFi.Name = "checkBoxWiFi";
            checkBoxWiFi.Size = new Size(194, 20);
            checkBoxWiFi.TabIndex = 0;
            checkBoxWiFi.Text = "High-Speed WiFi (+ Rs. 500)";
            checkBoxWiFi.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBoxMinibar
            // 
            checkBoxMinibar.AutoSize = true;
            checkBoxMinibar.Location = new Point(20, 55);
            checkBoxMinibar.Name = "checkBoxMinibar";
            checkBoxMinibar.Size = new Size(145, 20);
            checkBoxMinibar.TabIndex = 1;
            checkBoxMinibar.Text = "Minibar (+ Rs. 1,000)";
            checkBoxMinibar.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBoxRoomService
            // 
            checkBoxRoomService.AutoSize = true;
            checkBoxRoomService.Location = new Point(20, 80);
            checkBoxRoomService.Name = "checkBoxRoomService";
            checkBoxRoomService.Size = new Size(215, 20);
            checkBoxRoomService.TabIndex = 2;
            checkBoxRoomService.Text = "24/7 Room Service (+ Rs. 1,500)";
            checkBoxRoomService.CheckedChanged += checkBox_CheckedChanged;
            // 
            // groupBoxSummary
            // 
            groupBoxSummary.Controls.Add(labelRoomDetails);
            groupBoxSummary.Controls.Add(labelTotalCost);
            groupBoxSummary.Location = new Point(13, 270);
            groupBoxSummary.Name = "groupBoxSummary";
            groupBoxSummary.Padding = new Padding(10);
            groupBoxSummary.Size = new Size(560, 120);
            groupBoxSummary.TabIndex = 2;
            groupBoxSummary.TabStop = false;
            groupBoxSummary.Text = "Room Summary";
            // 
            // labelRoomDetails
            // 
            labelRoomDetails.Location = new Point(20, 30);
            labelRoomDetails.Name = "labelRoomDetails";
            labelRoomDetails.Size = new Size(520, 50);
            labelRoomDetails.TabIndex = 0;
            labelRoomDetails.Text = "Please select a room type";
            // 
            // labelTotalCost
            // 
            labelTotalCost.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            labelTotalCost.Location = new Point(20, 80);
            labelTotalCost.Name = "labelTotalCost";
            labelTotalCost.Size = new Size(520, 25);
            labelTotalCost.TabIndex = 1;
            labelTotalCost.Text = "Total Cost: Rs. 0";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.White;
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(13, 405);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(560, 40);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save Room Configuration";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(groupBoxRoomType);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(groupBoxSummary);
            panel1.Controls.Add(groupBoxFeatures);
            panel1.Location = new Point(278, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 467);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Thistle;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(labelUsername);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(256, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(650, 160);
            panel4.TabIndex = 16;
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
            panel5.Size = new Size(650, 79);
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
            linkLabelLogout.Location = new Point(509, 47);
            linkLabelLogout.Name = "linkLabelLogout";
            linkLabelLogout.Size = new Size(64, 21);
            linkLabelLogout.TabIndex = 0;
            linkLabelLogout.TabStop = true;
            linkLabelLogout.Text = "Logout";
            linkLabelLogout.VisitedLinkColor = Color.Black;
            linkLabelLogout.LinkClicked += linkLabelLogout_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(208, 38);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 2;
            label2.Text = "Room ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Thistle;
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(1, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(256, 668);
            panel3.TabIndex = 15;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Thistle;
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(panel7);
            panel6.ForeColor = Color.Black;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(256, 160);
            panel6.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(76, 79);
            label7.Name = "label7";
            label7.Size = new Size(82, 30);
            label7.TabIndex = 3;
            label7.Text = "System";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(20, 49);
            label8.Name = "label8";
            label8.Size = new Size(209, 30);
            label8.TabIndex = 2;
            label8.Text = "Hotel Management ";
            // 
            // panel7
            // 
            panel7.Location = new Point(277, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(687, 107);
            panel7.TabIndex = 1;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(901, 669);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RoomForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Room Configuration";
            Load += RoomForm_Load;
            groupBoxRoomType.ResumeLayout(false);
            groupBoxRoomType.PerformLayout();
            groupBoxFeatures.ResumeLayout(false);
            groupBoxFeatures.PerformLayout();
            groupBoxSummary.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRoomType;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.CheckBox checkBoxWiFi;
        private System.Windows.Forms.CheckBox checkBoxMinibar;
        private System.Windows.Forms.CheckBox checkBoxRoomService;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private Panel panel1;
        public ComboBox comboBoxRoomType;
        public Button buttonSave;
        public GroupBox groupBoxFeatures;
        public Label labelRoomDetails;
        public Label labelTotalCost;
        private Panel panel4;
        private Label label5;
        private Label labelUsername;
        private Panel panel5;
        private LinkLabel linkLabelLogout;
        private Label label2;
        private Panel panel3;
        private Panel panel6;
        private Label label7;
        private Label label8;
        private Panel panel7;
    }
}