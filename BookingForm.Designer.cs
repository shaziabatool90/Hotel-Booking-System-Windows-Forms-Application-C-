namespace DP_Project
{
    partial class BookingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxCNIC = new TextBox();
            textBoxPhone = new TextBox();
            textBoxName = new TextBox();
            labelCNIC = new Label();
            labelPhone = new Label();
            labelName = new Label();
            comboBoxRoomType = new ComboBox();
            labelRoomType = new Label();
            textBoxRoomPrice = new TextBox();
            labelRoomPrice = new Label();
            dateTimePickerCheckOut = new DateTimePicker();
            dateTimePickerCheckIn = new DateTimePicker();
            labelCheckOut = new Label();
            labelCheckIn = new Label();
            myPanel = new GroupBox();
            buttonConfigureRoom = new Button();
            label7 = new Label();
            textBoxRoomType = new TextBox();
            comboBoxBookingStatus = new ComboBox();
            textBoxRoomP = new TextBox();
            dateTimePickerCheck_Out = new DateTimePicker();
            buttonBookRoom = new Button();
            dateTimePickerCheck_In = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            newName = new Label();
            textBoxCusName = new TextBox();
            textBoxCusCNIC = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBoxCusPhone = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            labelUsername = new Label();
            panel5 = new Panel();
            linkLabelLogout = new LinkLabel();
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
            myPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxCNIC
            // 
            textBoxCNIC.Location = new Point(120, 107);
            textBoxCNIC.Name = "textBoxCNIC";
            textBoxCNIC.Size = new Size(220, 23);
            textBoxCNIC.TabIndex = 0;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(120, 67);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(220, 23);
            textBoxPhone.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(120, 27);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(220, 23);
            textBoxName.TabIndex = 0;
            // 
            // labelCNIC
            // 
            labelCNIC.AutoSize = true;
            labelCNIC.Location = new Point(20, 110);
            labelCNIC.Name = "labelCNIC";
            labelCNIC.Size = new Size(85, 16);
            labelCNIC.TabIndex = 0;
            labelCNIC.Text = "CNIC:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(20, 70);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(85, 16);
            labelPhone.TabIndex = 0;
            labelPhone.Text = "Phone Number:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(20, 30);
            labelName.Name = "labelName";
            labelName.Size = new Size(45, 16);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // comboBoxRoomType
            // 
            comboBoxRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoomType.Location = new Point(120, 27);
            comboBoxRoomType.Name = "comboBoxRoomType";
            comboBoxRoomType.Size = new Size(220, 23);
            comboBoxRoomType.TabIndex = 0;
            // 
            // labelRoomType
            // 
            labelRoomType.AutoSize = true;
            labelRoomType.Location = new Point(20, 30);
            labelRoomType.Name = "labelRoomType";
            labelRoomType.Size = new Size(75, 16);
            labelRoomType.TabIndex = 0;
            labelRoomType.Text = "Room Type:";
            // 
            // textBoxRoomPrice
            // 
            textBoxRoomPrice.Location = new Point(120, 67);
            textBoxRoomPrice.Name = "textBoxRoomPrice";
            textBoxRoomPrice.ReadOnly = true;
            textBoxRoomPrice.Size = new Size(220, 23);
            textBoxRoomPrice.TabIndex = 0;
            // 
            // labelRoomPrice
            // 
            labelRoomPrice.AutoSize = true;
            labelRoomPrice.Location = new Point(20, 70);
            labelRoomPrice.Name = "labelRoomPrice";
            labelRoomPrice.Size = new Size(75, 16);
            labelRoomPrice.TabIndex = 0;
            labelRoomPrice.Text = "Price/Night:";
            // 
            // dateTimePickerCheckOut
            // 
            dateTimePickerCheckOut.Location = new Point(120, 67);
            dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            dateTimePickerCheckOut.Size = new Size(220, 23);
            dateTimePickerCheckOut.TabIndex = 0;
            // 
            // dateTimePickerCheckIn
            // 
            dateTimePickerCheckIn.Location = new Point(120, 27);
            dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            dateTimePickerCheckIn.Size = new Size(220, 23);
            dateTimePickerCheckIn.TabIndex = 0;
            // 
            // labelCheckOut
            // 
            labelCheckOut.AutoSize = true;
            labelCheckOut.Location = new Point(20, 70);
            labelCheckOut.Name = "labelCheckOut";
            labelCheckOut.Size = new Size(75, 16);
            labelCheckOut.TabIndex = 0;
            labelCheckOut.Text = "Check Out:";
            // 
            // labelCheckIn
            // 
            labelCheckIn.AutoSize = true;
            labelCheckIn.Location = new Point(20, 30);
            labelCheckIn.Name = "labelCheckIn";
            labelCheckIn.Size = new Size(65, 16);
            labelCheckIn.TabIndex = 0;
            labelCheckIn.Text = "Check In:";
            // 
            // myPanel
            // 
            myPanel.BackColor = Color.Thistle;
            myPanel.Controls.Add(buttonConfigureRoom);
            myPanel.Controls.Add(label7);
            myPanel.Controls.Add(textBoxRoomType);
            myPanel.Controls.Add(comboBoxBookingStatus);
            myPanel.Controls.Add(textBoxRoomP);
            myPanel.Controls.Add(dateTimePickerCheck_Out);
            myPanel.Controls.Add(buttonBookRoom);
            myPanel.Controls.Add(dateTimePickerCheck_In);
            myPanel.Controls.Add(label4);
            myPanel.Controls.Add(label2);
            myPanel.Controls.Add(newName);
            myPanel.Controls.Add(textBoxCusName);
            myPanel.Controls.Add(textBoxCusCNIC);
            myPanel.Controls.Add(label3);
            myPanel.Controls.Add(label6);
            myPanel.Controls.Add(label5);
            myPanel.Controls.Add(textBoxCusPhone);
            myPanel.ForeColor = Color.Black;
            myPanel.Location = new Point(312, 149);
            myPanel.Name = "myPanel";
            myPanel.Size = new Size(425, 444);
            myPanel.TabIndex = 20;
            myPanel.TabStop = false;
            // 
            // buttonConfigureRoom
            // 
            buttonConfigureRoom.BackColor = Color.Transparent;
            buttonConfigureRoom.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConfigureRoom.Location = new Point(20, 137);
            buttonConfigureRoom.Margin = new Padding(3, 2, 3, 2);
            buttonConfigureRoom.Name = "buttonConfigureRoom";
            buttonConfigureRoom.Size = new Size(363, 34);
            buttonConfigureRoom.TabIndex = 22;
            buttonConfigureRoom.Text = "Room Configuration";
            buttonConfigureRoom.UseVisualStyleBackColor = false;
            buttonConfigureRoom.Click += buttonConfigureRoom_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 191);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 21;
            label7.Text = "Room Type";
            // 
            // textBoxRoomType
            // 
            textBoxRoomType.Location = new Point(152, 188);
            textBoxRoomType.Margin = new Padding(3, 2, 3, 2);
            textBoxRoomType.Name = "textBoxRoomType";
            textBoxRoomType.Size = new Size(223, 23);
            textBoxRoomType.TabIndex = 20;
            // 
            // comboBoxBookingStatus
            // 
            comboBoxBookingStatus.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxBookingStatus.ForeColor = Color.Black;
            comboBoxBookingStatus.FormattingEnabled = true;
            comboBoxBookingStatus.Location = new Point(20, 348);
            comboBoxBookingStatus.Margin = new Padding(3, 2, 3, 2);
            comboBoxBookingStatus.Name = "comboBoxBookingStatus";
            comboBoxBookingStatus.Size = new Size(367, 27);
            comboBoxBookingStatus.TabIndex = 13;
            comboBoxBookingStatus.Text = "Booking Status";
            // 
            // textBoxRoomP
            // 
            textBoxRoomP.Location = new Point(152, 229);
            textBoxRoomP.Margin = new Padding(3, 2, 3, 2);
            textBoxRoomP.Name = "textBoxRoomP";
            textBoxRoomP.Size = new Size(223, 23);
            textBoxRoomP.TabIndex = 17;
            // 
            // dateTimePickerCheck_Out
            // 
            dateTimePickerCheck_Out.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerCheck_Out.Format = DateTimePickerFormat.Short;
            dateTimePickerCheck_Out.Location = new Point(152, 305);
            dateTimePickerCheck_Out.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerCheck_Out.Name = "dateTimePickerCheck_Out";
            dateTimePickerCheck_Out.Size = new Size(223, 27);
            dateTimePickerCheck_Out.TabIndex = 6;
            // 
            // buttonBookRoom
            // 
            buttonBookRoom.BackColor = Color.Transparent;
            buttonBookRoom.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBookRoom.Location = new Point(23, 394);
            buttonBookRoom.Margin = new Padding(3, 2, 3, 2);
            buttonBookRoom.Name = "buttonBookRoom";
            buttonBookRoom.Size = new Size(363, 34);
            buttonBookRoom.TabIndex = 10;
            buttonBookRoom.Text = "Book Room";
            buttonBookRoom.UseVisualStyleBackColor = false;
            buttonBookRoom.Click += buttonBookRoom_Click_1;
            // 
            // dateTimePickerCheck_In
            // 
            dateTimePickerCheck_In.CalendarForeColor = Color.DimGray;
            dateTimePickerCheck_In.CalendarTitleForeColor = Color.DimGray;
            dateTimePickerCheck_In.CustomFormat = "long";
            dateTimePickerCheck_In.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerCheck_In.Format = DateTimePickerFormat.Short;
            dateTimePickerCheck_In.Location = new Point(152, 264);
            dateTimePickerCheck_In.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerCheck_In.Name = "dateTimePickerCheck_In";
            dateTimePickerCheck_In.Size = new Size(223, 27);
            dateTimePickerCheck_In.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 312);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 5;
            label4.Text = "Check-Out Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 232);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 18;
            label2.Text = "Room Price";
            // 
            // newName
            // 
            newName.AutoSize = true;
            newName.BackColor = Color.Transparent;
            newName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newName.Location = new Point(20, 19);
            newName.Name = "newName";
            newName.Size = new Size(119, 20);
            newName.TabIndex = 9;
            newName.Text = "Customer Name";
            // 
            // textBoxCusName
            // 
            textBoxCusName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxCusName.Location = new Point(152, 16);
            textBoxCusName.Margin = new Padding(3, 2, 3, 2);
            textBoxCusName.Name = "textBoxCusName";
            textBoxCusName.Size = new Size(223, 27);
            textBoxCusName.TabIndex = 8;
            // 
            // textBoxCusCNIC
            // 
            textBoxCusCNIC.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxCusCNIC.Location = new Point(152, 97);
            textBoxCusCNIC.Margin = new Padding(3, 2, 3, 2);
            textBoxCusCNIC.Name = "textBoxCusCNIC";
            textBoxCusCNIC.Size = new Size(223, 27);
            textBoxCusCNIC.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 271);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 3;
            label3.Text = " Check-In Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 62);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 11;
            label6.Text = "Customer Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 104);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 15;
            label5.Text = "Customer CNIC";
            // 
            // textBoxCusPhone
            // 
            textBoxCusPhone.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxCusPhone.Location = new Point(152, 55);
            textBoxCusPhone.Margin = new Padding(3, 2, 3, 2);
            textBoxCusPhone.Name = "textBoxCusPhone";
            textBoxCusPhone.Size = new Size(223, 27);
            textBoxCusPhone.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(96, 40);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 0;
            label1.Text = "Hotel Booking";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Thistle;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(labelUsername);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(262, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(511, 138);
            panel4.TabIndex = 22;
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
            panel5.Size = new Size(511, 79);
            panel5.TabIndex = 2;
            // 
            // linkLabelLogout
            // 
            linkLabelLogout.ActiveLinkColor = Color.Thistle;
            linkLabelLogout.AutoSize = true;
            linkLabelLogout.BackColor = Color.White;
            linkLabelLogout.Cursor = Cursors.Hand;
            linkLabelLogout.DisabledLinkColor = Color.Thistle;
            linkLabelLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelLogout.ForeColor = Color.Black;
            linkLabelLogout.LinkColor = Color.Black;
            linkLabelLogout.Location = new Point(437, 49);
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
            panel1.Size = new Size(260, 611);
            panel1.TabIndex = 21;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.Location = new Point(18, 302);
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
            buttonDashboard.Click += buttonDashboard_Click_1;
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
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(277, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(687, 107);
            panel3.TabIndex = 1;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 607);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(myPanel);
            Font = new Font("Microsoft Sans Serif", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book a Room";
            Load += BookingForm_Load;
            myPanel.ResumeLayout(false);
            myPanel.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxCNIC;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelCNIC;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.TextBox textBoxRoomPrice;
        private System.Windows.Forms.Label labelRoomPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckIn;
        private System.Windows.Forms.Label labelCheckOut;
        private System.Windows.Forms.Label labelCheckIn;
        private GroupBox myPanel;
        private Label label1;
        private ComboBox comboBoxBookingStatus;
        private TextBox textBoxRoomP;
        private DateTimePicker dateTimePickerCheck_Out;
        private Button buttonBookRoom;
        private DateTimePicker dateTimePickerCheck_In;
        private Label label4;
        private Label label2;
        private Label newName;
        private TextBox textBoxCusName;
        private TextBox textBoxCusCNIC;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox textBoxCusPhone;
        private Label label7;
        private TextBox textBoxRoomType;
        private Button buttonConfigureRoom;
        private Panel panel4;
        private Label label8;
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
        private Label label9;
        private Label label10;
        private Panel panel3;
    }
}
