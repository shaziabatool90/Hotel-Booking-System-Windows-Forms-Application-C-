namespace DP_Project
{
    partial class BookingDetails
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
            dataGridViewBookings = new DataGridView();
            panel4 = new Panel();
            label5 = new Label();
            labelUsername = new Label();
            panel5 = new Panel();
            label3 = new Label();
            linkLabelLogout = new LinkLabel();
            panel1 = new Panel();
            panelSlide = new Panel();
            buttonReservation = new Button();
            buttonRoomDetails = new Button();
            buttonBookingDetails = new Button();
            buttonDashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookings).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBookings
            // 
            dataGridViewBookings.AllowUserToOrderColumns = true;
            dataGridViewBookings.BackgroundColor = Color.Thistle;
            dataGridViewBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookings.Location = new Point(258, 186);
            dataGridViewBookings.Name = "dataGridViewBookings";
            dataGridViewBookings.Size = new Size(1013, 358);
            dataGridViewBookings.TabIndex = 0;
            dataGridViewBookings.CellContentClick += dataGridViewBookings_CellContentClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Thistle;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(labelUsername);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(251, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1028, 178);
            panel4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Thistle;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(22, 130);
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
            labelUsername.Location = new Point(118, 130);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(17, 21);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "?";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(linkLabelLogout);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1028, 107);
            panel5.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(283, 65);
            label3.Name = "label3";
            label3.Size = new Size(168, 30);
            label3.TabIndex = 4;
            label3.Text = "Booking Details";
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
            linkLabelLogout.Location = new Point(933, 72);
            linkLabelLogout.Name = "linkLabelLogout";
            linkLabelLogout.Size = new Size(64, 21);
            linkLabelLogout.TabIndex = 0;
            linkLabelLogout.TabStop = true;
            linkLabelLogout.Text = "Logout";
            linkLabelLogout.VisitedLinkColor = Color.Black;
            linkLabelLogout.LinkClicked += linkLabelLogout_LinkClicked;
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
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 551);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.ForeColor = Color.Black;
            panelSlide.Location = new Point(21, 235);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(10, 53);
            panelSlide.TabIndex = 0;
            // 
            // buttonReservation
            // 
            buttonReservation.FlatAppearance.BorderSize = 0;
            buttonReservation.FlatStyle = FlatStyle.Flat;
            buttonReservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReservation.ForeColor = Color.Black;
            buttonReservation.Location = new Point(34, 349);
            buttonReservation.Name = "buttonReservation";
            buttonReservation.Size = new Size(212, 49);
            buttonReservation.TabIndex = 4;
            buttonReservation.Text = "                  Reservation";
            buttonReservation.TextAlign = ContentAlignment.MiddleLeft;
            buttonReservation.UseVisualStyleBackColor = true;
            buttonReservation.Click += buttonReservation_Click;
            // 
            // buttonRoomDetails
            // 
            buttonRoomDetails.FlatAppearance.BorderSize = 0;
            buttonRoomDetails.FlatStyle = FlatStyle.Flat;
            buttonRoomDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRoomDetails.ForeColor = Color.Black;
            buttonRoomDetails.Location = new Point(34, 294);
            buttonRoomDetails.Name = "buttonRoomDetails";
            buttonRoomDetails.Size = new Size(212, 49);
            buttonRoomDetails.TabIndex = 3;
            buttonRoomDetails.Text = "                  Room Details";
            buttonRoomDetails.TextAlign = ContentAlignment.MiddleLeft;
            buttonRoomDetails.UseVisualStyleBackColor = true;
            buttonRoomDetails.Click += buttonRoomDetails_Click;
            // 
            // buttonBookingDetails
            // 
            buttonBookingDetails.FlatAppearance.BorderSize = 0;
            buttonBookingDetails.FlatStyle = FlatStyle.Flat;
            buttonBookingDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBookingDetails.ForeColor = Color.Black;
            buttonBookingDetails.Location = new Point(37, 239);
            buttonBookingDetails.Name = "buttonBookingDetails";
            buttonBookingDetails.Size = new Size(209, 49);
            buttonBookingDetails.TabIndex = 2;
            buttonBookingDetails.Text = "               Booking Details";
            buttonBookingDetails.TextAlign = ContentAlignment.MiddleLeft;
            buttonBookingDetails.UseVisualStyleBackColor = true;
            buttonBookingDetails.Click += buttonBookingDetails_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboard.ForeColor = Color.Black;
            buttonDashboard.Location = new Point(34, 184);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(212, 49);
            buttonDashboard.TabIndex = 1;
            buttonDashboard.Text = "                  Dashboard";
            buttonDashboard.TextAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.ForeColor = Color.DimGray;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 178);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(72, 95);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 3;
            label2.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(20, 65);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 2;
            label1.Text = "Hotel Management ";
            // 
            // panel3
            // 
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(277, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(687, 107);
            panel3.TabIndex = 1;
            // 
            // BookingDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 551);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(dataGridViewBookings);
            ForeColor = Color.Black;
            Name = "BookingDetails";
            Text = "BookingDetails";
            Load += BookingDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookings).EndInit();
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

        private DataGridView dataGridViewBookings;
        private Panel panel4;
        private Label label5;
        private Label labelUsername;
        private Panel panel5;
        private LinkLabel linkLabelLogout;
        private Panel panel1;
        private Panel panelSlide;
        private Button buttonReservation;
        private Button buttonRoomDetails;
        private Button buttonBookingDetails;
        private Button buttonDashboard;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Label label3;
    }
}