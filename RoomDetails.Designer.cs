namespace DP_Project
{
    partial class RoomDetails
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
            dataGridViewRoomDetails = new DataGridView();
            panel4 = new Panel();
            label8 = new Label();
            labelUsername = new Label();
            panel5 = new Panel();
            linkLabelLogout = new LinkLabel();
            label1 = new Label();
            panel1 = new Panel();
            panelSlide = new Panel();
            buttonReservation = new Button();
            buttonRoomDetails = new Button();
            buttonBookingDetails = new Button();
            buttonDashboard = new Button();
            panel2 = new Panel();
            label9 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoomDetails).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewRoomDetails
            // 
            dataGridViewRoomDetails.AllowUserToOrderColumns = true;
            dataGridViewRoomDetails.BackgroundColor = Color.Thistle;
            dataGridViewRoomDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoomDetails.Location = new Point(279, 156);
            dataGridViewRoomDetails.Name = "dataGridViewRoomDetails";
            dataGridViewRoomDetails.Size = new Size(830, 399);
            dataGridViewRoomDetails.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Thistle;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(labelUsername);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(261, -2);
            panel4.Name = "panel4";
            panel4.Size = new Size(846, 138);
            panel4.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Thistle;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(22, 102);
            label8.Name = "label8";
            label8.Size = new Size(90, 21);
            label8.TabIndex = 3;
            label8.Text = "Welcome: ";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Thistle;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.Black;
            labelUsername.Location = new Point(118, 102);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(17, 21);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "?";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(linkLabelLogout);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(846, 79);
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
            linkLabelLogout.Location = new Point(754, 47);
            linkLabelLogout.Name = "linkLabelLogout";
            linkLabelLogout.Size = new Size(64, 21);
            linkLabelLogout.TabIndex = 0;
            linkLabelLogout.TabStop = true;
            linkLabelLogout.Text = "Logout";
            linkLabelLogout.VisitedLinkColor = Color.Black;
            linkLabelLogout.LinkClicked += linkLabelLogout_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(281, 38);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 0;
            label1.Text = "Room Details";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(panelSlide);
            panel1.Controls.Add(buttonReservation);
            panel1.Controls.Add(buttonRoomDetails);
            panel1.Controls.Add(buttonBookingDetails);
            panel1.Controls.Add(buttonDashboard);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 570);
            panel1.TabIndex = 24;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.ForeColor = Color.Black;
            panelSlide.Location = new Point(20, 254);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(10, 57);
            panelSlide.TabIndex = 0;
            // 
            // buttonReservation
            // 
            buttonReservation.FlatAppearance.BorderSize = 0;
            buttonReservation.FlatStyle = FlatStyle.Flat;
            buttonReservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReservation.ForeColor = Color.Black;
            buttonReservation.Location = new Point(34, 309);
            buttonReservation.Name = "buttonReservation";
            buttonReservation.Size = new Size(219, 49);
            buttonReservation.TabIndex = 4;
            buttonReservation.Text = "                  Reservation";
            buttonReservation.TextAlign = ContentAlignment.MiddleLeft;
            buttonReservation.UseVisualStyleBackColor = true;
            buttonReservation.Click += buttonReservation_Click_1;
            // 
            // buttonRoomDetails
            // 
            buttonRoomDetails.FlatAppearance.BorderSize = 0;
            buttonRoomDetails.FlatStyle = FlatStyle.Flat;
            buttonRoomDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRoomDetails.ForeColor = Color.Black;
            buttonRoomDetails.Location = new Point(34, 254);
            buttonRoomDetails.Name = "buttonRoomDetails";
            buttonRoomDetails.Size = new Size(219, 49);
            buttonRoomDetails.TabIndex = 3;
            buttonRoomDetails.Text = "                  Room Details";
            buttonRoomDetails.TextAlign = ContentAlignment.MiddleLeft;
            buttonRoomDetails.UseVisualStyleBackColor = true;
            buttonRoomDetails.Click += buttonRoomDetails_Click_1;
            // 
            // buttonBookingDetails
            // 
            buttonBookingDetails.FlatAppearance.BorderSize = 0;
            buttonBookingDetails.FlatStyle = FlatStyle.Flat;
            buttonBookingDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBookingDetails.ForeColor = Color.Black;
            buttonBookingDetails.Location = new Point(33, 199);
            buttonBookingDetails.Name = "buttonBookingDetails";
            buttonBookingDetails.Size = new Size(219, 49);
            buttonBookingDetails.TabIndex = 2;
            buttonBookingDetails.Text = "                  Booking Details";
            buttonBookingDetails.TextAlign = ContentAlignment.MiddleLeft;
            buttonBookingDetails.UseVisualStyleBackColor = true;
            buttonBookingDetails.Click += buttonBookingDetails_Click_1;
            // 
            // buttonDashboard
            // 
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboard.ForeColor = Color.Black;
            buttonDashboard.Location = new Point(34, 147);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(219, 49);
            buttonDashboard.TabIndex = 1;
            buttonDashboard.Text = "                  Dashboard";
            buttonDashboard.TextAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(panel3);
            panel2.ForeColor = Color.DimGray;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 138);
            panel2.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(74, 79);
            label9.Name = "label9";
            label9.Size = new Size(82, 30);
            label9.TabIndex = 3;
            label9.Text = "System";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(20, 49);
            label10.Name = "label10";
            label10.Size = new Size(209, 30);
            label10.TabIndex = 2;
            label10.Text = "Hotel Management ";
            // 
            // panel3
            // 
            panel3.Location = new Point(277, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(687, 107);
            panel3.TabIndex = 1;
            // 
            // RoomDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 562);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(dataGridViewRoomDetails);
            Name = "RoomDetails";
            Text = "RoomDetails";
            Load += RoomDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoomDetails).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewRoomDetails;
        private Panel panel4;
        private Label label8;
        private Label labelUsername;
        private Panel panel5;
        private LinkLabel linkLabelLogout;
        private Label label1;
        private Panel panel1;
        private Panel panelSlide;
        private Button buttonReservation;
        private Button buttonRoomDetails;
        private Button buttonBookingDetails;
        private Button buttonDashboard;
        private Panel panel2;
        private Label label9;
        private Label label10;
        private Panel panel3;
    }
}